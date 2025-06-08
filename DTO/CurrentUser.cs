using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CurrentUser
    {
        private static CurrentUser _instance;

        public static NhanVien User { get; set; }

        private CurrentUser() { }

        public static CurrentUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CurrentUser();
                return _instance;
            }
        }
    }
}
