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
   public class BUSTheoMoiSach
    {
        DALThemMoiSach dalsach = new DALThemMoiSach();
        public DataTable getSach()
        {
            return dalsach.getSach();
        }

        public DataTable timSach(string tensach)
        {
            return dalsach.timSach(tensach);
        }

        public DataTable getSach(int bookId)
        {
            return dalsach.getSach(bookId);
        }

        public bool themSach(DTOThemMoiSach s)
        {
            return dalsach.themSach(s);
        }

        public bool suaSach(DTOThemMoiSach s)
        {
            return dalsach.suaSach(s);
        }

        public bool xoaSach(int maSach)
        {
            return dalsach.xoaSach(maSach);
        }
    }
}
