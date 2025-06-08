using System;
using System.Net.Http;
using System.Text.Json;
using System.IO;
using ImageMagick;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class FrmProductList : Form
    {
        public FrmProductList()
        {
            InitializeComponent();
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private async void FrmProductList_Load(object sender, EventArgs e)
        {
            await LoadProductListAsync();
        }
        public async void AddToCartSuccessHandler()
        {
            await LoadProductListAsync();
        }

        public void AddToCart(string name, decimal price, int quantity, string color, string size, Image image)
        {
            Cart cartItem = new Cart
            {
                ProductName = name,
                ProductColor = color,
                ProductSize = size,
                ProductQuantity = quantity,
                ProductImage = image,
                ProductPrice = price
            };
            cartItem.QuantityChanged += CartItem_QuantityChanged;
            flowCart.Controls.Add(cartItem);
            UpdateTotalCartPrice();
            AddToCartSuccessHandler();
        }

        private void CartItem_QuantityChanged(object sender, EventArgs e)
        {
            UpdateTotalCartPrice();
        }
        private async Task LoadProductListAsync()
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            var client = new HttpClient(handler)
            {
                BaseAddress = new Uri("https://localhost:7265/")
            };

            var response = await client.GetAsync("api/SanPham");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Không thể lấy danh sách sản phẩm.");
                return;
            }

            var jsonString = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(jsonString))
            {
                MessageBox.Show("Dữ liệu sản phẩm trả về rỗng.");
                return;
            }

            List<DTO.Product> products = null;
            try
            {
                products = JsonSerializer.Deserialize<List<DTO.Product>>(jsonString, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu sản phẩm: " + ex.Message);
                return;
            }

            flowLayoutPanel1.Controls.Clear();
            var httpClientForImages = new HttpClient();

            foreach (var item in products ?? new List<DTO.Product>())
            {
                var chiTietResponse = await client.GetAsync($"api/BienTheSanPham/GetByProductId/{item.MaSanPham}");

                if (!chiTietResponse.IsSuccessStatusCode)
                {
                    // Không hiển thị MessageBox ở đây nếu chỉ muốn lướt qua yên lặng
                    continue;
                }

                var chiTietJson = await chiTietResponse.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(chiTietJson))
                {
                    continue;
                }

                List<DTO.DetailProduct> variants = null;
                try
                {
                    variants = JsonSerializer.Deserialize<List<DTO.DetailProduct>>(chiTietJson, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                }
                catch
                {
                    continue;
                }

                // Bỏ qua nếu không có biến thể
                if (variants == null || variants.Count == 0)
                    continue;

                var productControl = new Product();

                // Load ảnh nếu có
                string imageUrl = !string.IsNullOrEmpty(variants[0].HinhAnh)
                                    ? $"https://localhost:7265/images/{variants[0].HinhAnh}"
                                    : null;

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
                                productControl.ProductImage = bitmap;
                            }
                        }
                    }
                    catch
                    {
                        // Có thể log lỗi hoặc bỏ qua nếu không muốn hiển thị MessageBox liên tục
                    }
                }

                productControl.ProductName = item.TenSanPham;
                productControl.ProductPrice = variants[0].GiaBan.ToString("N0") + " VNĐ";

                List<string> colors = variants.Select(v => v.MauSac).Distinct().ToList();
                productControl.LoadColors(colors);
                productControl.LoadVariants(variants);

                productControl.InitializeSizeButtons();
                flowLayoutPanel1.Controls.Add(productControl);
            }
        }


        private FrmCart frmCart = new FrmCart();
        private void UpdateTotalCartPrice()
        {
            decimal totalPrice = 0;

            foreach (Cart cartItem in flowCart.Controls.OfType<Cart>())
            {
                totalPrice += cartItem.ProductPrice * cartItem.ProductQuantity;
            }

            txtPrice.Text = totalPrice.ToString("N0") + " VNĐ";

            if (frmCart != null && !frmCart.IsDisposed)
            {
                frmCart.SetTotalPrice(totalPrice);
            }
        }
        private void flowCart_Paint(object sender, PaintEventArgs e)
        {

        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {

            string tensp = txtBarcode.Text.Trim();
            await SearchProductsByNameAsync(tensp);
        }
        private async Task SearchProductsByNameAsync(string tensp)
        {

            if (string.IsNullOrEmpty(tensp))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            using (var client = new HttpClient(handler) { BaseAddress = new Uri("https://localhost:7265/") })
            {
                try
                {
                    // Gọi API lấy danh sách sản phẩm
                    var response = await client.GetAsync("api/SanPham");
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Không thể lấy danh sách sản phẩm.");
                        return;
                    }

                    var jsonString = await response.Content.ReadAsStringAsync();
                    if (string.IsNullOrEmpty(jsonString))
                    {
                        MessageBox.Show("Dữ liệu sản phẩm trả về rỗng.");
                        return;
                    }

                    List<DTO.Product> products = JsonSerializer.Deserialize<List<DTO.Product>>(jsonString, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    // Lọc sản phẩm theo tên (có thể dùng Contains ignore case)
                    var filteredProducts = products
                        .Where(p => !string.IsNullOrEmpty(p.TenSanPham) &&
                                    p.TenSanPham.IndexOf(tensp, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();

                    if (filteredProducts.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm với tên này.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    flowLayoutPanel1.Controls.Clear();

                    var httpClientForImages = new HttpClient();

                    foreach (var item in filteredProducts)
                    {
                        // Lấy chi tiết sản phẩm
                        var chiTietResponse = await client.GetAsync($"api/BienTheSanPham/GetByProductId/{item.MaSanPham}");

                        if (!chiTietResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Không thể lấy chi tiết sản phẩm {item.MaSanPham}");
                            continue;
                        }

                        var chiTietJson = await chiTietResponse.Content.ReadAsStringAsync();
                        if (string.IsNullOrEmpty(chiTietJson))
                        {
                            MessageBox.Show($"Dữ liệu chi tiết sản phẩm {item.MaSanPham} rỗng.");
                            continue;
                        }

                        List<DTO.DetailProduct> variants = JsonSerializer.Deserialize<List<DTO.DetailProduct>>(chiTietJson, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

                        var productControl = new Product();

                        if (variants != null && variants.Count > 0)
                        {
                            string imageUrl = string.IsNullOrEmpty(variants[0].HinhAnh)
                                                ? null
                                                : $"https://localhost:7265/images/{variants[0].HinhAnh}";

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
                                            productControl.ProductImage = bitmap;
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lỗi tải ảnh: " + ex.Message);
                                }
                            }
                        }

                        productControl.ProductName = item.TenSanPham;
                        productControl.ProductPrice = variants?[0].GiaBan.ToString("N0") + " VNĐ";

                        var colorss = variants?.Select(v => v.MauSac).Distinct().ToList() ?? new List<string>();
                        productControl.LoadColors(colorss);
                        productControl.LoadVariants(variants ?? new List<DTO.DetailProduct>());
                        productControl.InitializeSizeButtons();

                        flowLayoutPanel1.Controls.Add(productControl);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
                }
            }
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f = new frmMain();
            f.Show();
        }

        private async void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            string tensp = txtBarcode.Text.Trim();
            if (string.IsNullOrWhiteSpace(tensp))
            {
                await LoadProductListAsync();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if (frmCart == null || frmCart.IsDisposed)
            {
                frmCart = new FrmCart();
            }

            //frmCart.ClearCart(); // Hàm tự viết để reset nếu cần

            foreach (Cart cartItem in flowCart.Controls.OfType<Cart>())
            {
                Cart clonedItem = new Cart
                {
                    ProductName = cartItem.ProductName,
                    ProductColor = cartItem.ProductColor,
                    ProductSize = cartItem.ProductSize,
                    ProductQuantity = cartItem.ProductQuantity,
                    ProductImage = cartItem.ProductImage,
                    ProductPrice = cartItem.ProductPrice
                };

                frmCart.AddCartItemToCart(clonedItem);
            }

            // Tính tổng tiền
            decimal totalPrice = flowCart.Controls.OfType<Cart>()
                .Sum(item => item.ProductPrice * item.ProductQuantity);
            frmCart.SetTotalPrice(totalPrice);

            this.Hide();
            frmCart.FormClosed += (s, args) => this.Show(); // Hiện lại form chính khi frmCart đóng
            frmCart.Show();
        }
    }
}
