using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // thu vien
namespace diem_danh
{
    public partial class formQuanLyTK : Form
    {
        public static bool quyentaikhoan = false;

        public formQuanLyTK()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{1,24}$");
            // check 6 ki tu tro len <24 ki tu
        }
        public bool CheckEmail(string em) ////////// k dung
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,30}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void freeTextbox()
        {
            QuanLyTK.Text = "";
            QuanLyMK.Text = "";
            QuanLyXnMK.Text = "";
        }
        private void QuanLyThem_Click(object sender, EventArgs e) // check dang ki tai khoan moi
        {
            if (quyentaikhoan == true)
            {
                string tentk = QuanLyTK.Text;
                string matkhau = QuanLyMK.Text;
                string xnmatkhau = QuanLyXnMK.Text;
                if (!checkAccount(tentk))
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản đúng với định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    freeTextbox();
                    return;
                }
                if (!checkAccount(matkhau))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu đúng với định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    freeTextbox();
                    return;
                }
                if (xnmatkhau != matkhau)
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    freeTextbox();
                    return;
                }
                // thêm vào một số kiểm tra nếu cần
                if (modify.TaiKhoans("Select * from TaiKhoan where TaiKhoan = '" + tentk + "'").Count != 0) // nếu tài khoản đã tồn tại
                {
                    MessageBox.Show("Tài khoản đã được đăng kí!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    freeTextbox();
                    return; // 44'53
                }
                else
                {
                    string query = "Insert into TaiKhoan values ('" + tentk + "', '" + matkhau + "', '" + "user" + "')";
                    modify.Command(query);
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    freeTextbox();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập với admin để thêm tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void QuanLyHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyXem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewQuanLyTK1.DataSource = modify.Table("Select * from TaiKhoan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formQuanLyTK_Load(object sender, EventArgs e)
        {
            if (quyentaikhoan == true)
            {
                // show data bang TaiKhoan
                QuanLyXem.Enabled = true;
            }
            else
            {
                QuanLyXem.Enabled = false;
            }
        }

        private void dataGridViewQuanLyTK1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
