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
using System.Drawing;
//using System.Windows.Forms.DataVisualization.Charting;
using DTO;


namespace GUI
{
    public partial class FrmReport : Form
    {
        //private readonly HttpClient _httpClient;
        //private const string ApiBaseUrl = "https://localhost:7000/api/"; // Thay bằng URL API thực tế của bạn

        public FrmReport()
        {
            InitializeComponent();
        }
        private void FrmReport_Load(object sender, EventArgs e)
        {
            cbbTypeReport.Items.AddRange(new string[] { "Từ ngày đến ngày", "Ngày", "Tuần", "Tháng", "Hàng tồn"});
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

        private DataTable ConvertToDataTable(List<HoaDonViewModel> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Ngày lập");
            dt.Columns.Add("Thành tiền", typeof(decimal)); // dùng decimal cho đúng kiểu

            foreach (var hd in list)
            {
                dt.Rows.Add(
                    hd.MaHoaDon,
                    hd.MaKH,
                    hd.MaNV,
                    hd.NgayLap.ToString("dd/MM/yyyy"),
                    hd.ThanhTien
                );
            }

            return dt;
        }

        /* Thống kê doanh thu từ ngày đến ngày */
        public async Task<ThongKe> GetDoanhThuAsync(DateTime from, DateTime to)
        {
            string url = $"api/ThongKe/doanhthu/TuNgay-Ngay?ngayStart={from:yyyy-MM-dd}&ngayEnd={to:yyyy-MM-dd}";


            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<ThongKe>(
                jsonString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        /* Thống kê doanh thu theo tuần */
        public async Task<ThongKe> GetDoanhThuTheoTuanAsync(DateTime from)
        {
            string url = $"api/ThongKe/doanhthu/tuan?ngayBatDau={from:MM-dd-yyyy}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<ThongKe>(
                jsonString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        /* Thống kê doanh thu theo ngày */
        public async Task<ThongKe> GetDoanhThuTheoNgayAsync(DateTime from)
        {
            string url = $"api/ThongKe/doanhthungay?ngay={from:yyyy-MM-dd}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<ThongKe>(
                jsonString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        /* Thống kê doanh thu theo tháng */
        public async Task<ThongKe> GetDoanhThuTheoThangAsync(int year, int month)
        {
            string url = $"api/ThongKe/doanhthu/thang?nam={year}&thang={month}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<ThongKe>(
                jsonString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        /* Thống kê tồn kho */
        public async Task<ThongKe> GetTonKhoAsync()
        {
            string url = "api/ThongKe/hang-ton-kho";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            var list = JsonSerializer.Deserialize<List<DTO.SanPhamTonKho>>(
                jsonString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return new ThongKe
            {
                DataSP = list 
            };
        }


        private void HienThiKetQuaThongKe(ThongKe result)
        {
            if (result != null && result.Data != null && result.Data.Any())
            {
                DataTable dt = ConvertToDataTable(result.Data);
                dgvKH.DataSource = dt;

                lbTotal.Text = $"{result.TongTien:N0} VND";
            }
            else
            {
                dgvKH.DataSource = null;
                lbTotal.Text = "0 VND";
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ChinhHienThiDataGridView();
        }

        private void ChinhHienThiDataGridView()
        {
            dgvKH.ReadOnly = true;
            dgvKH.AllowUserToAddRows = false;
            dgvKH.AllowUserToDeleteRows = false;
            dgvKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKH.MultiSelect = false;
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKH.AutoGenerateColumns = true;

            dgvKH.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvKH.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvKH.EnableHeadersVisualStyles = false;
            dgvKH.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;

            dgvKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKH.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvKH.RowTemplate.Height = 30;
            dgvKH.ColumnHeadersHeight = 35;

            dgvKH.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKH.GridColor = Color.LightGray;
        }

        private void HienThiHangTonKho(List<SanPhamTonKho> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sản phẩm");
            dt.Columns.Add("Tên sản phẩm");
            dt.Columns.Add("Tổng số lượng tồn", typeof(int));
            dt.Columns.Add("Giá bán", typeof(string)); // Format giá theo VNĐ

            foreach (var sp in list)
            {
                dt.Rows.Add(
                    sp.MaSP,
                    sp.TenSP,
                    sp.TongSoLuongTon,
                    $"{sp.GiaBan:N0} VND" // định dạng giá tiền
                );
            }

            dgvKH.DataSource = dt;

            // Tuỳ chỉnh hiển thị cho đẹp
            dgvKH.Columns[0].Width = 120;
            dgvKH.Columns[1].Width = 200;
            dgvKH.Columns[2].Width = 150;
            dgvKH.Columns[3].Width = 120;

            dgvKH.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvKH.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvKH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKH.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKH.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private async void btnReport_Click(object sender, EventArgs e)
        {
            string selectedLoai = cbbTypeReport.SelectedItem?.ToString();
            ThongKe result = null;

            try
            {
                DateTime from = DTPStart.Value.Date;
                DateTime to = DTPEnd.Value.Date;

                switch (selectedLoai)
                {
                    case "Từ ngày đến ngày":
                        result = await GetDoanhThuAsync(from, to);
                        break;

                    case "Ngày":
                        result = await GetDoanhThuTheoNgayAsync(from);
                        break;

                    case "Tuần":
                        result = await GetDoanhThuTheoTuanAsync(from);
                        break;

                    case "Tháng":
                        result = await GetDoanhThuTheoThangAsync(from.Year, from.Month);
                        break;

                    case "Hàng tồn":
                        result = await GetTonKhoAsync();
                        HienThiHangTonKho(result.DataSP);
                        return;

                    default:
                        MessageBox.Show("Vui lòng chọn loại thống kê hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                }

                HienThiKetQuaThongKe(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cbbTypeReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
