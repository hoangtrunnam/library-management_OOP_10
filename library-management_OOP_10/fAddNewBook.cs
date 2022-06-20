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
    public partial class fAddNewBook : Form
    {
        BUSTheoMoiSach busS = new BUSTheoMoiSach();

        public fAddNewBook()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text != "" && txtTenSach.Text != "" && txtTenTacGia.Text != "" && txtNhaXuatBan.Text != "" && txtNgayMuaSach.Text != "" && txtGiaSach.Text != "" && txtSoLuongSach.Text != "")
            {


                string tenSach = txtTenSach.Text;
                string tenTacGia = txtTenTacGia.Text;
                string nhaXuatBan = txtNhaXuatBan.Text;
                string ngayMuaSach = txtNgayMuaSach.Text;
                string keSach = txtKeSach.Text;
                Int64 giaSach = Int64.Parse(txtGiaSach.Text);
                Int64 soLuong = Int64.Parse(txtSoLuongSach.Text);
                DTOThemMoiSach s = new DTOThemMoiSach(tenSach, tenTacGia, nhaXuatBan, ngayMuaSach, giaSach, soLuong, keSach);
                busS.themSach(s);
               
                MessageBox.Show("Lưu sách mới thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuongSach.Clear();
                txtGiaSach.Clear();
                txtNhaXuatBan.Clear();
                txtTenTacGia.Clear();
                txtTenSach.Clear();
                txtKeSach.Clear();
            }

            else
            {
                MessageBox.Show("có ô đang trống, hãy nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (txtKeSach.Text == "" && txtTenSach.Text == "" && txtTenTacGia.Text == "" && txtNhaXuatBan.Text == "" && txtGiaSach.Text == "" && txtSoLuongSach.Text == "")
            {
                this.Close();
                return;
            }
            else if (MessageBox.Show("Hành động này sẽ xoá và không lưu dữ liệu", "Bạn chắc chắn chứ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSoLuongSach.Clear();
            txtGiaSach.Clear();
            txtNhaXuatBan.Clear();
            txtTenTacGia.Clear();
            txtTenSach.Clear();
            txtKeSach.Clear();

        }
    }
}