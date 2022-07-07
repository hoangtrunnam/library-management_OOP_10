using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALThongKe : DBConnect
    {
        public DataSet DaMuon(string tungay, string denngay)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;

            cmd.CommandText = "select*from tbl_MuonTra where ngaytra is not null and (convert(date , ngaytra,103) between (select CONVERT(date,  '"+tungay+"') ) and (select CONVERT(date,  '"+denngay+"')))";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet DangMuonTheoThang(string tungay, string denngay)

        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;

            cmd.CommandText = "select*from tbl_MuonTra where ngaytra is null  and(convert(date,ngayMuon,103) between (select CONVERT(date,  '" + tungay+"',103) ) and (select CONVERT(date,  '"+denngay+"',103)))";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet DaMuonTheoThang (string tungay, string denngay)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;

            cmd.CommandText = "select*from tbl_MuonTra where ngaytra is not null and (convert(date , ngaytra,103) between (select CONVERT(date,  '" + tungay + "',103) ) and (select CONVERT(date,  '" + denngay + "',103)))";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet DangMuon()

        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;

            cmd.CommandText = "select*from tbl_MuonTra where ngaytra is null ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet DaMuon()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;

            cmd.CommandText = "select*from tbl_MuonTra where ngaytra is not null ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet DangMuonTheoThangSV(string tungay, string denngay,string mssv)

        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;

            cmd.CommandText = "select*from tbl_MuonTra where ngaytra is null and mssv = '" + mssv + "'  and(convert(date,ngayMuon,103) between (select CONVERT(date,  '" + tungay + "',103) ) and (select CONVERT(date,  '" + denngay + "',103)))";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet DaMuonTheoThangSV(string tungay, string denngay, string mssv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;

            cmd.CommandText = "select*from tbl_MuonTra where ngaytra is not null and mssv = '"+mssv+"' and (convert(date , ngaytra,103) between (select CONVERT(date,  '" + tungay + "',103) ) and (select CONVERT(date,  '" + denngay + "',103)))";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet NoPhatTheoThangSV(string tungay, string denngay, string mssv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;

            cmd.CommandText = "select*from tbl_MuonTra where statusmoney = '1' and ngaytra is not null and mssv = '" + mssv + "' and (convert(date , ngaytra,103) between (select CONVERT(date,  '" + tungay + "',103) ) and (select CONVERT(date,  '" + denngay + "',103)))";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
