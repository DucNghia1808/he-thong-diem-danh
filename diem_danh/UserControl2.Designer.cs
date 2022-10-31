namespace diem_danh
{
    partial class UserControl2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.comPortConnect = new System.Windows.Forms.Button();
            this.comboPORT = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.sqldataUART = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.xoavantay = new System.Windows.Forms.Button();
            this.suatenvantay = new System.Windows.Forms.Button();
            this.xoatest = new System.Windows.Forms.Button();
            this.ThoiGian = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqldataUART)).BeginInit();
            this.SuspendLayout();
            // 
            // comPortConnect
            // 
            this.comPortConnect.Location = new System.Drawing.Point(14, 95);
            this.comPortConnect.Name = "comPortConnect";
            this.comPortConnect.Size = new System.Drawing.Size(111, 31);
            this.comPortConnect.TabIndex = 75;
            this.comPortConnect.Text = "Connect";
            this.comPortConnect.UseVisualStyleBackColor = true;
            this.comPortConnect.Click += new System.EventHandler(this.comPortConnect_Click);
            // 
            // comboPORT
            // 
            this.comboPORT.FormattingEnabled = true;
            this.comboPORT.Location = new System.Drawing.Point(15, 57);
            this.comboPORT.Name = "comboPORT";
            this.comboPORT.Size = new System.Drawing.Size(111, 21);
            this.comboPORT.TabIndex = 74;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(34, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 44);
            this.label1.TabIndex = 84;
            this.label1.Text = "TRẠNG THÁI\r\n  THIẾT BỊ 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboPORT);
            this.groupControl1.Controls.Add(this.comPortConnect);
            this.groupControl1.Location = new System.Drawing.Point(38, 16);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(206, 181);
            this.groupControl1.TabIndex = 85;
            this.groupControl1.Text = "KẾT NỐI HỆ THỐNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(34, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 44);
            this.label2.TabIndex = 86;
            this.label2.Text = "TRẠNG THÁI\r\n  THIẾT BỊ 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.sqldataUART);
            this.groupControl2.Location = new System.Drawing.Point(324, 17);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(331, 224);
            this.groupControl2.TabIndex = 87;
            this.groupControl2.Text = "DANH SÁCH VÂN TAY";
            // 
            // sqldataUART
            // 
            this.sqldataUART.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqldataUART.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqldataUART.Location = new System.Drawing.Point(2, 23);
            this.sqldataUART.Name = "sqldataUART";
            this.sqldataUART.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sqldataUART.Size = new System.Drawing.Size(327, 199);
            this.sqldataUART.TabIndex = 0;
            this.sqldataUART.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sqldataUART_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(177, 275);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 3;
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(177, 302);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(100, 20);
            this.textBoxNAME.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 76;
            this.button1.Text = "Hiển Thị";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xoavantay
            // 
            this.xoavantay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.xoavantay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.xoavantay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xoavantay.Image = global::diem_danh.Properties.Resources.clear_32x32;
            this.xoavantay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoavantay.Location = new System.Drawing.Point(324, 264);
            this.xoavantay.Margin = new System.Windows.Forms.Padding(4);
            this.xoavantay.Name = "xoavantay";
            this.xoavantay.Size = new System.Drawing.Size(75, 40);
            this.xoavantay.TabIndex = 88;
            this.xoavantay.Text = "Xóa";
            this.xoavantay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xoavantay.UseVisualStyleBackColor = false;
            this.xoavantay.Click += new System.EventHandler(this.xoavantay_Click);
            // 
            // suatenvantay
            // 
            this.suatenvantay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.suatenvantay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.suatenvantay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suatenvantay.Image = global::diem_danh.Properties.Resources.clear_32x32;
            this.suatenvantay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suatenvantay.Location = new System.Drawing.Point(541, 264);
            this.suatenvantay.Margin = new System.Windows.Forms.Padding(4);
            this.suatenvantay.Name = "suatenvantay";
            this.suatenvantay.Size = new System.Drawing.Size(75, 40);
            this.suatenvantay.TabIndex = 89;
            this.suatenvantay.Text = "Sửa";
            this.suatenvantay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.suatenvantay.UseVisualStyleBackColor = false;
            this.suatenvantay.Click += new System.EventHandler(this.suatenvantay_Click);
            // 
            // xoatest
            // 
            this.xoatest.Location = new System.Drawing.Point(324, 322);
            this.xoatest.Name = "xoatest";
            this.xoatest.Size = new System.Drawing.Size(111, 31);
            this.xoatest.TabIndex = 90;
            this.xoatest.Text = "Xoa";
            this.xoatest.UseVisualStyleBackColor = true;
            this.xoatest.Click += new System.EventHandler(this.xoatest_Click);
            // 
            // ThoiGian
            // 
            this.ThoiGian.Tick += new System.EventHandler(this.ThoiGian_Tick);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.xoatest);
            this.Controls.Add(this.suatenvantay);
            this.Controls.Add(this.xoavantay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(701, 376);
            this.Leave += new System.EventHandler(this.UserControl2_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sqldataUART)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button comPortConnect;
        private System.Windows.Forms.ComboBox comboPORT;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView sqldataUART;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button xoavantay;
        private System.Windows.Forms.Button suatenvantay;
        private System.Windows.Forms.Button xoatest;
        private System.Windows.Forms.Timer ThoiGian;
    }
}
