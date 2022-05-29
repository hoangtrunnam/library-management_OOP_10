using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library_management_OOP_10
{
    public partial class fMuonSach : Form
    {
        public fMuonSach()
        {
            InitializeComponent();
        }

        private void fMuonSach_Load(object sender, EventArgs e)
        {
            // lấy ra commoBox sách từ tbl sách
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ;database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand("select tenSach from tbl_Sach",conn);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                    string item = sdr.GetString(i);
                    cmbTenSachMuon.Items.Add(item);
                }
            }
            sdr.Close();
            conn.Close();
            

            // lấy ra tên thủ thư khi mở form lên
            SqlConnection conn1 = new SqlConnection();
            conn1.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ;database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn1;
            conn1.Open();
            cmd1 = new SqlCommand("select hoTenNV from tbl_thuThu where maTT = '"+GlobalVar.globalMaTT+"' ", conn1);
            SqlDataReader sdr1 = cmd1.ExecuteReader();



            while (sdr1.Read())
            {
                /*txtThuThu.Text = sdr1.GetValue();*/
                // lấy ra tên thủ thư dựa vào mã thủ thư đã lưu ở globalVar
                int a = 5;
            }
            sdr1.Close();
            conn1.Close();
        }
    }
}
