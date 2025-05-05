using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class LoginDAL
    {
        string connectionString = "server=localhost;user=root;database=store;password= mysql;";


        public string HashPass(string text)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] temp = Encoding.ASCII.GetBytes(text);
                byte[] hashData = md5.ComputeHash(temp);
                StringBuilder sb = new StringBuilder();
                foreach (var b in hashData)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public List<NhanVien> GetAllUsers()
        {
            List<NhanVien> users = new List<NhanVien>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NhanVien";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NhanVien user = new NhanVien
                            {
                                MaNhanVien = reader.GetInt32("MaNhanVien"),
                                TenNV = reader.GetString("TenNV"),
                                MatKhau = reader.GetString("MatKhau")
                            };
                            users.Add(user);
                        }
                    }
                }
            }

            return users;
        }

        // Optional: CheckLogin bằng câu lệnh SQL trực tiếp (nếu cần)
        public bool CheckLogin(string tenNV, string matKhau)
        {
            //string hashedPassword = HashPass(matKhau);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM NhanVien WHERE TenNV = @TenNV AND MatKhau = @MatKhau";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenNV", tenNV);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    var result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result) > 0;
                }
            }
        }
    }
}
