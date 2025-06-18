using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using DTO;
using System.Net.Http;

namespace GUI
{
    public partial class FrmSanPham : Form
    {
        private List<SanPhamDTO> sanPhamList = new List<SanPhamDTO>();
        private string selectedMaSP = "";
        public FrmSanPham()
        {
            InitializeComponent();
            dataGridViewSP.AutoGenerateColumns = false;
        }

        private async void FrmSanPham_Load(object sender, EventArgs e)
        {
            SetupGridColumns();
            await LoadLoaiSP();
            await LoadNhaCungCap();
            await LoadSanPhamAsync();
        }
        private async Task LoadLoaiSP()
        {
            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetAsync("https://localhost:7265/api/LoaiSanPham/flat");
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    var list = JsonConvert.DeserializeObject<List<LoaiSanPhamDTO>>(json);

                    list.Insert(0, new LoaiSanPhamDTO
                    {
                        MaLoai = null,
                        TenLoai = "-- Chưa phân loại --"
                    });

                    cbbMaLoai.DataSource = list;
                    cbbMaLoai.DisplayMember = "TenLoai";
                    cbbMaLoai.ValueMember = "MaLoai";

                }
            }
        }



        private async Task LoadNhaCungCap()
        {
            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetAsync("https://localhost:7265/api/NhaCungCap");
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    var list = JsonConvert.DeserializeObject<List<Supplier>>(json);
                    cbbMaNCC.DataSource = list;
                    cbbMaNCC.DisplayMember = "TenNCC";
                    cbbMaNCC.ValueMember = "MaNCC";
                }
            }
        }

        private async Task LoadSanPhamAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7265/api/SanPham");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    sanPhamList = JsonConvert.DeserializeObject<List<SanPhamDTO>>(json);
                    dataGridViewSP.DataSource = sanPhamList;
                }
            }
        }

        private void SetupGridColumns()
        {
            dataGridViewSP.Columns.Clear();
            dataGridViewSP.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaSanPham", // <- Cần có Name để CellClick tìm đúng
                HeaderText = "Mã SP",
                DataPropertyName = "MaSanPham",
                Width = 100
            });
            dataGridViewSP.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenSanPham",
                HeaderText = "Tên SP",
                DataPropertyName = "TenSanPham",
                Width = 200
            });
            dataGridViewSP.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MoTa",
                HeaderText = "Mô tả",
                DataPropertyName = "MoTa",
                Width = 150
            });
            dataGridViewSP.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HinhAnh",
                HeaderText = "Hình ảnh",
                DataPropertyName = "HinhAnh",
                Width = 150
            });
            dataGridViewSP.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaLoai",
                HeaderText = "Mã Loại",
                DataPropertyName = "MaLoai",
                Width = 100
            });
            dataGridViewSP.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaNCC",
                HeaderText = "Mã NCC",
                DataPropertyName = "MaNCC",
                Width = 100
            });
        }


        private string GenerateRandomMaSP()
        {
            Random rnd = new Random();
            return $"SP{rnd.Next(1000, 9999)}";
        }
        private void dataGridViewSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewSP.Rows[e.RowIndex];
                selectedMaSP = row.Cells["MaSanPham"].Value?.ToString();
                txtTenSP.Text = row.Cells["TenSanPham"].Value?.ToString();
                txtMota.Text = row.Cells["MoTa"].Value?.ToString();
                txtHinhAnh.Text = row.Cells["HinhAnh"].Value?.ToString();
                var maLoai = row.Cells["MaLoai"].Value?.ToString();
                if (!string.IsNullOrEmpty(maLoai) && cbbMaLoai.Items.Cast<LoaiSanPhamDTO>().Any(x => x.MaLoai == maLoai))
                {
                    cbbMaLoai.SelectedValue = maLoai;
                }
                else
                {
                    cbbMaLoai.SelectedIndex = 0; // chọn "-- Chưa phân loại --" (item có MaLoai = null)
                }
                var maNcc = row.Cells["MaNCC"].Value?.ToString();
                if (!string.IsNullOrEmpty(maNcc) && cbbMaNCC.Items.Cast<Supplier>().Any(x => x.MaNCC == maNcc))
                {
                    cbbMaNCC.SelectedValue = maNcc;
                }
                else
                {
                    cbbMaNCC.SelectedIndex = -1; // hoặc giữ nguyên nếu bạn có mục mặc định
                }
            }
        }

        private async void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaSP))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.");
                return;
            }

            var sp = new SanPhamDTO
            {
                MaSanPham = selectedMaSP,
                TenSanPham = txtTenSP.Text.Trim(),
                MaLoai = cbbMaLoai.SelectedValue.ToString(),
                MaNCC = cbbMaNCC.SelectedValue.ToString(),
                TrangThai = 1
            };

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(sp), Encoding.UTF8, "application/json");
                var res = await client.PutAsync($"https://localhost:7265/api/SanPham/{sp.MaSanPham}", content);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật thành công");
                    await LoadSanPhamAsync();
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật");
                }
            }
        }

        private async void guna2ButtonThêm_Click(object sender, EventArgs e)
        {
            var sp = new SanPhamDTO
            {
                MaSanPham = GenerateRandomMaSP(),
                TenSanPham = txtTenSP.Text.Trim(),
                MoTa = txtMota.Text.Trim(),
                HinhAnh = txtHinhAnh.Text.Trim(),
                MaLoai = cbbMaLoai.SelectedValue?.ToString(),
                MaNCC = cbbMaNCC.SelectedValue?.ToString(),
                TrangThai = 1
            };

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(sp), Encoding.UTF8, "application/json");
                var res = await client.PostAsync("https://localhost:7265/api/SanPham", content);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm thành công");
                    await LoadSanPhamAsync();
                    ClearInputs(); // <- gọi ở đây
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
        private void ClearInputs()
        {
            txtTenSP.Clear();
            txtMota.Clear();
            txtHinhAnh.Clear();
            cbbMaLoai.SelectedIndex = 0;   // "-- Chưa phân loại --"
            cbbMaNCC.SelectedIndex = -1;   // hoặc 0 nếu bạn muốn về mục đầu
            selectedMaSP = "";
        }


        private async void guna2ButtonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaSP)) return;

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            using (HttpClient client = new HttpClient())
            {
                var res = await client.DeleteAsync($"https://localhost:7265/api/SanPham/{selectedMaSP}");
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Xóa thành công");
                    await LoadSanPhamAsync();
                    ClearInputs(); // <- gọi ở đây
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void guna2ButtonDong_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form hiện tại
            frmMain mainForm = new frmMain(); // Tạo form chính mới
            mainForm.Show(); // Hiển thị form chính
        }

        private void cbbMaLoai_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbMaNCC_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        public class SanPhamDTO
        {
            public string MaSanPham { get; set; }
            public string TenSanPham { get; set; }
            public string MoTa { get; set; }
            public string HinhAnh { get; set; }
            public string MaLoai { get; set; }
            public string MaNCC { get; set; }
            public int TrangThai { get; set; }
        }
    }
}
