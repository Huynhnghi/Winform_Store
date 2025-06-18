using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using ImageMagick;

namespace GUI
{
    public partial class Product : UserControl
    {
        private readonly HttpClient httpClientForImages = new HttpClient();
        private List<DetailProduct> _variants = new List<DetailProduct>();
        private string selectedColor = null;
        private string selectedSize = null;

        public string MaSanPham { get; set; }

        public Product()
        {
            InitializeComponent();
            InitializeSizeButtons();
            cbbMauSac.SelectedIndexChanged += cbbMauSac_SelectedIndexChanged;
            cbbMauSac.DropDownStyle = ComboBoxStyle.DropDownList;
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

        public string ProductSKU
        {
            get => txtBarcode.Text;
            set => txtBarcode.Text = value;
        }

        public string ProductPrice
        {
            get => txtGia.Text;
            set => txtGia.Text = value;
        }

        public string SelectedColor
        {
            get => cbbMauSac.SelectedItem?.ToString();
            set
            {
                if (cbbMauSac.Items.Contains(value))
                    cbbMauSac.SelectedItem = value;
            }
        }

        public int Quantity
        {
            get { return (int)NUPQuantity.Value; }
        }

        public string StockQuantity
        {
            get => txtStock.Text;
            set => txtStock.Text = value;
        }

        private async void cbbMauSac_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColor = cbbMauSac.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedColor))
            {
                LoadImageForSelectedColor(selectedColor);
                await LoadStockQuantityAsync(MaSanPham, selectedSize, selectedColor);
            }
        }

        public async Task LoadStockQuantityPublic(string size, string mauSac)
        {
            selectedSize = size;
            selectedColor = mauSac;
            await LoadStockQuantityAsync(MaSanPham, size, mauSac);
        }

        private async Task LoadStockQuantityAsync(string maSP, string size, string mauSac)
        {
            if (string.IsNullOrWhiteSpace(maSP) || string.IsNullOrWhiteSpace(size) || string.IsNullOrWhiteSpace(mauSac))
                return;

            string encodedColor = Uri.EscapeDataString(mauSac);
            string apiUrl = $"https://localhost:7265/api/BienTheSanPham/tonkho?maSP={maSP}&size={size}&mauSac={encodedColor}";

            try
            {
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };

                using (var client = new HttpClient(handler))
                {
                    var response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var tonKhoObj = JsonSerializer.Deserialize<TonKhoResponse>(json, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        if (tonKhoObj != null)
                        {
                            StockQuantity = tonKhoObj.TonKho.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy tồn kho: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadColors(List<string> colors)
        {
            cbbMauSac.SelectedIndexChanged -= cbbMauSac_SelectedIndexChanged;
            cbbMauSac.Items.Clear();
            foreach (var color in colors)
            {
                cbbMauSac.Items.Add(color);
            }
            if (colors.Count > 0) cbbMauSac.SelectedIndex = 0;
            cbbMauSac.SelectedIndexChanged += cbbMauSac_SelectedIndexChanged;
        }

        // Method to load image based on selected color
        private async void LoadImageForSelectedColor(string color)
        {
            if (string.IsNullOrWhiteSpace(color)) return;

            var variant = _variants.FirstOrDefault(v => v.MauSac.Equals(color, StringComparison.OrdinalIgnoreCase));

            if (variant != null)
            {
                string imageUrl = string.IsNullOrEmpty(variant.HinhAnh)
                    ? null
                    : $"https://localhost:7265/images/{variant.HinhAnh}";

                if (!string.IsNullOrEmpty(imageUrl))
                {
                    try
                    {
                        var imgResponse = await httpClientForImages.GetAsync(imageUrl);
                        imgResponse.EnsureSuccessStatusCode();

                        var imageBytes = await imgResponse.Content.ReadAsByteArrayAsync();

                        using (var magickImage = new MagickImage(imageBytes))
                        {
                            magickImage.Resize(220, 160);
                            magickImage.Extent(220, 160, Gravity.Center, MagickColors.Transparent);
                            magickImage.Format = MagickFormat.Bmp;

                            using (var ms = new MemoryStream())
                            {
                                magickImage.Write(ms);
                                ms.Position = 0;
                                Bitmap bitmap = new Bitmap(ms);
                                ProductImage = bitmap;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải ảnh: " + ex.Message, "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có hình ảnh tương ứng với màu đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public string SelectSize
        {
            get
            {
                foreach (var control in flCBB.Controls)
                {
                    if (control is Button button)
                    {
                        if (button.Text == "S" && button.BackColor == Color.Green) 
                        {
                            return "S";
                        }
                        else if (button.Text == "M" && button.BackColor == Color.Green)
                        {
                            return "M";
                        }
                        else if (button.Text == "L" && button.BackColor == Color.Green)
                        {
                            return "L";
                        }
                        else if (button.Text == "XL" && button.BackColor == Color.Green)
                        {
                            return "XL";
                        }
                    }
                }
                return "No size selected";
            }
        }

        public bool SelectBuy => btnMua.Enabled;

        private void btnMua_Click(object sender, EventArgs e)
        {
            string name = ProductName;
            string size = SelectSize;
            string color = SelectedColor;
            Image img = ProductImage;
            int quantity = this.Quantity;
            string sku = ProductSKU;

            if (!decimal.TryParse(ProductPrice.Replace(" VNĐ", "").Replace(",", ""), out decimal price))
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ.", "Lỗi giá", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(color) || size == "No size selected")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ màu và size trước khi mua.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form parentForm = this.FindForm();
            if (parentForm is FrmProductList frm)
            {
                // Gọi phương thức add vào giỏ hàng (nếu có)
                frm.AddToCart(name, price, quantity,color, size, img);
                MessageBox.Show("Đã thêm vào giỏ hàng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xử lý khi chọn nút size
        private void SizeButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Gán selectedSize từ button
                selectedSize = btn.Text;

                if (cbbMauSac.SelectedItem != null)
                {
                    selectedColor = cbbMauSac.SelectedItem.ToString();
                }

                // Reset màu tất cả button size
                foreach (var control in flCBB.Controls)
                {
                    if (control is Button b)
                    {
                        b.BackColor = SystemColors.Control;
                    }
                }

                btn.BackColor = Color.Green;
                var variant = _variants.FirstOrDefault(v => v.MauSac == selectedColor && v.Size == selectedSize);

                if (variant != null)
                {
                    ProductSKU = variant.Barcode;
                    ProductPrice = variant.GiaBan.ToString("N0") + " VNĐ";
                }
                else
                {
                    MessageBox.Show("Sản phẩm hiện không còn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        // Load biến thể sản phẩm (variants) và gán màu cho combo box (nên là màu chứ không phải size ở đây)
        public void LoadVariants(List<DetailProduct> variants)
        {
            _variants = variants;

            cbbMauSac.SelectedIndexChanged -= cbbMauSac_SelectedIndexChanged;
            cbbMauSac.Items.Clear();

            var colors = variants.Select(v => v.MauSac).Distinct().ToList();
            foreach (var color in colors)
            {
                cbbMauSac.Items.Add(color);
            }

            if (cbbMauSac.Items.Count > 0)
                cbbMauSac.SelectedIndex = 0;

            cbbMauSac.SelectedIndexChanged += cbbMauSac_SelectedIndexChanged;
        }

        // Cập nhật barcode và giá khi chọn biến thể
        private void UpdateBarcodeAndPrice(DetailProduct variant)
        {
            ProductSKU = variant.Barcode;
            ProductPrice = $"{variant.GiaBan:N0} VNĐ";
        }

        private ComboBox cbbSize; 
        public void LoadSizes(List<string> sizes)
        {
            if (cbbSize == null) return;

            cbbSize.SelectedIndexChanged -= cbbSize_SelectedIndexChanged;
            cbbSize.Items.Clear();

            foreach (var size in sizes)
            {
                cbbSize.Items.Add(size);
            }

            if (sizes.Count > 0)
                cbbSize.SelectedIndex = 0;

            cbbSize.SelectedIndexChanged += cbbSize_SelectedIndexChanged;
        }

        private void cbbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSize.SelectedItem == null || string.IsNullOrEmpty(SelectedColor)) return;

            string selectedSize = cbbSize.SelectedItem.ToString();
            string selectedColor = SelectedColor;

            var selectedVariant = _variants.FirstOrDefault(v => v.Size == selectedSize && v.MauSac == selectedColor);
            if (selectedVariant != null)
            {
                UpdateBarcodeAndPrice(selectedVariant);
            }
        }

        // Gán sự kiện click cho các nút chọn size
        public void InitializeSizeButtons()
        {
            foreach (var control in flCBB.Controls)
            {
                if (control is Button button)
                {
                    button.Click -= SizeButton_Click; 
                    button.Click += SizeButton_Click;
                }
            }
        }

        private void NUPQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtStock.Text, out int stock))
            {
                if (NUPQuantity.Value > stock)
                {
                    MessageBox.Show($"Số lượng vượt quá số lượng tồn kho ({stock})", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NUPQuantity.Value = stock; 
                }
            }
            else
            {
                MessageBox.Show("Không thể xác định số lượng tồn kho.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
