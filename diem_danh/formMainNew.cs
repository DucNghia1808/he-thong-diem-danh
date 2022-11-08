using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace diem_danh
{
    public partial class formMainNew : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public formMainNew()
        {
            InitializeComponent();
            ThoiGian.Start();
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void trangChinh_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
            userControl21.Hide();
            userControl31.Hide();

        }

        private void trangPhu_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl21.BringToFront();
            userControl11.Hide();
            userControl31.Hide();
        }
        private void trangDoThi_Click(object sender, EventArgs e)
        {
            userControl31.Show();
            userControl31.BringToFront();
            userControl11.Hide();
            userControl21.Hide();
        }

        private void formMainNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void formMainNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình không", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }


        private void ThoiGian_Tick(object sender, EventArgs e)
        {
            text_time.Text = DateTime.Now.ToLongTimeString();
            text_day.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timeHT.Text = DateTime.Now.ToLongTimeString();
            dayHT.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void formMainNew_Load(object sender, EventArgs e)
        {

        }

        private void toolthemtk_Click(object sender, EventArgs e)
        {
            formQuanLyTK f = new formQuanLyTK();
            f.Show();
        }

        private void toolXoatk_Click(object sender, EventArgs e)
        {
            formXoaTaiKhoan f = new formXoaTaiKhoan();
            f.Show();
        }

        private void toolQuenmk_Click(object sender, EventArgs e)
        {
            QuenMK f = new QuenMK();
            f.Show();
        }

        private void toolDoimk_Click(object sender, EventArgs e)
        {
            SuaMK f = new SuaMK();
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
        private void dữLiệuĐiểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void kếtNốiThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl21.BringToFront();
            userControl11.Hide();
            userControl31.Hide();
        }
        private void importFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl31.Show();
            userControl31.BringToFront();
            userControl11.Hide();
            userControl21.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
