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
using System.Globalization;

namespace library_management_OOP_10
{
    public partial class fTraSach : Form
    {
        BUSMuonTraSach busmt = new BUSMuonTraSach();
        public fTraSach()
        {
            InitializeComponent();
        }

        private void txtMssvTraSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiemTraSach_Click(object sender, EventArgs e)
        {
            if (txtMssvTraSach.Text != null)
            {

                subFormTraSach.DataSource = busmt.getDSSachMuonSV(txtMssvTraSach.Text).Tables[0];
                txtTongTien.Text = busmt.tongTienPhat(txtMssvTraSach.Text).Tables[0].Rows[0][0].ToString();
            }
            else
            {
                txtTongTien.Text = "0";
                subFormTraSach.DataSource = busmt.getDSSachMuon().Tables[0];
            }
        }

        Int64 maMuon;
        Int64 maSach;


        private void subFormTraSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (subFormTraSach.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                maMuon = Int64.Parse(subFormTraSach.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panelTraSach.Visible = true;

            string ngayTraSach = busmt.getDSSachMuoMM((int)maMuon).Tables[0].Rows[0][6].ToString();

            string ngayHen = busmt.getDSSachMuoMM((int)maMuon).Tables[0].Rows[0][5].ToString();
            if (ngayTraSach == "")
            {
                DateTime dt = DateTime.Now;
                string ketqua = dt.ToString("dd/MM/yyyy");
                txtNgayTra.Text = ketqua;


                DateTime ngayhen = DateTime.ParseExact(ngayHen, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                TimeSpan Time = dt - ngayhen;
                int TongSoNgay = Time.Days;

                if (TongSoNgay > 0)
                {
                    int tienPhat = TongSoNgay * 1000;
                    txtNgayQuaHan.Text = TongSoNgay.ToString();
                    txtTienPhat.Text = tienPhat.ToString();
                }
                else
                {
                    txtNgayQuaHan.Text = "0";
                    txtTienPhat.Text = "0";

                }
                //DateTime dt1 = DateTime.Parse(ketqua);
                //txtNgayQuaHan.Text = dt1.ToString("dd/MM/yyyy");
            }
            else
            {
                txtNgayTra.Text = ngayTraSach;

                DateTime ngayhen = DateTime.ParseExact(ngayHen, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime ngaytra = DateTime.ParseExact(ngayTraSach, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                TimeSpan Time = ngaytra - ngayhen;
                int TongSoNgay = Time.Days;
                if (TongSoNgay > 0)
                {
                    int tienPhat = TongSoNgay * 1000;
                    txtNgayQuaHan.Text = TongSoNgay.ToString();
                    txtTienPhat.Text = tienPhat.ToString();
                }
                else
                {
                    txtNgayQuaHan.Text = "0";
                    txtTienPhat.Text = "0";

                }

            }

            txtNgayHen.Text = ngayHen;
            txtNgayMuon.Text = busmt.getDSSachMuoMM((int)maMuon).Tables[0].Rows[0][4].ToString();
            txtMaSachTra.Text = busmt.getDSSachMuoMM((int)maMuon).Tables[0].Rows[0][2].ToString();
            maSach = Int64.Parse(txtMaSachTra.Text);

            busmt.mo();
            SqlDataReader sdr = busmt.temSachMuon((int)maSach).ExecuteReader();

            while (sdr.Read())
            {
                txtTenSach.Text = sdr["tenSach"].ToString();
                // lấy ra tên thủ thư dựa vào mã thủ thư đã lưu ở globalVar
                //int a = 5;
            }
            sdr.Close();
            busmt.tat();
        }
        string maTT;
        private void btnTraSach_Click(object sender, EventArgs e)
        {



            if (txtNgayTra.Text != "" && maTT != "")

            {
                string maTT = GlobalVar.globalMaTT;
                Int64 maMuon1 = maMuon;
                string ngayTra = txtNgayTra.Text;
                string ngayQuaHan = txtNgayQuaHan.Text;
                string tienPhat = txtTienPhat.Text;




                //tenSach = cmbTenSachMuon.Text;


                DTOMuonTraSach A = new DTOMuonTraSach((int)maMuon1, ngayTra, ngayQuaHan, tienPhat);
                busmt.traSach(A);
                if (txtNgayQuaHan.Text == "0")
                {
                    DTOMuonTraSach B = new DTOMuonTraSach((int)maMuon1, "0");
                    busmt.updateStatusmoney(B);

                }
                MessageBox.Show("Trả sách thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (txtMssvTraSach.Text != null)
                {
                    subFormTraSach.DataSource = busmt.getDSSachMuonSV(txtMssvTraSach.Text).Tables[0];
                    txtTongTien.Text = busmt.tongTienPhat(txtMssvTraSach.Text).Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    subFormTraSach.DataSource = busmt.getDSSachMuon().Tables[0];
                    txtTongTien.Text = "0";
                }

                txtNgayHen.Clear();
                txtNgayMuon.Clear();
                txtMaSachTra.Clear();
                txtTenSach.Clear();
                txtTienPhat.Clear();
                txtNgayQuaHan.Clear();

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
            txtTenSach.Clear();
            txtTienPhat.Clear();
            txtNgayQuaHan.Clear();
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
            txtTienPhat.Clear();
            txtNgayQuaHan.Clear();
        }
        private void fTraSach_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayTra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDongPhat_Click(object sender, EventArgs e)
        {
            Int64 maMuon1 = maMuon;
            DTOMuonTraSach B = new DTOMuonTraSach((int)maMuon1, "0");
            if (busmt.updateStatusmoney(B))
            {
                busmt.updateStatusmoney(B);
                MessageBox.Show("Dóng phạt thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtMssvTraSach.Text != "")
                {
                    subFormTraSach.DataSource = busmt.getDSSachMuonSV(txtMssvTraSach.Text).Tables[0];
                    txtTongTien.Text = busmt.tongTienPhat(txtMssvTraSach.Text).Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    subFormTraSach.DataSource = busmt.getDSSachMuon().Tables[0];
                    txtTongTien.Text = "0";
                }
            }

            else
            {
                MessageBox.Show("Đóng Phạt không Thành Công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtMssvTraSach.Text != null)
                {
                    subFormTraSach.DataSource = busmt.getDSSachMuonSV(txtMssvTraSach.Text).Tables[0];
                    txtTongTien.Text = busmt.tongTienPhat(txtMssvTraSach.Text).Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    subFormTraSach.DataSource = busmt.getDSSachMuon().Tables[0];
                    txtTongTien.Text = "0";
                }

            }


            txtNgayHen.Clear();
            txtNgayMuon.Clear();
            txtMaSachTra.Clear();
            txtTenSach.Clear();
            txtTienPhat.Clear();
            txtNgayQuaHan.Clear();
        }

        private void btnTraTienTong_Click(object sender, EventArgs e)
        {
            if (busmt.DongPhatTaiCa(txtMssvTraSach.Text))
            {
                MessageBox.Show("Đóng Phạt Thành Công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtMssvTraSach.Text != null)
                {

                    subFormTraSach.DataSource = busmt.getDSSachMuonSV(txtMssvTraSach.Text).Tables[0];
                    txtTongTien.Text = busmt.tongTienPhat(txtMssvTraSach.Text).Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    txtTongTien.Text = "0";
                    subFormTraSach.DataSource = busmt.getDSSachMuon().Tables[0];
                }
                txtTongTien.Text = busmt.tongTienPhat(txtMssvTraSach.Text).Tables[0].Rows[0][0].ToString();
            }
            else
            {
                if (txtMssvTraSach.Text != null)
                {

                    subFormTraSach.DataSource = busmt.getDSSachMuonSV(txtMssvTraSach.Text).Tables[0];
                    txtTongTien.Text = busmt.tongTienPhat(txtMssvTraSach.Text).Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    txtTongTien.Text = "0";
                    subFormTraSach.DataSource = busmt.getDSSachMuon().Tables[0];
                }
                MessageBox.Show("Đóng Phạt không Thành Công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTongTien.Text = "0";
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void subFormTraSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelTraSach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNgayTra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTienPhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayQuaHan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayHen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSachTra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayMuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMatSach_Click(object sender, EventArgs e)
        {
            Int64 maMuon1 = maMuon;
            Int64 masach = Int64.Parse(txtMaSachTra.Text);
            DTOMuonTraSach B = new DTOMuonTraSach("0","1",txtNgayTra.Text, (int)maMuon1);
            if (busmt.matSach(B) && busmt.updateSLSach((int)masach))
            {
                busmt.matSach(B);
                busmt.updateSLSach((int)masach);
                MessageBox.Show("Báo mất thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtMssvTraSach.Text != "")
                {
                    subFormTraSach.DataSource = busmt.getDSSachMuonSV(txtMssvTraSach.Text).Tables[0];
                    txtTongTien.Text = busmt.tongTienPhat(txtMssvTraSach.Text).Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    subFormTraSach.DataSource = busmt.getDSSachMuon().Tables[0];
                    txtTongTien.Text = "0";
                }
            }

            else
            {
                MessageBox.Show("Báo mất không Thành Công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (txtMssvTraSach.Text != null)
                {
                    subFormTraSach.DataSource = busmt.getDSSachMuonSV(txtMssvTraSach.Text).Tables[0];
                    txtTongTien.Text = busmt.tongTienPhat(txtMssvTraSach.Text).Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    subFormTraSach.DataSource = busmt.getDSSachMuon().Tables[0];
                    txtTongTien.Text = "0";
                }
            }
        }
    }
}
