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
using BUS;
using DTO;
namespace library_management_OOP_10
{
    public partial class fHienDocGia : Form
    {
        BUSThemMoiDocGia busDocGia = new BUSThemMoiDocGia();
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
                subFormDSDocGia.DataSource = busDocGia.timDocGia(txtTimMSSV.Text);
            }
            else
            {
            //    SqlConnection conn = new SqlConnection();
            //    conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = conn;

            //    //cmd.CommandText = "select * from tbl_sinhVien";
            //    //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    //DataSet ds = new DataSet();
               
            //    //da.Fill(ds);

                subFormDSDocGia.DataSource = busDocGia.getDocGia();

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtTimMSSV.Clear();
            subFormDSDocGia.Visible = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            if (MessageBox.Show("dữ liệu sẽ bị xoá", "thành công", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                    busDocGia.xoaDocGia(mssv);
                    MessageBox.Show("Xóa thành công");
                    subFormDSDocGia.DataSource = busDocGia.getDocGia();

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



                

                DTOThemDocGia docGia = new DTOThemDocGia(MSSV, tenDocGia, gioiTinh, Lop, Khoa, (int)SDT); // Vì ID tự tăng nên để ID số gì cũng dc

                // Sửa
                if (busDocGia.suaDocGia(docGia))
                {
                    MessageBox.Show("Sửa thành công");
                    //dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }



                if (txtTimMSSV.Text != "")
                {


                    subFormDSDocGia.DataSource = busDocGia.timDocGia(txtTimMSSV.Text);
                }
                else
                {

                    subFormDSDocGia.DataSource = busDocGia.getDocGia();
                }



            }
        }

        private void fHienDocGia_Load(object sender, EventArgs e)
        {
           
            subFormDSDocGia.DataSource = busDocGia.getDocGia();

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
            busDocGia.getDocGia(mssv);

             rowMssv = busDocGia.getDocGia(mssv).Rows[0][0].ToString();

            txtSDT.Text = busDocGia.getDocGia(mssv).Rows[0][5].ToString();
            txtKhoa.Text = busDocGia.getDocGia(mssv).Rows[0][4].ToString();
            txtLop.Text = busDocGia.getDocGia(mssv).Rows[0][3].ToString();
            txtMSSV.Text = busDocGia.getDocGia(mssv).Rows[0][0].ToString();
            txtTenDocGia.Text = busDocGia.getDocGia(mssv).Rows[0][1].ToString();
            txtGioiTinh.Text = busDocGia.getDocGia(mssv).Rows[0][2].ToString();
        }
    }
}
