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
    public partial class ucLoaiSP : DevExpress.XtraEditors.XtraUserControl
    {
        SqlConnection connect = ClassKetNoi.connect;
        public ucLoaiSP()
        {
            InitializeComponent();
            dtgLoaiSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridview();
            autoId();
        }
        public void autoId()
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select count(IDloai) from loaisp", connect);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            connect.Close();
            i++;
            txtId.Text = i.ToString();
        }

        public void ClearDonvi()
        {
            txtLoaiSP.Clear();
            txtId.Clear();
        }


        public void gridview()
        {
            string query = "select IDloai as [Id],TenLoai as [Tên Loại] from loaisp";
            SqlDataAdapter sqldatasp = new SqlDataAdapter(query, connect);
            DataTable datasp = new DataTable();
            sqldatasp.Fill(datasp);
            dtgLoaiSp.DataSource = datasp;
            connect.Close();
        }

        private void dtgLoaiSp_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = dtgLoaiSp.CurrentRow.Cells[0].Value.ToString();
            txtLoaiSP.Text = dtgLoaiSp.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoaiSP.Text))
            {
                MessageBox.Show("Chưa nhập đơn vị");
                txtLoaiSP.Select();
            }
            else
            {
                using (var cmd = new SqlCommand("INSERT INTO loaisp (IDloai ,TenLoai) VALUES (@IDloai ,@TenLoai) "))
                {
                    cmd.Connection = connect;
                    cmd.Parameters.AddWithValue("@IDloai", txtId.Text);
                    cmd.Parameters.AddWithValue("@TenLoai", txtLoaiSP.Text);

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
                    using (var cmd = new SqlCommand("update loaisp set TenLoai=@TenLoai where IDloai=@IDloai"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IDloai", txtId.Text);
                        cmd.Parameters.AddWithValue("@TenLoai", txtLoaiSP.Text);
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
                    using (var cmd = new SqlCommand("delete loaisp where IDloai=@IDloai"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IDloai", txtId.Text);
                        cmd.Parameters.AddWithValue("@TenLoai", txtLoaiSP.Text);
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
