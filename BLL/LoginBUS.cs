using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class LoginBUS
    {
        loginAccess login = new loginAccess();
        public string checkLogin(authen taikhoan)
        {
            if (taikhoan.maTT == "")
            {
                return "required_maTT";
            }
            else if(taikhoan.matKhau == "")
            {
                return "required_matKhau";
            }
            string info = login.checkLogin(taikhoan);
            return info;
        }
    }
}
