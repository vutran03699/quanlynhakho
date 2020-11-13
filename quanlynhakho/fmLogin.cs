using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace quanlynhakho
{
    public partial class fmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static string usernv = "";
        SqlConnection connect = ClassKetNoi.connect;
        public fmLogin()
        {
            InitializeComponent();
          
        }
      

    
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //string Username = txtTaiKhoan.Text;
            //string Password = txtMatKhau.Text;
            //if (Login(Username, Password))
            //{
            //    fmMain f = new fmMain();
            //    this.Hide();
            //    f.ShowDialog();
            //}
            //MessageBox.Show("Sai tên tài khoản or mật khẩu");
            usernv = txtTaiKhoan.Text;
            string querynv = "Select * From nhanvien where usernv ='" + txtTaiKhoan.Text + "' and passnv='" + txtMatKhau.Text + "' ";
            SqlDataAdapter sqldata = new SqlDataAdapter(querynv, connect);
            DataTable datatb1 = new DataTable();
            sqldata.Fill(datatb1);
            if (datatb1.Rows.Count == 1)
            {
                fmMain f = new fmMain();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMatKhau_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked == true)
                txtMatKhau.Properties.UseSystemPasswordChar = false;
            else
                txtMatKhau.Properties.UseSystemPasswordChar = true;
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            

        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
          

        }
    }
}