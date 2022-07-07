using System;
using System.Collections.Generic;
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
    }
}
