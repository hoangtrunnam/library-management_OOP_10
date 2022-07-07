using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace library_management_OOP_10
{
    public partial class fHienThuThu : Form
    {
        BUSThuThu bustt = new BUSThuThu();
        public fHienThuThu()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtTimTenTT.Clear();
            subFormDSThuThu.Visible = true;
        }

        private void txtTimTenTT_TextChanged(object sender, EventArgs e)
        {
            if (txtTimTenTT.Text != "")
            {
                labelThuThu.Visible = false;
                string fullPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "assets\\search1.gif");
                Image image = Image.FromFile(fullPath);
                pictureSearch.Image = image;
            }
            else
            {
                labelThuThu.Visible = true;
                string fullPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "assets\\search.gif");
                Image image = Image.FromFile(fullPath);
                pictureSearch.Image = image;
            }


            if (txtTimTenTT.Text != "")
            {
                subFormDSThuThu.DataSource = bustt.timThuThu(txtTimTenTT.Text);
            }
            else
            {

                subFormDSThuThu.DataSource = bustt.getThuThu();

            }
        }

        private void fHienThuThu_Load(object sender, EventArgs e)
        {
            subFormDSThuThu.DataSource = bustt.getThuThu();
        }

        private void subFormDSThuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string maTT;
        string rowMaTT;
        private void subFormDSThuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (subFormDSThuThu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                maTT = subFormDSThuThu.Rows[e.RowIndex].Cells[0].Value.ToString();
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            bustt.getThuThu(maTT);

            rowMaTT = bustt.getThuThu(maTT).Rows[0][0].ToString();


            txtDiaChi.Text = bustt.getThuThu(maTT).Rows[0][4].ToString();
            txtCanCuoc.Text = bustt.getThuThu(maTT).Rows[0][3].ToString();
            txtMaThuThu.Text = bustt.getThuThu(maTT).Rows[0][0].ToString();
            txtTenThuThu.Text = bustt.getThuThu(maTT).Rows[0][1].ToString();
            txtSDT.Text = bustt.getThuThu(maTT).Rows[0][2].ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("dữ liệu sẽ bị thay đổi", "cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                Int64 SDT = Int64.Parse(txtSDT.Text);






                DTOThuThu tt = new DTOThuThu(txtMaThuThu.Text, txtTenThuThu.Text, (int)SDT, txtCanCuoc.Text, txtDiaChi.Text);

                // Sửa
                if (bustt.suaThuThu(tt))
                {
                    MessageBox.Show("Sửa thành công");
                    //dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }



                if (txtTimTenTT.Text != "")
                {
                    subFormDSThuThu.DataSource = bustt.timThuThu(txtTimTenTT.Text);
                }
                else
                {

                    subFormDSThuThu.DataSource = bustt.getThuThu();

                }


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string matt = txtMaThuThu.Text;
            if (MessageBox.Show("dữ liệu sẽ bị xoá", "thành công", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bustt.xoaThuThu(matt);
                MessageBox.Show("Xóa thành công");
                subFormDSThuThu.DataSource = bustt.getThuThu();
                txtTimTenTT.Clear();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (txtMaThuThu.Text != "" && txtTenThuThu.Text != "" && txtSDT.Text != "" && txtCanCuoc.Text != "")
            {
                this.Close();
                return;
            }
            else if (MessageBox.Show("Hành động này sẽ xoá và không lưu dữ liệu", "Bạn chắc chắn chứ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
