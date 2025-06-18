using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Net.Http.Json;
using System.Net.Http;
using Newtonsoft.Json;


namespace GUI
{
    public partial class frmQuanLyDanhMuc : Form
    {
        private List<LoaiSanPhamDTO> danhMucList = new List<LoaiSanPhamDTO>();
        private string selectedMaLoai = "";
        public frmQuanLyDanhMuc()
        {
            InitializeComponent();
            dataGridViewLoaiSP.AutoGenerateColumns = false;
        }
        private async Task LoadDanhMucAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7265/api/LoaiSanPham/flat");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    danhMucList = JsonConvert.DeserializeObject<List<LoaiSanPhamDTO>>(json);

                    SetupGridColumns();
                    BindComboBox();
                    FilterGridByParentId();
                }
            }
        }

        private void BindComboBox()
        {
            var copyList = danhMucList.ToList();
            copyList.Insert(0, new LoaiSanPhamDTO { MaLoai = "", TenLoai = "-- Tất cả --" });
            cbbParentId.DataSource = copyList;
            cbbParentId.DisplayMember = "MaLoai";
            cbbParentId.ValueMember = "MaLoai";
            cbbParentId.SelectedIndex = 0;
        }

        private void FilterGridByParentId()
        {
            string selectedParentId = cbbParentId.SelectedValue?.ToString();
            var filtered = string.IsNullOrEmpty(selectedParentId)
                ? danhMucList
                : danhMucList.Where(d => d.ParentId == selectedParentId).ToList();

            dataGridViewLoaiSP.DataSource = null;
            dataGridViewLoaiSP.DataSource = filtered;
        }

        private void SetupGridColumns()
        {
            if (dataGridViewLoaiSP.Columns.Count > 0) return;

            dataGridViewLoaiSP.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaLoai",  // <== Thêm Name
                HeaderText = "Mã Loại",
                DataPropertyName = "MaLoai",
                Width = 150
            });

            dataGridViewLoaiSP.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenLoai",  // <== Thêm Name
                HeaderText = "Tên Loại",
                DataPropertyName = "TenLoai",
                Width = 200
            });

            dataGridViewLoaiSP.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "XuatSu",  // <== Thêm Name
                HeaderText = "Xuất Xứ",
                DataPropertyName = "XuatSu",
                Width = 150
            });

            dataGridViewLoaiSP.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ParentId",  // <== Thêm Name
                HeaderText = "Danh mục cha",
                DataPropertyName = "ParentId",
                Width = 150
            });
        }


        private void ClearInputs()
        {
            txtTenLoai.Clear();
            txtXuatsu.Clear();
            cbbParentId.SelectedIndex = 0;
            selectedMaLoai = "";
        }

        private string GenerateRandomMaLoai()
        {
            Random rnd = new Random();
            int soNgauNhien = rnd.Next(1000, 9999);
            return $"LSP{soNgauNhien}";
        }


        private async void frmQuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            await LoadDanhMucAsync();
        }

        private void dataGridViewLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewLoaiSP.Rows[e.RowIndex];
                selectedMaLoai = row.Cells["MaLoai"].Value?.ToString();
                txtTenLoai.Text = row.Cells["TenLoai"].Value?.ToString();
                txtXuatsu.Text = row.Cells["XuatSu"].Value?.ToString();

                var parentId = row.Cells["ParentId"].Value?.ToString();

                if (string.IsNullOrEmpty(parentId) || !cbbParentId.Items.Cast<LoaiSanPhamDTO>().Any(x => x.MaLoai == parentId))
                {
                    cbbParentId.SelectedIndex = 0; // chọn "-- Tất cả --" hoặc null
                }
                else
                {
                    cbbParentId.SelectedValue = parentId;
                }
            }
        }

        private async void guna2Button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaLoai))
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa.");
                return;
            }

            var updatedLoai = new
            {
                MaLoai = selectedMaLoai,
                TenLoai = txtTenLoai.Text.Trim(),
                XuatSu = txtXuatsu.Text.Trim(),
                ParentId = cbbParentId.SelectedValue?.ToString()
            };

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(updatedLoai), Encoding.UTF8, "application/json");
                var res = await client.PutAsync($"https://localhost:7265/api/LoaiSanPham/{selectedMaLoai}", content);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cập nhật thành công");
                    await LoadDanhMucAsync();
                }
                else
                {
                    string msg = await res.Content.ReadAsStringAsync();
                    MessageBox.Show("Lỗi cập nhật: " + msg);
                }
            }
        }

        private async void guna2ButtonThêm_Click(object sender, EventArgs e)
        {
            var newItem = new LoaiSanPhamDTO
            {
                MaLoai = GenerateRandomMaLoai(), // Sinh ngẫu nhiên
                TenLoai = txtTenLoai.Text.Trim(),
                XuatSu = txtXuatsu.Text.Trim(),
                ParentId = string.IsNullOrEmpty(cbbParentId.SelectedValue?.ToString()) ? null : cbbParentId.SelectedValue.ToString()
            };

            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(newItem), Encoding.UTF8, "application/json");
                var res = await client.PostAsync("https://localhost:7265/api/LoaiSanPham", content);
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm mới thành công");
                    await LoadDanhMucAsync();
                }
                else
                {
                    string msg = await res.Content.ReadAsStringAsync();
                    MessageBox.Show("Lỗi thêm: " + msg);
                }
            }
        }

        private async void guna2ButtonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaLoai))
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa loại: {selectedMaLoai}?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            using (HttpClient client = new HttpClient())
            {
                var res = await client.DeleteAsync($"https://localhost:7265/api/LoaiSanPham/{selectedMaLoai}");
                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Xóa thành công");
                    await LoadDanhMucAsync();
                    ClearInputs();
                }
                else
                {
                    string msg = await res.Content.ReadAsStringAsync();
                    MessageBox.Show("Không thể xóa: " + msg);
                }
            }
        }

        private void dataGridViewLoaiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2ButtonDong_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn form hiện tại
            frmMain mainForm = new frmMain(); // Tạo form chính mới
            mainForm.Show(); // Hiển thị form chính
        }

        private void cbbParentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbParentId.SelectedIndex >= 0 && cbbParentId.SelectedValue != null)
            {
                FilterGridByParentId();
            }
        }
    }
}
