namespace diem_danh
{
    partial class DangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.tkDangNhap = new System.Windows.Forms.TextBox();
            this.mkDangNhap = new System.Windows.Forms.TextBox();
            this.text_day = new System.Windows.Forms.Label();
            this.text_time = new System.Windows.Forms.Label();
            this.ThoiGian = new System.Windows.Forms.Timer(this.components);
            this.quenMK = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tkDangNhap
            // 
            this.tkDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tkDangNhap.Location = new System.Drawing.Point(602, 206);
            this.tkDangNhap.Multiline = true;
            this.tkDangNhap.Name = "tkDangNhap";
            this.tkDangNhap.Size = new System.Drawing.Size(170, 39);
            this.tkDangNhap.TabIndex = 2;
            this.tkDangNhap.TabStop = false;
            // 
            // mkDangNhap
            // 
            this.mkDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.mkDangNhap.Location = new System.Drawing.Point(602, 257);
            this.mkDangNhap.Multiline = true;
            this.mkDangNhap.Name = "mkDangNhap";
            this.mkDangNhap.PasswordChar = '*';
            this.mkDangNhap.Size = new System.Drawing.Size(170, 39);
            this.mkDangNhap.TabIndex = 3;
            this.mkDangNhap.UseSystemPasswordChar = true;
            // 
            // text_day
            // 
            this.text_day.AutoSize = true;
            this.text_day.BackColor = System.Drawing.Color.Transparent;
            this.text_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_day.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.text_day.Location = new System.Drawing.Point(228, 355);
            this.text_day.Name = "text_day";
            this.text_day.Size = new System.Drawing.Size(33, 16);
            this.text_day.TabIndex = 71;
            this.text_day.Text = "day";
            // 
            // text_time
            // 
            this.text_time.AutoSize = true;
            this.text_time.BackColor = System.Drawing.Color.Transparent;
            this.text_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_time.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.text_time.Location = new System.Drawing.Point(65, 355);
            this.text_time.Name = "text_time";
            this.text_time.Size = new System.Drawing.Size(36, 16);
            this.text_time.TabIndex = 70;
            this.text_time.Text = "time";
            // 
            // ThoiGian
            // 
            this.ThoiGian.Tick += new System.EventHandler(this.ThoiGian_Tick);
            // 
            // quenMK
            // 
            this.quenMK.AutoSize = true;
            this.quenMK.BackColor = System.Drawing.Color.Transparent;
            this.quenMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.quenMK.Location = new System.Drawing.Point(669, 308);
            this.quenMK.Name = "quenMK";
            this.quenMK.Size = new System.Drawing.Size(109, 16);
            this.quenMK.TabIndex = 73;
            this.quenMK.TabStop = true;
            this.quenMK.Text = "Quên mật khẩu";
            this.quenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quenMK_LinkClicked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(577, 100);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 82;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::diem_danh.Properties.Resources.encryptdocument_32x32;
            this.pictureBox3.Location = new System.Drawing.Point(542, 257);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 83;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::diem_danh.Properties.Resources.bouser_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(542, 206);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label8.Location = new System.Drawing.Point(542, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 22);
            this.label8.TabIndex = 82;
            this.label8.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btDangNhap.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btDangNhap.ForeColor = System.Drawing.Color.White;
            this.btDangNhap.Image = global::diem_danh.Properties.Resources.assignto_32x32;
            this.btDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDangNhap.Location = new System.Drawing.Point(542, 333);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(124, 43);
            this.btDangNhap.TabIndex = 4;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btThoat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.Image = global::diem_danh.Properties.Resources.close_32x32;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(672, 333);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 43);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "     Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(65, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(381, 32);
            this.label9.TabIndex = 92;
            this.label9.Text = "SVTH: Nguyễn Đức Nghĩa             MSSV: N18DCDT036\r\nGVHD: TS. Nguyễn Trọng Kiên\r" +
    "\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(45, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(433, 72);
            this.label14.TabIndex = 91;
            this.label14.Text = "Đề Tài: Xây Dựng Hệ Thống Điểm Danh Vân Tay \r\nSử Dụng Vi Điều Khiển STM32 \r\nvà Gi" +
    "ao Diện Window Form";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(152, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 26);
            this.label7.TabIndex = 90;
            this.label7.Text = "ĐỒ ÁN TỐT NGHIỆP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(45, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 66);
            this.label3.TabIndex = 85;
            this.label3.Text = "HỌC VIỆN CÔNG NGHỆ BƯU CHÍNH VIẾN THÔNG \r\nCƠ SỞ TẠI TP HCM\r\nKHOA KĨ THUẬT ĐIỆN TỬ" +
    " II";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(211, 121);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(78, 77);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 89;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(110, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 86;
            this.label4.Text = "---------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(236, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 26);
            this.label6.TabIndex = 88;
            this.label6.Text = "°°°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(268, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 87;
            this.label5.Text = "---------------";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(538, 308);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 94;
            this.checkBox1.Text = "Hiện Mật Khẩu";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 410);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.mkDangNhap);
            this.Controls.Add(this.quenMK);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tkDangNhap);
            this.Controls.Add(this.text_day);
            this.Controls.Add(this.text_time);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangNhap_FormClosed);
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tkDangNhap;
        private System.Windows.Forms.TextBox mkDangNhap;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label text_day;
        private System.Windows.Forms.Label text_time;
        private System.Windows.Forms.Timer ThoiGian;
        private System.Windows.Forms.LinkLabel quenMK;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

