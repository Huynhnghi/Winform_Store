using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using GUI;
using Microsoft.AspNetCore.SignalR.Client;

namespace GUI
{
    public partial class FrmBill : Form
    {
        private readonly HttpClient _httpClient;
        public FrmBill()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7265/api/HoaDon/")
            };
        }
        private async Task LoadHoaDon(string trangThaiFilter = "Tất cả")
        {
            try
            {
                var response = await _httpClient.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    var hoaDons = await response.Content.ReadFromJsonAsync<List<HoaDon>>();

                    // Lọc nếu không phải "Tất cả"
                    if (trangThaiFilter != "Tất cả")
                    {
                        hoaDons = hoaDons
                            .Where(hd => hd.TrangThai_VanChuyen != null && hd.TrangThai_VanChuyen.Equals(trangThaiFilter, StringComparison.OrdinalIgnoreCase))
                            .ToList();
                    }

                    dgvBTC.DataSource = hoaDons;

                    dgvBTC.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
                    dgvBTC.Columns["MaKH"].HeaderText = "Mã khách hàng";
                    dgvBTC.Columns["MaNV"].HeaderText = "Mã nhân viên";
                    dgvBTC.Columns["NgayLap"].HeaderText = "Ngày lập";
                    dgvBTC.Columns["TongTien"].HeaderText = "Tổng tiền";
                    dgvBTC.Columns["GiamGia"].HeaderText = "Giảm giá";
                    dgvBTC.Columns["ThanhTien"].HeaderText = "Thành tiền";
                    dgvBTC.Columns["MaKM"].HeaderText = "Mã khuyến mãi";
                    dgvBTC.Columns["TrangThai"].HeaderText = "Trạng thái đơn";
                    dgvBTC.Columns["GhiChu"].HeaderText = "Ghi chú";
                    dgvBTC.Columns["MaDiaChi"].HeaderText = "Mã địa chỉ";
                    dgvBTC.Columns["MaTT"].HeaderText = "Mã thanh toán";
                    dgvBTC.Columns["MaDVVC"].HeaderText = "Mã đơn vị vận chuyển";
                    dgvBTC.Columns["TrangThai_VanChuyen"].HeaderText = "Trạng thái vận chuyển";
                }
                else
                {
                    MessageBox.Show("Không thể lấy danh sách hóa đơn từ máy chủ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gọi API: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CapNhatTrangThaiVanChuyen(string maHoaDon, string trangThaiMoi)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7265/api/HoaDon/");

                var content = new StringContent($"\"{trangThaiMoi}\"", Encoding.UTF8, "application/json");
                var response = await client.PutAsync($"capnhat-trangthai-vanchuyen/{maHoaDon}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật trạng thái thành công.");
                }
                else
                {
                    string err = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Lỗi cập nhật: " + err);
                }
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f = new frmMain();
            f.ShowDialog();
            f.Show();
        }

        private void dgvBTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTKVSK_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvBTC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // đảm bảo không click vào header
            {
                // Lấy MaHoaDon từ dòng hiện tại
                var maHD = dgvBTC.Rows[e.RowIndex].Cells["MaHoaDon"].Value?.ToString();

                if (!string.IsNullOrEmpty(maHD))
                {
                    // Mở form chi tiết hóa đơn và truyền mã vào
                    FrnChiTietHoaDon frmChiTiet = new FrnChiTietHoaDon(maHD);
                    frmChiTiet.ShowDialog();
                }
            }
        }

        private async void FrmBill_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            // ComboBox lọc trạng thái
            cbBoxTrangThai.Items.Clear();
            cbBoxTrangThai.Items.Add("Tất cả");
            cbBoxTrangThai.Items.AddRange(new string[]
            {
        "Chờ xác nhận", "Đang lấy hàng", "Đang giao hàng", "Đã giao hàng", "Giao thất bại"
            });
            cbBoxTrangThai.SelectedIndex = 0;

            // ComboBox cập nhật trạng thái
            cbBoxCapNhatTrangThai.Items.Clear();
            cbBoxCapNhatTrangThai.Items.Add("Tất cả");
            cbBoxCapNhatTrangThai.Items.AddRange(new string[]
            {
        "Chờ xác nhận", "Đang lấy hàng", "Đang giao hàng", "Đã giao hàng", "Giao thất bại"
            });
            cbBoxCapNhatTrangThai.SelectedIndex = 0;

            await LoadHoaDon();
        }
        
        // Lớp ánh xạ dữ liệu hóa đơn
        public class HoaDon
        {
            public string MaHoaDon { get; set; }
            public string MaKH { get; set; }
            public string MaNV { get; set; }
            public DateTime NgayLap { get; set; }
            public decimal TongTien { get; set; }
            public decimal? GiamGia { get; set; }
            public decimal ThanhTien { get; set; }
            public string MaKM { get; set; }
            public int TrangThai { get; set; }
            public string GhiChu { get; set; }
            public string MaDiaChi { get; set; }
            public string MaTT { get; set; }
            public string MaDVVC { get; set; }
            public string TrangThai_VanChuyen { get; set; }
        }

        private async void guna2Button3_Click(object sender, EventArgs e)
        {
            // Lấy trạng thái hiện tại từ ComboBox lọc (nếu có)
            string selectedTrangThai = cbBoxTrangThai.SelectedItem?.ToString() ?? "Tất cả";

            // Gọi lại hàm load dữ liệu
            await LoadHoaDon(selectedTrangThai);
        }

        private async void cbBoxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTrangThai = cbBoxTrangThai.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTrangThai))
                selectedTrangThai = "Tất cả";

            await LoadHoaDon(selectedTrangThai);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void cbBoxCapNhatTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trangThaiMoi = cbBoxCapNhatTrangThai.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(trangThaiMoi) || trangThaiMoi == "Tất cả")
                return;

            if (dgvBTC.CurrentRow != null)
            {
                string maHoaDon = dgvBTC.CurrentRow.Cells["MaHoaDon"].Value?.ToString();

                if (!string.IsNullOrEmpty(maHoaDon))
                {
                    DialogResult result = MessageBox.Show(
                        $"Bạn có chắc muốn cập nhật trạng thái vận chuyển cho hóa đơn {maHoaDon} thành \"{trangThaiMoi}\" không?",
                        "Xác nhận cập nhật",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        await CapNhatTrangThaiVanChuyen(maHoaDon, trangThaiMoi);

                        // Reload dữ liệu theo ComboBox lọc
                        string selectedTrangThai = cbBoxTrangThai.SelectedItem?.ToString() ?? "Tất cả";
                        await LoadHoaDon(selectedTrangThai);
                        var connection = new HubConnectionBuilder()
                        .WithUrl("https://localhost:7265/hoadonhub")
                        .Build();

                                        await connection.StartAsync();
                                        await connection.InvokeAsync("SendUpdate", maHoaDon);
                                        await connection.StopAsync();
                                    }
                                }
            }
        }

        private void cbBoxCapNhatTrangThai_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
