using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using quanlynhakho.Views;
using DevExpress.XtraTab;
using quanlynhakho.Usercontrols;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraEditors;

namespace quanlynhakho
{
    public partial class fmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //private static XtraTabControl tabstatic;
        private readonly fmMain _fmmain;
        public fmMain(fmMain fmmain)
        {
            _fmmain = fmmain;
            InitializeComponent();
         //   autoloadThongKe();
         //   tabstatic = tabControl;

        }

        //==================
        //new HashMap to store pages, this is out of the function!  
        //private void MoveTabPages(XtraTabControl sourceTabControl, XtraTabControl targetTabControl)
        //{
        //    foreach (XtraTabPage tabPage in sourceTabControl.TabPages)
        //    {
        //        XtraTabPage newPage = new XtraTabPage();
        //        newPage.Text = tabPage.Text;
        //        newPage.Controls.AddRange(tabPage.Controls.OfType<Control>().ToArray());
        //        targetTabControl.TabPages.Add(newPage);
        //    }
        //}


        //======

        //#region Kiểm tra TabPabPage có tồn tại không
        //public static bool KiemTraTabPage(string Ten)
        //{
        //    bool ok = false;
        //    foreach (XtraTabPage tabpage in tabstatic.TabPages)
        //    {
        //        if (tabpage.Text == Ten)
        //        {
        //            return ok = true;
        //        }
        //    }
        //    return ok;
        //}
        //#region Tìm vị trí TabPage
        //public static int ViTriTabPage(string Ten)
        //{
        //    int vitri = 0;
        //    for (int i = 0; i < tabstatic.TabPages.Count; i++)
        //    {
        //        if (tabstatic.TabPages[i].Text == Ten)
        //            vitri = i;
        //    }
        //    return vitri;
        //}




        //void autoloadThongKe()
        //{
        //    //XtraTabControl tab = xtbc;
        //    //XtraTabPage page = new XtraTabPage();
        //    //tab.TabPages.Add(page);
        //    //tab.SelectedTabPage = page;
        //    ////Usercontrols.ucThongKe uc = new Usercontrols.ucThongKe();
        //    //page.Controls.Add(uc);
        //    //page.Text = "Thống kê";
        //    //uc.Dock = DockStyle.Fill;
            
        //}
        
        //private bool ExitFrom(XtraForm from)
        //{
        //    foreach (var child in MiChild)
        //    {
        //        if (child.Name == from.Name)
        //        {
        //            child.Activate();
        //            return true;
        //        }
        //    }
        //}

        private void btnNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnNhapHang_ItemClick_1(object sender, ItemClickEventArgs e)
        {

            XtraTabControl tab = xtbc;
            XtraTabPage page = new XtraTabPage();
            tab.TabPages.Add(page);
            tab.SelectedTabPage = page;
            Usercontrols.ucNhapKho uc = new Usercontrols.ucNhapKho();
            page.Controls.Add(uc);
            page.Text = "Nhập Kho";
            uc.Dock = DockStyle.Fill;
          //  _fmmain.ucNhapKho.SelectedTabPage = _fmmain.ucNhapKho;
            //ucNhapKho.SelectedTabPageIndex = 0;
            // page.PageVisible = !page.PageVisible;

        }

        private void btnTest_ItemClick(object sender, ItemClickEventArgs e)
        {
         
            XtraTabControl tab = xtbc;
            XtraTabPage page = new XtraTabPage();
        
            tab.TabPages.Add(page);
            tab.SelectedTabPage = page;
            Usercontrols.ucTest uc = new Usercontrols.ucTest();
            page.Controls.Add(uc);
            page.Text = "Test";
            uc.Dock = DockStyle.Fill;

            page.Show();
            page.PageVisible = true;
            //page.TabPages[0].selected = true;

        }

        private void btnQuanLyTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            fmManageUser f = new fmManageUser();
            f.Show();
        }

        private void btnXuatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraTabControl tab = xtbc;
            XtraTabPage page = new XtraTabPage();
            tab.TabPages.Add(page);
            tab.SelectedTabPage = page;
            Usercontrols.ucXuatKho uc = new Usercontrols.ucXuatKho();
            page.Controls.Add(uc);
            page.Text = "Xuất Kho";
            uc.Dock = DockStyle.Fill;

           // page.PageVisible = !page.PageVisible;
        }

        private void xtbc_Click(object sender, EventArgs e)
        {

        }

        private void btnTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {

            XtraTabControl tab = xtbc;
            XtraTabPage page = new XtraTabPage();
            tab.TabPages.Add(page);
            tab.SelectedTabPage = page;
            Usercontrols.ucTonKho uc = new Usercontrols.ucTonKho();
            page.Controls.Add(uc);
            page.Text = "Tồn Kho";
            uc.Dock = DockStyle.Fill;
        }

        private void btnDonVi_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraTabControl tab = xtbc;
            XtraTabPage page = new XtraTabPage();
            tab.TabPages.Add(page);
            tab.SelectedTabPage = page;
            Usercontrols.ucDonvi uc = new Usercontrols.ucDonvi();
            page.Controls.Add(uc);
            page.Text = "Đơn Vị";
            uc.Dock = DockStyle.Fill;
        }

        private void btnLoai_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t= 0;
            XtraTabControl tab = xtbc;
            XtraTabPage page = new XtraTabPage();
            tab.TabPages.Add(page);
            tab.SelectedTabPage = page;
            Usercontrols. ucLoaiSP uc = new Usercontrols.ucLoaiSP();
            page.Controls.Add(uc);
            page.Text = "Đơn Vị";
            uc.Dock = DockStyle.Fill;
            


        }

    }
}