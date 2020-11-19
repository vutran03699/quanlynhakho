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
using System.IO;

namespace quanlynhakho.Usercontrols
{
    public partial class ucNhapKho : DevExpress.XtraEditors.XtraUserControl
    {
        // SqlConnection connect = new SqlConnection(@"data source=DESKTOP-O6D11FL;initial catalog=QuanLyKho;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        SqlConnection connect = ClassKetNoi.connect;
        internal static int SelectedTabPageIndex;

        //  SqlCommand command;
        // string imgloc;
        //đẩy sp lên bảng
        public void GridViewSp()
        {
            string querysp = @"select masp as 'Mã sản phẩm', tensp as 'Tên sản phẩm', soluongsp as 'Số lượng', gianhapsp as 'Giá nhập', giabansp as 'Giá bán', loaisp as 'Loại', donvisp as 'Đơn vị', ngaynhapkho as 'Ngày nhập kho', nvnhapkho as 'Nhân viên' from nhapkho";
            SqlDataAdapter sqldatasp = new SqlDataAdapter(querysp, connect);
            DataTable databsp = new DataTable();
            sqldatasp.Fill(databsp);
            dtgNhapKho.DataSource = databsp;
            connect.Close();
            

        }
        public void clearSp()
        {
            txtId.Text = string.Empty;
            txtTenSp.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtGiaBan.Text= string.Empty;
            txtGiaNhap.Text = string.Empty;
            comboLoai.Text = string.Empty;
            comboDonVi.Text = string.Empty;
     //       pictureBoxIMG.Image = null;


        }
        public ucNhapKho()
        {
            InitializeComponent();


            dtgNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridViewSp();

            //query loan vs sp ra
            string queryloai = @"select * from loaisp";
            string querydonvi = @"select * from donvisp";

            //đổ dữ liệu vào dataset
            SqlDataAdapter sqldataloai = new SqlDataAdapter(queryloai,connect);
            SqlDataAdapter sqldayadonvi = new SqlDataAdapter(querydonvi, connect);

            DataTable dataloai = new DataTable();
            DataTable datadonvi = new DataTable();

            sqldataloai.Fill(dataloai);
            sqldayadonvi.Fill(datadonvi);

            //combobox
            comboLoai.Items.Clear();
            comboDonVi.Items.Clear();
           
            // chạy vòng lặp add loại vs dơn vị vào
            foreach(DataRow dr in dataloai.Rows)
            {
                comboLoai.Items.Add(dr["TenLoai"].ToString());
            }
            foreach (DataRow dr2 in datadonvi.Rows)
            {
                comboDonVi.Items.Add(dr2["TenDonvi"].ToString());
            }


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiem tra nhap gi chưa
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Trống mã sản phẩm ");
                txtId.Select();
            }else if(string.IsNullOrWhiteSpace(txtTenSp.Text))
            {
                MessageBox.Show("Trống Tên ");
                txtTenSp.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Trống Số Lượng ");
                txtSoLuong.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtGiaNhap.Text))
            {
                MessageBox.Show("Trống giá nhập");
                txtGiaNhap.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtGiaBan.Text))
            {
                MessageBox.Show("Trống Gía Bán ");
                txtGiaBan.Select();
            }
            else if (comboLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn Loại ");
                comboLoai.Select();
            }
            else if (comboDonVi.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn đơn vị ");
                comboDonVi.Select();
            }
            
        

            else
            {

                string queryadd = "INSERT INTO nhapkho (masp,tensp,soluongsp,gianhapsp,giabansp,loaisp,donvisp,ngaynhapkho,nvnhapkho) VALUES (@masp,@tensp,@soluongsp,@gianhapsp, @giabansp,@loaisp,@donvisp,@ngaynhapkho,@nvnhapkho)";
                SqlCommand cmd = new SqlCommand(queryadd, connect);
                cmd.Parameters.AddWithValue("@masp", txtId.Text);
                cmd.Parameters.AddWithValue("@tensp", txtTenSp.Text);
                cmd.Parameters.AddWithValue("@soluongsp", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@gianhapsp", txtGiaNhap.Text);
                cmd.Parameters.AddWithValue("@giabansp", txtGiaBan.Text);
                cmd.Parameters.AddWithValue("@loaisp", comboLoai.Text);
                cmd.Parameters.AddWithValue("@donvisp", comboDonVi.Text);
                cmd.Parameters.AddWithValue("@ngaynhapkho", DateTime.Now);
                cmd.Parameters.AddWithValue("@nvnhapkho", fmLogin.usernv);
                connect.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đã thêm");

                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                    connect.Close();
                }
                GridViewSp();
            }
        }

        private void dtgNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btnXoaDuLieuNhap_Click(object sender, EventArgs e)
        {
            clearSp();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    OpenFileDialog dlg = new OpenFileDialog();
            //    if (dlg.ShowDialog() == DialogResult.OK)
            //  h  {
            //        imgloc = dlg.FileName.ToString();
            //        pictureBoxIMG.ImageLocation = imgloc;
            //    }
            //}
            //catch(Exception ex)
            //{
            //    connect.Close();
            //    MessageBox.Show("Lỗi: "+ ex.Message);
            //}
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            //pictureBoxIMG.Image = null;
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
                    using (var cmd = new SqlCommand("delete nhapkho where masp=@masp"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@masp", txtId.Text);
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
                catch(Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }

            }
            GridViewSp();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //ktr kết nối database
                if (connect.State != ConnectionState.Open)
                    // chưa mở thì mở thui
                    connect.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(@"select masp,tensp,soluongsp,gianhapsp,giabansp,loaisp,donvisp 
                                                        from nhapkho where ( masp like '" + txtTimKiem.Text + "%' or tensp like N'" + txtTimKiem.Text + "%' or soluongsp like '" + txtTimKiem.Text + "%' or gianhapsp like '" + txtTimKiem.Text + "%' or giabansp like '" + txtTimKiem.Text + "%'  or loaisp like N'" + txtTimKiem.Text + "%'  or donvisp like N'" + txtTimKiem.Text + "%'     ) ", connect))
                {
                    DataTable dtTimKiem = new DataTable("tonkho");
                    da.Fill(dtTimKiem);
                    dtgNhapKho.DataSource = dtTimKiem;
                }
                connect.Close();
                if(dtgNhapKho.Rows.Count > 1 && dtgNhapKho.Rows != null)
                {
                    labelTimKiem.Text = "Đã tìm thấy";
                }
               else
                {
                    labelTimKiem.Text = "Không Tìm Kiếm";
                }
                if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
                {
                    labelTimKiem.Text = "Tìm Kiếm";
                }

            }
            catch(Exception ex)
            {
                connect.Close();
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Thông tin trống");
            }
            else
            {
                try
                {
                    string querysave = "update nhapkho set tensp=@tensp,soluongsp=@soluongsp,gianhapsp=@gianhapsp,giabansp=@giabansp,loaisp=@loaisp,donvisp=@donvisp,ngaynhapkho=@ngaynhapkho,nvnhapkho=@nvnhapkho where masp=@masp";
                    SqlCommand cmd = new SqlCommand(querysave, connect);
                    cmd.Parameters.AddWithValue("@masp", txtId.Text);
                    cmd.Parameters.AddWithValue("@tensp", txtTenSp.Text);
                    cmd.Parameters.AddWithValue("@soluongsp", txtSoLuong.Text);
                    cmd.Parameters.AddWithValue("@gianhapsp", txtGiaNhap.Text);
                    cmd.Parameters.AddWithValue("@giabansp", txtGiaBan.Text);
                    cmd.Parameters.AddWithValue("@loaisp", comboLoai.Text);
                    cmd.Parameters.AddWithValue("@donvisp", comboDonVi.Text);
                    cmd.Parameters.AddWithValue("@ngaynhapkho", DateTime.Now);
                    cmd.Parameters.AddWithValue("@nvnhapkho", fmLogin.usernv);
                    connect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã Lưu");

                        connect.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                        connect.Close();
                    }
                    GridViewSp();
                }
                catch(Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Error " + ex.Message);

                }
            }
         

        }

        private void dtgNhapKho_DoubleClick(object sender, EventArgs e)
        {
            if (dtgNhapKho.CurrentRow.Index != 1)
            {
                clearSp();

                txtId.Text = dtgNhapKho.CurrentRow.Cells[0].Value.ToString();
                txtTenSp.Text = dtgNhapKho.CurrentRow.Cells[1].Value.ToString();
                txtSoLuong.Text = dtgNhapKho.CurrentRow.Cells[2].Value.ToString();
                txtGiaNhap.Text = dtgNhapKho.CurrentRow.Cells[3].Value.ToString();
                txtGiaBan.Text = dtgNhapKho.CurrentRow.Cells[4].Value.ToString();
                comboLoai.Text = dtgNhapKho.CurrentRow.Cells[5].Value.ToString();
                comboDonVi.Text = dtgNhapKho.CurrentRow.Cells[6].Value.ToString();
            }

        }

        private void dateEditNhapKho_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
