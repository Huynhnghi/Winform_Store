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
    public partial class FrmPofile : Form
    {
        //private readonly LoginBLL _accountBLL;
        public FrmPofile()
        {
            InitializeComponent();
            //_accountBLL = new LoginBLL();
            txtPassOld.PasswordChar = '*';
            txtNewPass.PasswordChar = '*';
            txtNhapLaiPass.PasswordChar = '*';

        }
        private void loadCbbQuyen()
        {
            //permissionBLL bll = new permissionBLL();
            //var roleList = bll.GetNameRole();

            //if (roleList != null && roleList.Count > 0)
            //{
            //    cbbRole.DataSource = roleList;
            //    cbbRole.DisplayMember = "RoleName";
            //    cbbRole.SelectedIndex = 0;
            //}
            //else
            //{
            //    MessageBox.Show("Không có quyền nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }



        private void LoadUserName(string currentUsername)
        {
            //string userName = _accountBLL.GetAccountNames(currentUsername);

            //if (userName != null)
            //{
            //    lbUserName.Text = userName;
            //}
            //else
            //{
            //    MessageBox.Show("Không tìm thấy tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void LoadAccount()
        {
            //try
            //{
            //    DataTable dt = _accountBLL.GetAccountsAsDataTable();

            //    if (dt.Rows.Count == 0)
            //    {
            //        MessageBox.Show("Không có dữ liệu trong collection Account.");
            //        return;
            //    }

            //    dgvND.DataSource = dt;
            //    dgvND.Columns["Tên đăng nhập"].Width = 200;
            //    dgvND.Columns["Mật khẩu"].Width = 120;
            //    dgvND.Columns["Quyền"].Width = 170;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            //}
        }

        private void FrmPofile_Load(object sender, EventArgs e)
        {
            lbNameDN.Text = CurrentUser.User.HoTen;
            txtDN.Text = CurrentUser.User.Username;
            //LoadAccount();

            //try
            //{
            //    string currentUsername = CurrentUser.Instance.Username;
            //    LoadUserName(currentUsername);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //loadCbbQuyen();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string username = txtDN.Text.Trim(); 
            //    //string password = txtMK.Text.Trim(); 
            //    //string role = cbbRole.SelectedValue.ToString(); 

            //    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            //    {
            //        MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    bool isAdded = _accountBLL.AddAccount(username, password, role);

            //    if (isAdded)
            //    {
            //        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LoadAccount(); 
            //    }
            //    else
            //    {
            //        MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        /* Cập nhật tên tài khoản */
        private async Task UpdateAccountUsernameAsync(string maNV, string tenDangNhapMoi)
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator; // Bypass HTTPS nếu cần

            var httpClient = new HttpClient(handler);
            var url = $"https://localhost:7265/api/NhanVien/UpdateAccountPartial/{maNV}";

            var data = new
            {
                MaNV = maNV,
                TenDangNhap = tenDangNhapMoi
            };

            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PutAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLogin f = new FrmLogin();
                    f.Show();
                    this.Close();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Lỗi cập nhật: {error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gọi API: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnCapNhat_Click(object sender, EventArgs e)
        {
            string newUsername = txtDN.Text.Trim();

            if (string.IsNullOrEmpty(newUsername))
            {
                MessageBox.Show("Tên đăng nhập không thể trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = CurrentUser.User.MaNhanVien; // Lấy mã NV từ người dùng đang đăng nhập

            await UpdateAccountUsernameAsync(maNV, newUsername);

            // Cập nhật giao diện nếu cần
            txtDN.Text = newUsername;
        }

        private void dgvND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    LoadUserName(LoginDAL.CurrentUsername);
            //    RefreshDataGridView();
            //}
        }

        private void RefreshDataGridView()
        {
            //dgvND.DataSource = _accountBLL.GetAccount();
            //dgvND.Refresh();
        }

        private async Task UpdatePasswordAsync(string maNV, string password)
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator; 

            var httpClient = new HttpClient(handler);
            var url = $"https://localhost:7265/api/NhanVien/UpdatePass/{maNV}";

            var data = new
            {
                MaNV = maNV,
                password = password
            };

            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PutAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLogin f = new FrmLogin();
                    f.Show();
                    this.Close();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Lỗi cập nhật: {error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gọi API: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCapNhatPass_Click(object sender, EventArgs e)
        {
            string currentPassword = txtPassOld.Text.Trim();
            string newPassword = txtNewPass.Text.Trim();
            string confirmPassword = txtNhapLaiPass.Text.Trim();

            if ( string.IsNullOrEmpty(currentPassword) ||
                string.IsNullOrEmpty(newPassword) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnCapNhatQuyen_Click(object sender, EventArgs e)
        {
            //string currentUsername = LoginDAL.CurrentUsername;
            //string newRoleName = cbbRole.SelectedValue.ToString();

            //if (string.IsNullOrWhiteSpace(newRoleName))
            //{
            //    MessageBox.Show("Vui lòng chọn vai trò mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //LoginDAL loginDal = new LoginDAL();
            //bool isUpdated = loginDal.UpdateRoleId(currentUsername, newRoleName);

            //if (isUpdated)
            //{
            //    MessageBox.Show("Cập nhật quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    loadCbbQuyen();
            //    LoadAccount();
            //}
            //else
            //{
            //    MessageBox.Show("Cập nhật quyền không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void ckHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHienThi.Checked == true)
            {
                txtNewPass.PasswordChar = (char)0;
                txtNhapLaiPass.PasswordChar = (char)0;
            }
            else
            {
                txtNewPass.PasswordChar = '*';
                txtNhapLaiPass.PasswordChar = '*';
            }
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked == true)
            {
                txtPassOld.PasswordChar = (char)0;
            }
            else
            {
                txtPassOld.PasswordChar = '*';
            }
        }
    }
}
