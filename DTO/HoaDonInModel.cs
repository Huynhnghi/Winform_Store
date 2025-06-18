using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonInModel
    {
        public string MaHoaDon { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; } // Nên có từ API
        public string SdtKH { get; set; } // Nên có từ API
        public string LoaiKhachHang { get; set; } // Nếu có
        public string MaNV { get; set; }
        public string TenNV { get; set; } // Nên có từ API
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
        public decimal GiamGia { get; set; }
        public decimal ThanhTien { get; set; }
        public string MaKM { get; set; }
        public string TenKM { get; set; } // Nên có từ API khuyến mãi
        public string MaTT { get; set; }
        public string TenPhuongThucThanhToan { get; set; } // Để hiển thị rõ hơn
        public string MaDVVC { get; set; }
        public string GhiChu { get; set; }
        public List<ChiTietHoaDonInModel> ChiTietHoaDon { get; set; }
    }

    public class ChiTietHoaDonInModel
    {
        public string MaBienThe { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MauSac { get; set; }
        public string Size { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
        public decimal ThanhTienTungSP { get { return SoLuong * GiaBan; } } // Thêm thuộc tính tính toán để in
    }
}