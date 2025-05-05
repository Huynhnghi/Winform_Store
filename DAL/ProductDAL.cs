using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DTO; 

namespace DAL
{
    public class ProductDAL
    {
        private string connectionString = "server=localhost;user=root;database=store;password= mysql;";

        //public List<Product> GetAllProducts()
        //{
        //    List<Product> products = new List<Product>();

        //    using (MySqlConnection conn = new MySqlConnection(connectionString))
        //    {
        //        conn.Open();
        //        string query = "SELECT * FROM SanPham"; 
        //        using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //        {
        //            using (MySqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    //Product product = new Product(
        //                    //    Convert.ToInt32(reader["MaSanPham"]),
        //                    //    reader["TenSanPham"].ToString(),
        //                    //    Convert.ToDouble(reader["GiaNhap"]),
        //                    //    Convert.ToDouble(reader["GiaBan"]),
        //                    //    Convert.ToInt32(reader["SoLuong"]),
        //                    //    Convert.ToInt32(reader["MaLoai"]),
        //                    //    Convert.ToInt32(reader["MaNCC"])
        //                    );
        //                    products.Add(product);
        //                }
        //            }
        //        }
        //    }

        //    return products;
        //}
    }
}
