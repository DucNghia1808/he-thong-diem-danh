using DevExpress.SpreadsheetSource.Implementation;
using ExcelDataReader;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace diem_danh
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        private void ImportExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {   

                            listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    } 
                    dataTable.Rows.Add(listRows.ToArray());
                }
                dataImport.DataSource = dataTable;
            }
        }
        //DataTableCollection tabCollection;
        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công!\n" + ex.Message, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            /*using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|**.xlsx" })
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textLinkFile.Text = openFileDialog.FileName;
                    using(var stream = File .Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tabCollection = result.Tables;
                            comboBox1.Items.Clear();
                            foreach (DataTable table in tabCollection)
                                comboBox1.Items.Add(table.TableName); // add sheet to combobox
                        }
                    }
                }
            }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt = tabCollection[comboBox1.SelectedItem.ToString()];
            //dataImport.DataSource = dt;
        }
    }
}
