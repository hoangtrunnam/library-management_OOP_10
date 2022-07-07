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
    public partial class fThongKeTheoDocGia : Form
    {
        BUSThongKe TK = new BUSThongKe();
        public fThongKeTheoDocGia()
        {
            InitializeComponent();
        }

        private void btnTimKiemThongKe_Click(object sender, EventArgs e)
        {
            if (txtMSSVThongKe.Text != null)
            {

                subFormDangMuon.DataSource = TK.DangMuonTheoThangSV(txtTuNgay.Text, txtDenNgay.Text, txtMSSVThongKe.Text).Tables[0];
                subFormDaMuon.DataSource = TK.DaMuonTheoThangSV(txtTuNgay.Text, txtDenNgay.Text, txtMSSVThongKe.Text).Tables[0];
            }

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

        private void btnLamMoiThoat_Click(object sender, EventArgs e)
        {

            this.Close();
           
        }

        private void btnLamMoiTraSach_Click(object sender, EventArgs e)
        {
            txtTuNgay.Clear();
            txtDenNgay.Clear();
            txtMSSVThongKe.Clear();

        }
    }
}