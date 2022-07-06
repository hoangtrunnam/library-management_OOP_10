using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace library_management_OOP_10
{
    public partial class fLogin : Form

    {
        BUSCheckLogin busLogin = new BUSCheckLogin();
        public fLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_MouseEnter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Clear();
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            // this.Close();
            Application.Exit();
        }

        private void txtMatKhau_MouseEnter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Clear();
                txtMatKhau.PasswordChar = '*';
            }
        }



        private void btnDangKi_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // bắt sự kiện đang chưa đúng ý
            if (txtTenDangNhap.Text != "" && txtMatKhau.Text != "")
            {
                // Tạo DTo
                DTOCheckLogin login = new DTOCheckLogin(txtTenDangNhap.Text, txtMatKhau.Text);

                // Them
                if (busLogin.login(login))
                {
                    GlobalVar.globalMaTT = txtTenDangNhap.Text; // lấy ra mã đăng nhập của thủ thư
                    fMain f = new fMain();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("tên đăng nhập hoặc mật khẩu không được để trống");
            }

        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
