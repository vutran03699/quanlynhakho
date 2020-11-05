using DevExpress.Charts.Native;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhakho.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            { if (instance == null) { instance = new AccountDAO(); } return instance; }
            private set { instance = value; }
        }
        private AccountDAO(){}

        public bool Login(string Username, string Password)
        {
            //fix loi   sql Injection
            string query = "USP_Login @Username , @Password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Username, Password });
                return result.Rows.Count > 0;
        }

    }

    
}
