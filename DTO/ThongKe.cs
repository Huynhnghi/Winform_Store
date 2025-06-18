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
        public List<SanPhamTonKho> DataSP { get; set; }
    }

    public class HoaDonViewModel
    {
        public string MaHoaDon { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
