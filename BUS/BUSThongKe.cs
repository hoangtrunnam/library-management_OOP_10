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
    public class BUSThongKe
    {
        DALThongKe tk = new DALThongKe();
        public DataSet DaMuonTheoThang(string tungay, string denngay)
        {
            return tk.DaMuonTheoThang(tungay,denngay);
        }

        public DataSet DangMuonTheoThang(string tungay, string denngay)
        {
            return tk.DangMuonTheoThang(tungay,denngay);
        }

        public DataSet DaMuon()
        {
            return tk.DaMuon();
        }

        public DataSet DangMuon()
        {
            return tk.DangMuon();
        }

        public DataSet DaMuonTheoThangSV(string tungay, string denngay, string mssv)
        {
            return tk.DaMuonTheoThangSV(tungay, denngay, mssv);
        }

        public DataSet DangMuonTheoThangSV(string tungay, string denngay, string mssv)
        {
            return tk.DangMuonTheoThangSV(tungay, denngay, mssv);
        }
    }
}
