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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.sqldataUART = new System.Windows.Forms.DataGridView();
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
            this.groupControl2.Size = new System.Drawing.Size(331, 327);
            this.groupControl2.TabIndex = 87;
            this.groupControl2.Text = "DỮ LIỆU NHẬN ĐƯỢC";
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 275);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(177, 302);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // sqldataUART
            // 
            this.sqldataUART.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqldataUART.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqldataUART.Location = new System.Drawing.Point(2, 23);
            this.sqldataUART.Name = "sqldataUART";
            this.sqldataUART.Size = new System.Drawing.Size(327, 302);
            this.sqldataUART.TabIndex = 0;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(701, 376);
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView sqldataUART;
    }
}
