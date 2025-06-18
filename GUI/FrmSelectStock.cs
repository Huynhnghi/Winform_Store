using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class FrmSelectStock : Form
    {
        public FrmSelectStock()
        {
            InitializeComponent();
            cbbSanPham.SelectedIndexChanged += cbbSanPham_SelectedIndexChanged;
        }

        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7265/")
        };

        /* Lấy sản phẩm */
       private async Task LoadSanPhamAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/SanPham");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var list = JsonSerializer.Deserialize<List<DTO.Product>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                   
                    if (list != null && list.Count > 0)
                    {
                        // Test xem có dữ liệu không
                        var first = list[0];

                        // Gán đúng thứ tự
                        cbbSanPham.DataSource = list;
                        cbbSanPham.DisplayMember = "TenSanPham";
                        cbbSanPham.ValueMember = "MaSanPham";
                    }
                    else
                    {
                        MessageBox.Show("Không có sản phẩm nào.");
                    }
                }
                else
                {
                    MessageBox.Show($"Lỗi khi gọi API: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private async Task LoadBienTheSanPhamAsync(string maSP)
        {
            try
            {
                // 1. Thêm tham số maSP vào URL API
                var response = await _httpClient.GetAsync($"api/BienTheSanPham/SanPham/{maSP}"); // Sử dụng string interpolation

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var listBienThe = JsonSerializer.Deserialize<List<DTO.DetailProduct>>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    if (listBienThe != null && listBienThe.Any())
                    {
                        var first = listBienThe[0];

                        
                        cbbBienThe.DataSource = listBienThe;
                        cbbBienThe.DisplayMember = "MaBienThe";

                        cbbBienThe.ValueMember = "MaBienThe";
                    }
                    else
                    {
                        MessageBox.Show($"Không có biến thể nào cho sản phẩm {maSP}.");
                        cbbBienThe.DataSource = null; 
                    }
                }
                else
                {
                    MessageBox.Show($"Lỗi khi gọi API biến thể: {response.StatusCode} - {await response.Content.ReadAsStringAsync()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải biến thể sản phẩm: " + ex.Message);
            }
        }
        private async void cbbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSanPham.SelectedValue != null)
            {
                string selectedMaSP = cbbSanPham.SelectedValue.ToString();
                await LoadBienTheSanPhamAsync(selectedMaSP);
            }
            else
            {
                if (cbbBienThe != null)
                {
                    cbbBienThe.DataSource = null;
                }
            }
        }
        public void LoadKho()
        {

        }

        private async void FrmSelectStock_Load(object sender, EventArgs e)
        {
            await LoadSanPhamAsync();
        }

        private async void btnSaveT_Click(object sender, EventArgs e)
        {
            try
            {
                var chiTiet = new ChiTietPhieuNhap
                { 
                    MaBienThe = cbbBienThe.Text.Trim(),         
                    SoLuong = int.Parse(txtSoLuong.Text.Trim()),  
                    DonGia = decimal.Parse(txtGiaVon.Text.Trim()) 
                };

                // Gửi POST request
                var json = JsonSerializer.Serialize(chiTiet);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("api/ChiTietPhieuNhap", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm chi tiết phiếu nhập thành công!");
                }
                else
                {
                    string errorMsg = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Lỗi khi thêm: {response.StatusCode}\n{errorMsg}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
