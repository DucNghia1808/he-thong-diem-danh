namespace diem_danh
{
    partial class UserControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.dataDiemDanh = new System.Windows.Forms.DataGridView();
            this.xoadiemdanh = new System.Windows.Forms.Button();
            this.TimKiem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HienThi = new System.Windows.Forms.Button();
            this.ThoiGian = new System.Windows.Forms.Timer(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDiemDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataDiemDanh
            // 
            this.dataDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDiemDanh.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataDiemDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDiemDanh.Location = new System.Drawing.Point(2, 23);
            this.dataDiemDanh.Name = "dataDiemDanh";
            this.dataDiemDanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDiemDanh.Size = new System.Drawing.Size(561, 351);
            this.dataDiemDanh.TabIndex = 0;
            this.dataDiemDanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDiemDanh_CellClick);
            // 
            // xoadiemdanh
            // 
            this.xoadiemdanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.xoadiemdanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.xoadiemdanh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xoadiemdanh.Image = global::diem_danh.Properties.Resources.clear_32x32;
            this.xoadiemdanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoadiemdanh.Location = new System.Drawing.Point(12, 205);
            this.xoadiemdanh.Margin = new System.Windows.Forms.Padding(4);
            this.xoadiemdanh.Name = "xoadiemdanh";
            this.xoadiemdanh.Size = new System.Drawing.Size(110, 40);
            this.xoadiemdanh.TabIndex = 89;
            this.xoadiemdanh.Text = "Xóa      ";
            this.xoadiemdanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xoadiemdanh.UseVisualStyleBackColor = false;
            this.xoadiemdanh.Click += new System.EventHandler(this.xoadiemdanh_Click);
            // 
            // TimKiem
            // 
            this.TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.TimKiem.Location = new System.Drawing.Point(8, 104);
            this.TimKiem.Multiline = true;
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(117, 36);
            this.TimKiem.TabIndex = 90;
            this.TimKiem.TextChanged += new System.EventHandler(this.TimKiem_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 94;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HienThi
            // 
            this.HienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.HienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.HienThi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HienThi.Image = global::diem_danh.Properties.Resources.insert_32x32;
            this.HienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HienThi.Location = new System.Drawing.Point(12, 157);
            this.HienThi.Margin = new System.Windows.Forms.Padding(4);
            this.HienThi.Name = "HienThi";
            this.HienThi.Size = new System.Drawing.Size(110, 40);
            this.HienThi.TabIndex = 95;
            this.HienThi.Text = "Hiển Thị";
            this.HienThi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HienThi.UseVisualStyleBackColor = false;
            this.HienThi.Click += new System.EventHandler(this.HienThi_Click);
            // 
            // ThoiGian
            // 
            this.ThoiGian.Interval = 10000;
            this.ThoiGian.Tick += new System.EventHandler(this.ThoiGian_Tick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataDiemDanh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(565, 376);
            this.groupControl1.TabIndex = 96;
            this.groupControl1.Text = "THÔNG TIN ĐIỂM DANH";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.xoadiemdanh);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.HienThi);
            this.splitContainer1.Panel2.Controls.Add(this.TimKiem);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(701, 376);
            this.splitContainer1.SplitterDistance = 565;
            this.splitContainer1.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 98;
            this.label1.Text = "QUẢN LÝ THÔNG TIN\r\n         NHÂN VIÊN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(7, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 48);
            this.label7.TabIndex = 97;
            this.label7.Text = "ĐỒ ÁN TỐT NGHIỆP\r\nNGUYỄN ĐƯC NGHĨA\r\n       N18DCDT036\r\n";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::diem_danh.Properties.Resources.tableproperties_32x32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 253);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 96;
            this.button2.Text = "FileExcel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(701, 376);
            ((System.ComponentModel.ISupportInitialize)(this.dataDiemDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDiemDanh;
        private System.Windows.Forms.Button xoadiemdanh;
        private System.Windows.Forms.TextBox TimKiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button HienThi;
        private System.Windows.Forms.Timer ThoiGian;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}
