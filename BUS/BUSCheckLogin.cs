using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class BUSCheckLogin
    {
        DALCheckLogin checkLogin = new DALCheckLogin();
        public bool login(DTOCheckLogin login)
        {
            return checkLogin.login(login);
        }

    }
}
