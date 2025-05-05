using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Hide();
            FrmCustomer f = new FrmCustomer();
            f.ShowDialog();
            f.Show();
        }

        private void NhaToChuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOrganizer f = new FrmOrganizer();
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

        private void Event_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProduct f = new FrmProduct();
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
            this.Hide();
            FrmPofile f = new FrmPofile();
            f.ShowDialog();
           f.Show();
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

        private void ThongKe_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FrmReport f = new FrmReport();
            //f.ShowDialog();
            //f.Show();
        }
    }
}
