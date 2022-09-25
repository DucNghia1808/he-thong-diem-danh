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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace diem_danh
{
    public partial class DangNhap : Form
    {

        public DangNhap()
        {
            InitializeComponent();
            ThoiGian.Start();
        }
        Modify modify = new Modify();
        private void btDangNhap_Click(object sender, EventArgs e)
        {   // connect to database taikhoan_table
            string tentk = tkDangNhap.Text;
            string matkhau = mkDangNhap.Text;

            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string query = "Select * from TaiKhoan where TaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count>0) // 25'41 // check đăng nhập
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tkDangNhap.Text = "";
                    mkDangNhap.Text = "";
                    string sql1 = "select *from TaiKhoan where TaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "' and Quyen = '" + "admin" + "'";
                    //modify.Command(sql1);
                    if (modify.TaiKhoans(sql1).Count > 0) // 25'41  // check tài khoản có phải admin không
                    {
                        //MessageBox.Show("Đăng nhập với admin!");
                        formQuanLyTK.quyentaikhoan = true;
                        formXoaTaiKhoan.quyentaikhoan = true;
                        QuenMK.quyentaikhoan = true;
                    }
                    else
                    {
                        //MessageBox.Show("Đăng nhập với user!");
                        formQuanLyTK.quyentaikhoan = false;
                        formXoaTaiKhoan.quyentaikhoan = false;
                        QuenMK.quyentaikhoan = false;
                    }
                    formMain1 f = new formMain1();
                    f.Show();
                    this.Hide();
                    f.Logout += F_Logout;
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tkDangNhap.Text = "";
                    mkDangNhap.Text = "";
                }
            }


        }

        private void F_Logout(object sender, EventArgs e) // hàm ủy thác
        {
            (sender as formMain1).isExit = false;
            (sender as formMain1).Close();
            this.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            text_time.Text = DateTime.Now.ToLongTimeString();
            text_day.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void quenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK f = new QuenMK();
            f.Show();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            mkDangNhap.UseSystemPasswordChar = !mkDangNhap.UseSystemPasswordChar;
        }
    }
}
