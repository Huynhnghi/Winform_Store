using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        private readonly LoginDAL loginDAL = new LoginDAL();
        public static string CurrentUsername { get; set; }

        public bool CheckLogin(string tenNV, string matKhau)
        {
            List<NhanVien> users = loginDAL.GetAllUsers();

            foreach (var user in users)
            {
                if (user.TenNV == tenNV && user.MatKhau == matKhau)
                {
                    CurrentUsername = tenNV;
                    return true;
                }
            }
            return false;
        }

        // Gọi trực tiếp đến DAL (tối ưu nếu DAL có Login theo SQL)
        public bool LoginDirect(string tenNV, string matKhau)
        {
            bool result = loginDAL.CheckLogin(tenNV, matKhau);
            if (result)
            {
                CurrentUsername = tenNV;
            }
            return result;
        }

        public void SetCurrentUser(string tenNV)
        {
            CurrentUsername = tenNV;
        }
    }

}
