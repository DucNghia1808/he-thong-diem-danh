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
        private static string stringConnection1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Do_An\diem-danh1\diem_danh\vantay_nhanvien.mdf;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
        public static SqlConnection GetSqlConnection1() // ket noi voi sql van tay
        {
            return new SqlConnection(stringConnection1);
        }
    }
}
