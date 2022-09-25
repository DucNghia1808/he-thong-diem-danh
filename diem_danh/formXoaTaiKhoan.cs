using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diem_danh
{
    public partial class formXoaTaiKhoan : Form
    {
        public formXoaTaiKhoan()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void QuanLyHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static bool quyentaikhoan = false;

        private void QuanLyXoa_Click(object sender, EventArgs e)
        {
            if (quyentaikhoan == true)
            {
                //string tentk = QuanLyTK.Text;
               
                if (dataGridViewQuanLyTK.Rows.Count > 1 )
                {
                    string choose = dataGridViewQuanLyTK.SelectedRows[0].Cells[0].Value.ToString();
                    string query = "DELETE TaiKhoan ";
                    query += "WHERE TaiKhoan= '" + choose + "'";
                    if ( choose.Trim() == "a") // k duoc xoa tk admin
                    {
                        MessageBox.Show("Không thể xóa tài khoản admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)== DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        {
                            dataGridViewQuanLyTK.DataSource = modify.Table("Select * from TaiKhoan");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message + "!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập với tài khoản admin để xóa tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void QuanLyXem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewQuanLyTK.DataSource = modify.Table("Select * from TaiKhoan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message + "!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formXoaTaiKhoan_Load(object sender, EventArgs e)
        {
            if (quyentaikhoan == true)
            {
                QuanLyXem.Enabled = true;
            }
            else
            {
                QuanLyXem.Enabled = false;
            }
        }

        private void dataGridViewQuanLyTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
