using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using System.Collections;
using System.Text.RegularExpressions;

namespace diem_danh
{
    public partial class SuaMK : Form
    {
        public SuaMK()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void freeTextbox()
        {
            suaTK.Text = "";
            mkHienTai.Text = "";
            suaMK1.Text = "";
            suaXNMK.Text = "";
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{1,24}$");
            // check 6 ki tu tro len <24 ki tu
        }
        private void suaMKbt_Click(object sender, EventArgs e) // không cần quyền
        {
            string tentk = suaTK.Text;
            string mk = mkHienTai.Text;
            string mkmoi = suaMK1.Text;
            string mkmoi1 = suaXNMK.Text;
            if (tentk == "" || mk == "" || mkmoi == "" || mkmoi1 == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                freeTextbox();
            }
            if (modify.TaiKhoans("Select * from TaiKhoan where TaiKhoan = '" + tentk + "' and MatKhau = '"+ mk +"'").Count != 0) // nếu tài khoản đã tồn tại
            {
                if (mkmoi!= mkmoi1)
                {
                    MessageBox.Show("Vui lòng chính xác mật khẩu mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (!checkAccount(mkmoi))
                {
                    MessageBox.Show("Vui lòng nhập tên mật khẩu đúng với định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    freeTextbox();
                }
                else
                {
                    //string query = "Select *from TaiKhoan where TaiKhoan = '" + tentk + "'";
                    //modify.TaiKhoans(query)[0].MatKhau = mkmoi;
                    //string query = "Insert into TaiKhoan values ('" + tentk + "', '" + mkmoi + "', '" + "user" + "')";
                    //modify.Command(query);
                    string query = "update TaiKhoan set MatKhau = '" + mkmoi + "'";
                    query +=  "Where TaiKhoan ='"+tentk+"'";
                    modify.Command(query); 
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                freeTextbox();
            }
            else
            {
                MessageBox.Show("Tài khoản sai!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                freeTextbox();
            }
        }

        private void HuySuaMK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
