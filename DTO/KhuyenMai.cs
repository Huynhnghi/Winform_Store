using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMai
    {
        public string MaKM { get; set; }
        public string TenKM { get; set; }
        public string MoTa { get; set; }
        public string MaLoaiKM { get; set; }
        public int? PhanTramGiam { get; set; }
        public decimal? GiamTien { get; set; }
        public decimal? DieuKien { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int TrangThai { get; set; }
        public int SoLuongApDung { get; set; }
        public int SoLuongDaApDung { get; set; }
    }
}
