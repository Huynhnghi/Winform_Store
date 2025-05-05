using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
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
            var loginDal = new LoginDAL();
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
            this.Hide();
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //string newUsername = txtDN.Text.Trim();

            //if (string.IsNullOrEmpty(newUsername))
            //{
            //    MessageBox.Show("Tên đăng nhập không thể trống.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //LoginBLL loginBll = new LoginBLL();
            //bool isUpdated = loginBll.UpdateUsername(newUsername);

            //if (isUpdated)
            //{
            //    MessageBox.Show("Cập nhật tên thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    lbUserName.Text = LoginDAL.CurrentUsername;
            //    LoadUserName(LoginDAL.CurrentUsername);
            //}
            //else
            //{
            //    MessageBox.Show("Cập nhật không thành công. vui lòng kiểm tra lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

        private void btnCapNhatPass_Click(object sender, EventArgs e)
        {
            //string currentUsername = LoginDAL.CurrentUsername;
            //string currentPassword = txtPassOld.Text.Trim();
            //string newPassword = txtNewPass.Text.Trim();
            //string confirmPassword = txtNhapLaiPass.Text.Trim();

            //if (string.IsNullOrEmpty(currentUsername) ||
            //    string.IsNullOrEmpty(currentPassword) ||
            //    string.IsNullOrEmpty(newPassword) ||
            //    string.IsNullOrEmpty(confirmPassword))
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //LoginBLL loginBll = new LoginBLL();
            //bool isCurrentPasswordValid = loginBll.Login(currentUsername, currentPassword);
            //if (!isCurrentPasswordValid)
            //{
            //    MessageBox.Show("Mật khẩu hiện tại không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (newPassword != confirmPassword)
            //{
            //    MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không trùng khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //bool isUpdated = loginBll.UpdateUserPassword(currentUsername, newPassword);

            //if (isUpdated)
            //{
            //    MessageBox.Show("Cập nhật mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Hide();
            //    frmMain f = new frmMain();
            //    f.ShowDialog();
            //    f.Show();
            //    txtPassOld.Clear();
            //    txtNewPass.Clear();
            //    txtNhapLaiPass.Clear();
            //}
            //else
            //{
            //    MessageBox.Show("Cập nhật mật khẩu không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
