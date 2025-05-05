using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        private int maSanPham;
        private string tenSanPham;
        private double giaNhap;
        private double giaBan;
        private int soLuong;
        private int maLoai;
        private int maNCC;

        public int MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public double GiaNhap { get => giaNhap; set => giaNhap = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int MaLoai { get => maLoai; set => maLoai = value; }
        public int MaNCC { get => maNCC; set => maNCC = value; }
    }
}
