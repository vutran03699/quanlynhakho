using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlynhakho
{
    class ClassKetNoi
    {
        public static SqlConnection connect = new SqlConnection(@"data source=DESKTOP-O6D11FL;initial catalog=QuanLyKho;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
    }
}
