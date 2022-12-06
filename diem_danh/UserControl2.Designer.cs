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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboPORT = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.comPortConnect = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.sqldataUART = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.xoavantay = new System.Windows.Forms.Button();
            this.suatenvantay = new System.Windows.Forms.Button();
            this.ThoiGian = new System.Windows.Forms.Timer(this.components);
            this.hienthi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.xuatExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqldataUART)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(44, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 84;
            this.label1.Text = "MÃ SỐ ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboPORT);
            this.groupControl1.Controls.Add(this.progressBar1);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.comPortConnect);
            this.groupControl1.Location = new System.Drawing.Point(27, 17);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(260, 181);
            this.groupControl1.TabIndex = 85;
            this.groupControl1.Text = "KẾT NỐI HỆ THỐNG";
            // 
            // comboPORT
            // 
            this.comboPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPORT.FormattingEnabled = true;
            this.comboPORT.Location = new System.Drawing.Point(111, 51);
            this.comboPORT.Name = "comboPORT";
            this.comboPORT.Size = new System.Drawing.Size(121, 23);
            this.comboPORT.TabIndex = 95;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 83);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(225, 23);
            this.progressBar1.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(5, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 93;
            this.label3.Text = "COM PORT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comPortConnect
            // 
            this.comPortConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.comPortConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.comPortConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comPortConnect.Image = global::diem_danh.Properties.Resources.insert_32x32;
            this.comPortConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comPortConnect.Location = new System.Drawing.Point(35, 113);
            this.comPortConnect.Margin = new System.Windows.Forms.Padding(4);
            this.comPortConnect.Name = "comPortConnect";
            this.comPortConnect.Size = new System.Drawing.Size(125, 40);
            this.comPortConnect.TabIndex = 93;
            this.comPortConnect.Text = "Kết Nối    ";
            this.comPortConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.comPortConnect.UseVisualStyleBackColor = false;
            this.comPortConnect.Click += new System.EventHandler(this.comPortConnect_Click_1);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.sqldataUART);
            this.groupControl2.Location = new System.Drawing.Point(324, 17);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(331, 295);
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
            this.sqldataUART.Size = new System.Drawing.Size(327, 270);
            this.sqldataUART.TabIndex = 0;
            this.sqldataUART.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sqldataUART_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(147, 266);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(112, 32);
            this.textBoxID.TabIndex = 3;
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(147, 226);
            this.textBoxNAME.Multiline = true;
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(112, 32);
            this.textBoxNAME.TabIndex = 4;
            // 
            // xoavantay
            // 
            this.xoavantay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.xoavantay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.xoavantay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xoavantay.Image = global::diem_danh.Properties.Resources.clear_32x32;
            this.xoavantay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoavantay.Location = new System.Drawing.Point(172, 316);
            this.xoavantay.Margin = new System.Windows.Forms.Padding(4);
            this.xoavantay.Name = "xoavantay";
            this.xoavantay.Size = new System.Drawing.Size(87, 40);
            this.xoavantay.TabIndex = 88;
            this.xoavantay.Text = "Xóa  ";
            this.xoavantay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xoavantay.UseVisualStyleBackColor = false;
            this.xoavantay.Click += new System.EventHandler(this.xoavantay_Click);
            // 
            // suatenvantay
            // 
            this.suatenvantay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.suatenvantay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.suatenvantay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suatenvantay.Image = global::diem_danh.Properties.Resources.bodetails_32x32;
            this.suatenvantay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suatenvantay.Location = new System.Drawing.Point(48, 316);
            this.suatenvantay.Margin = new System.Windows.Forms.Padding(4);
            this.suatenvantay.Name = "suatenvantay";
            this.suatenvantay.Size = new System.Drawing.Size(106, 40);
            this.suatenvantay.TabIndex = 89;
            this.suatenvantay.Text = "Sửa Tên";
            this.suatenvantay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.suatenvantay.UseVisualStyleBackColor = false;
            this.suatenvantay.Click += new System.EventHandler(this.suatenvantay_Click);
            // 
            // ThoiGian
            // 
            this.ThoiGian.Tick += new System.EventHandler(this.ThoiGian_Tick);
            // 
            // hienthi
            // 
            this.hienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.hienthi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hienthi.Image = global::diem_danh.Properties.Resources.insert_32x32;
            this.hienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hienthi.Location = new System.Drawing.Point(324, 317);
            this.hienthi.Margin = new System.Windows.Forms.Padding(4);
            this.hienthi.Name = "hienthi";
            this.hienthi.Size = new System.Drawing.Size(125, 40);
            this.hienthi.TabIndex = 90;
            this.hienthi.Text = "Hiển Thị   ";
            this.hienthi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hienthi.UseVisualStyleBackColor = false;
            this.hienthi.Click += new System.EventHandler(this.hienthi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(45, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 91;
            this.label2.Text = "HỌ TÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // xuatExcel
            // 
            this.xuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.xuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.xuatExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xuatExcel.Image = global::diem_danh.Properties.Resources.tableproperties_32x32;
            this.xuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xuatExcel.Location = new System.Drawing.Point(531, 317);
            this.xuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.xuatExcel.Name = "xuatExcel";
            this.xuatExcel.Size = new System.Drawing.Size(124, 40);
            this.xuatExcel.TabIndex = 92;
            this.xuatExcel.Text = "Xuất Excel ";
            this.xuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xuatExcel.UseVisualStyleBackColor = false;
            this.xuatExcel.Click += new System.EventHandler(this.xuatExcel_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.xuatExcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hienthi);
            this.Controls.Add(this.suatenvantay);
            this.Controls.Add(this.xoavantay);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(701, 376);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sqldataUART)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridView sqldataUART;
        private System.Windows.Forms.Button xoavantay;
        private System.Windows.Forms.Button suatenvantay;
        private System.Windows.Forms.Timer ThoiGian;
        private System.Windows.Forms.Button hienthi;
        private System.Windows.Forms.Button comPortConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button xuatExcel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboPORT;
    }
}
