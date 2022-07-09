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
using BUS;
using DTO;

namespace library_management_OOP_10
{
    public partial class fCompleteBookDetails : Form
    {
        BUSThongKe bustk = new BUSThongKe();
        public fCompleteBookDetails()
        {
            InitializeComponent();
        }

        private void fCompleteBookDetails_Load(object sender, EventArgs e)
        {
            //Da Muon
            dataGridView2.DataSource = bustk.DangMuon().Tables[0];

            //Dang Muon
            dataGridView1.DataSource = bustk.DaMuon().Tables[0];

            subformMatSach.DataSource = bustk.MatSach().Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void txtTuNgay_AddText(object sender, EventArgs e)
        {
            
        }

        public void txtDenNgay_AddText(object sender, EventArgs e)
        {
          
        }

        

        private void txtTuNgay_MouseEnter(object sender, EventArgs e)
        {
            if (txtTuNgay.Text == "dd/mm/yyyy")
            {
                txtTuNgay.Clear();
            }
        }

        private void txtDenNgay_MouseEnter(object sender, EventArgs e)
        {
            if (txtDenNgay.Text == "dd/mm/yyyy")
            {
                txtDenNgay.Clear();
                
            }
        }

        private void btnThongKeTheoThang_Click(object sender, EventArgs e)
        {

            if(bustk.DangMuonTheoThang(txtTuNgay.Text, txtDenNgay.Text).Tables[0] !=null && bustk.DaMuonTheoThang(txtTuNgay.Text, txtDenNgay.Text).Tables[0] != null)
            {

            //Da Muon
            dataGridView2.DataSource = bustk.DangMuonTheoThang(txtTuNgay.Text, txtDenNgay.Text).Tables[0];

            //Dang Muon
            dataGridView1.DataSource = bustk.DaMuonTheoThang(txtTuNgay.Text, txtDenNgay.Text).Tables[0];

                //mat
                subformMatSach.DataSource = bustk.MatSachTheoThang(txtTuNgay.Text, txtDenNgay.Text).Tables[0];
            }
        }



        private void btnExportDangMuon_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GlobalVar.exportExcel(saveFileDialog.FileName, dataGridView2);
                    MessageBox.Show("xuất file thành công");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("xuất file thành công\n" + ex.Message);

                }
            }
        }

        private void btnExportMatSach_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GlobalVar.exportExcel(saveFileDialog.FileName, subformMatSach);
                    MessageBox.Show("xuất file thành công");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("xuất file thành công\n" + ex.Message);

                }
            }
        }

        private void btnExportDaMuon_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GlobalVar.exportExcel(saveFileDialog.FileName, dataGridView1);
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
