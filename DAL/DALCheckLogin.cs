using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class DALCheckLogin : DBConnect
    {
        public void mo()
        {
            _conn.Open();
        }

        public void tat()
        {
            _conn.Close();
        }
        public DataSet login(DTOCheckLogin login)
        {
            
            
                // Ket noi
                //_conn.Open();

                // Query string kiểm tra giá trị truyền từ GUI truyền xuống xem có giống ở db ko
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "select * from authen where authen.maTT = '" + login.maTT + "' and authen.matKhau = '" + login.matKhau + "' "; // câu lệnh truy vấn
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
                
            

        }
    }
}
