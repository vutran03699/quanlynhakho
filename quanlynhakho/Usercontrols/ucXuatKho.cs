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
    public partial class ucXuatKho : DevExpress.XtraEditors.XtraUserControl
    {
        [System.ComponentModel.Browsable(true)]
        public System.Windows.Forms.AutoCompleteMode AutoCompleteMode { get; set; }

        SqlConnection connect = ClassKetNoi.connect;

        int checkslsp;//kiem tra so luong san pham nao do trong ton kho

        public ucXuatKho()
        {
            InitializeComponent();
        }

        public static string thanhtoan = "";
        public static string IDhoadon = "";
        public static string HDmasp = "";
        public static string HDtensp = "";
        public static string HDdongia = "";
        public static string HDsl = "";
        public static string HDloai = "";
        public static string DonVi = "";
        public static string SDT = "";
        public static string TenKH = "";
       
        

        // kiem trs sl san pham
        int checklsp;
        int indexRow;

        private void autoidHD()
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("select count(IDhoadon) from HoaDon", connect);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            connect.Close();
            i++;
            txtsohd.Text = i.ToString();
           IDhoadon = txtsohd.Text; // luu cho form tt
        }
        public void clearsp()
        {
            txtmasp.Text = null;
            txttensp.Text = null;
            txtsoluongsp.Text = null;
            txtdongiasp.Text = null;
   
            txttiensp.Text = null;
            comboBoxdonvisp.SelectedItem = null;
            comboBoxdonvisp.Text = null;
            comboBoxloaisp.Text = null;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // nếu mã sp giống nhau sẽ cộng dồn số lượng và tiền vào ô
                    if(Convert.ToString(row.Cells[0].Value) == txtmasp.Text)
                    {
                        row.Cells[2].Value = (int.Parse(txtsoluongsp.Text) + Convert.ToInt16(row.Cells[2].Value.ToString()));
                        row.Cells[4].Value = (double.Parse(txttiensp.Text) + Convert.ToDouble(row.Cells[4].Value.ToString()));
                    }
                }
                if (!found)
                {
                    dataGridView1.Rows.Add(txtmasp.Text, txttensp.Text, txtsoluongsp.Text, txtdongiasp.Text, txttiensp.Text, comboBoxdonvisp.Text, comboBoxloaisp.Text);
                }

            }
            else
            {
                dataGridView1.Rows.Add(txtmasp.Text, txttensp.Text, txtsoluongsp.Text, txtdongiasp.Text, txttiensp.Text, comboBoxdonvisp.Text, comboBoxloaisp.Text );
            }
            //// tinh tong tien sp trong dataGridView
            //double sum = 0;
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            //}
            // txtcongtientong.Text = sum.ToString("####,###");
            tinhtongView();

            // update sql
            try
            {
                using (var cmdupdatesl = new SqlCommand("update tonkho set soluongsp=soluongsp - '" + txtsoluongsp.Text + "' where masp='" + txtmasp.Text + "' "))
                {
                    cmdupdatesl.Connection = connect;
                    connect.Open();
                    if(cmdupdatesl.ExecuteNonQuery() >0)
                    {
                        MessageBox.Show("ĐÃ UPDATE");
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                    connect.Close();
                }

            }catch(Exception ex)
            {
                connect.Close();
                MessageBox.Show("Loi update " + ex.Message);
            }
            clearsp();
        }


        private void btnsua_Click(object sender, EventArgs e)
        {
            //tra lai slsp
            using (var cmdedit = new SqlCommand("update tonkho set soluongsp=soluongsp + '" + slspedit + "' where masp='" + maspedit + "' "))
            {
                cmdedit.Connection = connect;
                connect.Open();
                if (cmdedit.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đã update");
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                    connect.Close();
                }
                connect.Close();
            }

            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            newDataRow.Cells[0].Value = txtmasp.Text;
            newDataRow.Cells[1].Value = txttensp.Text;
            newDataRow.Cells[2].Value = txtsoluongsp.Text;
            newDataRow.Cells[3].Value = txtdongiasp.Text;
            newDataRow.Cells[4].Value = txttiensp.Text;
            newDataRow.Cells[5].Value = comboBoxdonvisp.Text;
            newDataRow.Cells[6].Value = comboBoxloaisp.Text;

            // tru slsp
            using (var cmdedit2 = new SqlCommand("update tonkho set soluongsp=soluongsp - '" + txtsoluongsp.Text + "' where masp='" + txtmasp.Text + "' "))
            {
                cmdedit2.Connection = connect;
                connect.Open();
                if (cmdedit2.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đã update");
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                    connect.Close();
                }
                connect.Close();
            }

            clearsp();

        }
        string maspedit;
        int slspedit;

        private void btnhuy_Click(object sender, EventArgs e)
        {
            clearsp();
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                clearsp();
                txtmasp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txttensp.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtsoluongsp.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtdongiasp.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                txttiensp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                comboBoxdonvisp.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                comboBoxloaisp.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                maspedit = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                slspedit = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            }
            else
            {
                MessageBox.Show("No data!");
            }
        }
        string masp1;
        int slsp1;
        private void btnxoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                DataGridViewRow row = dataGridView1.Rows[item.Index];
                masp1 = row.Cells[0].Value.ToString();
                slsp1 = Convert.ToInt32(row.Cells[2].Value.ToString());
                dataGridView1.Rows.RemoveAt(item.Index); //remove row in datagridview
            }
            //------------- tra lai soluong sp database -----------------//
            try
            {
                using (var cmdupdatesl2 = new SqlCommand("update tonkho set soluongsp=soluongsp + '" + slsp1 + "' where masp='" + masp1 + "' "))
                {
                    cmdupdatesl2.Connection = connect;
                    connect.Open();
                    if (cmdupdatesl2.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã update");
                    }
                    else
                    {
                        MessageBox.Show("Không thành công!");
                    }
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show("loi update ne" + ex.Message);
            }
            //-----------------------------------------//
        }




        private void ucXuatKho_Load(object sender, EventArgs e)
        {
           
            try
            {
                autoidHD();
                string sqltensp = "select tensp from tonkho";
                SqlCommand cmd = new SqlCommand(sqltensp, connect);
                connect.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection autotensp = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    autotensp.Add(dr.GetString(0));
                }
                txttensp.AutoCompleteMode = AutoCompleteMode.Suggest;
                txttensp.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txttensp.AutoCompleteCustomSource = autotensp;
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

      

        private void txttensp_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtmasp_KeyDown(object sender, KeyEventArgs e)
        {
          //  string loaisp1;
            if (e.KeyCode == Keys.Enter)
            {
                connect.Open();
                string sqlsp = "";
                SqlCommand cmd2 = new SqlCommand(sqlsp, connect);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    txtmasp.Text = (dr2["masp"].ToString());
                    txttensp.Text = (dr2["tensp"].ToString());
                    txtdongiasp.Text = (dr2["giabansp"].ToString());
                    txtsoluongsp.Text = "1";
                    comboBoxdonvisp.Text = (dr2[""].ToString());
                    comboBoxloaisp.Text = (dr2[""].ToString());

                    double slsp;
                    double dongiasp;
                    double thanhtiensp;
                    // double thanhtiensp2;
                    slsp = double.Parse(txtsoluongsp.Text);
                    dongiasp = double.Parse(txtdongiasp.Text);
                    thanhtiensp = slsp * dongiasp;



                    txttiensp.Text = thanhtiensp.ToString("###,###,###,###");

                }
                connect.Close();
            }
        }

        private void txttensp_KeyDown(object sender, KeyEventArgs e)
        {
            string loaisp1;
          //  double giamgiaTextbox;

            if (e.KeyCode == Keys.Enter)
            {
                connect.Open();
                string sqlsp = "select * from tonkho where (tensp= N'" + txttensp.Text + "') ";
                SqlCommand cmd2 = new SqlCommand(sqlsp, connect);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    checkslsp = Convert.ToInt32(dr2["soluongsp"]);
                    if (checkslsp < 1)
                    {
                        MessageBox.Show("het hang");
                    }
                    else
                    {
                        txtmasp.Text = (dr2["masp"].ToString());
                        txtdongiasp.Text = (dr2["giabansp"].ToString());
                        txtsoluongsp.Text = "1";
                        comboBoxdonvisp.Text = (dr2["donvisp"].ToString());
                        comboBoxloaisp.Text = (dr2["loaisp"].ToString());
                      //  thanhtiensp = Con(txtsoluongsp) * Convert.ToInt32(txtdongiasp);
                        double slsp;
                        double dongiasp;
                        double thanhtiensp;
                       // double tongtien;
                       // double thanhtiensp2;
                        slsp = double.Parse(txtsoluongsp.Text);
                        dongiasp = double.Parse(txtdongiasp.Text);
                       // tongtien = double.Parse(txttiensp.Text);
                       
                        thanhtiensp = slsp * dongiasp;
                        // MessageBox.Show(thanhtiensp.ToString());
                        //tien giam gia cua san pham
                        // giamgiaTextbox = double.Parse(txtgiamphantramsp.Text);
                        // double giamgiasp = (giamgiaTextbox * thanhtiensp) / 100;
                        //tien san pham = (so luong * don gia ) - giam gia
                        //  thanhtiensp2 = thanhtiensp - giamgiasp;

                        txtdongiasp.Text = dongiasp.ToString("###,###,###,###");
                        txttiensp.Text = thanhtiensp.ToString("###,###,###,###");

                        //luu tru cho from  TT
                      //  loaisp1 = comboBoxloaisp.Text;
                        //
                                                      //  HDmasp = txtmasp.Text;
                                                      //  HDdongia = txtdongiasp.Text;
                                                      //  HDsl = txtsoluongsp.Text;
                                                      //  HDdonvi = comboBoxdonvisp.Text;
                                                      //  HDtensp = txttensp.Text;
                                                      //   HDloai = loaisp1;
                    }

                }
                connect.Close();
            }
        }

        private void txtsoluongsp_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsoluongsp.Text))
            {

            }
            else if (string.IsNullOrWhiteSpace(txtdongiasp.Text))
            {

            }
            else
            {
                {
                    int slspHienTai = Convert.ToInt32(txtsoluongsp.Text);
                    if (slspHienTai > checkslsp)
                    {
                        // nếu số lượng sp nhập nào nhiều hơn số lượng trong database thì lấy số lượng trong database
                        txtsoluongsp.Text = checkslsp.ToString();
                    }
                    else
                    {

                        double slsp;
                        double dongiasp;
                        double thanhtiensp;
                        slsp = double.Parse(txtsoluongsp.Text);
                        dongiasp = double.Parse(txtdongiasp.Text);
                        thanhtiensp = slsp * dongiasp;



                        txttiensp.Text = thanhtiensp.ToString("###,###,###,###");

                    }
                }
            }
        }
        private void txttiensp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtsoluongsp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void tinhtongView()
        {
            double sum = 0;
            for (int i =0;i<dataGridView1.Rows.Count ; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            txttongcongtiensp.Text = sum.ToString("###,###,###,###");
        }
    }
}
