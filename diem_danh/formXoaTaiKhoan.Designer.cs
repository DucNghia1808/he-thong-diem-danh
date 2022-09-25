namespace diem_danh
{
    partial class formXoaTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formXoaTaiKhoan));
            this.dataGridViewQuanLyTK = new System.Windows.Forms.DataGridView();
            this.QuanLyHuy = new System.Windows.Forms.Button();
            this.QuanLyTK = new System.Windows.Forms.TextBox();
            this.QuanLyXem = new System.Windows.Forms.Button();
            this.QuanLyXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuanLyTK
            // 
            this.dataGridViewQuanLyTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuanLyTK.Location = new System.Drawing.Point(31, 109);
            this.dataGridViewQuanLyTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewQuanLyTK.Name = "dataGridViewQuanLyTK";
            this.dataGridViewQuanLyTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuanLyTK.Size = new System.Drawing.Size(318, 258);
            this.dataGridViewQuanLyTK.TabIndex = 21;
            this.dataGridViewQuanLyTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuanLyTK_CellClick);
            // 
            // QuanLyHuy
            // 
            this.QuanLyHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.QuanLyHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.QuanLyHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuanLyHuy.Image = global::diem_danh.Properties.Resources.close_32x32;
            this.QuanLyHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuanLyHuy.Location = new System.Drawing.Point(274, 375);
            this.QuanLyHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuanLyHuy.Name = "QuanLyHuy";
            this.QuanLyHuy.Size = new System.Drawing.Size(75, 40);
            this.QuanLyHuy.TabIndex = 20;
            this.QuanLyHuy.Text = "Hủy";
            this.QuanLyHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QuanLyHuy.UseVisualStyleBackColor = false;
            this.QuanLyHuy.Click += new System.EventHandler(this.QuanLyHuy_Click);
            // 
            // QuanLyTK
            // 
            this.QuanLyTK.Location = new System.Drawing.Point(189, 59);
            this.QuanLyTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuanLyTK.Multiline = true;
            this.QuanLyTK.Name = "QuanLyTK";
            this.QuanLyTK.Size = new System.Drawing.Size(160, 33);
            this.QuanLyTK.TabIndex = 13;
            // 
            // QuanLyXem
            // 
            this.QuanLyXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.QuanLyXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.QuanLyXem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuanLyXem.Image = global::diem_danh.Properties.Resources.insert_32x32;
            this.QuanLyXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuanLyXem.Location = new System.Drawing.Point(151, 375);
            this.QuanLyXem.Margin = new System.Windows.Forms.Padding(4);
            this.QuanLyXem.Name = "QuanLyXem";
            this.QuanLyXem.Size = new System.Drawing.Size(75, 40);
            this.QuanLyXem.TabIndex = 22;
            this.QuanLyXem.Text = "Xem";
            this.QuanLyXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QuanLyXem.UseVisualStyleBackColor = false;
            this.QuanLyXem.Click += new System.EventHandler(this.QuanLyXem_Click);
            // 
            // QuanLyXoa
            // 
            this.QuanLyXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.QuanLyXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.QuanLyXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuanLyXoa.Image = global::diem_danh.Properties.Resources.clear_32x32;
            this.QuanLyXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuanLyXoa.Location = new System.Drawing.Point(31, 375);
            this.QuanLyXoa.Margin = new System.Windows.Forms.Padding(4);
            this.QuanLyXoa.Name = "QuanLyXoa";
            this.QuanLyXoa.Size = new System.Drawing.Size(75, 40);
            this.QuanLyXoa.TabIndex = 19;
            this.QuanLyXoa.Text = "Xóa";
            this.QuanLyXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QuanLyXoa.UseVisualStyleBackColor = false;
            this.QuanLyXoa.Click += new System.EventHandler(this.QuanLyXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 94;
            this.label2.Text = "TÀI KHOẢN CẦN XÓA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(97, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 26);
            this.label7.TabIndex = 95;
            this.label7.Text = "XÓA TÀI KHOẢN";
            // 
            // formXoaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 428);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuanLyXem);
            this.Controls.Add(this.dataGridViewQuanLyTK);
            this.Controls.Add(this.QuanLyHuy);
            this.Controls.Add(this.QuanLyXoa);
            this.Controls.Add(this.QuanLyTK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formXoaTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formXoaTaiKhoan";
            this.Load += new System.EventHandler(this.formXoaTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuanLyTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewQuanLyTK;
        private System.Windows.Forms.Button QuanLyHuy;
        private System.Windows.Forms.Button QuanLyXoa;
        private System.Windows.Forms.TextBox QuanLyTK;
        private System.Windows.Forms.Button QuanLyXem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}