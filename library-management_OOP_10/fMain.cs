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
            }
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("fAddNewBook"))
            {
                fAddNewBook f = new fAddNewBook();
                f.MdiParent = this;
                f.Show();
                
            }
            else 
                ActiveChildForm("fAddNewBook");
        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("fXemDsSach"))
            {
                fXemDsSach f = new fXemDsSach();
                f.MdiParent = this;
                f.Show();
            }
            else
                ActiveChildForm("fXemDsSach");
        }

        private void btnThemMoiDocGia_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("fThemMoiDocGia"))
            {
                fThemMoiDocGia tmdg = new fThemMoiDocGia();
                tmdg.MdiParent = this;
                tmdg.Show();
            }
            else
                ActiveChildForm("fThemMoiDocGia");
        }

        private void btnXemDanhSachDocGia_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("fHienDocGia"))
            {
                fHienDocGia hdg = new fHienDocGia();
                hdg.MdiParent = this;
                hdg.Show();
            }
            else
                ActiveChildForm("fHienDocGia");
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("fMuonSach"))
            {
                fMuonSach ms = new fMuonSach();
                ms.MdiParent = this;
                ms.Show();
            }
            else
                ActiveChildForm("fMuonSach");
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("fTraSach"))
            {
                fTraSach ts = new fTraSach();
                ts.MdiParent = this;
                ts.Show();
            }
            else
                ActiveChildForm("fTraSach");
        }

        private void btnChiTietMuonTra_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("fCompleteBookDetails"))
            {
                fCompleteBookDetails ct = new fCompleteBookDetails();
                ct.MdiParent = this;
                ct.Show();
            }
            else
                ActiveChildForm("fCompleteBookDetails");
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKeTheoDocGia_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("fThongKeTheoDocGia"))
            {
                fThongKeTheoDocGia tDG = new fThongKeTheoDocGia();
                tDG.MdiParent = this;
                tDG.Show();
            }
            else
                ActiveChildForm("fThongKeTheoDocGia");
        }

        private void quanrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }    
            }    
            return check;
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }    
            }    
        }
    }
}

