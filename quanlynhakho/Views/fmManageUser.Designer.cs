namespace quanlynhakho.Views
{
    partial class fmManageUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserNV = new DevExpress.XtraEditors.TextEdit();
            this.txtNameNV = new DevExpress.XtraEditors.TextEdit();
            this.txtPassNV = new DevExpress.XtraEditors.TextEdit();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSua = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.df = new System.Windows.Forms.Label();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSttNV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserNV
            // 
            this.txtUserNV.EditValue = "UserName";
            this.txtUserNV.Location = new System.Drawing.Point(33, 55);
            this.txtUserNV.Name = "txtUserNV";
            this.txtUserNV.Size = new System.Drawing.Size(216, 20);
            this.txtUserNV.TabIndex = 0;
            // 
            // txtNameNV
            // 
            this.txtNameNV.EditValue = "FullName";
            this.txtNameNV.Location = new System.Drawing.Point(33, 81);
            this.txtNameNV.Name = "txtNameNV";
            this.txtNameNV.Size = new System.Drawing.Size(216, 20);
            this.txtNameNV.TabIndex = 0;
            // 
            // txtPassNV
            // 
            this.txtPassNV.EditValue = "PassWord";
            this.txtPassNV.Location = new System.Drawing.Point(33, 107);
            this.txtPassNV.Name = "txtPassNV";
            this.txtPassNV.Size = new System.Drawing.Size(216, 20);
            this.txtPassNV.TabIndex = 0;
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(12, 139);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 23);
            this.BtnThem.TabIndex = 1;
            this.BtnThem.Text = "THÊM";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(93, 139);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(75, 23);
            this.BtnSua.TabIndex = 1;
            this.BtnSua.Text = "SỬA";
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(174, 139);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(75, 23);
            this.BtnXoa.TabIndex = 1;
            this.BtnXoa.Text = "XÓA";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnHuy
            // 
            this.BtnHuy.Location = new System.Drawing.Point(93, 180);
            this.BtnHuy.Name = "BtnHuy";
            this.BtnHuy.Size = new System.Drawing.Size(75, 23);
            this.BtnHuy.TabIndex = 1;
            this.BtnHuy.Text = "Hủy";
            this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // df
            // 
            this.df.AutoSize = true;
            this.df.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.df.Location = new System.Drawing.Point(262, 25);
            this.df.Name = "df";
            this.df.Size = new System.Drawing.Size(268, 33);
            this.df.TabIndex = 2;
            this.df.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AllowUserToOrderColumns = true;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(301, 98);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 51;
            this.dtgvAccount.Size = new System.Drawing.Size(571, 371);
            this.dtgvAccount.TabIndex = 3;
            this.dtgvAccount.DoubleClick += new System.EventHandler(this.dtgvAccount_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSttNV);
            this.groupBox1.Controls.Add(this.BtnSua);
            this.groupBox1.Controls.Add(this.BtnThem);
            this.groupBox1.Controls.Add(this.BtnHuy);
            this.groupBox1.Controls.Add(this.txtPassNV);
            this.groupBox1.Controls.Add(this.BtnXoa);
            this.groupBox1.Controls.Add(this.txtNameNV);
            this.groupBox1.Controls.Add(this.txtUserNV);
            this.groupBox1.Location = new System.Drawing.Point(13, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 256);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài khoản";
            // 
            // txtSttNV
            // 
            this.txtSttNV.Location = new System.Drawing.Point(33, 28);
            this.txtSttNV.Name = "txtSttNV";
            this.txtSttNV.ReadOnly = true;
            this.txtSttNV.Size = new System.Drawing.Size(216, 21);
            this.txtSttNV.TabIndex = 5;
            this.txtSttNV.Text = "STT";
            // 
            // fmManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 481);
            this.Controls.Add(this.dtgvAccount);
            this.Controls.Add(this.df);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmManageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gdul";
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUserNV;
        private DevExpress.XtraEditors.TextEdit txtNameNV;
        private DevExpress.XtraEditors.TextEdit txtPassNV;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.SimpleButton BtnSua;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnHuy;
        private System.Windows.Forms.Label df;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSttNV;
    }
}