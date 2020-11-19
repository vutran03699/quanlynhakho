namespace quanlynhakho
{
    partial class fmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation3 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnQuanLyTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonVi = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoai = new DevExpress.XtraBars.BarButtonItem();
            this.btnTest = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtbc = new DevExpress.XtraTab.XtraTabControl();
            this.MdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtbc)).BeginInit();
            this.xtbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CaptionBarItemLinks.Add(this.btnQuanLyTaiKhoan);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnQuanLyTaiKhoan,
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnXuatHang,
            this.btnTonKho,
            this.btnDonVi,
            this.btnNhapHang,
            this.btnLoai,
            this.btnTest,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 39;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 283;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.Size = new System.Drawing.Size(1065, 89);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.Caption = "Quản Lý Tài Khoản";
            this.btnQuanLyTaiKhoan.Id = 38;
            this.btnQuanLyTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyTaiKhoan.ImageOptions.Image")));
            this.btnQuanLyTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyTaiKhoan.ImageOptions.LargeImage")));
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLyTaiKhoan_ItemClick);
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.Caption = "Xuất hàng";
            this.btnXuatHang.Id = 28;
            this.btnXuatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXuatHang.ImageOptions.SvgImage")));
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatHang_ItemClick);
            // 
            // btnTonKho
            // 
            this.btnTonKho.Caption = "Xem Tồn Kho";
            this.btnTonKho.Id = 29;
            this.btnTonKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTonKho.ImageOptions.SvgImage")));
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonKho_ItemClick);
            // 
            // btnDonVi
            // 
            this.btnDonVi.Caption = "Đơn Vị";
            this.btnDonVi.Id = 32;
            this.btnDonVi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDonVi.ImageOptions.SvgImage")));
            this.btnDonVi.Name = "btnDonVi";
            this.btnDonVi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonVi_ItemClick);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Caption = "Nhập Hàng";
            this.btnNhapHang.Id = 34;
            this.btnNhapHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhapHang.ImageOptions.SvgImage")));
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapHang_ItemClick_1);
            // 
            // btnLoai
            // 
            this.btnLoai.Caption = "Loại";
            this.btnLoai.Id = 35;
            this.btnLoai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoai.ImageOptions.SvgImage")));
            this.btnLoai.Name = "btnLoai";
            this.btnLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoai_ItemClick);
            // 
            // btnTest
            // 
            this.btnTest.Caption = "Test";
            this.btnTest.Id = 36;
            this.btnTest.Name = "btnTest";
            this.btnTest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTest_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 37;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            reduceOperation3.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation3.GroupName = null;
            reduceOperation3.ItemLinkIndex = 0;
            reduceOperation3.ItemLinksCount = 0;
            reduceOperation3.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.ButtonGroups;
            this.ribbonPage1.ReduceOperations.Add(reduceOperation3);
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnXuatHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTonKho);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDonVi);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLoai);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 606);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1065, 24);
            // 
            // xtbc
            // 
            this.xtbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtbc.Location = new System.Drawing.Point(0, 89);
            this.xtbc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtbc.Name = "xtbc";
            this.xtbc.Size = new System.Drawing.Size(1065, 517);
            this.xtbc.TabIndex = 9;
            this.xtbc.Click += new System.EventHandler(this.xtbc_Click);
            // 
            // MdiManager
            // 
            this.MdiManager.MdiParent = this;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 515);
            this.panel1.TabIndex = 0;
            // 
            // fmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 630);
            this.Controls.Add(this.xtbc);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "fmMaincs";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtbc)).EndInit();
            this.xtbc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnXuatHang;
        private DevExpress.XtraBars.BarButtonItem btnTonKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDonVi;
        private DevExpress.XtraBars.BarButtonItem btnNhapHang;
        private DevExpress.XtraBars.BarButtonItem btnLoai;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnTest;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraTab.XtraTabControl xtbc;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MdiManager;
        private System.Windows.Forms.Panel panel1;
    }
}