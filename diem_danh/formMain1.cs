using DevExpress.XtraBars;
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

namespace diem_danh
{
    public partial class formMain1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public formMain1()
        {
            InitializeComponent();
            ThoiGian.Start();
        }

        private void btDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void formMain1_Load(object sender, EventArgs e)
        {
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

        private void formMain1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void formMain1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình không", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btThemTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            formQuanLyTK f = new formQuanLyTK();
            f.Show();
        }

        private void btXoaTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            formXoaTaiKhoan f = new formXoaTaiKhoan();
            f.Show();
        }

        private void btDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            SuaMK f = new SuaMK();
            f.Show();
        }

        private void btQuenMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuenMK f = new QuenMK();
            f.Show();
        }

        private void btThemVanTay_ItemClick(object sender, ItemClickEventArgs e)
        {
            formVanTay f = new formVanTay();
            f.Show();
        }

        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            text_time.Text = DateTime.Now.ToLongTimeString();
            text_day.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btConnectPort_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không thể kết nối cổng serial!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}