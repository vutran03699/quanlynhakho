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

namespace quanlynhakho
{
    public partial class fmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //bool flag = false;
        public fmMain()
        {
            InitializeComponent();
            autoloadThongKe();
        }

        void autoloadThongKe()
        {
            XtraTabControl tab = xtbc;
            XtraTabPage page = new XtraTabPage();
            tab.TabPages.Add(page);
            tab.SelectedTabPage = page;
            Usercontrols.ucThongKe uc = new Usercontrols.ucThongKe();
            page.Controls.Add(uc);
            page.Text = "Thống kê";
            uc.Dock = DockStyle.Fill;
            
        }
        

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
            //ucXuatHang xuathang = new ucXuatHang();
            fmLogin login = new fmLogin();
            login.MdiParent = this;
            login.Show();
        }

        private void xtbc_Click(object sender, EventArgs e)
        {

        }
    }
}