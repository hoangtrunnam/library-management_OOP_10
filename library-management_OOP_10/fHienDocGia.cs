using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

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
                string fullPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "assets\\search1.gif");
                Image image = Image.FromFile(fullPath);
                pictureSearch.Image = image;
            }
            else
            {
                label1.Visible = true;
                string fullPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "assets\\search.gif");
                Image image = Image.FromFile(fullPath);
                pictureSearch.Image = image;
            }
        }
    }
}
