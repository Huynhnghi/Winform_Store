using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DTO
{
    public class Product
    {
        public string MaSanPham { get; set; } // Mã sản phẩm (MASP)

        [JsonProperty("TenSP")] // ánh xạ chính xác từ field JSON
        public string TenSanPham { get; set; }

        public string MoTa { get; set; } // Mô tả (MOTA)

        public string HinhAnh { get; set; } // Hình ảnh (HINHANH)

        public string HinhAnhURL { get; set; }
        public string MaLoai { get; set; } // Mã loại sản phẩm (MALOAI)

        public string MaNCC { get; set; } // Mã nhà cung cấp (MANCC)

        public int TrangThai { get; set; } = 1; // 1 hoạt động, 0 ngừng
        public Product()
        {
        }

        public Product(string maSanPham, string tenSanPham, string moTa, string hinhAnh, string maLoai, string maNCC, int trangThai)
        {
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.MoTa = moTa;
            this.HinhAnh = hinhAnh;
            this.MaLoai = maLoai;
            this.MaNCC = maNCC;
            this.TrangThai = trangThai;
        }
    }

}
