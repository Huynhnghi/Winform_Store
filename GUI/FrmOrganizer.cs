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

namespace GUI
{
    public partial class FrmOrganizer : Form
    {
        //private readonly OrganizerBLL _organizerBLL;
        public FrmOrganizer()
        {
            InitializeComponent();
            //_organizerBLL = new OrganizerBLL();

        }

        private void FrmOrganizer_Load(object sender, EventArgs e)
        {
            LoadOrganizer();
        }
        private void LoadOrganizer()
        {
            //try
            //{
            //    DataTable dt = _organizerBLL.GetOrganizerAsDataTable();

            //    if (dt.Rows.Count == 0)
            //    {
            //        MessageBox.Show("Không có dữ liệu trong collection Organizers.");
            //        return;
            //    }

            //    dgvBTC.DataSource = dt;
            //    dgvBTC.Columns["Mã ban tổ chức"].Width = 100;
            //    dgvBTC.Columns["Tên ban tổ chức"].Width = 250;
            //    dgvBTC.Columns["Email"].Width = 200;
            //    dgvBTC.Columns["Số điện thoại"].Width = 100;
            //    dgvBTC.Columns["Địa chỉ"].Width = 250;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            //}
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //string searchName = txtMatc.Text;

            //if (string.IsNullOrEmpty(searchName))
            //{
            //    MessageBox.Show("Vui lòng nhập tên ban tổ chức để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //try
            //{
            //    List<BsonDocument> organizers = _organizerBLL.SearchOrganizer(searchName);
            //    DataTable dt = new DataTable();
            //    dt.Columns.Add("Mã ban tổ chức", typeof(string));
            //    dt.Columns.Add("Tên ban tổ chức", typeof(string));
            //    dt.Columns.Add("Email", typeof(string));
            //    dt.Columns.Add("Số điện thoại", typeof(string));
            //    dt.Columns.Add("Địa chỉ", typeof(string));

            //    foreach (var org in organizers)
            //    {
            //        DataRow row = dt.NewRow();
            //        row["Mã ban tổ chức"] = org["organizer_id"].ToString();
            //        row["Tên ban tổ chức"] = org["name"].ToString();
            //        row["Email"] = org["email"].ToString();
            //        row["Số điện thoại"] = org["phone"].ToString();
            //        row["Địa chỉ"] = org["address"].ToString();
            //        dt.Rows.Add(row);
            //    }

            //    // Gán DataTable vào DataGridView
            //    dgvBTC.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ////if (dgvBTC.SelectedRows.Count == 0)
            ////{
            ////    MessageBox.Show("Vui lòng chọn nhà tổ chức cần chỉnh sửa!.");
            ////    return;
            ////}
            //string organizerId = txtMaBTC.Text;
            //string name = txtTenBTC.Text;
            //string address = txtDiaChiBTC.Text;
            //string phone = txtSDTBTC.Text;
            //string email = txtEmailBTC.Text;
            //try
            //{
            //    _organizerBLL.UpdateOrganizer(organizerId, name, address, phone, email);
            //    LoadOrganizer();
            //    MessageBox.Show("Cập nhật nhà tổ chức thành công!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi cập nhật nhà tổ chức: " + ex.Message);
            //}
        }

        private void dgvBTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dgvBTC.Rows[e.RowIndex];
            //    txtMaBTC.Text = row.Cells["Mã ban tổ chức"].Value.ToString();
            //    txtTenBTC.Text = row.Cells["Tên ban tổ chức"].Value.ToString();
            //    txtEmailBTC.Text = row.Cells["Email"].Value.ToString();
            //    txtSDTBTC.Text = row.Cells["Số điện thoại"].Value.ToString();
            //    txtDiaChiBTC.Text = row.Cells["Địa chỉ"].Value.ToString();
            //}
        }
        public void NewOrganizer()
        {
            txtMaBTC.Clear();
            txtTenBTC.Clear();
            txtDiaChiBTC.Clear();
            txtSDTBTC.Clear();
            txtEmailBTC.Clear();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //string organizerId = txtMaBTC.Text;
            //var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà tổ chức này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if (confirmResult == DialogResult.Yes)
            //{
            //    try
            //    {
            //        _organizerBLL.DeletetOrganizer(organizerId);
            //        LoadOrganizer();
            //        MessageBox.Show("Xóa nhà tổ chức thành công!");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi khi xóa nhà tổ chức: " + ex.Message);
            //    }
            //}
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f = new frmMain();
            f.ShowDialog();
            f.Show();

        }
    }
}
            //string organizerId = txtMaBTC.Text.Trim();
            //string name = txtTenBTC.Text.Trim();
            //string address = txtDiaChiBTC.Text.Trim();
            //string phone = txtSDTBTC.Text.Trim();
            //string email = txtEmailBTC.Text.Trim();
            //if (string.IsNullOrEmpty(organizerId) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email))
            //{
            //    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            //    return;
            //}
            //try
            //{
            //    _organizerBLL.AddOrganizer(organizerId, name, address, phone, email);

            //    LoadOrganizer();
            //    MessageBox.Show("Thêm nhà tổ chức thành công!");
            //    NewOrganizer();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi khi thêm nhà tổ chức: " + ex.Message);
            //}