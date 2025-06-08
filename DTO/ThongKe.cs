using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKe
    {
        public decimal TongTien { get; set; }
        public List<HoaDonViewModel> Data { get; set; }
    }

    public class HoaDonViewModel
    {
        public string MaHoaDon { get; set; }
        public string TenKhachHang { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal ThanhTien { get; set; }
    }

}
