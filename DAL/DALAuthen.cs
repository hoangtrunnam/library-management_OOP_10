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
    public class DALAuthen : DBConnect
    {
        public bool themAuthen(DTOAuthen aut)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO authen (matt, matkhau, phanquyen) VALUES ('{0}', '{1}', '{2}')", aut.matt,aut.matkhau,aut.phanquyen);

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

        public bool suaAuthen(DTOAuthen aut)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE authen  SET Matkhau = '{1}', phanquyen = '{2}' WHERE Matt = '{0}'",aut.matt, aut.matkhau,aut.phanquyen);

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



        public bool xoaAuthen(string mtt)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("delete from authen  where Matt = N'" + mtt + "'");

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

        public DataTable getAuthen()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from authen ", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }

        public DataTable getAuthen(string matt)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from authen  where matt = '" + matt + "'", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }

        public DataTable timAuthen(string matt)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from authen where matt LIKE N'" + matt + "%'", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;

        }

    }
}
