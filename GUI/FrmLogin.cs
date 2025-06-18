using System;
using System.Security.Cryptography;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
            txtMK.PasswordChar = '*';
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Không cần xử lý gì khi load form
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

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTDN.Text.Trim();
            string password = txtMK.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(HashPassword(password)))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.");
                return;
            }

            var loginData = new
            {
                Username = username,
                Password = password
            };

            try
            {
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };

                var client = new HttpClient(handler)
                {
                    BaseAddress = new Uri("https://localhost:7265/")
                };


                string json = JsonSerializer.Serialize(loginData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("api/NhanVien/login", content);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    try
                    {
                        var nhanVien = JsonSerializer.Deserialize<NhanVien>(result, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        if (nhanVien != null)
                        {
                            CurrentUser.User = nhanVien;
                            SessionManager.MaNhanVien = nhanVien.MaNhanVien;

                            MessageBox.Show($"Đăng nhập thành công. Xin chào {nhanVien.HoTen}!", "Thông báo");

                            frmMain mainForm = new frmMain();
                            this.Hide();
                            mainForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Không thể đọc thông tin người dùng từ phản hồi.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi phân tích JSON: " + ex.Message);
                    }
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu.\n" + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gọi API:\n" + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckHienThi_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.PasswordChar = ckHienThi.Checked ? '\0' : '*';
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e) { }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e) { }
    }
}
