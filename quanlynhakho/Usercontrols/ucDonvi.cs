using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace quanlynhakho.Usercontrols
{
    public partial class ucDonvi : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection connect = ClassKetNoi.connect;
        public ucDonvi()
        {
            InitializeComponent();
            dtgDonVi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridview();
            autoId();


        }
        public void autoId()
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select count(IDdonvi) from donvisp", connect);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            connect.Close();
            i++;
            txtId.Text = i.ToString();
        }

        public void ClearDonvi()
        {
            txtDonVi.Clear();
            txtId.Clear();
        }


        public void gridview()
        {
            string query = "select IDdonvi as [Id],TenDonvi as [Tên đơn vị] from donvisp";
            SqlDataAdapter sqldatasp = new SqlDataAdapter(query, connect);
            DataTable datasp = new DataTable();
            sqldatasp.Fill(datasp);
            dtgDonVi.DataSource = datasp;
            connect.Close();
        }

       
        private void dtgDonVi_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = dtgDonVi.CurrentRow.Cells[0].Value.ToString();
            txtDonVi.Text = dtgDonVi.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtDonVi.Text))
            {
                MessageBox.Show("Chưa nhập đơn vị");
                txtDonVi.Select();
            }
            else
            {
                using (var cmd = new SqlCommand("INSERT INTO donvisp (IDdonvi ,TenDonvi) VALUES (@iddonvi ,@tendonvi) "))
                {
                    cmd.Connection = connect;
                    cmd.Parameters.AddWithValue("@iddonvi", txtId.Text);
                    cmd.Parameters.AddWithValue("@tendonvi", txtDonVi.Text);

                    connect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã thêm ");
                        connect.Close();
                        ClearDonvi();
                        autoId();

                    }
                    else
                    {
                        MessageBox.Show("Lỗi thêm");
                        connect.Close();
                    }
                    gridview();

                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Thông Tin Trống!");
            }


            else
            {
                try
                {
                    // xoa sp kho =================
                    using (var cmd = new SqlCommand("update donvisp set TenDonVi=@TenDonvi where IDdonvi=@IDdonvi"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IDdonvi", txtId.Text);
                        cmd.Parameters.AddWithValue("@TenDonvi", txtDonVi.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã Sửa");
                            connect.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công");
                            connect.Close();
                        }

                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }
                gridview();

            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Thông Tin Trống!");
            }


            else
            {
                try
                {
                    // xoa sp kho =================
                    using (var cmd = new SqlCommand("delete donvisp where IDdonvi=@IDdonvi"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IDdonvi", txtId.Text);
                        cmd.Parameters.AddWithValue("@TenDonvi", txtDonVi.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã Xóa");
                            connect.Close();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công");
                            connect.Close();
                        }

                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }
                gridview();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearDonvi();
            autoId();
        }
    }
}
    
