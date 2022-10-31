using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace diem_danh
{
    public partial class UserControl1 : UserControl
    {
        Modify modify = new Modify();
        public UserControl1()
        {
            InitializeComponent();
            ThoiGian.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void HienThi_Click(object sender, EventArgs e)
        {
            dataDiemDanh.DataSource = modify.Table("Select * from DiemDanh");
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            //dataDiemDanh.DataSource = modify.Table("Select * from DiemDanh");
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {
            string name = TimKiem.Text.Trim();
            if (name == "")
            {
                dataDiemDanh.DataSource = modify.Table("Select * from DiemDanh");
            }
            else
            {
                string query = "select * from DiemDanh where Name like '%"+ name +"%'";
                dataDiemDanh.DataSource = modify.Table(query);
            }
        }

        private void dataDiemDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xoadiemdanh_Click(object sender, EventArgs e)
        {
            string t1 = "";
            string t2 = "";
            string t3 = "";
            string t4 = "";
            if (dataDiemDanh.Rows.Count > 1) // chọn dòng
            {
                t1 = dataDiemDanh.SelectedRows[0].Cells[0].Value.ToString();
                t2 = dataDiemDanh.SelectedRows[0].Cells[1].Value.ToString();
                t3 = dataDiemDanh.SelectedRows[0].Cells[2].Value.ToString();
                t4 = dataDiemDanh.SelectedRows[0].Cells[3].Value.ToString();
                string query = "DELETE DiemDanh ";
                query += "WHERE Time= '"+t3+"'";
                modify.Command(query);
                dataDiemDanh.DataSource = modify.Table("Select * from DiemDanh");
                MessageBox.Show("Đã xóa OK!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
