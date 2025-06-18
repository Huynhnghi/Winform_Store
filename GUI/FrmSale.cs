using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;


namespace GUI
{
    public partial class FrmSale : Form
    {
        private DataTable dtSales = null;
        public FrmSale()
        {
            InitializeComponent();
        }

        private async void FrmSale_Load(object sender, EventArgs e)
        {
            cbbstatus.DataSource = new List<dynamic>
            {
                new { Value = 1, Text = "Hoạt động" },
                new { Value = 0, Text = "Ngưng hoạt động" }
            };
            cbbstatus.ValueMember = "Value";
            cbbstatus.DisplayMember = "Text";

            LoadKhuyenMaiLoaiAsync();
            await LoadSalesAsync();
        }

        private DataTable ConvertToDataTable(List<KhuyenMai> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã KM");
            dt.Columns.Add("Tên KM");
            dt.Columns.Add("Mô tả");
            dt.Columns.Add("Mã loại KM");
            dt.Columns.Add("Phần trăm giảm");
            dt.Columns.Add("Giảm tiền");
            dt.Columns.Add("Điều kiện");
            dt.Columns.Add("Ngày bắt đầu");
            dt.Columns.Add("Ngày kết thúc");
            dt.Columns.Add("Trạng thái");
            dt.Columns.Add("Số lượng áp dụng");
            dt.Columns.Add("Số lượng đã áp dụng");

            foreach (var km in list)
            {
                dt.Rows.Add(
                km.MaKM ?? "",
                km.TenKM ?? "",
                km.MoTa ?? "",
                km.MaLoaiKM ?? "",
                km.PhanTramGiam.ToString() ?? "",
                km.GiamTien,
                km.DieuKien,
                km.NgayBatDau.ToString("dd/MM/yyyy") ?? "",
                km.NgayKetThuc.ToString("dd/MM/yyyy") ?? "",
                km.TrangThai == 1 ? "Hoạt động" : "Ngưng hoạt động",
                (km.SoLuongApDung.ToString()) ?? "0",
                (km.SoLuongDaApDung.ToString()) ?? "0"

                );
            }

            return dt;
        }



        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7265/") 
        };
        private async Task<List<KhuyenMai>> GetAllSalesDirectAsync()
        {
            var response = await _httpClient.GetAsync("api/KhuyenMai");

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                var sales = await JsonSerializer.DeserializeAsync<List<KhuyenMai>>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return sales ?? new List<KhuyenMai>();
            }

            return new List<KhuyenMai>();
        }

        private async Task LoadSalesAsync()
        {
            try
            {
                var listSale = await GetAllSalesDirectAsync();

                if (listSale == null || listSale.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu khuyến mãi");
                    return;
                }

                dtSales = ConvertToDataTable(listSale);
                dgvSale.DataSource = dtSales;

                // Cấu hình độ rộng cột cho DataGridView của khuyến mãi
                if (dgvSale.Columns.Contains("Mã KM"))
                    dgvSale.Columns["Mã KM"].Width = 100;
                if (dgvSale.Columns.Contains("Tên KM"))
                    dgvSale.Columns["Tên KM"].Width = 180;
                if (dgvSale.Columns.Contains("Mô tả"))
                    dgvSale.Columns["Mô tả"].Width = 200;
                if (dgvSale.Columns.Contains("Mã loại KM"))
                    dgvSale.Columns["Mã loại KM"].Width = 100;
                if (dgvSale.Columns.Contains("Phần trăm giảm"))
                    dgvSale.Columns["Phần trăm giảm"].Width = 120;
                //if (dgvSale.Columns.Contains("Giảm tối đa"))
                //    dgvSale.Columns["Giảm tối đa"].Width = 120;
                //if (dgvSale.Columns.Contains("Giảm tiền"))
                //    dgvSale.Columns["Giảm tiền"].Width = 120;
                //if (dgvSale.Columns.Contains("Điều kiện"))
                //    dgvSale.Columns["Điều kiện"].Width = 120;
                if (dgvSale.Columns.Contains("Ngày bắt đầu"))
                    dgvSale.Columns["Ngày bắt đầu"].Width = 120;
                if (dgvSale.Columns.Contains("Ngày kết thúc"))
                    dgvSale.Columns["Ngày kết thúc"].Width = 120;
                if (dgvSale.Columns.Contains("Trạng thái"))
                    dgvSale.Columns["Trạng thái"].Width = 100;
                if (dgvSale.Columns.Contains("Số lượng áp dụng"))
                    dgvSale.Columns["Số lượng áp dụng"].Width = 130;
                if (dgvSale.Columns.Contains("Số lượng đã áp dụng"))
                    dgvSale.Columns["Số lượng đã áp dụng"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu khuyến mãi: " + ex.Message);
            }
        }
        private void dgvSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSale.Rows[e.RowIndex];
                txtSaleCode.Text = row.Cells["Mã KM"].Value?.ToString();
                txtSaleName.Text = row.Cells["Tên KM"].Value?.ToString();
                txtPTG.Text = row.Cells["Phần trăm giảm"].Value?.ToString();
                txtDescription.Text = row.Cells["Mô tả"].Value?.ToString();
                txtAmount.Text = row.Cells["Số lượng áp dụng"].Value?.ToString();
                string statusText = row.Cells["Trạng thái"].Value?.ToString();

                if (statusText == "Hoạt động")
                    cbbstatus.SelectedValue = 1;
                else if (statusText == "Ngưng hoạt động")
                    cbbstatus.SelectedValue = 0;
                else
                    cbbstatus.SelectedIndex = -1;
                if (DateTime.TryParse(row.Cells["Ngày bắt đầu"].Value?.ToString(), out DateTime ngaybatdau))
                    DTPStart.Value = ngaybatdau;
                if (DateTime.TryParse(row.Cells["Ngày kết thúc"].Value?.ToString(), out DateTime ngayketthuc))
                    DTPEnd.Value = ngayketthuc;
            }
        }
        private void ClearForm()
        {
            txtSaleCode.Clear();
            txtSaleName.Clear();
            txtPTG.Clear();
            txtAmount.Clear();
            txtDescription.Clear();

            cbbstatus.SelectedIndex = 0;
            CBBTypeKM.SelectedIndex = 0;

            DTPStart.Value = DateTime.Now;
            DTPEnd.Value = DateTime.Now;
        }
        private async Task LoadKhuyenMaiLoaiAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/LoaiKhuyenMai");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var list = JsonSerializer.Deserialize<List<LoaiKM>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    CBBTypeKM.DataSource = list;
                    CBBTypeKM.DisplayMember = "TenLoaiKM";  
                    CBBTypeKM.ValueMember = "MaLoaiKM";
                }
                else
                {
                    MessageBox.Show($"API lỗi: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gọi API: " + ex.Message);
            }
        }

        /* Thêm Khuyến mãi mới */
        private async Task<KhuyenMai> AddSaleDirectAsync(KhuyenMai khuyenMai)
        {
            var json = JsonSerializer.Serialize(khuyenMai);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/KhuyenMai", content);

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<KhuyenMai>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Lỗi khi thêm khuyến mãi: {errorContent}");
            }

            return null;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newKhuyenMai = new KhuyenMai
                {
                    MaKM = txtSaleCode.Text.Trim(),
                    TenKM = txtSaleName.Text.Trim(),
                    MoTa = txtDescription.Text.Trim(),
                    MaLoaiKM = CBBTypeKM.SelectedValue?.ToString(), 
                    PhanTramGiam = int.TryParse(txtPTG.Text.Trim(), out int ptg) ? ptg : 0,
                    GiamTien = decimal.TryParse(txtGiamTien.Text.Trim(), out decimal giamTien) ? giamTien : (decimal?)null,
                    DieuKien = decimal.TryParse(txtDieuKien.Text.Trim(), out decimal dieuKien) ? dieuKien : (decimal?)null,
                    NgayBatDau = DTPStart.Value,
                    NgayKetThuc = DTPEnd.Value,
                    TrangThai = (cbbstatus.SelectedValue != null && int.TryParse(cbbstatus.SelectedValue.ToString(), out int trangthai)) ? trangthai : 0,
                    SoLuongApDung = int.TryParse(txtAmount.Text.Trim(), out int soLuongApDung) ? soLuongApDung : 0,
                    SoLuongDaApDung = 0 
                };

                var result = await AddSaleDirectAsync(newKhuyenMai);

                if (result != null)
                {
                    MessageBox.Show("Thêm khuyến mãi thành công!");
                    await LoadSalesAsync();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khuyến mãi: " + ex.Message);
            }
        }

        /* Cập nhật thông tin khuyến mãi */
        private async Task<bool> UpdateSaleDirectAsync(string maKM, KhuyenMai khuyenMai)
        {
            var json = JsonSerializer.Serialize(khuyenMai);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"api/KhuyenMai/{maKM}", content);
            return response.IsSuccessStatusCode;
        }
        private async Task<KhuyenMai> GetSaleByIdAsync(string maKM)
        {
            var response = await _httpClient.GetAsync($"api/KhuyenMai/{maKM}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<KhuyenMai>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }

            return null;
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string maKM = txtSaleCode.Text.Trim();
                if (string.IsNullOrEmpty(maKM))
                {
                    MessageBox.Show("Vui lòng chọn mã khuyến mãi để cập nhật.");
                    return;
                }

                var oldData = await GetSaleByIdAsync(maKM);
                if (oldData == null)
                {
                    MessageBox.Show("Không tìm thấy khuyến mãi để cập nhật.");
                    return;
                }

                // Cập nhật thông tin mới
                oldData.TenKM = txtSaleName.Text.Trim();
                oldData.MoTa = txtDescription.Text.Trim();
                oldData.MaLoaiKM = CBBTypeKM.SelectedValue?.ToString();
                oldData.PhanTramGiam = int.TryParse(txtPTG.Text.Trim(), out int ptg) ? ptg : 0;
                oldData.NgayBatDau = DTPStart.Value;
                oldData.NgayKetThuc = DTPEnd.Value;
                oldData.TrangThai = (cbbstatus.SelectedValue != null && int.TryParse(cbbstatus.SelectedValue.ToString(), out int trangthai)) ? trangthai : 0;
                oldData.SoLuongApDung = int.TryParse(txtAmount.Text.Trim(), out int soLuong) ? soLuong : 0;
                // Giữ nguyên SoLuongDaApDung hiện tại

                var success = await UpdateSaleDirectAsync(maKM, oldData);
                if (success)
                {
                    MessageBox.Show("Cập nhật khuyến mãi thành công!");
                    await LoadSalesAsync();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật khuyến mãi: " + ex.Message);
            }
        }

        /* Xóa khuyến mãi */
        private async Task<bool> DeleteSaleDirectAsync(string MaKM)
        {
            var response = await _httpClient.DeleteAsync($"api/KhuyenMai/{MaKM}");
            return response.IsSuccessStatusCode;
        }
        private async void btnDel_Click(object sender, EventArgs e)
        {
            string maKM = txtSaleCode.Text;
            bool result = await DeleteSaleDirectAsync(maKM);

            if (result)
            {
                MessageBox.Show("Xóa thành công!");
                await LoadSalesAsync();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        /* Tìm kiếm tên khuyến mãi */
        private void SearchSaleByName(string searchText)
        {
            if (dtSales == null) return;
            DataView dv = new DataView(dtSales);
            dv.RowFilter = $"[Tên KM] LIKE '%{searchText.Replace("'", "''")}%'";
            dgvSale.DataSource = dv;
        }
        private void txtSearchSaleName_TextChanged(object sender, EventArgs e)
        {
            SearchSaleByName(txtSearchSaleName.Text.Trim());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f = new frmMain();
            f.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f = new frmMain();
            f.Show();
        }
    }
}
