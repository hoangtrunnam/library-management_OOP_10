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
    static class GlobalVar
    {
        // định nghĩa các tên các bảng và tên domain,database ở đây.
        // muốn dùng được thì phải đổi đường dẫn _globalDomain
        // tên database bắt buộc phải là lib_Management
        // các phương thức chỉ được phép get, cấm sử dụng set

        private static string _globalDomain = "DESKTOP-62VA20P\\HOANGNAM";
        private static string _globalDataBase = "lib_Management2";
        private static string _maTT = "";



        public static string GlobalDomain
        {
            get { return _globalDomain; }
        }

        public static string globalDataBase
        {
            get { return _globalDataBase; }
        }

        public static string globalMaTT
        {
            get { return _maTT; }
            set { _maTT = value; }
        }

    }

    public class sqlConnectionData
    {
        public static SqlConnection connect()
        {
            string strConn = "data source = '" + GlobalVar.GlobalDomain + "' ;database= '" + GlobalVar.globalDataBase + "'; integrated security=True";
            SqlConnection conn = new SqlConnection(strConn);
            return conn;
        }
    }
    public class DBConnect
    {
        public static string checkLoginDTO(authen taiKhoan)
        {
            string maTT = null;
            SqlConnection conn = sqlConnectionData.connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("procLogin",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maTT",taiKhoan.maTT);
            cmd.Parameters.AddWithValue("@matKhau", taiKhoan.matKhau);

            cmd.Connection=conn;
            SqlDataReader reader = cmd.ExecuteReader(); 
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    maTT = reader.GetString(0);
                    return maTT;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "invalid";
            }




            return maTT;
        }
    }
}
