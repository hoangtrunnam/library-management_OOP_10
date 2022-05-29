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
    public partial class fTraSach : Form
    {
        public fTraSach()
        {
            InitializeComponent();
        }

        private void txtMssvTraSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiemTraSach_Click(object sender, EventArgs e)
        {
            if (txtMssvTraSach.Text != "")
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from tbl_Muon where Mssv ='" + txtMssvTraSach.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                subFormTraSach.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from tbl_Muon";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                subFormTraSach.DataSource = ds.Tables[0];
            }
        }

        Int64 maMuon;
        Int64 maSach;
        private void subFormTraSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (subFormTraSach.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                maMuon = Int64.Parse(subFormTraSach.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panelTraSach.Visible = true;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from tbl_Muon where tbl_Muon.maMuon  = " + maMuon + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            txtNgayHen.Text = ds.Tables[0].Rows[0][5].ToString();
            txtNgayMuon.Text = ds.Tables[0].Rows[0][4].ToString();
            txtMaSachTra.Text = ds.Tables[0].Rows[0][2].ToString();
            maSach = Int64.Parse(txtMaSachTra.Text);

            conn.Open();
            cmd = new SqlCommand("select tenSach from tbl_Sach where  maSach = " + maSach , conn);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                txtTenSach.Text = sdr["tenSach"].ToString();
                // lấy ra tên thủ thư dựa vào mã thủ thư đã lưu ở globalVar
                //int a = 5;
            }
            sdr.Close();
            conn.Close();
        }
        string maTT;
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection();
            conn1.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ;database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn1;
           

            if (txtNgayTra.Text != "" && maTT != "" )

            {
                string maTT = GlobalVar.globalMaTT;
                Int64 maMuon1 = maMuon;
                string ngayTra = txtNgayTra.Text;
              
               


                //tenSach = cmbTenSachMuon.Text;
               
                conn1.Open();
                cmd1.CommandText = "insert into tbl_Tra (maMuon,ngayTra,maTT) values " +
                    "(" + maMuon1 + ",'" + ngayTra + "','" + maTT + "')";
                cmd1.ExecuteNonQuery();
                conn1.Close();

                MessageBox.Show("Trả sách thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn1.Open();
                cmd1.CommandText = "DELETE  FROM tbl_Muon WHERE maMuon = "+maMuon1 ;
                cmd1.ExecuteNonQuery();
                conn1.Close();

                if (txtMssvTraSach.Text != "")
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "select * from tbl_Muon where Mssv ='" + txtMssvTraSach.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    subFormTraSach.DataSource = ds.Tables[0];
                }
                else
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "select * from tbl_Muon";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    subFormTraSach.DataSource = ds.Tables[0];
                }

                txtNgayHen.Clear();
                txtNgayMuon.Clear();
                txtMaSachTra.Clear();
                txtTenSach.Clear();

            }

            else
            {
                MessageBox.Show("có ô đang trống, hãy nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnLamMoiTraSach_Click(object sender, EventArgs e)
        {

            txtNgayHen.Clear();
            txtNgayMuon.Clear();
            txtMaSachTra.Clear();
            txtMssvTraSach.Clear();
            txtTenSach.Clear();
        }

        private void btnLamMoiThoat_Click(object sender, EventArgs e)
        {
            if (txtNgayTra.Text == "")
            {
                this.Close();
                return;
            }
            else if (MessageBox.Show("Hành động này sẽ xoá và không lưu dữ liệu", "Bạn chắc chắn chứ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnHuyTraSach_Click(object sender, EventArgs e)
        {
            txtNgayHen.Clear();
            txtNgayMuon.Clear();
            txtMaSachTra.Clear();
            txtTenSach.Clear();
        }
    }
}
