using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUSAuthen
    {
        DALAuthen authen = new DALAuthen();
        public bool themAuthen(DTOAuthen aut)
        {
            return authen.themAuthen(aut);
        }
         public bool suaAuthen(DTOAuthen aut)
        {
            return authen.suaAuthen(aut);
        }
         public bool xoaAuthen(string mtt)
        {
            return authen.xoaAuthen(mtt);
        }
         public DataTable getAuthen()
        {
            return authen.getAuthen();
        }
         public DataTable getAuthen(string matt)
        {
            return authen.getAuthen(matt);
        }

         public DataTable timAuthen(string matt)
        {
            return authen.timAuthen(matt);
        }
    }
}
