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
    public class DALThemMoiSach : DBConnect
    {
        public bool themSach(DTOThemMoiSach s)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("insert into tbl_Sach (tenSach,tenTacGia,nhaXuatBan,ngayMuaSach,giaSach,soLuong,keSach) values (N'{0}', N'{1}', N'{2}',N'{3}',{4},{5},N'{6}')", s.tensach,s.tentacgia,s.nhaxuatban,s.ngaymuasach,s.giasach,s.soluong,s.kesach);

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

        public DataTable getSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_Sach", _conn);
            DataTable dtSach = new DataTable();
            da.Fill(dtSach);
            return dtSach;
        }

        public DataTable getSach(int bookId)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_Sach where maSach = N'" + bookId +"'", _conn);
            DataTable dtSach = new DataTable();
            da.Fill(dtSach);
            return dtSach;
        }
        // tin sach theo ten sach
        public DataTable timSach(string tensach)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_Sach where tenSach like N'" + tensach + "%'", _conn);
            DataTable dtSach = new DataTable();
            da.Fill(dtSach);
            return dtSach;
        }

        public bool suaSach(DTOThemMoiSach s)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("update tbl_Sach set tenSach = N'"+s.tensach+"',tenTacGia= N'" + s.tentacgia + "', nhaXuatBan= N'"+ s.nhaxuatban + "' , ngayMuaSach = N'"+ s.ngaymuasach + "', giaSach= "+ s.giasach + " ,soLuong="+ s.soluong + ",keSach=N'"+s.kesach+"' where maSach = " + s.maSach);
               
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

        public bool xoaSach(int maSach)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                //string SQL = string.Format("delete from tbl_sinhVien where Mssv = N'" + mssv + "'");
                string SQL = string.Format("delete from tbl_Sach where maSach = "+ maSach);

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
