using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CartItem
    {
        public string MaBienThe { get; set; }      // Mã biến thể duy nhất (mỗi màu + size có mã khác nhau)
        public string TenSanPham { get; set; }     // Tên hiển thị
        public string MauSac { get; set; }         // Ví dụ: Trắng
        public string KichThuoc { get; set; }      // Ví dụ: Medium (M)
        public string HinhAnh { get; set; }        // Đường dẫn ảnh
        public int SoLuong { get; set; }           // Số lượng người dùng chọn
        public decimal DonGia { get; set; }        // Đơn giá cho biến thể này
    }


}
