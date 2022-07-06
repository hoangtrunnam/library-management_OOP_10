using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BUS
{
    public class BUSMuonTraSach
    {
        DALMuonTraSach mts = new DALMuonTraSach();
        
        public SqlCommand hiemListSach()
        {
            return mts.hiemListSach();
        }

        public SqlCommand hiemMaTT(string a)
        {
            return mts.hiemMaTT(a);
}
        public void mo()
        {
             mts.mo();
        }

        public void tat()
        {
            mts.tat();
        }

        public DataSet timSinhVien(string mssv)
        {
           return mts.timsinhvien(mssv);
        }

        public SqlCommand maSachMuon(string a)
        {
            return mts.maSachMuon(a);
        }

        public bool themSachMuon(DTOMuonTraSach MT)
        {
            return mts.themSachMuon(MT);
        }

        public SqlCommand SlSachMuon(int ms)
        {
            return mts.SlSachMuon(ms);
        }


        public DataSet SlSach(int ms)
        {
            return mts.SlSach(ms);
        }

        public DataSet getDSSachMuonSV(string mssv)
        {
            return mts.getDSSachMuonSV(mssv);
        }

        public DataSet getDSSachMuon()
        {
            return mts.getDSSachMuon();
        }

        public DataSet getDSSachMuoMM(int maMuon)
        {
            return mts.getDSSachMuoMM(maMuon);
        }
        public SqlCommand temSachMuon(int a)
        {
            return mts.temSachMuon(a);
        }

        public bool traSach(DTOMuonTraSach tv)
        {
            return mts.traSach(tv);
        }

        public bool updateStatusmoney(DTOMuonTraSach tv)
        {
            return mts.updateStatusmoney(tv);
        }

    }
}
