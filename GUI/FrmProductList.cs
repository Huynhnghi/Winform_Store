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
    public partial class FrmProductList : Form
    {
        //private ProductBLL productBLL = new ProductBLL();
        public FrmProductList()
        {
            InitializeComponent();
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Giả sử bạn có một đối tượng UserControl tên là productControl
            //Product.btnMua_Click(sender, e);  // Gọi hàm btnMua_Click từ UserControl
        }
        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {
                    }
    }
}
