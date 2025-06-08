using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSuDiem
    {
        public int MaLSD { get; set; }

        [JsonPropertyName("KHACHHANG")]
        public string KhachHang { get; set; }

        public DateTime Ngay { get; set; }

        public int DiemTichLuy { get; set; }

        public string Loai { get; set; }

        public string GhiChu { get; set; }
    }
}
