using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class FrmCustomer : Form
    {
        private DataTable dtCustomers = null;

        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7265/")
        };

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private async void FrmCustomer_Load(object sender, EventArgs e)
        {
            await LoadKhachHangAsync();
            await LoadLoaiKhachHangAsync();
        }

        // JsonConverter to handle nullable DateTime parsing
        public class NullableDateTimeConverter : JsonConverter<DateTime?>
        {
            public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.String)
                {
                    var str = reader.GetString();
                    if (string.IsNullOrEmpty(str)) return null;

                    if (DateTime.TryParse(str, out var date)) return date;

                    return null;
                }
                else if (reader.TokenType == JsonTokenType.Null)
                {
                    return null;
                }
                throw new JsonException();
            }

            public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
            {
                if (value.HasValue)
                    writer.WriteStringValue(value.Value);
                else
                    writer.WriteNullValue();
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private DataTable ConvertToDataTable(List<KhachHang> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tài khoản");
            dt.Columns.Add("Email");
            dt.Columns.Add("Họ tên");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Ngày đăng ký");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Mật khẩu");

            foreach (var kh in list)
            {
                dt.Rows.Add(
                    kh.MaKH ?? "",
                    kh.TaiKhoan ?? "",
                    kh.Email ?? "",
                    kh.TenKH ?? "",
                    kh.SoDienThoai ?? "",
                    kh.NgaySinh,
                    kh.NgayDangKy,
                    kh.DiaChi ?? "",
                    kh.MatKhau ?? ""
                );
            }

            return dt;
        }

        private async Task<List<KhachHang>> GetAllCutomersDirectAsync()
        {
            var response = await _httpClient.GetAsync("api/KhachHang");

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    Converters = { new NullableDateTimeConverter() }
                };

                var customers = await JsonSerializer.DeserializeAsync<List<KhachHang>>(stream, options);
                return customers ?? new List<KhachHang>();
            }

            return new List<KhachHang>();
        }

        private async Task LoadKhachHangAsync()
        {
            try
            {
                var listCustomer = await GetAllCutomersDirectAsync();

                if (listCustomer == null || listCustomer.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu khách hàng");
                    return;
                }

                dtCustomers = ConvertToDataTable(listCustomer);
                dgvKH.DataSource = dtCustomers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu khách hàng: " + ex.Message);
            }
        }

        private async Task LoadLoaiKhachHangAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/LoaiKH");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var list = JsonSerializer.Deserialize<List<TypeCustomer>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    cbbTypeCus.DataSource = list;
                    cbbTypeCus.DisplayMember = "TenLoaiKH";
                    cbbTypeCus.ValueMember = "MaLoaiKH";
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

        private void ClearForm()
        {
            txtCusCode.Clear();
            txtCusName.Clear();
            txtAddressCus.Clear();
            txtPhoneCus.Clear();
            cbbTypeCus.SelectedIndex = 0;
        }

        private async Task<string> TaoMaNCCTuDong()
        {
            var danhSachCustomer = await GetAllCutomersDirectAsync();

            if (danhSachCustomer == null || danhSachCustomer.Count == 0)
                return "KH001";

            var maxMaCus = danhSachCustomer
                .Select(cus => cus.MaKH)
                .Where(ma => ma != null && ma.StartsWith("KH"))
                .Select(ma => int.TryParse(ma.Substring(2), out int so) ? so : 0)
                .DefaultIfEmpty(0)
                .Max();

            return "KH" + (maxMaCus + 1).ToString("D3");
        }

        private async void btnRandomCusCode_Click(object sender, EventArgs e)
        {
            string newMaKH = await TaoMaNCCTuDong();
            txtCusCode.Text = newMaKH;
        }


        private bool ValidateBirthAndWorkDate(DateTime ngaySinh, DateTime ngayVaoLam)
        {
            if (ngaySinh >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại.");
                return false;
            }

            int age = DateTime.Now.Year - ngaySinh.Year;
            if (DateTime.Now < ngaySinh.AddYears(age))
                age--;

            if (age < 16)
            {
                MessageBox.Show("Khách hàng phải có tuổi từ 16 trở lên khi mua hàng.");
                return false;
            }

            return true;
        }
        private async Task<KhachHang> AddCustomerDirectAsync(KhachHang khachHang)
        {
            var json = JsonSerializer.Serialize(khachHang);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/KhachHang/create", content);

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<KhachHang>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Lỗi khi thêm khách hàng: {errorContent}");
                return null;
            }
        }
        private async void btnAddCus_Click(object sender, EventArgs e)
        {
            var loaiKH = cbbTypeCus.SelectedValue?.ToString();
            var hoTen = txtCusName.Text?.Trim().ToLower();
            DateTime ngaySinh = DTPBirth.Value;
            DateTime ngayHT = DateTime.Now;

            if (!ValidateBirthAndWorkDate(ngaySinh, ngayHT))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtCusCode.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc tạo mã khách hàng.");
                return;
            }

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.");
                return;
            }

            string username = "";
            string password = "";

            if (loaiKH == "KHM") // Khách hàng mới
            {
                username = hoTen + "khm";
                password = HashPassword("khm123");
            }
            else if (loaiKH == "KHT") // Khách hàng thường
            {
                username = hoTen + "kht";
                password = HashPassword("kht123");
            }
            else if (loaiKH == "KHV") // Khách hàng vip
            {
                username = hoTen + "khv";
                password = HashPassword("khv123");
            }
            else
            {
                MessageBox.Show("Loại khách hàng không hợp lệ.");
                return;
            }

            var khachHang = new KhachHang
            {
                MaKH = txtCusCode.Text,
                TenKH = txtCusName.Text,
                DiaChi = txtAddressCus.Text,
                SoDienThoai = txtPhoneCus.Text,
                MaLoaiKH = loaiKH,
                TaiKhoan = username,
                MatKhau = password,
                NgaySinh = DTPBirth.Value
            };

            var result = await AddCustomerDirectAsync(khachHang);

            if (result != null)
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                await LoadKhachHangAsync();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKH.Rows[e.RowIndex];
                txtCusCode.Text = row.Cells["Mã khách hàng"].Value?.ToString();
                txtCusName.Text = row.Cells["Họ tên"].Value?.ToString();
                txtAddressCus.Text = row.Cells["Địa chỉ"].Value?.ToString();
                txtPhoneCus.Text = row.Cells["Số điện thoại"].Value?.ToString();
                if (DateTime.TryParse(row.Cells["Ngày sinh"].Value?.ToString(), out DateTime ngaySinh))
                    DTPBirth.Value = ngaySinh;
                // If you have "Loại khách hàng" column, uncomment below:
                // string maLoai = row.Cells["Loại khách hàng"].Value?.ToString();
                // if (!string.IsNullOrEmpty(maLoai))
                //     cbbTypeCus.SelectedValue = maLoai;
            }
        }

        private async Task<bool> DeleteCustomerDirectAsync(string maKH)
        {
            var response = await _httpClient.DeleteAsync($"api/KhachHang/Delete/{maKH}");

            return response.IsSuccessStatusCode;
        }

        private async void btnDeleteCus_Click(object sender, EventArgs e)
        {
            string maKH = txtCusCode.Text;

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.");
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa khách hàng {maKH} không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                bool deleted = await DeleteCustomerDirectAsync(maKH);
                if (deleted)
                {
                    MessageBox.Show("Xóa khách hàng thành công.");
                    await LoadKhachHangAsync();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại.");
                }
            }
        }

        private async Task<bool> UpdateCustomerDirectAsync(KhachHang khachHang)
        {
            var json = JsonSerializer.Serialize(khachHang);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync("api/KhachHang/Update", content);

            return response.IsSuccessStatusCode;
        }

        private async void btnUpdateCus_Click(object sender, EventArgs e)
        {
            var maKH = txtCusCode.Text;
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để cập nhật.");
                return;
            }

            var loaiKH = cbbTypeCus.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(loaiKH))
            {
                MessageBox.Show("Vui lòng chọn loại khách hàng.");
                return;
            }

            var khachHang = new KhachHang
            {
                MaKH = maKH,
                TenKH = txtCusName.Text,
                DiaChi = txtAddressCus.Text,
                SoDienThoai = txtPhoneCus.Text,
                MaLoaiKH = loaiKH,
                // Retain old username and password or update if needed here
                // You may need to fetch existing customer data first or handle accordingly
            };

            bool updated = await UpdateCustomerDirectAsync(khachHang);

            if (updated)
            {
                MessageBox.Show("Cập nhật khách hàng thành công.");
                await LoadKhachHangAsync();
            }
            else
            {
                MessageBox.Show("Cập nhật khách hàng thất bại.");
            }
        }

        private async void btn_Search_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchCusName.Text?.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                await LoadKhachHangAsync();
                return;
            }

            var listCustomer = await GetAllCutomersDirectAsync();

            var filtered = listCustomer.Where(kh =>
                (!string.IsNullOrEmpty(kh.MaKH) && kh.MaKH.ToLower().Contains(searchTerm)) ||
                (!string.IsNullOrEmpty(kh.TenKH) && kh.TenKH.ToLower().Contains(searchTerm)) ||
                (!string.IsNullOrEmpty(kh.SoDienThoai) && kh.SoDienThoai.ToLower().Contains(searchTerm)) ||
                (!string.IsNullOrEmpty(kh.DiaChi) && kh.DiaChi.ToLower().Contains(searchTerm)) ||
                (!string.IsNullOrEmpty(kh.TaiKhoan) && kh.TaiKhoan.ToLower().Contains(searchTerm))
            ).ToList();

            if (filtered.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng.");
            }
            else
            {
                dtCustomers = ConvertToDataTable(filtered);
                dgvKH.DataSource = dtCustomers;
            }
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
