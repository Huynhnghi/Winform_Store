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
using DTO;
using Newtonsoft.Json;

namespace GUI
{
    public partial class FrmPrintBill : Form
    {
        private HoaDonInModel _hoaDon;
        private readonly HttpClient _httpClient;

        public FrmPrintBill(HoaDonInModel hoaDon)
        {
            InitializeComponent();
            _hoaDon = hoaDon;

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:7265/") // 🔁 Thay thế bằng API URL thực tế
            };

            // Gọi hàm async từ constructor thông qua void async wrapper
            FillUI();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }


        // Hàm load dữ liệu hóa đơn
        private void FillUI()
        {
            if (_hoaDon == null)
            {
                MessageBox.Show("Không có dữ liệu hóa đơn để hiển thị.");
                return;
            }

            // Thông tin chung
            txtMaHD.Text = _hoaDon.MaHoaDon;
            txtMaNV.Text = $"{_hoaDon.MaNV} ({_hoaDon.TenNV})";
            txtNgayLap.Text = _hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm");
            txtTenKH.Text = _hoaDon.TenKH;
            txtSDT.Text = _hoaDon.SdtKH;
            txtLoaiKH.Text = _hoaDon.LoaiKhachHang;
            txtMaDVVC.Text = "Fasic Fashion Store (Địa chỉ của cửa hàng)";

            // Danh sách chi tiết sản phẩm
            listBT.Items.Clear();
            int stt = 1;
            foreach (var item in _hoaDon.ChiTietHoaDon)
            {
                var listItem = new ListViewItem(stt.ToString());
                listItem.SubItems.Add($"{item.TenSanPham} ({item.Size} - {item.MauSac})");
                listItem.SubItems.Add($"{item.GiaBan:N0} VND");
                listItem.SubItems.Add(item.SoLuong.ToString());
                listItem.SubItems.Add($"{item.ThanhTienTungSP:N0} VND");

                listBT.Items.Add(listItem);
                stt++;
            }

            // Tổng cộng
            lblTotalPrice.Text = $"{_hoaDon.TongTien:N0} VND";
            lblDiscount.Text = $"{_hoaDon.GiamGia:N0} VND";
            lblFinalPrice.Text = $"{_hoaDon.ThanhTien:N0} VND";
        }

    }
}
