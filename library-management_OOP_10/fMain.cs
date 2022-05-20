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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có chắc sẽ thoát?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                fLogin f = new fLogin();
                this.Hide();
                f.ShowDialog();
                // this.Show();
                // Application.Exit();
            }
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            fAddNewBook f = new fAddNewBook();
            f.Show();
        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            fXemDsSach f = new fXemDsSach();
            f.Show();
        }

        private void thêmMớiĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemMoiDocGia tmdg = new fThemMoiDocGia();
            tmdg.Show();
        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fHienDocGia hdg = new fHienDocGia();
            hdg.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMuonSach ms = new fMuonSach();
            ms.Show();
        }
    }
}
