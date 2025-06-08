using System;

namespace DTO
{
    public class DetailProduct
    {
        public string MaBienThe { get; set; }
        public string MaSanPham { get; set; }
        public string Size { get; set; }
        public string MauSac { get; set; }
        public string HinhAnh { get; set; }
        public string Barcode { get; set; }
        public decimal GiaVon { get; set; }
        public decimal GiaBan { get; set; }
        public int TonKho { get; set; }
        public float TrongLuong { get; set; }
        public int TrangThai { get; set; } = 1;
        public string HinhAnhUrl { get; set; }

        public DetailProduct() { }

        public DetailProduct(
            string maBienThe,
            string maSanPham,
            string size,
            string mauSac,
            string hinhanh,
            string barcode,
            decimal giaVon,
            decimal giaBan,
            int tonKho,
            float trongLuong,
            int trangThai,
            string hinhAnhUrl)
        {
            MaBienThe = maBienThe;
            MaSanPham = maSanPham;
            Size = size;
            MauSac = mauSac;
            HinhAnh = hinhanh;
            Barcode = barcode;
            GiaVon = giaVon;
            GiaBan = giaBan;
            TonKho = tonKho;
            TrongLuong = trongLuong;
            TrangThai = trangThai;
            HinhAnhUrl = hinhAnhUrl;
        }
    }
}
