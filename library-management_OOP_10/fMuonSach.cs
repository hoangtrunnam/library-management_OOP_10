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
using BUS;
using DTO;

namespace library_management_OOP_10
{
    public partial class fMuonSach : Form
    {
        BUSMuonTraSach busMT = new BUSMuonTraSach();
        BUSCheckLogin busLogin = new BUSCheckLogin();
        public fMuonSach()
        {
            InitializeComponent();
        }

        private void fMuonSach_Load(object sender, EventArgs e)
        {
            // lấy ra commoBox sách từ tbl sách
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "data source = '" + GlobalVar.GlobalDomain + "' ;database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = conn;
            //conn.Open();
            //cmd = new SqlCommand("select tenSach from tbl_Sach",conn);
            busMT.mo();
            SqlDataReader sdr = busMT.hiemListSach().ExecuteReader();
            //busMT.hiemListSach();
            while (sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                   string item = sdr.GetString(i);
                    cmbTenSachMuon.Items.Add(item);
                }
            }


            sdr.Close();
            //conn.Close();
            busMT.tat();


            // lấy ra tên thủ thư khi mở form lên
            busMT.mo();
            SqlDataReader sdr1 = busMT.hiemMaTT(GlobalVar.globalMaTT).ExecuteReader();



            while (sdr1.Read())
            {
                txtThuThu.Text = sdr1["hoTenNV"].ToString();
                // lấy ra tên thủ thư dựa vào mã thủ thư đã lưu ở globalVar
                //int a = 5;
            }
            sdr1.Close();
            busMT.tat();
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
            

            if(busMT.timSinhVien(mssv).Tables[0].Rows.Count !=0)
                {
                    txtSDTMuonSach.Text = busMT.timSinhVien(mssv).Tables[0].Rows[0][5].ToString();
                    txtKhoaMuonSach.Text = busMT.timSinhVien(mssv).Tables[0].Rows[0][4].ToString();
                    txtLopMuonSach.Text = busMT.timSinhVien(mssv).Tables[0].Rows[0][3].ToString();
                    txtMSSVMuonSach.Text = busMT.timSinhVien(mssv).Tables[0].Rows[0][0].ToString(); // đang bị lỗi nếu nhấn vào trường có data kiểu như : 10/02/2022
                    txtTenDocGia.Text = busMT.timSinhVien(mssv).Tables[0].Rows[0][1].ToString();
                    txtGTMuonSach.Text = busMT.timSinhVien(mssv).Tables[0].Rows[0][2].ToString();
                    txtNgayMuon.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
            txtNgayHenTraSach.Text = DateTime.Now.AddDays(+30).ToString("dd/MM/yyyy");
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
            string tenSach = cmbTenSachMuon.Text;

            busMT.mo();
            SqlDataReader sdr1 = busMT.maSachMuon(tenSach).ExecuteReader();

            

            while (sdr1.Read())
            {
                maSach = (int)sdr1["maSach"];
                // lấy ra tên thủ thư dựa vào mã thủ thư đã lưu ở globalVar
                //int a = 5;
            }
            sdr1.Close();
            busMT.tat();

            if (txtMSSVMuonSach.Text != "" && txtNgayMuon.Text != "" && txtNgayHenTraSach.Text != "" && cmbTenSachMuon.Text != "" && txtThuThu.Text != "" )

            {
                string A = GlobalVar.globalMaTT;
                string Mssv = txtMSSVMuonSach.Text;
                string ngayMuon = txtNgayMuon.Text;
                string ngayHenTra = txtNgayHenTraSach.Text;
                Int64 maSach1 = maSach;
                string  maThuThu = A;
                string statusmoney = "1";

                int SLSachMuon = 0;
                int SLSach = 0;
                //tenSach = cmbTenSachMuon.Text;
                DTOMuonTraSach MT = new DTOMuonTraSach(Mssv, (int)maSach1, maThuThu, ngayMuon, ngayHenTra, statusmoney);
                busMT.mo();
                SqlDataReader sdr = busMT.SlSachMuon((int)maSach1).ExecuteReader();


                while (sdr.Read())
                {
                    SLSachMuon = (int)sdr["SlSachMuon"];

                }
                sdr.Close();
                busMT.tat();


                

                string a = busMT.SlSach((int)maSach1).Tables[0].Rows[0][6].ToString();
                SLSach = (int)Int64.Parse(a);

                if (SLSachMuon < SLSach)
                {
                    busMT.themSachMuon(MT);

                    MessageBox.Show("Mượn mới thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNgayHenTraSach.Clear();
                }
                else
                {
                    MessageBox.Show("Sách đã được mượn hết", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
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
