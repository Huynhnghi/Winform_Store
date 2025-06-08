using System;
using System.Security.Cryptography;
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
    public partial class FrmStaff : Form
    {
        
        private DataTable dtStaffs = null;
        public FrmStaff()
        {
            InitializeComponent();
            
        }

        private async void FrmStaff_Load(object sender, EventArgs e)
        {
            LoadSexComboBox();
            await LoadStaffsAsync();
            await LoadChucVuAsync();
            await LoadQuyenAsync();
            

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

        private DataTable ConvertToDataTable(List<NhanVien> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Họ tên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Email");
            dt.Columns.Add("Ngày vào làm");
            dt.Columns.Add("Mã quyền");
            dt.Columns.Add("Mã chức vụ");

            foreach (var sup in list)
            {
                dt.Rows.Add(
                    sup.MaNhanVien ?? "",
                    sup.HoTen ?? "",
                    sup.NgaySinh,
                    sup.GioiTinh ? "Nam" : "Nữ",
                    sup.DiaChi ?? "",
                    sup.SDT ?? "",
                    sup.Email ?? "",
                    sup.NgayVaoLam,
                    sup.MaQuyen ?? "",
                    sup.MaCV ?? ""
                );
            }

            return dt;
        }

        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7265/") // Chỉnh đúng địa chỉ API của bạn
        };
        private async Task<List<NhanVien>> GetAllStaffsDirectAsync()
        {
            var response = await _httpClient.GetAsync("api/NhanVien");

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                var staffs = await JsonSerializer.DeserializeAsync<List<NhanVien>>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return staffs ?? new List<NhanVien>();
            }

            return new List<NhanVien>();
        }

        private async Task LoadStaffsAsync()
        {
            try
            {
                var listStaff = await GetAllStaffsDirectAsync();

                if (listStaff == null || listStaff.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nhân viên");
                    return;
                }

                dtStaffs = ConvertToDataTable(listStaff);
                dgvStaff.DataSource = dtStaffs;
                // Set column widths
                if (dgvStaff.Columns.Contains("Mã nhân viên"))
                    dgvStaff.Columns["Mã nhân viên"].Width = 120;
                if (dgvStaff.Columns.Contains("Họ tên"))
                    dgvStaff.Columns["Họ tên"].Width = 180;
                if (dgvStaff.Columns.Contains("Ngày sinh"))
                    dgvStaff.Columns["Ngày sinh"].Width = 120;
                if (dgvStaff.Columns.Contains("Giới tính"))
                    dgvStaff.Columns["Giới tính"].Width = 80;
                if (dgvStaff.Columns.Contains("Địa chỉ"))
                    dgvStaff.Columns["Địa chỉ"].Width = 200;
                if (dgvStaff.Columns.Contains("Số điện thoại"))
                    dgvStaff.Columns["Số điện thoại"].Width = 130;
                if (dgvStaff.Columns.Contains("Email"))
                    dgvStaff.Columns["Email"].Width = 200;
                if (dgvStaff.Columns.Contains("Ngày vào làm"))
                    dgvStaff.Columns["Ngày vào làm"].Width = 120;
                if (dgvStaff.Columns.Contains("Mã quyền"))
                    dgvStaff.Columns["Mã quyền"].Width = 100;
                if (dgvStaff.Columns.Contains("Mã chức vụ"))
                    dgvStaff.Columns["Mã chức vụ"].Width = 100;

                // Nếu cần ẩn các cột bổ sung thực tế (VD: tài khoản/password), bạn thêm sau khi có cột đó trong DataTable
                // dgvStaff.Columns["Tài khoản"].Visible = false;
                // dgvStaff.Columns["Password"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu nhân viên: " + ex.Message);
            }
        }
        
        /* Tạo mã nhân viên tự động */
        private async Task<string> TaoMaNCCTuDong()
        {
            var danhSachStaff = await GetAllStaffsDirectAsync();

            if (danhSachStaff == null || danhSachStaff.Count == 0)
                return "NV001";

            var maxMaStaff = danhSachStaff
                .Select(staff => staff.MaNhanVien)
                .Where(ma => ma.StartsWith("NV"))
                .Select(ma => int.TryParse(ma.Substring(3), out int so) ? so : 0)
                .Max();

            return "NV" + (maxMaStaff + 1).ToString("D3");
        }
        private async void btnCode_Click(object sender, EventArgs e)
        {
            txtStaffCode.Text = await TaoMaNCCTuDong();
        }

        private void LoadSexComboBox()
        {
            cbbSex.Items.Clear();
            cbbSex.Items.Add("Nam");
            cbbSex.Items.Add("Nữ");
            cbbSex.SelectedIndex = 0; // Hoặc -1 nếu không muốn mặc định chọn
        }

        private void ClearForm()
        {
            txtStaffCode.Clear();
            txtStaffName.Clear();
            txtAddressStaff.Clear();
            txtEmail.Clear();
            txtPhoneStaff.Clear();

            cbbCodeCV.SelectedIndex = 0;
            cbbRole.SelectedIndex = 0;
            cbbSex.SelectedIndex = 0;

            DTPBirth.Value = DateTime.Now;
            DTPDateWork.Value = DateTime.Now;
        }

        private bool ValidateBirthAndWorkDate(DateTime ngaySinh, DateTime ngayVaoLam)
        {
            if (ngaySinh >= ngayVaoLam)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày vào làm.");
                return false;
            }

            int age = ngayVaoLam.Year - ngaySinh.Year;
            if (ngayVaoLam < ngaySinh.AddYears(age))
                age--;

            if (age < 16)
            {
                MessageBox.Show("Nhân viên phải có tuổi từ 16 trở lên khi vào làm.");
                return false;
            }

            return true;
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvStaff.Rows[e.RowIndex];

                txtStaffCode.Text = row.Cells["Mã nhân viên"].Value?.ToString();
                txtStaffName.Text = row.Cells["Họ tên"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["Ngày sinh"].Value?.ToString(), out DateTime ngaySinh))
                    DTPBirth.Value = ngaySinh;
                string gioiTinh = row.Cells["Giới tính"].Value?.ToString();

                if (!string.IsNullOrEmpty(gioiTinh) && cbbSex.Items.Contains(gioiTinh))
                {
                    cbbSex.SelectedValue = gioiTinh;
                }
                else
                {
                    cbbSex.SelectedIndex = -1; 
                }


                txtAddressStaff.Text = row.Cells["Địa chỉ"].Value?.ToString();
                txtPhoneStaff.Text = row.Cells["Số điện thoại"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["Ngày vào làm"].Value?.ToString(), out DateTime ngayVaoLam))
                    DTPDateWork.Value = ngayVaoLam;

                string maCV = row.Cells["Mã chức vụ"].Value?.ToString();
                if (!string.IsNullOrEmpty(maCV))
                    cbbCodeCV.SelectedValue = maCV;

                string maQuyen = row.Cells["Mã quyền"].Value?.ToString();
                if (!string.IsNullOrEmpty(maQuyen))
                    cbbRole.SelectedValue = maQuyen;
            }
        }

        private async Task LoadChucVuAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/ChucVu");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var list = JsonSerializer.Deserialize<List<ChucVu>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    cbbCodeCV.DataSource = list;
                    cbbCodeCV.DisplayMember = "TenCV";   // phải trùng với property
                    cbbCodeCV.ValueMember = "MaCV";
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

        private async Task LoadQuyenAsync()
        {
            var response = await _httpClient.GetAsync("api/QuyenHan");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var list = JsonSerializer.Deserialize<List<QuyenHan>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                cbbRole.DataSource = list;
                cbbRole.DisplayMember = "TenQuyen"; // tên hiển thị
                cbbRole.ValueMember = "MaQuyen";    // giá trị thực sự (dùng gán SelectedValue)
            }
        }

        /* Cập nhật thông tin nhân viên */
        private async Task<bool> UpdateStaffDirectAsync(string maNV, NhanVien nhanVien)
        {
            var json = JsonSerializer.Serialize(nhanVien);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"api/NhanVien/{maNV}", content);
            return response.IsSuccessStatusCode;
        }
        private async Task<NhanVien> GetStaffByIdAsync(string maNV)
        {
            var response = await _httpClient.GetAsync($"api/NhanVien/{maNV}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<NhanVien>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }

            return null;
        }
        private async void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            string maNV = txtStaffCode.Text.Trim();
            DateTime ngaySinh = DTPBirth.Value;
            DateTime ngayVaoLam = DTPDateWork.Value;

            if (!ValidateBirthAndWorkDate(ngaySinh, ngayVaoLam))
            {
                return;
            }
            // Lấy dữ liệu nhân viên hiện tại (để giữ Username & Password)
            var oldData = await GetStaffByIdAsync(maNV);
            if (oldData == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên để cập nhật.");
                return;
            }

            // Cập nhật thông tin mới
            oldData.HoTen = txtStaffName.Text;
            oldData.NgaySinh = DTPBirth.Value;
            oldData.GioiTinh = cbbSex.SelectedItem?.ToString() == "Nam";
            oldData.DiaChi = txtAddressStaff.Text;
            oldData.SDT = txtPhoneStaff.Text;
            oldData.Email = txtEmail.Text;
            oldData.NgayVaoLam = DTPDateWork.Value;
            oldData.MaCV = cbbCodeCV.SelectedValue?.ToString();
            oldData.MaQuyen = cbbRole.SelectedValue?.ToString();

            bool result = await UpdateStaffDirectAsync(maNV, oldData);

            if (result)
            {
                MessageBox.Show("Cập nhật thành công!");
                await LoadStaffsAsync();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        /* Thêm nhân viên mới */
        private async Task<NhanVien> AddStaffDirectAsync(NhanVien nhanVien)
        {
            var json = JsonSerializer.Serialize(nhanVien);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/NhanVien", content);

            if (response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<NhanVien>(stream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Lỗi khi thêm nhân viên: {errorContent}");
            }

            return null;
        }
        private async void btnAddStaff_Click(object sender, EventArgs e)
        {
            var maQuyen = cbbRole.SelectedValue?.ToString();
            var hoTen = txtStaffName.Text?.Trim().ToLower(); 

            DateTime ngaySinh = DTPBirth.Value;
            DateTime ngayVaoLam = DTPDateWork.Value;

            if (!ValidateBirthAndWorkDate(ngaySinh, ngayVaoLam))
            {
                return;
            }

            string username = "";
            string password = "";

            if (maQuyen == "Q01") // Admin
            {
                username = hoTen + "admin";
                password = HashPassword("admin123");
            }
            else if (maQuyen == "Q02") // Nhân viên
            {
                username = hoTen + "nv";
                password = HashPassword("banhang123");
            }

            var nhanVien = new NhanVien
            {
                MaNhanVien = txtStaffCode.Text,
                HoTen = txtStaffName.Text,
                DiaChi = txtAddressStaff.Text,
                SDT = txtPhoneStaff.Text,
                Email = txtEmail.Text,
                NgaySinh = DTPBirth.Value,
                NgayVaoLam = DTPDateWork.Value,
                GioiTinh = cbbSex.SelectedItem?.ToString() == "Nam",
                MaCV = cbbCodeCV.SelectedValue?.ToString(),
                MaQuyen = maQuyen,
                Username = username,
                Password = password
            };

            var result = await AddStaffDirectAsync(nhanVien);

            if (result != null)
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                await LoadStaffsAsync();
                ClearForm();
                txtStaffCode.Text = await TaoMaNCCTuDong();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }

        /* Xóa nhân viên */
        private async Task<bool> DeleteStaffDirectAsync(string MaNV)
        {
            var response = await _httpClient.DeleteAsync($"api/NhanVien/{MaNV}");
            return response.IsSuccessStatusCode;
        }
        private async void btnDelStaff_Click(object sender, EventArgs e)
        {
            string maNV = txtStaffCode.Text;
            bool result = await DeleteStaffDirectAsync(maNV);

            if (result)
            {
                MessageBox.Show("Xóa thành công!");
                await LoadStaffsAsync();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Xóa thất bại! Nhân viên này có liên quan đến hóa đơn");
            }
        }

        /* Tìm kiếm tên nhân viên */
        private void SearchStaffByName(string searchText)
        {
            if (dtStaffs == null) return;
            DataView dv = new DataView(dtStaffs);
            dv.RowFilter = $"[Họ tên] LIKE '%{searchText.Replace("'", "''")}%'";
            dgvStaff.DataSource = dv;
        }
        private void txtMaEvent_TextChanged(object sender, EventArgs e)
        {
            SearchStaffByName(txtSearchNameStaff.Text.Trim());
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
