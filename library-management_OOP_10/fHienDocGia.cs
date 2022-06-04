using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Data.SqlClient;

namespace library_management_OOP_10
{
    public partial class fHienDocGia : Form
    {
        public fHienDocGia()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (txtTenDocGia.Text != "" && txtMSSV.Text != "" && txtLop.Text != "" && txtKhoa.Text != "" && txtSDT.Text != "" && txtGioiTinh.Text != "")
            {
                this.Close();
                return;
            }
            else if (MessageBox.Show("Hành động này sẽ xoá và không lưu dữ liệu", "Bạn chắc chắn chứ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }
        string rowMssv;
        private void txtTimMSSV_TextChanged(object sender, EventArgs e)
        {
            // trạng thái load ảnh
            if(txtTimMSSV.Text != "")
            {
                label1.Visible = false;
                string fullPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "assets\\search1.gif");
                Image image = Image.FromFile(fullPath);
                pictureSearch.Image = image;
            }
            else
            {
                label1.Visible = true;
                string fullPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "assets\\search.gif");
                Image image = Image.FromFile(fullPath);
                pictureSearch.Image = image;
            }
            // trạng thái hiện data
            if (txtTimMSSV.Text != "")
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = $@"select * from tbl_sinhVien where Mssv LIKE '{txtTimMSSV.Text}%' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                subFormDSDocGia.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from tbl_sinhVien";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                subFormDSDocGia.DataSource = ds.Tables[0];

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtTimMSSV.Clear();
            subFormDSDocGia.Visible = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("dữ liệu sẽ bị xoá", "thành công", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ;database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "delete from tbl_sinhVien where maSach=" + rowMssv+ " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
        string mssv;
        private void subFormDSDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("dữ liệu sẽ bị thay đổi", "cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                
                string tenDocGia = txtTenDocGia.Text;
                string MSSV = txtMSSV.Text;
                string Lop = txtLop.Text;
                string Khoa = txtKhoa.Text;
                Int64 SDT = Int64.Parse(txtSDT.Text);
                string gioiTinh = txtGioiTinh.Text;



                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "update tbl_sinhVien set hoTenSV = N'" + tenDocGia + "',Mssv= '" + MSSV +"',lop= N'" + Lop + "', khoa= N'" + Khoa + "' , sdt = " + SDT + ", gioiTinh= '" + gioiTinh+ "'  where Mssv = " + rowMssv + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (txtTimMSSV.Text != "")
                {
                    

                    cmd.CommandText = $@"select * from tbl_sinhVien where Mssv LIKE '{txtTimMSSV.Text}%' ";
                   
                    da.Fill(ds);

                    subFormDSDocGia.DataSource = ds.Tables[0];
                }
                else
                {
                    
                    cmd.Connection = conn;

                    cmd.CommandText = "select * from tbl_sinhVien";
                    
                    da.Fill(ds);

                    subFormDSDocGia.DataSource = ds.Tables[0];
                }



            }
        }

        private void fHienDocGia_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from tbl_sinhVien";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            subFormDSDocGia.DataSource = ds.Tables[0];

        }

        // bắt sự kiện click vào 1 hàng trong bảng data được đổ ra
        private void subFormDSDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (subFormDSDocGia.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                mssv = subFormDSDocGia.Rows[e.RowIndex].Cells[0].Value.ToString();
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from tbl_sinhVien where tbl_sinhVien.mssv = " + mssv + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowMssv = ds.Tables[0].Rows[0][0].ToString();

            txtSDT.Text = ds.Tables[0].Rows[0][5].ToString();
            txtKhoa.Text = ds.Tables[0].Rows[0][4].ToString();
            txtLop.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMSSV.Text = ds.Tables[0].Rows[0][0].ToString();
            txtTenDocGia.Text = ds.Tables[0].Rows[0][1].ToString();
            txtGioiTinh.Text = ds.Tables[0].Rows[0][2].ToString();
        }
    }
}
