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
using quanlynhakho.DAO;

namespace quanlynhakho
{
    public partial class fmLogin : DevExpress.XtraEditors.XtraForm
    {
        public fmLogin()
        {
            InitializeComponent();
          
        }
      

        bool Login(string Username, string Password)
        {

            return AccountDAO.Instance.Login(Username, Password) ; 
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string Username = txtTaiKhoan.Text;
            string Password = txtMatKhau.Text;
            if (Login(Username, Password))
            {
                fmMain f = new fmMain();
                this.Hide();
                f.ShowDialog();
            }
            MessageBox.Show("Sai tên tài khoản or mật khẩu");
  


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

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}