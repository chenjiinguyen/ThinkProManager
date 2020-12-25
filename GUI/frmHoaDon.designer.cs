namespace ThinkProManager.GUI
{
    partial class frmHoaDon 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.grboxThongTinChung = new System.Windows.Forms.GroupBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.gxboxThongTinMatHang = new System.Windows.Forms.GroupBox();
            this.btnXoaCTHD = new System.Windows.Forms.Button();
            this.btnThemCTHD = new System.Windows.Forms.Button();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.gridViewHD = new System.Windows.Forms.DataGridView();
            this.ID_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_BRAND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.btnInHoaDon = new System.Windows.Forms.ToolStripButton();
            this.btnLuuThayDoi = new System.Windows.Forms.ToolStripButton();
            this.grbxHoaDon = new System.Windows.Forms.GroupBox();
            this.cboxMaHoaDon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuongSanPham = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grboxThongTinChung.SuspendLayout();
            this.gxboxThongTinMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHD)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grbxHoaDon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxThongTinChung
            // 
            this.grboxThongTinChung.Controls.Add(this.txtMaHoaDon);
            this.grboxThongTinChung.Controls.Add(this.cboMaKH);
            this.grboxThongTinChung.Controls.Add(this.lblMaKH);
            this.grboxThongTinChung.Controls.Add(this.cboMaNV);
            this.grboxThongTinChung.Controls.Add(this.lblMaNV);
            this.grboxThongTinChung.Controls.Add(this.dtpNgayBan);
            this.grboxThongTinChung.Controls.Add(this.lblNgayBan);
            this.grboxThongTinChung.Controls.Add(this.lblHoaDon);
            this.grboxThongTinChung.Location = new System.Drawing.Point(20, 88);
            this.grboxThongTinChung.Name = "grboxThongTinChung";
            this.grboxThongTinChung.Size = new System.Drawing.Size(667, 114);
            this.grboxThongTinChung.TabIndex = 1;
            this.grboxThongTinChung.TabStop = false;
            this.grboxThongTinChung.Text = "Thông tin chung";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(112, 23);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(172, 20);
            this.txtMaHoaDon.TabIndex = 17;
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(433, 62);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(172, 21);
            this.cboMaKH.TabIndex = 10;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(344, 65);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(65, 13);
            this.lblMaKH.TabIndex = 9;
            this.lblMaKH.Text = "Khách hàng";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(433, 26);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(172, 21);
            this.cboMaNV.TabIndex = 7;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(344, 29);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(57, 13);
            this.lblMaNV.TabIndex = 6;
            this.lblMaNV.Text = "Nhân Viên";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "dd/MM/yy, HH:mm:ss";
            this.dtpNgayBan.Enabled = false;
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(112, 61);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(172, 20);
            this.dtpNgayBan.TabIndex = 5;
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Location = new System.Drawing.Point(23, 67);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(53, 13);
            this.lblNgayBan.TabIndex = 2;
            this.lblNgayBan.Text = "Ngày bán";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Location = new System.Drawing.Point(23, 26);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(65, 13);
            this.lblHoaDon.TabIndex = 0;
            this.lblHoaDon.Text = "Mã hóa đơn";
            // 
            // gxboxThongTinMatHang
            // 
            this.gxboxThongTinMatHang.Controls.Add(this.btnXoaCTHD);
            this.gxboxThongTinMatHang.Controls.Add(this.btnThemCTHD);
            this.gxboxThongTinMatHang.Controls.Add(this.lblDonGia);
            this.gxboxThongTinMatHang.Controls.Add(this.txtDonGia);
            this.gxboxThongTinMatHang.Controls.Add(this.txtSoLuong);
            this.gxboxThongTinMatHang.Controls.Add(this.lblSoLuong);
            this.gxboxThongTinMatHang.Controls.Add(this.cboMaSP);
            this.gxboxThongTinMatHang.Controls.Add(this.lblMaSP);
            this.gxboxThongTinMatHang.Location = new System.Drawing.Point(20, 467);
            this.gxboxThongTinMatHang.Name = "gxboxThongTinMatHang";
            this.gxboxThongTinMatHang.Size = new System.Drawing.Size(363, 142);
            this.gxboxThongTinMatHang.TabIndex = 2;
            this.gxboxThongTinMatHang.TabStop = false;
            this.gxboxThongTinMatHang.Text = "Thông tin các mặt hàng";
            // 
            // btnXoaCTHD
            // 
            this.btnXoaCTHD.Location = new System.Drawing.Point(275, 63);
            this.btnXoaCTHD.Name = "btnXoaCTHD";
            this.btnXoaCTHD.Size = new System.Drawing.Size(73, 23);
            this.btnXoaCTHD.TabIndex = 10;
            this.btnXoaCTHD.Text = "Xóa";
            this.btnXoaCTHD.UseVisualStyleBackColor = true;
            this.btnXoaCTHD.Click += new System.EventHandler(this.btnXoaCTHD_Click);
            // 
            // btnThemCTHD
            // 
            this.btnThemCTHD.Location = new System.Drawing.Point(275, 22);
            this.btnThemCTHD.Name = "btnThemCTHD";
            this.btnThemCTHD.Size = new System.Drawing.Size(73, 23);
            this.btnThemCTHD.TabIndex = 9;
            this.btnThemCTHD.Text = "Thêm";
            this.btnThemCTHD.UseVisualStyleBackColor = true;
            this.btnThemCTHD.Click += new System.EventHandler(this.btnThemCTHD_Click);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(23, 107);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(44, 13);
            this.lblDonGia.TabIndex = 8;
            this.lblDonGia.Text = "Đơn giá";
            this.lblDonGia.Click += new System.EventHandler(this.lblDonGia_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(112, 104);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(137, 20);
            this.txtDonGia.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(112, 63);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(137, 20);
            this.txtSoLuong.TabIndex = 6;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(23, 69);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(49, 13);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số lượng";
            this.lblSoLuong.Click += new System.EventHandler(this.lblSoLuong_Click);
            // 
            // cboMaSP
            // 
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(112, 21);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(137, 21);
            this.cboMaSP.TabIndex = 2;
            this.cboMaSP.SelectedIndexChanged += new System.EventHandler(this.cboMaSP_SelectedIndexChanged);
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(23, 28);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(55, 13);
            this.lblMaSP.TabIndex = 1;
            this.lblMaSP.Text = "Sản phẩm";
            this.lblMaSP.Click += new System.EventHandler(this.label2_Click);
            // 
            // gridViewHD
            // 
            this.gridViewHD.AllowUserToAddRows = false;
            this.gridViewHD.AllowUserToDeleteRows = false;
            this.gridViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_SP,
            this.TENSP,
            this.ID_BRAND,
            this.SOLUONG,
            this.DONGIA,
            this.THANHTIEN});
            this.gridViewHD.Location = new System.Drawing.Point(20, 208);
            this.gridViewHD.MultiSelect = false;
            this.gridViewHD.Name = "gridViewHD";
            this.gridViewHD.ReadOnly = true;
            this.gridViewHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewHD.Size = new System.Drawing.Size(663, 253);
            this.gridViewHD.TabIndex = 13;
            this.gridViewHD.Click += new System.EventHandler(this.gridViewHD_Click);
            // 
            // ID_SP
            // 
            this.ID_SP.DataPropertyName = "ID_SP";
            this.ID_SP.HeaderText = "Mã sản phẩm";
            this.ID_SP.Name = "ID_SP";
            this.ID_SP.ReadOnly = true;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            // 
            // ID_BRAND
            // 
            this.ID_BRAND.DataPropertyName = "TENTH";
            this.ID_BRAND.HeaderText = "Thương hiệu";
            this.ID_BRAND.Name = "ID_BRAND";
            this.ID_BRAND.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "GIATIEN";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnLuu,
            this.btnHuy,
            this.btnInHoaDon,
            this.btnLuuThayDoi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(49, 22);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(50, 22);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.Image")));
            this.btnInHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(94, 22);
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnLuuThayDoi
            // 
            this.btnLuuThayDoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuThayDoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuThayDoi.Image")));
            this.btnLuuThayDoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.Size = new System.Drawing.Size(104, 22);
            this.btnLuuThayDoi.Text = "Lưu Thay Đổi";
            this.btnLuuThayDoi.Click += new System.EventHandler(this.btnLuuThayDoi_Click);
            // 
            // grbxHoaDon
            // 
            this.grbxHoaDon.Controls.Add(this.cboxMaHoaDon);
            this.grbxHoaDon.Controls.Add(this.label1);
            this.grbxHoaDon.Location = new System.Drawing.Point(20, 28);
            this.grbxHoaDon.Name = "grbxHoaDon";
            this.grbxHoaDon.Size = new System.Drawing.Size(667, 54);
            this.grbxHoaDon.TabIndex = 14;
            this.grbxHoaDon.TabStop = false;
            this.grbxHoaDon.Text = "Hóa Đơn";
            // 
            // cboxMaHoaDon
            // 
            this.cboxMaHoaDon.FormattingEnabled = true;
            this.cboxMaHoaDon.Location = new System.Drawing.Point(112, 22);
            this.cboxMaHoaDon.Name = "cboxMaHoaDon";
            this.cboxMaHoaDon.Size = new System.Drawing.Size(549, 21);
            this.cboxMaHoaDon.TabIndex = 1;
            this.cboxMaHoaDon.SelectedIndexChanged += new System.EventHandler(this.cboxMaHoaDon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoLuongSanPham);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(389, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 142);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SL Sản Phẩm";
            // 
            // txtSoLuongSanPham
            // 
            this.txtSoLuongSanPham.Location = new System.Drawing.Point(124, 70);
            this.txtSoLuongSanPham.Name = "txtSoLuongSanPham";
            this.txtSoLuongSanPham.ReadOnly = true;
            this.txtSoLuongSanPham.Size = new System.Drawing.Size(137, 20);
            this.txtSoLuongSanPham.TabIndex = 7;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(124, 32);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(137, 20);
            this.txtTongTien.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng tiền";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 621);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbxHoaDon);
            this.Controls.Add(this.gridViewHD);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gxboxThongTinMatHang);
            this.Controls.Add(this.grboxThongTinChung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHoaDon";
            this.Text = "HÓA ĐƠN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.grboxThongTinChung.ResumeLayout(false);
            this.grboxThongTinChung.PerformLayout();
            this.gxboxThongTinMatHang.ResumeLayout(false);
            this.gxboxThongTinMatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHD)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbxHoaDon.ResumeLayout(false);
            this.grbxHoaDon.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxThongTinChung;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.GroupBox gxboxThongTinMatHang;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.DataGridView gridViewHD;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.ToolStripButton btnInHoaDon;
        private System.Windows.Forms.ToolStripButton btnLuuThayDoi;
        private System.Windows.Forms.GroupBox grbxHoaDon;
        private System.Windows.Forms.ComboBox cboxMaHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BRAND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.Button btnThemCTHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuongSanPham;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaCTHD;
    }
}