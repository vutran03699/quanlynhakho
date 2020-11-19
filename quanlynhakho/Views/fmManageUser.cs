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


namespace quanlynhakho.Views
{
    public partial class fmManageUser : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connect = ClassKetNoi.connect;


        Label IDtt = new Label();

        public fmManageUser()
        {

            //InitializeComponent();
            //gridviewNhanVien();
            if (fmLogin.usernv == "admin")
            {
                //MessageBox.Show("ban la nhan vien");
                InitializeComponent();
                gridviewNhanVien();
             
            }
            else
            {
              
                MessageBox.Show("Chỉ có admin mới có thể truy cập chức năng này!");

       
            }
        }
       

        public void gridviewNhanVien()
        {
            //data grid view nhan vien
            string querynv = @"select STT as 'STT', usernv as 'Tên tài khoản', tennv as 'Tên nhân viên', passnv as 'Mật khẩu' from nhanvien";
            SqlDataAdapter sqldatasp = new SqlDataAdapter(querynv, connect);
            DataTable datatbsp = new DataTable();
            sqldatasp.Fill(datatbsp);
            dtgvAccount.DataSource = datatbsp;
            connect.Close();

        }

        public void clearnv()
        {
            txtUserNV.Text="";
            txtNameNV.Text="";
            txtPassNV.Text ="";
        }

        


        private void dtgvAccount_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvAccount.CurrentRow.Index != -1)
            {
                txtSttNV.Text = dtgvAccount.CurrentRow.Cells[0].Value.ToString();
                txtUserNV.Text = dtgvAccount.CurrentRow.Cells[1].Value.ToString();
                txtNameNV.Text = dtgvAccount.CurrentRow.Cells[2].Value.ToString();
                txtPassNV.Text = dtgvAccount.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {

            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserNV.Text))
            {
                MessageBox.Show("Trống!");
                txtUserNV.Select();
            }

            if (string.IsNullOrWhiteSpace(txtNameNV.Text))
            {
                txtNameNV.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtPassNV.Text))
            {
                txtPassNV.Select();
            }
            else
            {
                using (var cmd = new SqlCommand("INSERT INTO nhanvien (usernv,tennv,passnv) VALUES (@usernv,@tennv,@passnv)"))
                {
                    cmd.Connection = connect;
                    //    cmd.Parameters.AddWithValue("@usernv", txtUserNV.Text);
                    cmd.Parameters.AddWithValue("@usernv", txtUserNV.Text);
                    cmd.Parameters.AddWithValue("@tennv", txtNameNV.Text);
                    cmd.Parameters.AddWithValue("@passnv", txtPassNV.Text);
                    connect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã thêm");
                        connect.Close();
                        clearnv();
                        gridviewNhanVien();

                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                        connect.Close();
                    }
                    connect.Close();

                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserNV.Text))
            {
                MessageBox.Show("Trống!");
                txtUserNV.Select();
            }

            if (string.IsNullOrWhiteSpace(txtNameNV.Text))
            {
                txtNameNV.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtPassNV.Text))
            {
                txtPassNV.Select();
            }
            else
            {
                try
                {
                    using (var cmd = new SqlCommand("update nhanvien set usernv=@usernv,tennv=@tennv,passnv=@passnv where STT=@STT"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@STT", txtSttNV.Text);
                        cmd.Parameters.AddWithValue("@usernv", txtUserNV.Text);
                        cmd.Parameters.AddWithValue("@tennv", txtNameNV.Text);
                        cmd.Parameters.AddWithValue("@passnv", txtPassNV.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã lựu");
                            connect.Close();
                            clearnv();
                            gridviewNhanVien();
                        }
                        else
                        {
                            MessageBox.Show("Lưu không thành công!");
                        }
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Error during update: " + ex.Message);
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUserNV.Text))
            {
                MessageBox.Show("Thông tin trống!");
            }
            else
            {
                try
                {
                    using (var cmd = new SqlCommand("delete nhanvien where usernv=@usernv"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@usernv", txtUserNV.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã xóa");
                            connect.Close();
                            clearnv();
                            gridviewNhanVien();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công!");
                        }
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Error during delete: " + ex.Message);
                }

            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            clearnv();
        }
    }
}
