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
            this.button10 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // comPortConnect
            // 
            this.comPortConnect.Location = new System.Drawing.Point(140, 147);
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
            this.comboPORT.Location = new System.Drawing.Point(130, 196);
            this.comboPORT.Name = "comboPORT";
            this.comboPORT.Size = new System.Drawing.Size(121, 21);
            this.comboPORT.TabIndex = 74;
            this.comboPORT.SelectedIndexChanged += new System.EventHandler(this.comboPORT_SelectedIndexChanged);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button10.Location = new System.Drawing.Point(266, 154);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 24);
            this.button10.TabIndex = 76;
            this.button10.Text = "COM PORT";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.comPortConnect);
            this.Controls.Add(this.comboPORT);
            this.Controls.Add(this.button10);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(675, 359);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button comPortConnect;
        private System.Windows.Forms.ComboBox comboPORT;
        private System.Windows.Forms.Button button10;
        private System.IO.Ports.SerialPort serialPort1;
    }
}
