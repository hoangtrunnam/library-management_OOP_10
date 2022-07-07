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
    public partial class fThenAuthen : Form
    {
        BUSAuthen busaut = new BUSAuthen();
        public fThenAuthen()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaThuThu.Text != "" && txtMatKhau.Text != "" && txtPhanQuyen.Text != "")
            {
              
                DTOAuthen aut = new DTOAuthen(txtMaThuThu.Text, txtMatKhau.Text,txtPhanQuyen.Text);
                if (busaut.themAuthen(aut))
                {
                    MessageBox.Show("Thêm thành công");
                    //dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview


                    txtMaThuThu.Clear();
                    txtMatKhau.Clear();
                    txtPhanQuyen.Clear();
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaThuThu.Clear();
            txtMatKhau.Clear();
            txtPhanQuyen.Clear();
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
