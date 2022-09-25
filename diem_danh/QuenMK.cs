using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace diem_danh
{
    public partial class QuenMK : Form
    {
        public static bool quyentaikhoan = false;
        public QuenMK()
        {
            InitializeComponent();
            QuenTK.Text = "";
            mkHienTai.Text = "";
        }
        Modify modify = new Modify();
        private void LayMK_Click(object sender, EventArgs e)
        {
            if ( quyentaikhoan == true)
            {
                string tentk = QuenTK.Text;
                if (tentk.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đúng tài khoản đăng kí!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string query = "Select *from TaiKhoan where TaiKhoan = '" + tentk + "'";
                    if (modify.TaiKhoans(query).Count() != 0)
                    {
                        mkHienTai.Text = modify.TaiKhoans(query)[0].MatKhau;
                    }
                    else
                    {
                       MessageBox.Show("Tài khoản chưa được đăng kí!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập với tài khoản admin để lấy lại mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HuyLayMK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuenMK_Load(object sender, EventArgs e)
        {

        }
    }
}
