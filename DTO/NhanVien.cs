using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int MaNhanVien { get; set; }
        public string TenNV { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string NgayVaoLam { get; set; }
        public int MaChucVu { get; set; }
        public NhanVien() { }

        public NhanVien(int maNV, string tenNV, string matKhau, string email, string diaChi, string ngayVaoLam, int maChucVu)
        {
            MaNhanVien = maNV;
            TenNV = tenNV;
            MatKhau = matKhau;
            Email = email;
            DiaChi = diaChi;
            NgayVaoLam = ngayVaoLam;
            MaChucVu = maChucVu;

        }
    }
}
