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
            this.tsmiNhapHang = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmiNguoiDung,
            this.tsmiNhapHang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1811, 33);
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
            this.tsmiName.Size = new System.Drawing.Size(177, 29);
            this.tsmiName.Text = "Chào, Nguyễn Duy";
            // 
            // tsmiThongTin
            // 
            this.tsmiThongTin.Name = "tsmiThongTin";
            this.tsmiThongTin.Size = new System.Drawing.Size(273, 34);
            this.tsmiThongTin.Text = "Thông Tin Tài Khoản";
            this.tsmiThongTin.Click += new System.EventHandler(this.tsmiThongTin_Click);
            // 
            // tsmiDoiMatKhau
            // 
            this.tsmiDoiMatKhau.Name = "tsmiDoiMatKhau";
            this.tsmiDoiMatKhau.Size = new System.Drawing.Size(273, 34);
            this.tsmiDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.tsmiDoiMatKhau.Click += new System.EventHandler(this.tsmiDoiMatKhau_Click);
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(273, 34);
            this.tsmiLogout.Text = "Đăng Xuất";
            this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);
            // 
            // tsmiSanPham
            // 
            this.tsmiSanPham.Name = "tsmiSanPham";
            this.tsmiSanPham.Size = new System.Drawing.Size(107, 29);
            this.tsmiSanPham.Text = "Sản Phẩm";
            this.tsmiSanPham.Click += new System.EventHandler(this.tsmiSanPham_Click);
            // 
            // tsmiHoaDon
            // 
            this.tsmiHoaDon.Name = "tsmiHoaDon";
            this.tsmiHoaDon.Size = new System.Drawing.Size(100, 29);
            this.tsmiHoaDon.Text = "Hóa Đơn";
            // 
            // tsmiNguoiDung
            // 
            this.tsmiNguoiDung.Name = "tsmiNguoiDung";
            this.tsmiNguoiDung.Size = new System.Drawing.Size(127, 29);
            this.tsmiNguoiDung.Text = "Người Dùng";
            // 
            // tsmiNhapHang
            // 
            this.tsmiNhapHang.Name = "tsmiNhapHang";
            this.tsmiNhapHang.Size = new System.Drawing.Size(119, 29);
            this.tsmiNhapHang.Text = "Nhập Hàng";
            this.tsmiNhapHang.Click += new System.EventHandler(this.tsmiNhapHang_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::ThinkProManager.Properties.Resources.backgound;
            this.ClientSize = new System.Drawing.Size(1811, 978);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem tsmiNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem tsmiThongTin;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem tsmiNhapHang;
    }
}