using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Net.Http;

namespace GUI
{
    public partial class FrnChiTietHoaDon : Form
    {
        private string _maHD;
        public FrnChiTietHoaDon(string maHD)
        {
            InitializeComponent();
            _maHD = maHD;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtDieuKien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void FrnChiTietHoaDon_Load(object sender, EventArgs e)
        {
            await LoadChiTietHoaDon(_maHD);
        }
        private async Task LoadChiTietHoaDon(string maHD)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7265/api/HoaDon/");
                try
                {
                    var response = await client.GetAsync($"chitiethoadon/{maHD}");
                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadFromJsonAsync<List<ChiTietHoaDon>>();
                        dataGridView1.DataSource = data;
                        dataGridView1.Columns["MaChiTietHD"].HeaderText = "Mã chi tiết đơn";
                        dataGridView1.Columns["MaHD"].HeaderText = "Mã hóa đơn";
                        dataGridView1.Columns["MaBienThe"].HeaderText = "Mã biến thể";
                        dataGridView1.Columns["SoLuong"].HeaderText = "Số lượng";
                        dataGridView1.Columns["GiaBan"].HeaderText = "Giá bán";
                        dataGridView1.Columns["GiaGiam"].HeaderText = "Giá giảm";
                        dataGridView1.Columns["ThanhTien"].HeaderText = "Thành tiền";
                    }
                    else
                    {
                        MessageBox.Show("Không lấy được chi tiết hóa đơn.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        public class ChiTietHoaDon
        {
            public string MaChiTietHD { get; set; }
            public string MaHD { get; set; }
            public string MaBienThe { get; set; }
            public int SoLuong { get; set; }
            public decimal? GiaBan { get; set; }
            public decimal? GiaGiam { get; set; }
            public decimal ThanhTien { get; set; }
        }
    }
}
