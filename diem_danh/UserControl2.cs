using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ClipboardSource.SpreadsheetML;
using Newtonsoft.Json;
using System.Text.RegularExpressions; // thu vien


namespace diem_danh
{
    public partial class UserControl2 : UserControl
    {
        string Data = "";
        public UserControl2()
        {
            InitializeComponent();
            string[] myport = SerialPort.GetPortNames();
            comboPORT.Items.AddRange(myport);// get port
        }

        private void comPortConnect_Click(object sender, EventArgs e)
        {
            if (comboPORT.Text == "")
            {
                MessageBox.Show("Vui lòng kết nối cổng serial!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    comboPORT.Enabled = true;
                    comPortConnect.Text = "Kết Nối";
                    MessageBox.Show("Cổng serial đã đóng!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    serialPort1.PortName = comboPORT.Text;
                    serialPort1.BaudRate = 115200; // Int.Parse(comboBaudrate.Text) // baudrate
                    comboPORT.Enabled = false;
                    serialPort1.Open();
                    comPortConnect.Text = "Ngắt Kết Nối";
                    MessageBox.Show("Đã kết nối!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối cổng serial!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Modify modify = new Modify();
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // User form_load(send, e);


            if (serialPort1.IsOpen)
            {
               Data = serialPort1.ReadLine(); // sai hoài vì serialport đang mở và đọc
               this.Invoke(new EventHandler(ShowData));
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }

        }
        private void ShowData(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try // hàm bắt lỗi data json
                {
                    var Datajson = JsonConvert.DeserializeObject<dynamic>(Data.Trim());
                    //Datajson.a
                    string mode = Datajson.Mode; // lấy data json của từng nhãn
                    string admin = Datajson.Admin;
                    string id = Datajson.Id;
                    string name = Datajson.Name;
                    textBox1.Text = mode;
                    textBox2.Text = admin;
                    textBoxID.Text = id;
                    textBoxNAME.Text = name;
                    if (mode == "1" )  // mode == 1 them van tay
                    {
                        if (id == "0") {
                            string query = "update VanTay set Name = '" + textBoxNAME.Text + "'";
                            query += "Where ID ='" + textBoxID.Text + "'";
                            modify.Command(query);
                            MessageBox.Show("Đã thêm OK!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sqldataUART.DataSource = modify.Table("Select * from VanTay");
                        }
                        else
                        {
                            string query = "Insert into VanTay values ('" + textBoxNAME.Text + "', '" + textBoxID.Text + "')";
                            modify.Command(query);
                            serialPort1.Write("OK");
                            MessageBox.Show("Đã thêm OK!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sqldataUART.DataSource = modify.Table("Select * from VanTay");
                        }
                    }
                    else if (mode == "2") // mode == 2 xoa van tay (ten + id) trong sql
                    {
                        if (admin == "3") // thong bao xoa ok tu pc gui ve stm va gui lai
                        {
                            string choose = sqldataUART.SelectedRows[0].Cells[1].Value.ToString();
                            string query = "DELETE VanTay ";
                            query += "WHERE ID= '" + choose + "'";
                            if(choose != "0")
                            {
                                modify.Command(query);
                                MessageBox.Show("Đã xóa OK: "+id+"!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                sqldataUART.DataSource = modify.Table("Select * from VanTay");
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa vân tay admin!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            string query = "delete VanTay where ID= '" + id + "'";
                            modify.Command(query);
                            MessageBox.Show("Đã xóa OK!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sqldataUART.DataSource = modify.Table("Select * from VanTay");
                        }
                    }
                    else if (mode == "3") // diem danh
                    {
                        // tim id lay ten gui ve STM
                        string ten_vantay = "";
                        string query = "select Name from VanTay where ID='"+id+"'";
                        ten_vantay = modify.Command_getName(query);

                        //MessageBox.Show("Tên vân tay " + ten_vantay +"!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string dataName = "{\"NAME\":\"" + ten_vantay + "\"}";
                        serialPort1.WriteLine(dataName);
                        // ADD day time vao new table 
                        string text_time = DateTime.Now.ToLongTimeString();
                        string text_day = DateTime.Now.ToString("dd/MM/yyyy");
                        string querydiemdanh = "Insert into DiemDanh values ('" + ten_vantay + "', '" + id + "','" + text_time + "', '" + text_day + "' )";
                        modify.Command(querydiemdanh);
                       // MessageBox.Show("Đã thêm OK!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //sqldataUART.DataSource = modify.Table("Select * from DiemDanh");

                    }
                    Data = "";
                }
                catch (Exception)
                {

                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqldataUART.DataSource = modify.Table("Select * from VanTay");
            MessageBox.Show("Đã SHOW OK!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void xoavantay_Click(object sender, EventArgs e)
        {
            /*if (sqldataUART.Rows.Count > 1)
            {
                string choose = sqldataUART.SelectedRows[0].Cells[1].Value.ToString();
                string choose1 = sqldataUART.SelectedRows[0].Cells[1].Value.ToString();
                string query = "DELETE VanTay ";
                query += "WHERE ID= '" + choose + "'";
                if (choose.Trim() == "0") // k duoc xoa tk admin
                {
                    MessageBox.Show("Không thể xóa vân tay admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    modify.Command(query);
                    MessageBox.Show("Xóa vân tay thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        sqldataUART.DataSource = modify.Table("Select * from VanTay");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message + "!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/
            //// gửi tín hiệu cho STM32 xóa
            if (serialPort1.IsOpen)
            {
                string idvantay = "{\"Xoa\":\"" + textBoxID.Text + "\"}";
                serialPort1.WriteLine(idvantay);
            }
            else
            {
                MessageBox.Show("Chưa kết nối cổng com!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sqldataUART_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(sqldataUART.Rows.Count > 1) // chọn dòng
            {
                textBoxNAME.Text = sqldataUART.SelectedRows[0].Cells[0].Value.ToString();
                textBoxID.Text = sqldataUART.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void suatenvantay_Click(object sender, EventArgs e)
        {
            // kiểm tra nếu tên mới của ID chưa tồn tại
            string tenmoi = textBoxNAME.Text;
            if (tenmoi == "" || textBoxID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(modify.TaiKhoans("Select * from VanTay where Name = '" + tenmoi + "'").Count != 0) // nếu đã tồn tại
            {
                MessageBox.Show("Tên nhân viên đã tồn tại!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // nếu chưa tồn tại
            {
                string query = "update VanTay set Name = '" + tenmoi + "'";
                query += "Where ID ='" + textBoxID.Text + "'";
                modify.Command(query);
                MessageBox.Show("Đổi tên thành viên thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqldataUART.DataSource = modify.Table("Select * from VanTay");
            }

        }

        private void UserControl2_Leave(object sender, EventArgs e)
        {

        }

        private void xoatest_Click(object sender, EventArgs e)
        {
            //string dataxoa = "{\"Xoa\":\"1\"}";
            serialPort1.WriteLine("{\"Xoa\":\"1\"}");
           // serialPort1.WriteLine(dataxoa);
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            //text_time.Text = DateTime.Now.ToLongTimeString();
           // text_day.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
