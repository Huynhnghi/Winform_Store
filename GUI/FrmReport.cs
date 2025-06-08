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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            cbbTypeReport.Items.AddRange(new string[] { "Ngày", "Tuần", "Tháng" });
            cbbTypeReport.SelectedIndex = 0;

        }
        private void DTPBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f = new frmMain();
            f.ShowDialog();
            f.Show();
        }

        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7265/")
        };

        public async Task<ThongKe> GetDoanhThuAsync(DateTime from, DateTime to, string type)
        {
            // Format ngày thành chuỗi yyyy-MM-dd
            string url = $"api/ThongKe/DoanhThu?from={from:yyyy-MM-dd}&to={to:yyyy-MM-dd}&type={type}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<ThongKe>(
                jsonString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        private async void btnReport_Click(object sender, EventArgs e)
        {
            DateTime from = DTPStart.Value.Date;
            DateTime to = DTPEnd.Value.Date;
            string type = cbbTypeReport.SelectedItem?.ToString()?.ToLower();

            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Vui lòng chọn loại thống kê.");
                return;
            }

            try
            {
                var result = await GetDoanhThuAsync(from, to, type);
                dgvKH.DataSource = result.Data;
                lbTotal.Text = $"{result.TongTien:N0} VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        
    }
}
