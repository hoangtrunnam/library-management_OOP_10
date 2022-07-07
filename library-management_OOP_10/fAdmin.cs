using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_OOP_10
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void quảnLýĐộcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc sẽ thoát?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                fLogin f = new fLogin();
                this.Hide();
                f.ShowDialog();
            }
        }

        private void btnThemMoiDocGia_Click(object sender, EventArgs e)
        {
            fThemMoiThuThu mtt = new fThemMoiThuThu();
            mtt.Show();
        }

        private void btnXemDanhSachDocGia_Click(object sender, EventArgs e)
        {
            fHienThuThu htt = new fHienThuThu();
            htt.Show();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThenAuthen faut = new fThenAuthen();
            faut.Show();
        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHienAuthen haut = new fHienAuthen();
            haut.Show();
        }
    }
}
