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
    public class BUSThuThu
    {
        DALThuThu tt = new DALThuThu();
        public bool themThuThu(DTOThuThu TT)
        {
            return tt.themThuThu(TT);
        }

        public DataTable getThuThu()
        {
            return tt.getThuThu();
        }

        public DataTable timThuThu(string tentt)
        {

            return tt.timThuThu(tentt);
        }

        public DataTable getThuThu(string matt)
        {
            return tt.getThuThu(matt);
        }

        public bool xoaThuThu(string mtt)
        {
            return tt.xoaThuThu(mtt);
        }

        public bool suaThuThu(DTOThuThu tt1)
        {
            return tt.suaThuThu(tt1);
        }
    }
}
