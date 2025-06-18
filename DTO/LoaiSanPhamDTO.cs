using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPhamDTO
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string XuatSu { get; set; }
        public string ParentId { get; set; }
        public List<LoaiSanPhamDTO> Children { get; set; }
    }
}
