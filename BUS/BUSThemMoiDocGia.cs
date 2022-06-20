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
    public class BUSThemMoiDocGia
    {

        DALThemDocGia dalDocGia = new DALThemDocGia();

        public DataTable getDocGia()
        {
            return dalDocGia.getDocGia();
        }
        //lay theo mssv
        public DataTable getDocGia(string mssv)
        {
            return dalDocGia.getDocGia(mssv);
        }

        public bool themDocGia(DTOThemDocGia tv)
        {
            return dalDocGia.themDocGia(tv);
        }

        public bool suaDocGia(DTOThemDocGia tv)
        {
            return dalDocGia.suaDocGia(tv);
        }

        public bool xoaDocGia(string mssv)
        {
            return dalDocGia.xoaDocGia(mssv);
        }
        public DataTable timDocGia(string mssv)
        {
            return dalDocGia.timDocGia(mssv);
        }



    }
}
