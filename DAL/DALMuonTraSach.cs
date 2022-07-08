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
    public class DALMuonTraSach :DBConnect
    {
        public SqlCommand hiemListSach()
        {

            SqlCommand 
            cmd = new SqlCommand("select tenSach from tbl_Sach", _conn);
            return cmd;
           
        }

        public SqlCommand hiemMaTT(string a)
        {

            SqlCommand cmd = new SqlCommand("select * from tbl_thuThu where maTT = '" + a + "' ", _conn);
            return cmd;

        }

        public void mo()
        {
            _conn.Open();
        }

        public void tat()
        {
            _conn.Close();
        }

        public DataSet timsinhvien(string mssv)
        {
           
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = _conn;

            cmd1.CommandText = "select * from tbl_sinhVien where Mssv = '" + mssv + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd1);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            return DS;
        }


        public SqlCommand maSachMuon(string a)
        {


            SqlCommand 
            cmd = new SqlCommand("select * from tbl_Sach where  tenSach = N'" + a + "' ", _conn);
            return cmd;

        }

        public bool themSachMuon(DTOMuonTraSach MT)
        {
            try
            {
                // Ket noi
                _conn.Open();
                
               
                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("insert into tbl_MuonTra (Mssv,ngayMuon,ngayHenTra,maSach,maTT,statusMoney ) values('" + MT.mssv+"','"+ MT.ngaymuon+"','" + MT.ngayhentra + "'," + MT.masach + ",'" + MT.matt + "','" + MT.statusmoney + "')");

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
        // so sach theo ma sach da muon
        public SqlCommand SlSachMuon(int ms)
        {
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = _conn;

            cmd1.CommandText = "select count(tbl_MuonTra.maSach ) as SlSachMuon  from tbl_MuonTra where maSach = " + ms + "and ngayTra IS NULL";
            
            return cmd1;
        }

       
        // so sach theo ma sach
        public DataSet SlSach(int ms)
        
            {

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = _conn;

            cmd1.CommandText = "select*from tbl_Sach  where maSach = " + ms;
            SqlDataAdapter DA = new SqlDataAdapter(cmd1);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            return DS;
        }

        // hien so sach chua tra cua sinh vien
        public DataSet getDSSachMuonSV(string mssv)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;

            cmd.CommandText = "select * from tbl_MuonTra  where Mssv ='" + mssv + "' and statusmoney = '1'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
       

        public DataSet getDSSachMuon()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;

            cmd.CommandText = "select * from tbl_Muon";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        //DS SACH THEO MA MUON

        public DataSet getDSSachMuoMM(int maMuon)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;

            cmd.CommandText = "select * from tbl_MuonTra where tbl_MuonTra.maMuon  = " + maMuon + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

           

        }
        //tem sach

        public SqlCommand temSachMuon(int  a)
        {


            SqlCommand
            cmd = new SqlCommand("select tenSach from tbl_Sach where  maSach = " + a , _conn);
            return cmd;

        }

        //Tra Sach;


        public bool traSach(DTOMuonTraSach tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE tbl_MuonTra SET ngayTra = '" +tv.ngaytra+"', soNgayQuaHan = '"+tv.songayquahan+"', tienPhat = '"+tv.tienphat+ "' WHERE maMuon  = " + tv.maMuon);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }


        public bool updateStatusmoney(DTOMuonTraSach tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE tbl_MuonTra SET statusmoney = '" + tv.statusmoney+ "' WHERE maMuon  = " + tv.maMuon + "and ngaytra is not null");

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        public DataSet tongTienPhat(string mssv)
        {

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = _conn;

            cmd1.CommandText = "select sum(cast(tienphat as int)) from tbl_MuonTra where Mssv = '" + mssv + "'AND statusmoney = '1' and ngaytra is not null";
            SqlDataAdapter DA = new SqlDataAdapter(cmd1);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            return DS;
        }


        //btn Dong Phatj Tai Ca cua mot Sinh Vien
        public bool DongPhatTaiCa(string mssv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE tbl_MuonTra SET statusmoney = '0' WHERE mssv  = '" + mssv + "' and ngaytra is not null and statusmoney = '1'");

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }


        //Mat Sach

        public bool matSach(DTOMuonTraSach tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE tbl_MuonTra SET statusBook = '" + tv.statusBook + "',ngaytra = '" + tv.ngaytra + "' WHERE maMuon  = " + tv.maMuon);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        public bool updateSLSach(int masach)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE tbl_Sach  SET soLuong  = (soluong - 1) WHERE maSach  = " + masach);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

    }


}
