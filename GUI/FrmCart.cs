using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using System.Text.RegularExpressions;
using DTO;

namespace GUI
{
    public partial class FrmCart : Form
    {
        private int diemTichLuy = 0;
        private List<KhuyenMai> danhSachKM = new List<KhuyenMai>();


        // Biến lưu tổng tiền gốc (chưa trừ điểm)
        private decimal tongTienGoc = 0m; // Khai báo ở đầu class

        public FrmCart()
        {
            InitializeComponent();
            cbbKM.SelectedIndexChanged += cbbKM_SelectedIndexChanged;
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

        private async void CapNhatTongTienSauGiam()
        {
            try
            {
                decimal giamGiaKhuyenMai = 0m;
                string maKM = cbbKM.SelectedValue?.ToString(); 
                txtKM.Text = string.Empty;

                if (!string.IsNullOrEmpty(maKM))
                {
                    KhuyenMai selectedKhuyenMai = null;
                    try
                    {
                        selectedKhuyenMai = danhSachKM?.FirstOrDefault(k => k.MaKM == maKM);
                        if (selectedKhuyenMai == null)
                        {
                            selectedKhuyenMai = await GetKhuyenMaiByMaKMAsync(maKM);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải thông tin khuyến mãi: {ex.Message}", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbbKM.SelectedValue = null; 
                        txtKM.Text = string.Empty; 
                    }

                    if (selectedKhuyenMai != null)
                    {
                        DateTime ngayHienTai = DateTime.Now;
                        bool isExpired = ngayHienTai < selectedKhuyenMai.NgayBatDau || ngayHienTai > selectedKhuyenMai.NgayKetThuc;
                        bool isUsageLimitReached = selectedKhuyenMai.SoLuongDaApDung >= selectedKhuyenMai.SoLuongApDung;

                        if (!isExpired && !isUsageLimitReached)
                        {
                            txtKM.Text = selectedKhuyenMai.TenKM;

                            if (selectedKhuyenMai.MaLoaiKM == "GIAM_PHAN_TRAM" && selectedKhuyenMai.PhanTramGiam.HasValue) 
                            {
                                giamGiaKhuyenMai = tongTienGoc * ((decimal)selectedKhuyenMai.PhanTramGiam.Value / 100m);
                            }
                            else if (selectedKhuyenMai.MaLoaiKM == "GIAM_TIEN" && selectedKhuyenMai.GiamTien.HasValue) 
                            {
                                decimal dieuKienApDung = 0;
                                if (!decimal.TryParse(selectedKhuyenMai.DieuKien?.ToString(), out dieuKienApDung))
                                {
                                    dieuKienApDung = 0;
                                }


                                if (tongTienGoc >= dieuKienApDung)
                                {
                                    giamGiaKhuyenMai = selectedKhuyenMai.GiamTien.Value;
                                }
                                else
                                {
                                    giamGiaKhuyenMai = 0;
                                    MessageBox.Show($"Khuyến mãi chỉ áp dụng cho đơn hàng từ {dieuKienApDung:N0} VND trở lên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Loại khuyến mãi '{selectedKhuyenMai.MaLoaiKM}' không được xử lý hoặc thiếu giá trị giảm giá.");
                                giamGiaKhuyenMai = 0m;
                            }
                        }
                        else 
                        {
                            string message = $"Mã khuyến mãi '{selectedKhuyenMai.TenKM}' (Mã: {selectedKhuyenMai.MaKM}) ";
                            if (isExpired)
                                message += "đã hết hạn sử dụng (Ngày bắt đầu: " + selectedKhuyenMai.NgayBatDau.ToShortDateString() + ", Ngày kết thúc: " + selectedKhuyenMai.NgayKetThuc.ToShortDateString() + "). ";
                            if (isUsageLimitReached)
                                message += "đã hết lượt áp dụng (Đã dùng: " + selectedKhuyenMai.SoLuongDaApDung + "/" + selectedKhuyenMai.SoLuongApDung + "). ";
                            message += "Vui lòng chọn khuyến mãi khác.";
                            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cbbKM.SelectedValue = null; 
                            txtKM.Text = string.Empty; 
                            giamGiaKhuyenMai = 0m;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Mã khuyến mãi '{maKM}' không tìm thấy. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbbKM.SelectedValue = null;
                        txtKM.Text = string.Empty;
                        giamGiaKhuyenMai = 0m; 
                    }
                }
                else
                {
                    txtKM.Text = string.Empty;
                    giamGiaKhuyenMai = 0m;
                }

                int diemSuDung = 0;
                if (int.TryParse(txtUsePoint.Text.Trim(), out int parsedDiemDung))
                {
                    diemSuDung = parsedDiemDung;
                }

                if (diemSuDung > diemTichLuy)
                {
                    diemSuDung = (int)diemTichLuy;
                }
                else if (diemSuDung < 0)
                {
                    diemSuDung = 0;
                }
                decimal giamGiaTuDiem = diemSuDung * 1000m; 

                decimal totalGiamGia = giamGiaKhuyenMai + giamGiaTuDiem;
                decimal finalThanhTien = tongTienGoc - totalGiamGia;
                if (finalThanhTien < 0)
                {
                    finalThanhTien = 0;
                }
                txtTT.Text = $"{tongTienGoc:N0} đ";
                txtGiamGia.Text = $"{totalGiamGia:N0} đ"; 
                txtTotal.Text = $"{finalThanhTien:N0} VNĐ"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính tổng tiền: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            await LoadDiemTichLuyAsync(tenKH, sdt);
        }
        private void txtUsePoint_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsePoint.Text))
            {
                txtUsePoint.Text = "0";
                txtUsePoint.SelectionStart = txtUsePoint.Text.Length;
            }

            if (int.TryParse(txtUsePoint.Text.Trim(), out int diemDung))
            {
                if (diemDung > diemTichLuy)
                {
                    // Thay vì MessageBox.Show, bạn có thể chỉ cập nhật TextBox và thông báo nhỏ
                    // MessageBox.Show("Số điểm sử dụng không được vượt quá điểm tích lũy.");
                    txtUsePoint.Text = diemTichLuy.ToString();
                    txtUsePoint.SelectionStart = txtUsePoint.Text.Length;
                }
                else if (diemDung < 0)
                {
                    txtUsePoint.Text = "0";
                    txtUsePoint.SelectionStart = txtUsePoint.Text.Length;
                }
            }
            else // Nếu nhập không phải số
            {
                txtUsePoint.Text = "0";
                txtUsePoint.SelectionStart = txtUsePoint.Text.Length;
            }

            // Luôn gọi CapNhatTongTienSauGiam để cập nhật hiển thị
            CapNhatTongTienSauGiam();
        }
       

        // Hàm gọi API PUT để cập nhật điểm tích lũy
        private async Task LoadDiemTichLuyAsync(string tenKH, string sdt)
        {
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
        private async Task<bool> UpdateDiemAsync(string maKH, int diem)
        {
            if (string.IsNullOrEmpty(maKH))
                return false;

            var lichSuDiem = new
            {
                Diem = diem
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7265");

                var json = JsonConvert.SerializeObject(lichSuDiem);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"api/LichSuDiem/{maKH}", content);

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"API lỗi: {response.StatusCode}\n{error}");
                }

                return response.IsSuccessStatusCode;
            }
        }
        private async Task<bool> UpdateDiemCongAsync(string maKH, int diem)
        {
            if (string.IsNullOrEmpty(maKH))
                return false;

            var lichSuDiem = new
            {
                Diem = diem
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7265");

                var json = JsonConvert.SerializeObject(lichSuDiem);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"api/LichSuDiem/Cong/{maKH}", content);

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"API lỗi: {response.StatusCode}\n{error}");
                }

                return response.IsSuccessStatusCode;
            }
        }
        private async void btnUsePoint_Click(object sender, EventArgs e)
        {
            try
            {
                string tenKH = txtCusName.Text.Trim();
                string sdt = txtCusPhone.Text.Trim();
                string maKH = await GetMaKhachHangAsync(tenKH, sdt);
                int diem = int.TryParse(txtUsePoint.Text.Trim(), out int parsedDiem) ? parsedDiem : 0;

                if (string.IsNullOrEmpty(maKH))
                {
                    MessageBox.Show("Không tìm thấy Mã khách hàng.");
                    return;
                }

                bool success = await UpdateDiemAsync(maKH, diem);

                if (success)
                {
                    MessageBox.Show("Cập nhật điểm thành công!");
                    await LoadDiemTichLuyAsync(tenKH, sdt); // load lại điểm
                }
                else
                {
                    MessageBox.Show("Cập nhật điểm thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7265/")
        };

        /* Lấy khuyến mãi */
        private async Task LoadKhuyenMaiAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/KhuyenMai"); 
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<KhuyenMai>>(jsonResponse);

                if (list != null && list.Any()) 
                {
                    danhSachKM = list;

                    DateTime ngayHienTai = DateTime.Now;
                    var validKhuyenMai = danhSachKM
                        .Where(km => km.NgayBatDau <= ngayHienTai && km.NgayKetThuc >= ngayHienTai && km.TrangThai == 1 && km.SoLuongDaApDung < km.SoLuongApDung)
                        .ToList();

                    cbbKM.DisplayMember = "MaKM"; 
                    cbbKM.ValueMember = "MaKM";  
                    cbbKM.DataSource = validKhuyenMai;
                    cbbKM.SelectedIndex = -1; 

                    
                    if (cbbKM.SelectedItem is KhuyenMai firstKm)
                    {
                        txtKM.Text = firstKm.TenKM;
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu khuyến mãi hợp lệ để hiển thị.");
                    cbbKM.DataSource = null; // Xóa dữ liệu ComboBox nếu không có KM
                    txtKM.Text = string.Empty;
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Lỗi kết nối API khi tải danh sách khuyến mãi: {httpEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonSerializationException jsonEx)
            {
                MessageBox.Show($"Lỗi định dạng dữ liệu khi tải danh sách khuyến mãi: {jsonEx.Message}. Chi tiết: {jsonEx.Path}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định khi tải danh sách khuyến mãi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<KhuyenMai> GetKhuyenMaiByMaKMAsync(string maKM)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/KhuyenMai/{maKM}");
                response.EnsureSuccessStatusCode(); 

                var jsonResponse = await response.Content.ReadAsStringAsync();
                var khuyenMai = JsonConvert.DeserializeObject<KhuyenMai>(jsonResponse);
                return khuyenMai;
            }
            catch (HttpRequestException httpEx)
            {
                throw new Exception("Không thể kết nối đến máy chủ API để lấy thông tin khuyến mãi.", httpEx);
            }
            catch (JsonSerializationException jsonEx)
            {
                throw new Exception($"Lỗi định dạng dữ liệu khuyến mãi (Json): {jsonEx.Message}. Path: {jsonEx.Path} Line: {jsonEx.LineNumber}", jsonEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi không mong muốn khi lấy thông tin khuyến mãi.", ex);
            }
        }
        private void cbbKM_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTongTienSauGiam();
        }

        private async void FrmCart_Load(object sender, EventArgs e)
        {
            LoadKhuyenMaiAsync();
            LoadPhuongThucThanhToanAsync();
        }

        private async Task LoadPhuongThucThanhToanAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/PhuongThucThanhToan");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    var list = JsonConvert.DeserializeObject<List<PhuongThucThanhToan>>(json); 

                    if (list != null && list.Count > 0)
                    {
                        cbbPPTT.DataSource = list;
                        cbbPPTT.DisplayMember = "TenTT"; // tên hiển thị
                        cbbPPTT.ValueMember = "MaTT";    // mã giá trị
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu phương thức thanh toán.");
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

        private async Task<string> GetMaKhachHangAsync(string tenKH, string sdt)
        {
            try
            {
                string encodedTenKH = Uri.EscapeDataString(tenKH.Trim());
                string encodedSDT = Uri.EscapeDataString(sdt.Trim());

                string url = $"https://localhost:7265/api/KhachHang/GetMaKH?tenKH={encodedTenKH}&sdt={encodedSDT}";

                var response = await _httpClient.GetAsync(url); 

                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<dynamic>(responseJson);
                    return result?.maKH;
                }
                else
                {
                    MessageBox.Show($"API trả về lỗi: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gọi API: " + ex.Message);
                return null;
            }
        }

        /* Tìm mã biến thể sản phẩm */
        private async Task<string> GetMaBienTheAsync(string tenSP, string size, string mauSac)
        {
            try
            {
                string encodedTenSP = Uri.EscapeDataString(tenSP);
                string encodedSize = Uri.EscapeDataString(size);
                string encodedMauSac = Uri.EscapeDataString(mauSac);

                string url = $"api/BienTheSanPham/TimMaBienThe?tenSP={encodedTenSP}&size={encodedSize}&mauSac={encodedMauSac}";
                var response = await _httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<JObject>(content);
                return result["maBienThe"]?.ToString(); 
            }
            catch
            {
                return null;
            }
        }


        /* Tạo đơn hàng mới */
        private List<CartItem> gioHang = new List<CartItem>();

        private async void btnAccpet_Click(object sender, EventArgs e)
        {
            try
            {
                string tenKH = txtCusName.Text.Trim();
                string sdt = txtCusPhone.Text.Trim();
                string phuongThuc = cbbPPTT.Text.Trim();
                string maKM = cbbKM.Text;
                string ghiChu = txtNote.Text.Trim();

                int diemSuDung = int.TryParse(txtUsePoint.Text.Trim(), out var diem) ? diem : 0;
                string giamGiaText = txtGiamGia.Text.Trim();
                decimal giamGia = 0;

                string cleanGiamGiaText = Regex.Replace(giamGiaText, @"[^\d]", "");
                if (!string.IsNullOrEmpty(cleanGiamGiaText) && decimal.TryParse(cleanGiamGiaText, out var tempGiamGia))
                    giamGia = tempGiamGia;

                DateTime ngayHienTai = DateTime.Now;

                // Parse thành tiền
                string rawText = Regex.Replace(txtTotal.Text, @"[^\d]", "");
                if (!decimal.TryParse(rawText, out decimal thanhTien))
                {
                    MessageBox.Show($"Giá trị thành tiền không hợp lệ: \"{rawText}\"");
                    return;
                }

                decimal tongTien = thanhTien + giamGia;

                if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(phuongThuc))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng và phương thức thanh toán.");
                    return;
                }

                string maKH = await GetMaKhachHangAsync(tenKH, sdt);
                if (string.IsNullOrEmpty(maKH))
                {
                    MessageBox.Show("Không thể lấy được mã khách hàng.");
                    return;
                }

                string MapPhuongThuc(string pt)
                {
                    if (pt == "Thanh toán khi nhận hàng (COD)") return "COD";
                    if (pt == "Thanh toán bằng VNPAY QR") return "QR";
                    return "KHAC";
                }

                // Chuẩn bị danh sách giỏ hàng
                List<CartItem> gioHang = new List<CartItem>();
                foreach (Cart cartItem in flwCart.Controls.OfType<Cart>())
                {
                    string maBienThe = await GetMaBienTheAsync(cartItem.ProductName, cartItem.ProductSize, cartItem.ProductColor);
                    if (string.IsNullOrEmpty(maBienThe))
                    {
                        MessageBox.Show($"Không tìm thấy mã biến thể cho sản phẩm: {cartItem.ProductName} - {cartItem.ProductSize} - {cartItem.ProductColor}");
                        return;
                    }

                    gioHang.Add(new CartItem
                    {
                        MaBienThe = maBienThe,
                        TenSanPham = cartItem.ProductName,
                        MauSac = cartItem.ProductColor,
                        KichThuoc = cartItem.ProductSize,
                        HinhAnh = null,
                        SoLuong = cartItem.ProductQuantity,
                        DonGia = cartItem.ProductPrice
                    });
                }

                if (!gioHang.Any())
                {
                    MessageBox.Show("Giỏ hàng trống. Vui lòng chọn sản phẩm.");
                    return;
                }

                // Tạo đối tượng request
                var hoaDon = new
                {
                    MaKH = maKH,
                    MaNV = SessionManager.MaNhanVien,
                    NgayLap = ngayHienTai.ToString("yyyy-MM-ddTHH:mm:ss"),
                    TongTien = tongTien,
                    GiamGia = giamGia,
                    ThanhTien = thanhTien,
                    MaKM = maKM,
                    MaTT = MapPhuongThuc(phuongThuc),
                    MaDVVC = "ch",
                    TrangThai = 1,
                    GhiChu = ghiChu,
                    ChiTietHoaDon = gioHang
                };

                var json = JsonConvert.SerializeObject(hoaDon);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("api/HoaDon", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Tạo hóa đơn thành công!");

                    string responseContent = await response.Content.ReadAsStringAsync();
                    var responseData = JsonConvert.DeserializeObject<dynamic>(responseContent);
                    string maHD = responseData?.maHD;

                    // ✅ Tính điểm tích lũy: 10.000 VNĐ = 1 điểm
                    int diemTichLuyMoi = (int)(thanhTien / 100000);

                    bool updateSuccess = await UpdateDiemCongAsync(maKH, diemTichLuyMoi);
                    if (updateSuccess)
                        MessageBox.Show($"Cộng {diemTichLuyMoi} điểm tích lũy cho khách hàng thành công.");
                    else
                        MessageBox.Show("Cập nhật điểm tích lũy thất bại.");

                    // ✅ Lấy thông tin hóa đơn để in
                    HttpResponseMessage getHDResponse = await _httpClient.GetAsync($"api/HoaDon/GetHoaDonByMa?maHD={maHD}");
                    if (getHDResponse.IsSuccessStatusCode)
                    {
                        string hoaDonJson = await getHDResponse.Content.ReadAsStringAsync();
                        var createdHoaDon = JsonConvert.DeserializeObject<HoaDonInModel>(hoaDonJson);
                        if (createdHoaDon != null)
                        {
                            OpenPrintInvoiceForm(createdHoaDon);
                        }
                        else
                        {
                            MessageBox.Show("Không thể phân tích thông tin hóa đơn để in.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy thông tin chi tiết hóa đơn vừa tạo.");
                    }
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    try
                    {
                        var errorObj = JsonConvert.DeserializeObject<dynamic>(error);
                        if (errorObj.errors != null)
                        {
                            StringBuilder sb = new StringBuilder();
                            foreach (var prop in errorObj.errors)
                            {
                                sb.AppendLine($"{prop.Name}: {string.Join(", ", prop.Value)}");
                            }
                            MessageBox.Show("Lỗi khi tạo hóa đơn:\n" + sb.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi tạo hóa đơn:\n" + error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi khi tạo hóa đơn:\n" + error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void OpenPrintInvoiceForm(HoaDonInModel hoaDonToPrint)
        {
            FrmPrintBill printForm = new FrmPrintBill(hoaDonToPrint);
            printForm.ShowDialog(); 
        }
        private void txtTT_Click(object sender, EventArgs e)
        {

        }
    }
}