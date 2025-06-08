using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.IO;
using ImageMagick;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class FrmCart : Form
    {
        private int diemTichLuy = 0;

        // Biến lưu tổng tiền gốc (chưa trừ điểm)
        private decimal tongTienGoc = 0m; // Khai báo ở đầu class

        public FrmCart()
        {
            InitializeComponent();
        }
        public void AddCartItemToCart(Cart cartItem)
        {
            flwCart.Controls.Add(cartItem);
        }

        public void SetTotalPrice(decimal totalPrice)
        {
            tongTienGoc = totalPrice; // Gán vào biến toàn cục
            txtTotal.Text = totalPrice.ToString("N0") + " VNĐ";
        }

        /* Lấy điểm tích lũy và sử dụng điểm */
        private async void btnGetPoint_Click(object sender, EventArgs e)
        {
            string tenKH = txtCusName.Text.Trim();
            string sdt = txtCusPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenKH) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên và số điện thoại.");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://localhost:7265/api/KhachHang/Search_point?tenKH={(tenKH)}&sdt={(sdt)}";

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        var result = JsonConvert.DeserializeObject<LichSuDiem>(json);

                        if (result != null)
                        {
                            diemTichLuy = result.DiemTichLuy;
                            lbPoint.Text = $"{result.DiemTichLuy}";
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng hoặc không có điểm.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Lỗi gọi API: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi gọi API: {ex.Message}");
                }
            }
        }
        private void txtUsePoint_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtUsePoint.Text.Trim(), out int diemDung))
            {
                if (diemDung > diemTichLuy)
                {
                    MessageBox.Show("Số điểm sử dụng không được vượt quá điểm tích lũy.");
                    txtUsePoint.Text = diemTichLuy.ToString();
                    diemDung = diemTichLuy;
                    txtUsePoint.SelectionStart = txtUsePoint.Text.Length; 
                }
                else if (diemDung < 0)
                {
                    diemDung = 0;
                    txtUsePoint.Text = "0";
                    txtUsePoint.SelectionStart = txtUsePoint.Text.Length;
                }
            }
            else
            {
                diemDung = 0;
            }

            UpdateTotalAmountDisplay();
        }
        private void UpdateTotalAmountDisplay()
        {
            int diemDung = 0;
            if (!int.TryParse(txtUsePoint.Text.Trim(), out diemDung))
            {
                diemDung = 0;
            }

            if (diemDung > diemTichLuy)
                diemDung = diemTichLuy;
            else if (diemDung < 0)
                diemDung = 0;

            decimal tienGiam = diemDung * 1000m;

            decimal tongTienSauGiam = tongTienGoc - tienGiam;
            if (tongTienSauGiam < 0) tongTienSauGiam = 0;

            txtTotal.Text = $"{tongTienSauGiam:N0} VNĐ";
        }

        // Hàm gọi API PUT để cập nhật điểm tích lũy
        private async Task<bool> UpdateDiemAsync(string maKH, int diem)
        {
            if (string.IsNullOrEmpty(maKH))
                return false;

            var lichSuDiem = new
            {
                MaKH = maKH,
                Diem = diem
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7265"); 

                var json = JsonConvert.SerializeObject(lichSuDiem);  
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"api/LichSuDiem/{maKH}", content);

                return response.IsSuccessStatusCode;
            }
        }
        private async void btnUsePoint_Click(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtCusName.Text.Trim();
                int diem = int.TryParse(txtUsePoint.Text.Trim(), out int parsedDiem) ? parsedDiem : 0;

                if (string.IsNullOrEmpty(maKH))
                {
                    MessageBox.Show("Vui lòng nhập Mã khách hàng.");
                    return;
                }

                bool success = await UpdateDiemAsync(maKH, diem);

                if (success)
                {
                    MessageBox.Show("Cập nhật điểm thành công!");
                    // Có thể gọi hàm load lại điểm nếu có
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gọi API: " + ex.Message);
            }
        }
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7265/")
        };
        private async Task LoadKhuyenMaiAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/KhuyenMai");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    var list = JsonConvert.DeserializeObject<List<KhuyenMai>>(json); // Dùng Newtonsoft.Json cho an toàn WinForms

                    if (list != null && list.Count > 0)
                    {
                        cbbKM.DataSource = list;
                        cbbKM.DisplayMember = "MaKM";     // Thuộc tính tên khuyến mãi (hiển thị)
                        cbbKM.ValueMember = "TenKM";      // Mã khuyến mãi (ẩn)

                        cbbKM.SelectedIndexChanged += (s, e) =>
                        {
                            if (cbbKM.SelectedItem is KhuyenMai selected)
                            {
                                txtKM.Text = selected.TenKM;
                            }
                        };

                        if (cbbKM.SelectedItem is KhuyenMai first)
                        {
                            txtKM.Text = first.TenKM;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu loại khuyến mãi.");
                    }
                }
                else
                {
                    MessageBox.Show($"API lỗi: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gọi API: " + ex.Message);
            }
        }

        private void FrmCart_Load(object sender, EventArgs e)
        {
            LoadKhuyenMaiAsync();
        }
    }
}