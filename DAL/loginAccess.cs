using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class loginAccess:DBConnect
    {
        public string checkLogin(authen taikhoan)
        {
            string info = checkLoginDTO(taikhoan);
            return info;
        }
    }
}
