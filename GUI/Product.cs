using System;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        public Image ProductImage
        {
            get => pic.Image;
            set => pic.Image = value;
        }

        public string ProductName
        {
            get => txtTenSP.Text;
            set => txtTenSP.Text = value;
        }

        public string ProductPrice
        {
            get => txtGia.Text;
            set => txtGia.Text = value;
        }

        public string SelectedColor
        {
            get => cbbMauSac.SelectedItem?.ToString();
            set => cbbMauSac.SelectedItem = value;
        }

        private string selectedSize = "No size selected";

        public string SelectSize
        {
            get
            {
                foreach (var control in flCBB.Controls)
                {
                    if (control is Button button)
                    {
                        if (button.Text == "S" && button.BackColor == Color.Green) // Kiểm tra nếu button được chọn
                        {
                            return "Small (S)";
                        }
                        else if (button.Text == "M" && button.BackColor == Color.Green)
                        {
                            return "Medium (M)";
                        }
                        else if (button.Text == "L" && button.BackColor == Color.Green)
                        {
                            return "Large (L)";
                        }
                        else if (button.Text == "XL" && button.BackColor == Color.Green)
                        {
                            return "Extra Large (XL)";
                        }
                    }
                }
                return "No size selected";
            }
        }

        public bool SelectBuy
        {
            get => btnMua.Enabled;
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            string productName = ProductName;
            string productPrice = ProductPrice;
            string selectedSize = SelectSize;
            string selectedColor = SelectedColor;
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productPrice) || selectedSize == "No size selected" || string.IsNullOrEmpty(selectedColor))
            {
                MessageBox.Show("Please select all options before buying.");
                return;
            }
            Product product = new Product
            {
                = productName,
                GiaBan = Convert.ToDouble(productPrice),
                SoLuong = 1, // Hoặc lấy từ thông tin khác
                // Bạn có thể thêm các thuộc tính khác vào đối tượng này
            };

            // Gọi BLL để thêm sản phẩm vào giỏ hàng
            bool success = productBLL.AddProductToCart(product);

            if (success)
            {
                MessageBox.Show($"Product '{productName}' has been added to the cart.\nSize: {selectedSize}, Color: {selectedColor}");
            }
            else
            {
                MessageBox.Show("Failed to add the product to the cart.");
            }
        }

        private void SizeButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            { 
                foreach (var control in flCBB.Controls)
                {
                    if (control is Button button)
                    {
                        button.BackColor = Color.Transparent; 
                    }
                }
                clickedButton.BackColor = Color.Green; 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        public void InitializeSizeButtons()
        {
            foreach (var control in flCBB.Controls)
            {
                if (control is Button button)
                {
                    button.Click += SizeButton_Click;
                }
            }
        }
    }
}
