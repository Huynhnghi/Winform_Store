using DTO;
using Newtonsoft.Json;
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

namespace GUI
{
    public partial class frmBienTheSP : Form
    {
        private List<ChiTietSanPhamDTO> chitietList = new List<ChiTietSanPhamDTO>();
        private string selectedMaBienThe = "";

        public frmBienTheSP()
        {
            InitializeComponent();
        }

        private async void frmBienTheSP_Load(object sender, EventArgs e)
        {
            await LoadSanPham();
            // Khởi tạo trạng thái cho combo box
            metroComboBox1.Items.Clear();
            metroComboBox1.Items.Add("Còn bán");  // index 1
            metroComboBox1.Items.Add("Ngưng bán"); // index 0
            metroComboBox1.SelectedIndex = 0;
        }

        private async Task LoadSanPham()
        {
            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetAsync("https://localhost:7265/api/SanPham");
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    var list = JsonConvert.DeserializeObject<List<SanPhamDTO>>(json);
                    cbbMaSP.DataSource = list;
                    cbbMaSP.DisplayMember = "TenSanPham";
                    cbbMaSP.ValueMember = "MaSanPham";
                }
            }
        }

        private async Task LoadBienTheTheoSP(string maSP)
        {
            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetAsync($"https://localhost:7265/api/BienTheSanPham/sanpham/{maSP}");
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    chitietList = JsonConvert.DeserializeObject<List<ChiTietSanPhamDTO>>(json);
                    dataGridViewBienThe.DataSource = chitietList;
                }
            }
        }

        private async void cbbMaSP_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbMaSP.SelectedValue != null)
            {
                string maSP = cbbMaSP.SelectedValue.ToString();
                await LoadBienTheTheoSP(maSP);
            }
        }

        private void dataGridViewBienThe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewBienThe.Rows[e.RowIndex];
                selectedMaBienThe = row.Cells["MaBienThe"].Value?.ToString();
                txtSize.Text = row.Cells["Size"].Value?.ToString();
                txtMauSac.Text = row.Cells["MauSac"].Value?.ToString();
                txtHinhAnh.Text = row.Cells["HinhAnh"].Value?.ToString();
                txtGiaVon.Text = row.Cells["GiaVon"].Value?.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString();
                numericUpDownSL.Text = row.Cells["TonKho"].Value?.ToString();
                txtTrongLuong.Text = row.Cells["TrongLuong"].Value?.ToString();
                int trangThai = int.Parse(row.Cells["TrangThai"].Value.ToString());
                metroComboBox1.SelectedIndex = (trangThai == 1) ? 0 : 1;

            }
        }


        private async void guna2ButtonThêm_Click(object sender, EventArgs e)
        {
            var bienThe = new ChiTietSanPhamDTO
            {
                MaBienThe = $"BT{new Random().Next(1000, 9999)}",
                MaSanPham = cbbMaSP.SelectedValue?.ToString(),
                Size = txtSize.Text.Trim(),
                MauSac = txtMauSac.Text.Trim(),
                HinhAnh = txtHinhAnh.Text.Trim(),
                Barcode = $"BAR{Guid.NewGuid().ToString("N").Substring(0, 8)}",
                GiaVon = decimal.Parse(txtGiaVon.Text),
                GiaBan = decimal.Parse(txtGiaBan.Text),
                TonKho = int.Parse(numericUpDownSL.Text),
                TrongLuong = float.Parse(txtTrongLuong.Text),
                TrangThai = metroComboBox1.SelectedIndex == 0 ? 1 : 0
            };

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(bienThe), Encoding.UTF8, "application/json");
                var res = await client.PostAsync("https://localhost:7265/api/BienTheSanPham", content);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm thành công");
                    await LoadBienTheTheoSP(bienThe.MaSanPham);
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private async void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaBienThe)) return;

            var bienThe = new ChiTietSanPhamDTO
            {
                MaBienThe = selectedMaBienThe,
                MaSanPham = cbbMaSP.SelectedValue?.ToString(),
                Size = txtSize.Text.Trim(),
                MauSac = txtMauSac.Text.Trim(),
                HinhAnh = txtHinhAnh.Text.Trim(),
                GiaVon = decimal.Parse(txtGiaVon.Text),
                GiaBan = decimal.Parse(txtGiaBan.Text),
                TonKho = int.Parse(numericUpDownSL.Text),
                TrongLuong = float.Parse(txtTrongLuong.Text),
                TrangThai = metroComboBox1.SelectedIndex
            };

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(bienThe), Encoding.UTF8, "application/json");
                var res = await client.PutAsync($"https://localhost:7265/api/BienTheSanPham/{selectedMaBienThe}", content);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật thành công");
                    await LoadBienTheTheoSP(bienThe.MaSanPham);
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }

        private async void guna2ButtonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaBienThe)) return;

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa biến thể này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            using (HttpClient client = new HttpClient())
            {
                var res = await client.DeleteAsync($"https://localhost:7265/api/BienTheSanPham/{selectedMaBienThe}");
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Xóa thành công");
                    await LoadBienTheTheoSP(cbbMaSP.SelectedValue?.ToString());
                    ClearInput();
                }
            }
        }

        private void guna2ButtonDong_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form hiện tại
            frmMain mainForm = new frmMain(); // Tạo form chính mới
            mainForm.Show(); // Hiển thị form chính
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ClearInput()
        {
            txtSize.Clear();
            txtMauSac.Clear();
            txtHinhAnh.Clear();
            txtGiaVon.Clear();
            txtGiaBan.Clear();
            numericUpDownSL.Value = 0;
            txtTrongLuong.Clear();
            metroComboBox1.SelectedIndex = 0;
            selectedMaBienThe = "";
        }

        public class ChiTietSanPhamDTO
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
        }

        public class SanPhamDTO
        {
            public string MaSanPham { get; set; }
            public string TenSanPham { get; set; }
        }
    }
}
