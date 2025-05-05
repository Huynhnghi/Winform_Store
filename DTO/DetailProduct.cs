using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetailProduct
    {
        private int maChiTiet;
        private int maSanPham;
        private int maLoaiSP;
        private string maSKU;
        private string moTa;
        private string mauSac;
        private string kichCo;
        private string chatLieu;
        private string dacTinh;
        private string form;
        private double gia;
        private int soLuong;
        private string hinhAnh;

        public int MaChiTiet { get => maChiTiet; set => maChiTiet = value; }
        public int MaSanPham { get => maSanPham; set => maSanPham = value; }
        public int MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
        public string MaSKU { get => maSKU; set => maSKU = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string MauSac { get => mauSac; set => mauSac = value; }
        public string KichCo { get => kichCo; set => kichCo = value; }
        public string ChatLieu { get => chatLieu; set => chatLieu = value; }
        public string DacTinh { get => dacTinh; set => dacTinh = value; }
        public string Form { get => form; set => form = value; }
        public double Gia { get => gia; set => gia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }

        public DetailProduct() { }

        public DetailProduct(int maChiTiet, int maSanPham, int maLoaiSP, string maSKU, string moTa,
                              string mauSac, string kichCo, string chatLieu, string dacTinh,
                              string form, double gia, int soLuong, string hinhAnh)
        {
            this.maChiTiet = maChiTiet;
            this.maSanPham = maSanPham;
            this.maLoaiSP = maLoaiSP;
            this.maSKU = maSKU;
            this.moTa = moTa;
            this.mauSac = mauSac;
            this.kichCo = kichCo;
            this.chatLieu = chatLieu;
            this.dacTinh = dacTinh;
            this.form = form;
            this.gia = gia;
            this.soLuong = soLuong;
            this.hinhAnh = hinhAnh;
        }
    }
}
