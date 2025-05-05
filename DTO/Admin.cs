using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Admin
    {
        public int MaAdmin { get; set; }
        public string MatKhau { get; set; }

        public Admin() { }

        public Admin(int maAdmin, string matKhau)
        {
            MaAdmin = maAdmin;
            MatKhau = matKhau;
        }
    }
}
