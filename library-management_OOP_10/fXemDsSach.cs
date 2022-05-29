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
    public partial class fXemDsSach : Form
    {
        public fXemDsSach()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panelThongTinSach.Visible = false;
        }

        private void fXemDsSach_Load(object sender, EventArgs e)
        {
            panelThongTinSach.Visible = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '"+ GlobalVar.globalDataBase +"'  ; integrated security=True"; //lib_Management là tên database
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from tbl_Sach";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        int bookId; // lấy ra id của sách để sửa
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bookId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panelThongTinSach.Visible = true;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from tbl_Sach where tbl_Sach.maSach = " + bookId+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowId = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtTenSach.Text= ds.Tables[0].Rows[0][1].ToString();
            txtTenTacGia.Text = ds.Tables[0].Rows[0][2].ToString();
            txtNhaXuatBan.Text = ds.Tables[0].Rows[0][3].ToString();
            txtNgayMuaSach.Text = ds.Tables[0].Rows[0][4].ToString(); // đang bị lỗi nếu nhấn vào trường có data kiểu như : 10/02/2022
            txtGiaSach.Text = ds.Tables[0].Rows[0][5].ToString();
            txtSoLuong.Text = ds.Tables[0].Rows[0][6].ToString();
            txtKeSach.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            if (txtTimSach.Text != "")
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = $@"select * from tbl_Sach where tenSach LIKE '{txtTimSach.Text}%' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from tbl_Sach";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtTimSach.Clear();
            panelThongTinSach.Visible = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("dữ liệu sẽ bị thay đổi","cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {

                string tenSach = txtTenSach.Text;
                string tenTacGia = txtTenTacGia.Text;
                string nhaXuatBan = txtNhaXuatBan.Text;
                string ngayMuaSach = txtNgayMuaSach.Text;
                Int64 giaSach = Int64.Parse(txtGiaSach.Text);
                Int64 soLuong = Int64.Parse(txtSoLuong.Text);
                Int64 keSach = Int64.Parse(txtKeSach.Text);



                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "update tbl_Sach set tenSach = '" + tenSach + "',tenTacGia= '" + tenTacGia + "', nhaXuatBan= '" + nhaXuatBan+"' , ngayMuaSach = '" + ngayMuaSach + "', giaSach= " + giaSach + " ,soLuong=" + soLuong + " ,keSach=" + keSach + " where maSach = "+rowId+" ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("dữ liệu sẽ bị xoá", "thành công", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ;database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "delete from tbl_Sach where maSach="+rowId+" ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
