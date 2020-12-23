namespace ThinkProManager.GUI
{
    partial class frmMain
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmiName = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiThongTin = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSanPham = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHoaDon = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiQuanLySanPham = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiQuanLyNhap = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiQuanLyNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiName,
            this.tsmiSanPham,
            this.tsmiHoaDon,
            this.tsmiNguoiDung});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(1207, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmiName
			// 
			this.tsmiName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThongTin,
            this.tsmiDoiMatKhau,
            this.tsmiLogout});
			this.tsmiName.Name = "tsmiName";
			this.tsmiName.Size = new System.Drawing.Size(113, 22);
			this.tsmiName.Text = "Chào, Nguyễn Duy";
			// 
			// tsmiThongTin
			// 
			this.tsmiThongTin.Name = "tsmiThongTin";
			this.tsmiThongTin.Size = new System.Drawing.Size(179, 22);
			this.tsmiThongTin.Text = "Thông Tin Tài Khoản";
			this.tsmiThongTin.Click += new System.EventHandler(this.tsmiThongTin_Click);
			// 
			// tsmiDoiMatKhau
			// 
			this.tsmiDoiMatKhau.Name = "tsmiDoiMatKhau";
			this.tsmiDoiMatKhau.Size = new System.Drawing.Size(179, 22);
			this.tsmiDoiMatKhau.Text = "Đổi Mật Khẩu";
			this.tsmiDoiMatKhau.Click += new System.EventHandler(this.tsmiDoiMatKhau_Click);
			// 
			// tsmiLogout
			// 
			this.tsmiLogout.Name = "tsmiLogout";
			this.tsmiLogout.Size = new System.Drawing.Size(179, 22);
			this.tsmiLogout.Text = "Đăng Xuất";
			this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);
			// 
			// tsmiSanPham
			// 
			this.tsmiSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQuanLySanPham,
            this.tsmiQuanLyNhap});
			this.tsmiSanPham.Name = "tsmiSanPham";
			this.tsmiSanPham.Size = new System.Drawing.Size(66, 22);
			this.tsmiSanPham.Text = "Sản Phẩm";
			// 
			// tsmiHoaDon
			// 
			this.tsmiHoaDon.Name = "tsmiHoaDon";
			this.tsmiHoaDon.Size = new System.Drawing.Size(63, 22);
			this.tsmiHoaDon.Text = "Hóa Đơn";
			// 
			// tsmiNguoiDung
			// 
			this.tsmiNguoiDung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQuanLyNguoiDung});
			this.tsmiNguoiDung.Name = "tsmiNguoiDung";
			this.tsmiNguoiDung.Size = new System.Drawing.Size(78, 22);
			this.tsmiNguoiDung.Text = "Người Dùng";
			// 
			// tsmiQuanLySanPham
			// 
			this.tsmiQuanLySanPham.Name = "tsmiQuanLySanPham";
			this.tsmiQuanLySanPham.Size = new System.Drawing.Size(180, 22);
			this.tsmiQuanLySanPham.Text = "Quản Lý Sản Phẩm";
			this.tsmiQuanLySanPham.Click += new System.EventHandler(this.tsmiQuanLySanPham_Click);
			// 
			// tsmiQuanLyNhap
			// 
			this.tsmiQuanLyNhap.Name = "tsmiQuanLyNhap";
			this.tsmiQuanLyNhap.Size = new System.Drawing.Size(180, 22);
			this.tsmiQuanLyNhap.Text = "Quản Lý Nhập";
			this.tsmiQuanLyNhap.Click += new System.EventHandler(this.tsmiQuanLyNhap_Click);
			// 
			// tsmiQuanLyNguoiDung
			// 
			this.tsmiQuanLyNguoiDung.Name = "tsmiQuanLyNguoiDung";
			this.tsmiQuanLyNguoiDung.Size = new System.Drawing.Size(180, 22);
			this.tsmiQuanLyNguoiDung.Text = "Quản Lý Người Dùng";
			this.tsmiQuanLyNguoiDung.Click += new System.EventHandler(this.tsmiQuanLyNguoiDung_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.BackgroundImage = global::ThinkProManager.Properties.Resources.backgound;
			this.ClientSize = new System.Drawing.Size(1207, 636);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmMain";
			this.Text = "Quản Lý - ThinkPro";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiName;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmiSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmiHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tsmiThongTin;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoiMatKhau;
		private System.Windows.Forms.ToolStripMenuItem tsmiNguoiDung;
		private System.Windows.Forms.ToolStripMenuItem tsmiQuanLySanPham;
		private System.Windows.Forms.ToolStripMenuItem tsmiQuanLyNhap;
		private System.Windows.Forms.ToolStripMenuItem tsmiQuanLyNguoiDung;
	}
}