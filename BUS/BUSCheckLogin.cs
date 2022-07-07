using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUSCheckLogin
    {
        DALCheckLogin checkLogin = new DALCheckLogin();
        public DataSet login(DTOCheckLogin login)
        {
            return checkLogin.login(login);
        }
        public void mo()
        {
           
        }

        public void tat()
        {
            
        }

    }
}
