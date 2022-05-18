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
    public partial class fHienDocGia : Form
    {
        public fHienDocGia()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        
        private void txtTimMSSV_TextChanged(object sender, EventArgs e)
        {
            if(txtTimMSSV.Text != "")
            {
                label1.Visible = false;
                //Thay Duong dan cua minh
                Image image = Image.FromFile("C:/Users/PC/Desktop/DoAnOOP/library-management_OOP_10/assets/search1.gif");
                pictureSearch.Image = image;
            }
            else
            {
                label1.Visible = true;
                //Thay Duong dan cua minh
                Image image = Image.FromFile("C:/Users/PC/Desktop/DoAnOOP/library-management_OOP_10/assets/search.gif");
                pictureSearch.Image = image;
            }
        }
    }
}
