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
using DTO;
using BUS;
namespace library_management_OOP_10
{
    public partial class fThemMoiDocGia : Form
    {
        BUSThemMoiDocGia busDocGia = new BUSThemMoiDocGia();
        public fThemMoiDocGia()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (textMSSV.Text != "" && textTenDocGia.Text != "" && textGioiTinh.Text != "" && textLop.Text != "" && textKhoa.Text != "" && textSDT.Text != "")
            {
                Int64 SDT = Int64.Parse(textSDT.Text);
                // Tạo DTo
                DTOThemDocGia tv = new DTOThemDocGia(textMSSV.Text, textTenDocGia.Text, textGioiTinh.Text, textLop.Text, textKhoa.Text, (int)SDT); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them
                if (busDocGia.themDocGia(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    //dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
        /*
        public fThemMoiDocGia()
        {
            InitializeComponent();
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (textTenDocGia.Text == "" && textMSSV.Text == "" && textLop.Text == "" && textSDT.Text == "" && textGioiTinh.Text == "" && textKhoa.Text == "")
            {
                this.Close();
                return;
            }
            else if (MessageBox.Show("Hành động này sẽ xoá và không lưu dữ liệu", "Bạn chắc chắn chứ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
        /*
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (textTenDocGia.Text != "" && textMSSV.Text != "" && textLop.Text != "" && textKhoa.Text != "" && textSDT.Text != "" && textGioiTinh.Text != "")
            {


                string tenDocGia = textTenDocGia.Text;
                string MSSV = textMSSV.Text;
                string Lop = textLop.Text;
                string Khoa = textKhoa.Text;
                Int64 SDT = Int64.Parse(textSDT.Text);
                string gioiTinh = textGioiTinh.Text;



                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                conn.Open();
                cmd.CommandText = "insert into tbl_sinhVien (hoTenSV,Mssv,gioiTinh,lop,khoa,sdt) values " +
                    "(N'" + tenDocGia + "','" + MSSV + "','" + gioiTinh + "',N'" + Lop + "', N'" + Khoa + "'," + SDT + ")";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Lưu Độc giả mới thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textGioiTinh.Clear();
                textSDT.Clear();
                textKhoa.Clear();
                textLop.Clear();
                textMSSV.Clear();
                textTenDocGia.Clear();
            }

            else
            {
                MessageBox.Show("có ô đang trống, hãy nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        */
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            textGioiTinh.Clear();
            textSDT.Clear();
            textKhoa.Clear();
            textLop.Clear();
            textMSSV.Clear();
            textTenDocGia.Clear();
        }

        private void fThemMoiDocGia_Load(object sender, EventArgs e)
        {

        }
    }
}
