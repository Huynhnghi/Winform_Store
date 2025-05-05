using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Diagnostics;

namespace GUI
{
    public partial class FrmCustomer : Form
    {
        //private readonly CustomerBLL _customerBLL;
        public FrmCustomer()
        {
            InitializeComponent();
            //_customerBLL = new CustomerBLL();
        }


        private void dgvKH_Click(object sender, EventArgs e)
        {

        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            //try
            //{
            //    DataTable dt = _customerBLL.GetCustomerAsDataTable();

            //    if (dt.Rows.Count == 0)
            //    {
            //        MessageBox.Show("Không có dữ liệu trong collection Customer.");
            //        return;
            //    }

            //    dgvKH.DataSource = dt;
            //    dgvKH.Columns["Mã khách hàng"].Width = 100;
            //    dgvKH.Columns["Tên khách hàng"].Width = 150;
            //    dgvKH.Columns["Email"].Width = 200;
            //    dgvKH.Columns["Ngày đăng ký"].Width = 120;
            //    dgvKH.Columns["Số điện thoại"].Width = 100;
            //    dgvKH.Columns["Địa chỉ"].Width = 250;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            //}
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //string id_customer = txtMaKH.Text;
            //string name = txtTenKH.Text;
            //string email = txtEmail.Text;
            //string phone = txtSDT.Text;
            //string address = txtDiaChi.Text;
            //string registration_date = dateTimePicker1.Text;
            //try
            //{
            //    _customerBLL.UpdateCustomer(id_customer, name, email, phone, address, registration_date);
            //    LoadCustomer();
            //    MessageBox.Show("Cập nhật khách hàng thành công!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi cập nhật khách hàng: " + ex.Message);
            //}
        }


        //private bool IsValidEmail(string email)
        //{
        //    //try
        //    //{
        //    //    var addr = new System.Net.Mail.MailAddress(email);
        //    //    return addr.Address == email;
        //    //}
        //    //catch
        //    //{
        //    //    return false;
        //    //}
        //}
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //// Get values from input fields
            //string id_customer = txtMaKH.Text.Trim();
            //string name = txtTenKH.Text.Trim();
            //string email = txtEmail.Text.Trim();
            //string phone = txtSDT.Text.Trim();
            //string address = txtDiaChi.Text.Trim();
            //string registration_date = dateTimePicker1.Text.Trim();

            //// Check for empty fields
            //if (string.IsNullOrEmpty(id_customer) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(registration_date))
            //{
            //    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            //    return;
            //}

            //// Validate email format
            //if (!IsValidEmail(email))
            //{
            //    MessageBox.Show("Email không hợp lệ.");
            //    return;
            //}

            //try
            //{
            //    _customerBLL.AddCustomer(id_customer, name, email, phone, address, registration_date);

            //    LoadCustomer();
            //    MessageBox.Show("Thêm khách hàng thành công!");
            //    NewCustomer();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
            //}
        }
        public void NewCustomer()
        {
            //txtMaKH.Clear();
            //txtTenKH.Clear();
            //txtEmail.Clear();
            //txtSDT.Clear();
            //txtDiaChi.Clear();
            //dateTimePicker1.Value = DateTime.Now;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmMain f = new frmMain();
            //f.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //string customerId = txtMaKH.Text;
            //var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if (confirmResult == DialogResult.Yes)
            //{
            //    try
            //    {
            //        _customerBLL.DeletetCustomer(customerId);
            //        LoadCustomer();
            //        MessageBox.Show("Xóa khách hàng thành công!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
            //    }
            //}
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //string searchName = txtMaKH.Text;

            //if (string.IsNullOrEmpty(searchName))
            //{
            //    MessageBox.Show("Vui lòng nhập tên khách hàng để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //try
            //{
            //    List<BsonDocument> customers = _customerBLL.SearchCustomer(searchName);
            //    DataTable dt = new DataTable();
            //    dt.Columns.Add("Mã khách hàng", typeof(string));
            //    dt.Columns.Add("Tên khách hàng", typeof(string));
            //    dt.Columns.Add("Email", typeof(string));
            //    dt.Columns.Add("Số điện thoại", typeof(string));
            //    dt.Columns.Add("Địa chỉ", typeof(string));
            //    dt.Columns.Add("Ngày đăng ký", typeof(string));

            //    foreach (var cus in customers)
            //    {
            //        DataRow row = dt.NewRow();
            //        row["Mã khách hàng"] = cus["id_customer"].ToString();
            //        row["Tên khách hàng"] = cus["name"].ToString();
            //        row["Email"] = cus["email"].ToString();
            //        row["Số điện thoại"] = cus["phone"].ToString();
            //        row["Địa chỉ"] = cus["address"].ToString();
            //        row["Ngày đăng ký"] = cus["registration_date"].ToString();
            //        dt.Rows.Add(row);
            //    }

            //    // Gán DataTable vào DataGridView
            //    dgvKH.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtMaKH.Text))
            //{
            //    LoadCustomer();
            //}
        }
    }
}


