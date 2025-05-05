using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class ConnectionString
    {
        public static string GetConnectionString()
        {
            // Kiểm tra connection string có tồn tại không
            var connectionString = ConfigurationManager.ConnectionStrings["Store"];
            if (connectionString == null)
            {
                throw new Exception("Connection string 'Store' not found.");
            }
            return connectionString.ConnectionString;
        }
    }
}
