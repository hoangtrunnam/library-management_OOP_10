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
using DTO;
using BUS;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;


namespace library_management_OOP_10
{
    public partial class fXemDsSach : Form
    {
        BUSTheoMoiSach busS = new BUSTheoMoiSach();
        public fXemDsSach()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panelThongTinSach.Visible = false;
        }

        private void fXemDsSach_Load(object sender, EventArgs e)
        {
            panelThongTinSach.Visible = false;
            

            dataGridView1.DataSource = busS.getSach();
        }
        int bookId; // lấy ra id của sách để sửa
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelThongTinSach.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bookId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }


            rowId = bookId;
            txtTenSach.Text = busS.getSach(bookId).Rows[0][1].ToString();
            txtTenTacGia.Text = busS.getSach(bookId).Rows[0][2].ToString();
            txtNhaXuatBan.Text = busS.getSach(bookId).Rows[0][3].ToString();
            txtNgayMuaSach.Text = busS.getSach(bookId).Rows[0][4].ToString(); // đang bị lỗi nếu nhấn vào trường có data kiểu như : 10/02/2022
            txtGiaSach.Text = busS.getSach(bookId).Rows[0][5].ToString();
            txtSoLuong.Text = busS.getSach(bookId).Rows[0][6].ToString();
            txtKeSach.Text = busS.getSach(bookId).Rows[0][7].ToString();
        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            if (txtTimSach.Text != "")
            {

                dataGridView1.DataSource = busS.timSach(txtTimSach.Text);
            }
            else
            {
                dataGridView1.DataSource = busS.getSach();
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtTimSach.Clear();
            panelThongTinSach.Visible = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("dữ liệu sẽ bị thay đổi","cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
               // Int64 maSach = Int64.Parse(textMaSach.Text);
                string tenSach = txtTenSach.Text;
                string tenTacGia = txtTenTacGia.Text;
                string nhaXuatBan = txtNhaXuatBan.Text;
                string ngayMuaSach = txtNgayMuaSach.Text;
                Int64 giaSach = Int64.Parse(txtGiaSach.Text);
                Int64 soLuong = Int64.Parse(txtSoLuong.Text);
                string keSach = txtKeSach.Text;

                DTOThemMoiSach s = new DTOThemMoiSach(tenSach, tenTacGia, nhaXuatBan, ngayMuaSach, giaSach, (int)soLuong, keSach, (int)bookId);
               
                if (busS.suaSach(s))
                {
                    MessageBox.Show("Sửa thành công");
                    //dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Sửa ko thành công");
                }



                if (txtTimSach.Text != "")
                {

                    dataGridView1.DataSource = busS.timSach(txtTimSach.Text);
                }
                else
                {
                    dataGridView1.DataSource = busS.getSach();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("dữ liệu sẽ bị xoá", "thành công", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {






                if (busS.xoaSach((int)bookId))
                {
                    MessageBox.Show("Xóa thành công");
                    //dgvTV.DataSource = busTV.getThanhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }

            if (txtTimSach.Text != "")
            {

                dataGridView1.DataSource = busS.timSach(txtTimSach.Text);
            }
            else
            {
                dataGridView1.DataSource = busS.getSach();
            }
        }

        private void panelThongTinSach_Paint(object sender, PaintEventArgs e)
        {

        }
        private void exportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    exportExcel(saveFileDialog.FileName);
                    MessageBox.Show("xuất file thành công");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("xuất file thành công\n" + ex.Message);

                }
            }
        }
    }
}
