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

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void KhachHang_Click(object sender, EventArgs e)
        {
            if (CurrentUser.User.MaQuyen != "Q01")
            {
                MessageBox.Show("Chức năng này chỉ dành cho Admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            FrmCustomer f = new FrmCustomer();
            f.ShowDialog();
            f.Show();
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (panelLeft.Width == 65)
            {
                panelLeft.Width = 203;
                panelRight.Width = 939;
                this.Width = 1142;
            }
            else
            {
                panelLeft.Width = 65;
                panelRight.Width = 801;
                this.Width = 866;
            }
        }

        private void Product_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProductList f = new FrmProductList();
            f.ShowDialog();
            f.Show();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FrmLogin();
            f.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FrmPofile frm = new FrmPofile();
            frm.FormClosed += (s, args) => this.Show(); // Hiện lại form chính khi FrmPofile đóng
            frm.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?","Xác nhận thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Form f = new frmMain();
                f.Show();
            }
        }



        private void Supplier_Click(object sender, EventArgs e)
        {
            if (CurrentUser.User.MaQuyen != "Q01")
            {
                MessageBox.Show("Chức năng này chỉ dành cho Admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            FrmSupplier f = new FrmSupplier();
            f.ShowDialog();
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var quyen = CurrentUser.User.MaQuyen;
            if (quyen == "Q01") // Admin
            {
                Staff.Enabled = true;
                Customer.Enabled = true;
                Product.Enabled = true;
                Sale.Enabled = true;
                Bill.Enabled = true;
                Report.Enabled = true;
                btnProfile.Enabled = true;
            }
            else if (quyen == "Q02") // Bán hàng
            {
                btnProfile.Enabled = true;
                Product.Enabled = true;
                Bill.Enabled = true;
            }
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            if (CurrentUser.User.MaQuyen != "Q01")
            {
                MessageBox.Show("Chức năng này chỉ dành cho Admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            if (CurrentUser.User.MaQuyen != "Q01")
            {
                MessageBox.Show("Chức năng này chỉ dành cho Admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            FrmBill f = new FrmBill();
            f.ShowDialog();
            f.Show();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            if (CurrentUser.User.MaQuyen != "Q01")
            {
                MessageBox.Show("Chức năng này chỉ dành cho Admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Hide();
            FrmStaff f = new FrmStaff();
            f.ShowDialog();
            f.Show();
        }
    }
}
