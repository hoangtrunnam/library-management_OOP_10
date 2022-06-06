using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_OOP_10
{
    public partial class fCompleteBookDetails : Form
    {
        public fCompleteBookDetails()
        {
            InitializeComponent();
        }

        private void fCompleteBookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ;database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select m.maMuon,m.Mssv,sv.hoTenSV,m.maSach,s.tenSach,m.maTT,m.ngayMuon,m.ngayHenTra " +
                                "from tbl_Muon m, tbl_sinhVien sv, tbl_Sach s " +
                                "where m.Mssv = sv.Mssv and m.maSach = s.maSach";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            cmd.CommandText = "select * from tbl_Tra";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
        }
    }
}
