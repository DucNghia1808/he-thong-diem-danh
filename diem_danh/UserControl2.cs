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


namespace diem_danh
{
    public partial class UserControl2 : UserControl
    {
        String Data = "";
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
                    comPortConnect.Text = "Connect";
                    MessageBox.Show("Cổng serial đã đóng!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    serialPort1.PortName = comboPORT.Text;
                    serialPort1.BaudRate = 115200; // Int.Parse(comboBaudrate.Text) // baudrate
                    comboPORT.Enabled = false;
                    serialPort1.Open();
                    comPortConnect.Text = "Disconnect";
                    MessageBox.Show("Đã kết nối!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối cổng serial!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //listBox1.Items.Clear();
            //Data = serialPort1.ReadExisting();
            //Invoke(new MethodInvoker(() => listBox1.Items.Add(Data)));
            if (serialPort1.IsOpen)
            {
               Data = serialPort1.ReadLine();
               this.Invoke(new EventHandler(ShowData));
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
                    textBox3.Text = id;
                    textBox4.Text = name;


                    Data = "";
                }
                catch (Exception)
                {

                }
            }
            
        }
    }
}
