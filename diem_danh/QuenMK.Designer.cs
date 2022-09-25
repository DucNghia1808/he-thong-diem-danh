namespace diem_danh
{
    partial class QuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMK));
            this.QuenTK = new System.Windows.Forms.TextBox();
            this.LayMK = new System.Windows.Forms.Button();
            this.mkHienTai = new System.Windows.Forms.TextBox();
            this.HuyLayMK = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // QuenTK
            // 
            this.QuenTK.Location = new System.Drawing.Point(102, 71);
            this.QuenTK.Multiline = true;
            this.QuenTK.Name = "QuenTK";
            this.QuenTK.Size = new System.Drawing.Size(169, 40);
            this.QuenTK.TabIndex = 1;
            // 
            // LayMK
            // 
            this.LayMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LayMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.LayMK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LayMK.Image = global::diem_danh.Properties.Resources.assigntome_32x32;
            this.LayMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LayMK.Location = new System.Drawing.Point(40, 181);
            this.LayMK.Name = "LayMK";
            this.LayMK.Size = new System.Drawing.Size(124, 44);
            this.LayMK.TabIndex = 2;
            this.LayMK.Text = "Lấy lại MK";
            this.LayMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LayMK.UseVisualStyleBackColor = false;
            this.LayMK.Click += new System.EventHandler(this.LayMK_Click);
            // 
            // mkHienTai
            // 
            this.mkHienTai.Location = new System.Drawing.Point(102, 125);
            this.mkHienTai.Multiline = true;
            this.mkHienTai.Name = "mkHienTai";
            this.mkHienTai.ReadOnly = true;
            this.mkHienTai.Size = new System.Drawing.Size(169, 40);
            this.mkHienTai.TabIndex = 3;
            // 
            // HuyLayMK
            // 
            this.HuyLayMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.HuyLayMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.HuyLayMK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HuyLayMK.Image = global::diem_danh.Properties.Resources.close_32x32;
            this.HuyLayMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HuyLayMK.Location = new System.Drawing.Point(170, 181);
            this.HuyLayMK.Name = "HuyLayMK";
            this.HuyLayMK.Size = new System.Drawing.Size(101, 44);
            this.HuyLayMK.TabIndex = 5;
            this.HuyLayMK.Text = "Hủy    ";
            this.HuyLayMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HuyLayMK.UseVisualStyleBackColor = false;
            this.HuyLayMK.Click += new System.EventHandler(this.HuyLayMK_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::diem_danh.Properties.Resources.encryptdocument_32x32;
            this.pictureBox3.Location = new System.Drawing.Point(40, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 85;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::diem_danh.Properties.Resources.bouser_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(40, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(58, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 26);
            this.label7.TabIndex = 91;
            this.label7.Text = "LẤY LẠI MẬT KHẨU";
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 249);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.HuyLayMK);
            this.Controls.Add(this.mkHienTai);
            this.Controls.Add(this.LayMK);
            this.Controls.Add(this.QuenTK);
            this.Name = "QuenMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMK";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.QuenMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox QuenTK;
        private System.Windows.Forms.Button LayMK;
        private System.Windows.Forms.TextBox mkHienTai;
        private System.Windows.Forms.Button HuyLayMK;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
    }
}