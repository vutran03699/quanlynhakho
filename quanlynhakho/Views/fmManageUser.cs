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
        public fmManageUser()
        {
            InitializeComponent();
            LoadAccountList();
        }
       // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O6D11FL;Initial Catalog=QLKhoHang;Integrated Security=True");

        void LoadAccountList()
        {

            //string qr = "select * from [dbo].[USERS]";
         
         //   string query = "exec dbo.USP_GetAccountByUserName @Username";
           
            //dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query,new object[] { "admin" });
        }
    }
}
