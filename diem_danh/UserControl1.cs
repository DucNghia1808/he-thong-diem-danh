using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;


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
            dataDiemDanh.DataSource = modify.Table("Select * from DiemDanh1");
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            dataDiemDanh.DataSource = modify.Table("Select * from DiemDanh1");
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {
            string name = TimKiem.Text.Trim();
            if (name == "")
            {
                dataDiemDanh.DataSource = modify.Table("Select * from DiemDanh1");
            }
            else
            {
                string query = "select * from DiemDanh1 where Name like '%"+ name +"%'";
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
                string query = "DELETE DiemDanh1 ";
                query += "WHERE TimeIN= '"+t3+"'";
                modify.Command(query);
                dataDiemDanh.DataSource = modify.Table("Select * from DiemDanh1");
                MessageBox.Show("Đã xóa OK!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for(int i = 0; i< dataDiemDanh.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dataDiemDanh.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataDiemDanh.Rows.Count; i++)
            {
                for(int j = 0; j < dataDiemDanh.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataDiemDanh.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
