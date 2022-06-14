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
        authen taikhoan = new authen();
        LoginBUS loginbus = new LoginBUS(); 

        public fLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_MouseEnter(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text =="Tên đăng nhập")
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
            if( txtMatKhau.Text =="Mật khẩu")
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
            // DESKTOP-62VA20P\HOANGNAM
            /*SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = '"+GlobalVar.GlobalDomain+ "' ;database= '" + GlobalVar.globalDataBase + "'; integrated security=True"; //lib_Management là tên database
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from authen where authen.maTT = '" + txtTenDangNhap.Text + "' and authen.matKhau = '" + txtMatKhau.Text + "' "; // câu lệnh truy vấn
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            
            

            if (ds.Tables[0].Rows.Count > 0)
            {
                GlobalVar.globalMaTT = txtTenDangNhap.Text; // lấy ra mã đăng nhập của thủ thư
                fMain f = new fMain();
                this.Hide();
                f.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("sai tên đăng nhập hoặc mật khẩu", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
            taikhoan.maTT = txtTenDangNhap.Text;
            taikhoan.matKhau = txtMatKhau.Text;
            string getTT = loginbus.checkLogin(taikhoan);

            switch (getTT)
            {
                case "required_maTT":
                    MessageBox.Show("tài khoản không được để trống");
                    return;
                case "required_matKhau":
                    MessageBox.Show("mật khẩu không được để trống");
                    return;
                case "invalid":
                    MessageBox.Show("thông tin tài khẩu hoặc tài khoản không chính xác");
                    return;
            }
            MessageBox.Show("đăng nhập thành công");

            GlobalVar.globalMaTT = txtTenDangNhap.Text; // lấy ra mã đăng nhập của thủ thư
            fMain f = new fMain();
            this.Hide();
            f.ShowDialog();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
