using Newtonsoft.Json;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class FrmThongKeHangTonKho : Form
    {
        public FrmThongKeHangTonKho()
        {
            InitializeComponent();
            LoadTonKhoData();
        }

        private async void LoadTonKhoData()
        {
            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetAsync("https://localhost:7265/api/BienTheSanPham");

                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    var bienTheList = JsonConvert.DeserializeObject<List<ChiTietSanPham>>(json);

                    if (bienTheList != null)
                    {
                        LoadColumnChart(bienTheList);
                        LoadDataGrid(bienTheList);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể tải dữ liệu tồn kho.");
                }
            }
        }

        private void LoadColumnChart(List<ChiTietSanPham> list)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            chart1.Titles.Add("Tồn kho theo biến thể sản phẩm");
            chart1.ChartAreas[0].AxisX.Interval = 1; // Hiển thị tất cả nhãn trục X

            chart1.Series.Add("Tồn kho");
            var series = chart1.Series["Tồn kho"];
            series.ChartType = SeriesChartType.Column; // <- BIỂU ĐỒ CỘT
            series.Color = Color.SeaGreen;

            foreach (var item in list)
            {
                if (item.TonKho > 0)
                {
                    series.Points.AddXY(item.MaBienThe, item.TonKho);
                }
            }

            series.IsValueShownAsLabel = true; // Hiện số lượng trên mỗi cột
        }

        private void LoadDataGrid(List<ChiTietSanPham> list)
        {
            dataGridView1.DataSource = list.Select(x => new
            {
                x.MaBienThe,
                x.MaSanPham,
                x.Size,
                x.MauSac,
                x.GiaBan,
                x.TonKho
            }).ToList();
        }
        public class ChiTietSanPham
        {
            public string MaBienThe { get; set; }
            public string MaSanPham { get; set; }
            public string Size { get; set; }
            public string MauSac { get; set; }
            public string HinhAnh { get; set; }
            public string Barcode { get; set; }
            public decimal GiaVon { get; set; }
            public decimal GiaBan { get; set; }
            public int TonKho { get; set; }
            public float TrongLuong { get; set; }
            public int TrangThai { get; set; }
            public string HinhAnhUrl { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form hiện tại
            frmMain mainForm = new frmMain(); // Tạo form chính mới
            mainForm.Show(); // Hiển thị form chính
        }
    }
}
