using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class FrmSupplier : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private DataTable dtSuppliers = null;

        public FrmSupplier()
        {
            InitializeComponent();

            _httpClient.BaseAddress = new Uri("https://localhost:7265/");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void FrmLocation_Load(object sender, EventArgs e)
        {
            await LoadSupplierAsync();
            await LoadStatussAsync();
            setStatus();
        }

        private DataTable ConvertToDataTable(List<Supplier> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhà cung cấp");
            dt.Columns.Add("Tên nhà cung cấp");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Email");
            dt.Columns.Add("Trạng thái");

            foreach (var sup in list)
            {
                dt.Rows.Add(
                    sup.MaNCC ?? "",
                    sup.TenNCC ?? "",
                    sup.DiaChi ?? "",
                    sup.SDT ?? "",
                    sup.Email ?? "",
                    sup.TrangThai == 1 ? "Hoạt động" : "Ngưng hoạt động"
                );
            }

            return dt;
        }

        private async Task<List<Supplier>> GetAllSuppliersDirectAsync()
        {
            var response = await _httpClient.GetAsync("api/NhaCungCap");

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                var suppliers = await JsonSerializer.DeserializeAsync<List<Supplier>>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return suppliers ?? new List<Supplier>();
            }

            return new List<Supplier>();
        }

        private async Task LoadSupplierAsync()
        {
            try
            {
                var listSupplier = await GetAllSuppliersDirectAsync();

                if (listSupplier == null || listSupplier.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nhà cung cấp");
                    return;
                }

                dtSuppliers = ConvertToDataTable(listSupplier);
                dgvNCC.DataSource = dtSuppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu nhà cung cấp: " + ex.Message);
            }
        }
        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNCC.Rows[e.RowIndex];
                txtSupplierCode.Text = row.Cells["Mã nhà cung cấp"].Value?.ToString();
                txtSupplierName.Text = row.Cells["Tên nhà cung cấp"].Value?.ToString();
                txtAddress.Text = row.Cells["Địa chỉ"].Value?.ToString();
                txtPhone.Text = row.Cells["Số điện thoại"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                string statusText = row.Cells["Trạng thái"].Value?.ToString();
                cbbStatus.SelectedValue = statusText == "Hoạt động" ? 1 : 0;
            }
        }
        private async Task<string> TaoMaNCCTuDong()
        {
            var danhSachNCC = await GetAllSuppliersDirectAsync();

            if (danhSachNCC == null || danhSachNCC.Count == 0)
                return "NCC01";

            var maxMaNCC = danhSachNCC
                .Select(ncc => ncc.MaNCC)
                .Where(ma => ma.StartsWith("NCC"))
                .Select(ma => int.TryParse(ma.Substring(3), out int so) ? so : 0)
                .Max();

            return "NCC" + (maxMaNCC + 1).ToString("D2");
        }
        private async void btnRandomCode_Click(object sender, EventArgs e)
        {
            txtSupplierCode.Text = await TaoMaNCCTuDong();
        }

        private async Task LoadStatussAsync()
        {
            cbbStatus.Items.Add(0);
            cbbStatus.Items.Add(1);
            cbbStatus.ValueMember = "TrangThai";
            cbbStatus.SelectedIndex = 0;
        }

        private void setStatus()
        {
            var statusList = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "Hoạt động"),
                new KeyValuePair<int, string>(0, "Ngưng hoạt động")
            };

            cbbStatus.DataSource = statusList;
            cbbStatus.DisplayMember = "Value";
            cbbStatus.ValueMember = "Key";
        }


        /* Thêm nhà cung cấp mới */
        private async Task<Supplier> AddSupplierDirectAsync(Supplier supplier)
        {
            var json = JsonSerializer.Serialize(supplier);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/NhaCungCap", content);

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<Supplier>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }

            return null;
        }
        private async void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier
            {
                MaNCC = txtSupplierCode.Text,
                TenNCC = txtSupplierName.Text,
                DiaChi = txtAddress.Text,
                SDT = txtPhone.Text,
                Email = txtEmail.Text,
                TrangThai = Convert.ToInt32(cbbStatus.SelectedValue)
            };

            var result = await AddSupplierDirectAsync(supplier);

            if (result != null)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công!");
                await LoadSupplierAsync();
                ClearForm();
                txtSupplierCode.Text = await TaoMaNCCTuDong();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }

        /* Cập nhật thông tin nhà cung cấp */
        private async Task<bool> UpdateSupplierDirectAsync(string maNCC, Supplier supplier)
        {
            var json = JsonSerializer.Serialize(supplier);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"api/NhaCungCap/Update/{maNCC}", content);
            return response.IsSuccessStatusCode;
        }
        private async void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            string maNCC = txtSupplierCode.Text;
            var supplier = new Supplier
            {
                MaNCC = maNCC,
                TenNCC = txtSupplierName.Text,
                DiaChi = txtAddress.Text,
                SDT = txtPhone.Text,
                Email = txtEmail.Text,
                TrangThai = Convert.ToInt32(cbbStatus.SelectedValue)
            };

            bool result = await UpdateSupplierDirectAsync(maNCC, supplier);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công!");
                await LoadSupplierAsync();
                ClearForm();
                txtSupplierCode.Text = await TaoMaNCCTuDong();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        /* Xóa nhà cung cấp */
        private async Task<bool> DeleteSupplierDirectAsync(string maNCC)
        {
            var response = await _httpClient.DeleteAsync($"api/NhaCungCap/{maNCC}");
            return response.IsSuccessStatusCode;
        }
        private async void btnDelSupplier_Click(object sender, EventArgs e)
        {
            string maNCC = txtSupplierCode.Text;
            bool result = await DeleteSupplierDirectAsync(maNCC);

            if (result)
            {
                MessageBox.Show("Xóa thành công!");
                await LoadSupplierAsync();
                ClearForm();
                txtSupplierCode.Text = await TaoMaNCCTuDong();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        /* Tìm tên nhà cung cấp */
        private void SearchSupplierByName(string searchText)
        {
            if (dtSuppliers == null) return;
            DataView dv = new DataView(dtSuppliers);
            dv.RowFilter = $"[Tên nhà cung cấp] LIKE '%{searchText.Replace("'", "''")}%'";
            dgvNCC.DataSource = dv;
        }
        private void txtSearchSupplierCode_TextChanged(object sender, EventArgs e)
        {
            SearchSupplierByName(txtSearchSupplierCode.Text.Trim());
        }

        private void ClearForm()
        {
            txtSupplierCode.Clear();
            txtSupplierName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cbbStatus.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f = new frmMain();
            f.ShowDialog();
            f.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f = new frmMain();
            f.ShowDialog();
            f.Show();
        }
    }
}
