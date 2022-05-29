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
            cmd1 = new SqlCommand("select * from tbl_thuThu where maTT = '"+GlobalVar.globalMaTT+"' ", conn1);
            SqlDataReader sdr1 = cmd1.ExecuteReader();



            while (sdr1.Read())
            {
                txtThuThu.Text = sdr1["hoTenNV"].ToString();
                // lấy ra tên thủ thư dựa vào mã thủ thư đã lưu ở globalVar
                //int a = 5;
            }
            sdr1.Close();
            conn1.Close();
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        string mssv;
        string tenSach;
        private void btnTimSinhVien_Click(object sender, EventArgs e)
        {
            if(txtMSSV.Text != "")
            {
                mssv = txtMSSV.Text;
            SqlConnection conn1 = new SqlConnection();
            conn1.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ;database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn1;

            cmd1.CommandText = "select * from tbl_sinhVien where Mssv = '" + mssv + "'";
             SqlDataAdapter DA = new SqlDataAdapter(cmd1);
             DataSet DS = new DataSet();
             DA.Fill(DS);

            if(DS.Tables[0].Rows.Count !=0)
                {
                    txtSDTMuonSach.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtKhoaMuonSach.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtLopMuonSach.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtMSSVMuonSach.Text = DS.Tables[0].Rows[0][0].ToString(); // đang bị lỗi nếu nhấn vào trường có data kiểu như : 10/02/2022
                    txtTenDocGia.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtGTMuonSach.Text = DS.Tables[0].Rows[0][2].ToString();
                }
            else
                {
                    txtSDTMuonSach.Clear();
                    txtKhoaMuonSach.Clear();
                    txtLopMuonSach.Clear();
                    txtMSSVMuonSach.Clear();
                    txtTenDocGia.Clear();
                    txtGTMuonSach.Clear();
                    MessageBox.Show("Mã Số Sinh Viên Không Tồn Tại", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void cmbTenSachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNgayHenTraSach.Text = DateTime.Now.AddDays(+30).ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSDTMuonSach.Clear();
            txtKhoaMuonSach.Clear();
            txtLopMuonSach.Clear();
            txtMSSVMuonSach.Clear();
            txtTenDocGia.Clear();
            txtGTMuonSach.Clear();
            txtMSSV.Clear();
        }
        Int64 maSach;
        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            tenSach = cmbTenSachMuon.Text;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand("select * from tbl_Sach where  tenSach = N'" + tenSach + "' ", conn);
            SqlDataReader sdr1 = cmd.ExecuteReader();

            

            while (sdr1.Read())
            {
                maSach = (int)sdr1["maSach"];
                // lấy ra tên thủ thư dựa vào mã thủ thư đã lưu ở globalVar
                //int a = 5;
            }
            sdr1.Close();
            conn.Close();

            if (txtMSSVMuonSach.Text != "" && dateTimePicker1.Text != "" && txtNgayHenTraSach.Text != "" && cmbTenSachMuon.Text != "" && txtThuThu.Text != "" )

            {
                string A = GlobalVar.globalMaTT;
                string Mssv = txtMSSVMuonSach.Text;
                string ngayMuon = dateTimePicker1.Text;
                string ngayHenTra = txtNgayHenTraSach.Text;
                Int64 maSach1 = maSach;
                string  maThuThu = A;


                //tenSach = cmbTenSachMuon.Text;
                SqlConnection conn1 = new SqlConnection();
                conn1.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ; database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
                SqlCommand cmd1= new SqlCommand();
                cmd1.Connection = conn1;
                conn1.Open();
                cmd1.CommandText = "insert into tbl_Muon (Mssv,ngayMuon,ngayHenTra,maSach,maTT) values " +
                    "('" + Mssv + "','" + ngayMuon + "','" + ngayHenTra + "', " + maSach1 + ",'" + maThuThu + "')";
                cmd1.ExecuteNonQuery();
                conn1.Close();

                MessageBox.Show("Mượn mới thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgayHenTraSach.Clear();
            }

            else
            {
                MessageBox.Show("có ô đang trống, hãy nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (txtNgayHenTraSach.Text == "")
            {
                this.Close();
                return;
            }
            else if (MessageBox.Show("Hành động này sẽ xoá và không lưu dữ liệu", "Bạn chắc chắn chứ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtThuThu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
