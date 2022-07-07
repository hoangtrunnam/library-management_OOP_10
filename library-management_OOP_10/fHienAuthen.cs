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
    public partial class fHienAuthen : Form
    {
        BUSAuthen busaut = new BUSAuthen();
        public fHienAuthen()
        {
            InitializeComponent();
        }

        private void txtTimMaTT_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMaTT.Text != "")
            {
                labelAuthen.Visible = false;
                string fullPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "assets\\search1.gif");
                Image image = Image.FromFile(fullPath);
                pictureSearch.Image = image;
            }
            else
            {
                labelAuthen.Visible = true;
                string fullPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "assets\\search.gif");
                Image image = Image.FromFile(fullPath);
                pictureSearch.Image = image;
            }


            if (txtTimMaTT.Text != "")
            {
                subFormDSAuthen.DataSource = busaut.timAuthen(txtTimMaTT.Text);
            }
            else
            {

                subFormDSAuthen.DataSource = busaut.getAuthen();

            }
        }

        private void fHienAuthen_Load(object sender, EventArgs e)
        {
            subFormDSAuthen.DataSource = busaut.getAuthen();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtTimMaTT.Clear();
            subFormDSAuthen.Visible = true;
        }
        string maTT;
        string rowMaTT;

        private void subFormDSAuthen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (subFormDSAuthen.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                maTT = subFormDSAuthen.Rows[e.RowIndex].Cells[0].Value.ToString();
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            busaut.getAuthen(maTT);

            rowMaTT = busaut.getAuthen(maTT).Rows[0][0].ToString();


           
            txtMaThuThu.Text = busaut.getAuthen(maTT).Rows[0][0].ToString();
            txtMatKhau.Text = busaut.getAuthen(maTT).Rows[0][1].ToString();
            txtPhanQuyen.Text = busaut.getAuthen(maTT).Rows[0][2].ToString();
        }

       
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("dữ liệu sẽ bị thay đổi", "cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                DTOAuthen aut = new DTOAuthen(txtMaThuThu.Text, txtMatKhau.Text, txtPhanQuyen.Text);

                // Sửa
                if (busaut.suaAuthen(aut))
                {
                    MessageBox.Show("Sửa thành công");
                    //dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }



                if (txtTimMaTT.Text != "")
                {
                    subFormDSAuthen.DataSource = busaut.timAuthen(txtTimMaTT.Text);
                }
                else
                {

                    subFormDSAuthen.DataSource = busaut.getAuthen();

                }


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string matt = txtMaThuThu.Text;
            if (MessageBox.Show("dữ liệu sẽ bị xoá", "thành công", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                busaut.xoaAuthen(matt);
                MessageBox.Show("Xóa thành công");
                subFormDSAuthen.DataSource = busaut.getAuthen();
                txtTimMaTT.Clear();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (txtMaThuThu.Text != "" || txtMatKhau.Text != "" || txtPhanQuyen.Text != "")
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


