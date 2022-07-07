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
    public class DALThuThu : DBConnect
    {
        public bool themThuThu(DTOThuThu TT)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO tbl_thuThu(matt, hoTennv, sdt,cccd,diachi) VALUES ('{0}', N'{1}', {2},'{3}',N'{4}')", TT.matt,TT.hotennv,TT.sdt,TT.cccd,TT.diachi);

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

        public bool suaThuThu(DTOThuThu tt)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE tbl_thuThu SET hoTennv = N'{1}', sdt = {2},cccd = '{3}',diachi = N'{4}' WHERE Matt = '{0}'", tt.matt,tt.hotennv,tt.sdt,tt.cccd,tt.diachi);

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



        public bool xoaThuThu(string mtt)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("delete from tbl_thuThu where Matt = N'" + mtt+ "'");

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

        public DataTable getThuThu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_thuThu", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }

        public DataTable getThuThu( string matt)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_thuThu where matt = '" + matt + "'", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }

        public DataTable timThuThu(string tentt)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_thuThu where hoTenNV LIKE N'" + tentt + "%'", _conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;

        }
    }
}
