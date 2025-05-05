using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class FrmLogin : Form
    {
        private readonly LoginBLL _loginBLL;
        public FrmLogin()
        {
            InitializeComponent();
            _loginBLL = new LoginBLL();
            ckHienThi.Cursor = Cursors.Hand;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '*';
            txtTDN.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTDN.Text;
            string password = txtMK.Text;

            // Gọi hàm từ BLL
            bool loginSuccess = _loginBLL.CheckLogin(username, password); // hoặc _loginBLL.LoginDirect(username, password);

            if (loginSuccess)
            {
                // Nếu bạn có class CurrentUser (singleton), gọi như sau:
                CurrentUser.Instance.Username = username;

                MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Form mainForm = new frmMain();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHienThi.Checked == true)
            {
                txtMK.PasswordChar = (char)0;
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
