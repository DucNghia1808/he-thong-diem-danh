using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace diem_danh
{
    class Connection
    {
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Do_An\diem_danh\diem_danh\TaiKhoan.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
