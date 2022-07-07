using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace library_management_OOP_10
{
    public partial class fThemMoiThuThu : Form
    {
        BUSThuThu bustt = new BUSThuThu();
        public fThemMoiThuThu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaThuThu.Text != "" && txtTenThuThu.Text != "" && txtSDT.Text != "" && txtCanCuoc.Text != "")
            {
                Int64 sdt = Int64.Parse(txtSDT.Text);
                DTOThuThu tt = new DTOThuThu(txtMaThuThu.Text,txtTenThuThu.Text,(int)sdt,txtCanCuoc.Text,txtDiaChi.Text);
                if (bustt.themThuThu(tt))
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtMaThuThu.Clear();
            txtCanCuoc.Clear();
            txtSDT.Clear();
            txtTenThuThu.Clear();
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
