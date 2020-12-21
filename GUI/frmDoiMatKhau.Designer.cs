namespace ThinkProManager.GUI
{
    partial class frmDoiMatKhau
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMKCU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMKMOI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXNMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(492, 73);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(245, 26);
            this.txtHoTen.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ Tên:";
            // 
            // txtMKCU
            // 
            this.txtMKCU.Location = new System.Drawing.Point(492, 129);
            this.txtMKCU.Name = "txtMKCU";
            this.txtMKCU.Size = new System.Drawing.Size(245, 26);
            this.txtMKCU.TabIndex = 10;
            this.txtMKCU.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật Khẩu Cũ:";
            // 
            // txtMKMOI
            // 
            this.txtMKMOI.Location = new System.Drawing.Point(492, 184);
            this.txtMKMOI.Name = "txtMKMOI";
            this.txtMKMOI.Size = new System.Drawing.Size(245, 26);
            this.txtMKMOI.TabIndex = 12;
            this.txtMKMOI.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật Khẩu Mới:";
            // 
            // txtXNMK
            // 
            this.txtXNMK.Location = new System.Drawing.Point(492, 238);
            this.txtXNMK.Name = "txtXNMK";
            this.txtXNMK.Size = new System.Drawing.Size(245, 26);
            this.txtXNMK.TabIndex = 14;
            this.txtXNMK.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Xác Nhận Mật Khẩu:";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(492, 286);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(174, 42);
            this.btnDoiMK.TabIndex = 15;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(46, 55);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(214, 220);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 6;
            this.pbAvatar.TabStop = false;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 350);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.txtXNMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMKMOI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMKCU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.TextBox txtMKCU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMKMOI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.TextBox txtXNMK;
    }
}