using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class Cart : UserControl
    {
        private decimal originalPrice = 0m;
        public event EventHandler QuantityChanged;

        public Cart()
        {
            InitializeComponent();
            picCartProduct.SizeMode = PictureBoxSizeMode.Zoom;
            selectSL.ValueChanged += SelectSL_ValueChanged;
        }

        public string ProductId { get; set; } // Mã sản phẩm thêm vào

        public Image ProductImage
        {
            get => picCartProduct.Image;
            set => picCartProduct.Image = value;
        }

        public string ProductName
        {
            get => lbTenSP.Text;
            set => lbTenSP.Text = value;
        }

        public string ProductColor
        {
            get => lbMauSac.Text;
            set => lbMauSac.Text = value;
        }

        public string ProductSize
        {
            get => lbSize.Text;
            set => lbSize.Text = value;
        }

        private int productQuantity = 1;
        public int ProductQuantity
        {
            get => (int)selectSL.Value;
            set
            {
                if (selectSL.Value != value)
                {
                    selectSL.Value = value;
                }

                productQuantity = value;
                QuantityChanged?.Invoke(this, EventArgs.Empty);
                UpdateTotalPriceDisplay();
            }
        }

        public decimal ProductPrice
        {
            get => originalPrice;
            set
            {
                originalPrice = value;
                UpdateTotalPriceDisplay();
            }
        }

        private void SelectSL_ValueChanged(object sender, EventArgs e)
        {
            ProductQuantity = (int)selectSL.Value;
        }

        public void UpdateTotalPriceDisplay()
        {
            decimal total = originalPrice * productQuantity;
            txtPrice.Text = total.ToString("N0") + " VNĐ";
        }
    }
}
