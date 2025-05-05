using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class DetailProductDAL
    {
        string connectionString = "server=localhost;user=root;database=store;password= mysql;";
        public DetailProduct GetDetailByMaSanPham(int maSanPham)
        {
            DetailProduct detail = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM ChiTietSanPham WHERE MaSanPham = @MaSanPham";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                conn.Open();
                
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    detail = new DetailProduct(
                        Convert.ToInt32(reader["MaChiTiet"]),
                        Convert.ToInt32(reader["MaSanPham"]),
                        Convert.ToInt32(reader["MaLoaiSP"]),
                        reader["MaSKU"].ToString(),
                        reader["MoTa"].ToString(),
                        reader["MauSac"].ToString(),
                        reader["KichCo"].ToString(),
                        reader["ChatLieu"].ToString(),
                        reader["DacTinh"].ToString(),
                        reader["Form"].ToString(),
                        Convert.ToDouble(reader["Gia"]),
                        Convert.ToInt32(reader["SoLuong"]),
                        reader["HinhAnh"].ToString()
                    );
                }

                reader.Close();
            }
            return detail;
        }
    }
}
