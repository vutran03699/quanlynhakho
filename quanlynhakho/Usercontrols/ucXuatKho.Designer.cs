namespace quanlynhakho.Usercontrols
{
    partial class ucXuatKho
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvsanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtiensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnXuatKho = new System.Windows.Forms.Button();
            this.btnhuyHD = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txttongcongtiensp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxloaisp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxdonvisp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtsohd = new DevExpress.XtraEditors.TextEdit();
            this.txtmasp = new DevExpress.XtraEditors.TextEdit();
            this.txttiensp = new DevExpress.XtraEditors.TextEdit();
            this.txtdongiasp = new DevExpress.XtraEditors.TextEdit();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoluongsp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSdtkh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsohd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmasp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttiensp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdongiasp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.soluongsp,
            this.dongiasp,
            this.dvsanpham,
            this.loaisp,
            this.thanhtiensp});
            this.dataGridView1.Location = new System.Drawing.Point(7, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(668, 369);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã hàng";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên Hàng";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // soluongsp
            // 
            this.soluongsp.HeaderText = "SL";
            this.soluongsp.Name = "soluongsp";
            this.soluongsp.ReadOnly = true;
            // 
            // dongiasp
            // 
            this.dongiasp.HeaderText = "Đơn Giá";
            this.dongiasp.Name = "dongiasp";
            this.dongiasp.ReadOnly = true;
            // 
            // dvsanpham
            // 
            this.dvsanpham.HeaderText = "Đơn Vị";
            this.dvsanpham.Name = "dvsanpham";
            this.dvsanpham.ReadOnly = true;
            // 
            // loaisp
            // 
            this.loaisp.HeaderText = "Loại";
            this.loaisp.Name = "loaisp";
            this.loaisp.ReadOnly = true;
            // 
            // thanhtiensp
            // 
            this.thanhtiensp.HeaderText = "Thành Tiền";
            this.thanhtiensp.Name = "thanhtiensp";
            this.thanhtiensp.ReadOnly = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(687, 309);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 43);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(768, 309);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 43);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(849, 310);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 43);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(930, 310);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 43);
            this.btnhuy.TabIndex = 4;
            this.btnhuy.Text = "HỦY";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatKho.Location = new System.Drawing.Point(687, 401);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(318, 68);
            this.btnXuatKho.TabIndex = 3;
            this.btnXuatKho.Text = "XUẤT KHO";
            this.btnXuatKho.UseVisualStyleBackColor = true;
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // btnhuyHD
            // 
            this.btnhuyHD.Location = new System.Drawing.Point(862, 520);
            this.btnhuyHD.Name = "btnhuyHD";
            this.btnhuyHD.Size = new System.Drawing.Size(70, 27);
            this.btnhuyHD.TabIndex = 3;
            this.btnhuyHD.Text = "Hủy Phiếu";
            this.btnhuyHD.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(938, 520);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(70, 27);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(310, 446);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 24);
            this.label16.TabIndex = 60;
            this.label16.Text = "VNĐ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 445);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 24);
            this.label15.TabIndex = 54;
            this.label15.Text = "Tổng cộng";
            // 
            // txttongcongtiensp
            // 
            this.txttongcongtiensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongcongtiensp.Location = new System.Drawing.Point(134, 446);
            this.txttongcongtiensp.Name = "txttongcongtiensp";
            this.txttongcongtiensp.ReadOnly = true;
            this.txttongcongtiensp.Size = new System.Drawing.Size(168, 29);
            this.txttongcongtiensp.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Số Hóa Đơn";
            // 
            // comboBoxloaisp
            // 
            this.comboBoxloaisp.FormattingEnabled = true;
            this.comboBoxloaisp.Location = new System.Drawing.Point(919, 165);
            this.comboBoxloaisp.Name = "comboBoxloaisp";
            this.comboBoxloaisp.Size = new System.Drawing.Size(70, 21);
            this.comboBoxloaisp.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Mã sản phẩm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(684, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 67;
            this.label19.Text = "Tên Sản Phẩm";
            // 
            // comboBoxdonvisp
            // 
            this.comboBoxdonvisp.FormattingEnabled = true;
            this.comboBoxdonvisp.Location = new System.Drawing.Point(843, 164);
            this.comboBoxdonvisp.Name = "comboBoxdonvisp";
            this.comboBoxdonvisp.Size = new System.Drawing.Size(70, 21);
            this.comboBoxdonvisp.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Số Lượng";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(907, 252);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 64;
            this.label20.Text = "VND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Thành Tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(703, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Đơn Giá";
            // 
            // txttensp
            // 
            this.txttensp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txttensp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txttensp.Location = new System.Drawing.Point(765, 126);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(184, 21);
            this.txttensp.TabIndex = 83;
            this.txttensp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttensp_KeyDown);
            this.txttensp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttensp_KeyPress);
            // 
            // txtsohd
            // 
            this.txtsohd.Location = new System.Drawing.Point(765, 54);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Properties.ReadOnly = true;
            this.txtsohd.Size = new System.Drawing.Size(101, 20);
            this.txtsohd.TabIndex = 76;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(765, 86);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(101, 20);
            this.txtmasp.TabIndex = 75;
            this.txtmasp.TextChanged += new System.EventHandler(this.txtmasp_TextChanged);
            this.txtmasp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmasp_KeyDown);
            // 
            // txttiensp
            // 
            this.txttiensp.Location = new System.Drawing.Point(765, 249);
            this.txttiensp.Name = "txttiensp";
            this.txttiensp.Properties.ReadOnly = true;
            this.txttiensp.Size = new System.Drawing.Size(136, 20);
            this.txttiensp.TabIndex = 73;
            this.txttiensp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttiensp_KeyPress);
            // 
            // txtdongiasp
            // 
            this.txtdongiasp.Location = new System.Drawing.Point(765, 210);
            this.txtdongiasp.Name = "txtdongiasp";
            this.txtdongiasp.Properties.ReadOnly = true;
            this.txtdongiasp.Size = new System.Drawing.Size(136, 20);
            this.txtdongiasp.TabIndex = 78;
            // 
            // txttenkh
            // 
            this.txttenkh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txttenkh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txttenkh.Location = new System.Drawing.Point(136, 12);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(184, 21);
            this.txttenkh.TabIndex = 83;
            this.txttenkh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttensp_KeyDown);
            this.txttenkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttensp_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // txtsoluongsp
            // 
            this.txtsoluongsp.Location = new System.Drawing.Point(766, 165);
            this.txtsoluongsp.Name = "txtsoluongsp";
            this.txtsoluongsp.Size = new System.Drawing.Size(63, 21);
            this.txtsoluongsp.TabIndex = 84;
            this.txtsoluongsp.TextChanged += new System.EventHandler(this.txtsoluongsp_TextChanged);
            this.txtsoluongsp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluongsp_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(907, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "VND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "SDT";
            // 
            // txtSdtkh
            // 
            this.txtSdtkh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSdtkh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSdtkh.Location = new System.Drawing.Point(449, 12);
            this.txtSdtkh.Name = "txtSdtkh";
            this.txtSdtkh.Size = new System.Drawing.Size(184, 21);
            this.txtSdtkh.TabIndex = 83;
            this.txtSdtkh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttensp_KeyDown);
            this.txtSdtkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttensp_KeyPress);
            // 
            // ucXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtsoluongsp);
            this.Controls.Add(this.txtSdtkh);
            this.Controls.Add(this.txttenkh);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxloaisp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.comboBoxdonvisp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.txttiensp);
            this.Controls.Add(this.txtdongiasp);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txttongcongtiensp);
            this.Controls.Add(this.btnXuatKho);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnhuyHD);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucXuatKho";
            this.Size = new System.Drawing.Size(1076, 568);
            this.Load += new System.EventHandler(this.ucXuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsohd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmasp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttiensp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdongiasp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnXuatKho;
        private System.Windows.Forms.Button btnhuyHD;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txttongcongtiensp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxloaisp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxdonvisp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtsohd;
        private DevExpress.XtraEditors.TextEdit txtmasp;
        private DevExpress.XtraEditors.TextEdit txttiensp;
        private DevExpress.XtraEditors.TextEdit txtdongiasp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsoluongsp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSdtkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtiensp;
    }
}
