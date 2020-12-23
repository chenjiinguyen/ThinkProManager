namespace ThinkProManager.GUI
{
    partial class frmSanPham
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
			System.Windows.Forms.Label lblMaSP;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.btnXoa = new System.Windows.Forms.ToolStripButton();
			this.btnSua = new System.Windows.Forms.ToolStripButton();
			this.btnLuu = new System.Windows.Forms.ToolStripButton();
			this.btnClear = new System.Windows.Forms.ToolStripButton();
			this.grboxThongTin = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAnhSP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.anhSP = new System.Windows.Forms.PictureBox();
			this.lblTinhTrang = new System.Windows.Forms.Label();
			this.cboTinhTrang = new System.Windows.Forms.ComboBox();
			this.cboLoai = new System.Windows.Forms.ComboBox();
			this.lblLoai = new System.Windows.Forms.Label();
			this.cboThuongHieu = new System.Windows.Forms.ComboBox();
			this.lblThuongHieu = new System.Windows.Forms.Label();
			this.richtxtGhiChu = new System.Windows.Forms.RichTextBox();
			this.lblThongtin = new System.Windows.Forms.Label();
			this.lblAnh = new System.Windows.Forms.Label();
			this.lblBaoHanh = new System.Windows.Forms.Label();
			this.txtTHBH = new System.Windows.Forms.TextBox();
			this.lblDonGia = new System.Windows.Forms.Label();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.txtTenSP = new System.Windows.Forms.TextBox();
			this.lblTenSP = new System.Windows.Forms.Label();
			this.txtMaSP = new System.Windows.Forms.TextBox();
			this.chboxThongTinThem = new System.Windows.Forms.CheckBox();
			this.txtThongTinThem = new System.Windows.Forms.TextBox();
			this.dgvDSSP = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cboThongTinThem = new System.Windows.Forms.ComboBox();
			this.btnLuuTT = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			lblMaSP = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.grboxThongTin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.anhSP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblMaSP
			// 
			lblMaSP.AutoSize = true;
			lblMaSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			lblMaSP.Location = new System.Drawing.Point(21, 34);
			lblMaSP.Name = "lblMaSP";
			lblMaSP.Size = new System.Drawing.Size(71, 13);
			lblMaSP.TabIndex = 0;
			lblMaSP.Text = "Mã sản phẩm";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.btnClear});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip1.Size = new System.Drawing.Size(945, 31);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
			this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(65, 28);
			this.btnThem.Text = "Thêm";
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
			this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(57, 28);
			this.btnXoa.Text = "Xóa";
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
			this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(55, 28);
			this.btnSua.Text = "Sửa";
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
			this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(56, 28);
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
			this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(76, 28);
			this.btnClear.Text = "Loại Bỏ";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// grboxThongTin
			// 
			this.grboxThongTin.Controls.Add(this.label2);
			this.grboxThongTin.Controls.Add(this.txtAnhSP);
			this.grboxThongTin.Controls.Add(this.label1);
			this.grboxThongTin.Controls.Add(this.anhSP);
			this.grboxThongTin.Controls.Add(this.lblTinhTrang);
			this.grboxThongTin.Controls.Add(this.cboTinhTrang);
			this.grboxThongTin.Controls.Add(this.cboLoai);
			this.grboxThongTin.Controls.Add(this.lblLoai);
			this.grboxThongTin.Controls.Add(this.cboThuongHieu);
			this.grboxThongTin.Controls.Add(this.lblThuongHieu);
			this.grboxThongTin.Controls.Add(this.richtxtGhiChu);
			this.grboxThongTin.Controls.Add(this.lblThongtin);
			this.grboxThongTin.Controls.Add(this.lblAnh);
			this.grboxThongTin.Controls.Add(this.lblBaoHanh);
			this.grboxThongTin.Controls.Add(this.txtTHBH);
			this.grboxThongTin.Controls.Add(this.lblDonGia);
			this.grboxThongTin.Controls.Add(this.txtDonGia);
			this.grboxThongTin.Controls.Add(this.txtTenSP);
			this.grboxThongTin.Controls.Add(this.lblTenSP);
			this.grboxThongTin.Controls.Add(this.txtMaSP);
			this.grboxThongTin.Controls.Add(lblMaSP);
			this.grboxThongTin.Location = new System.Drawing.Point(12, 38);
			this.grboxThongTin.Name = "grboxThongTin";
			this.grboxThongTin.Size = new System.Drawing.Size(924, 214);
			this.grboxThongTin.TabIndex = 3;
			this.grboxThongTin.TabStop = false;
			this.grboxThongTin.Text = "Thông tin";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(182, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 24;
			this.label2.Text = "Tháng";
			// 
			// txtAnhSP
			// 
			this.txtAnhSP.Location = new System.Drawing.Point(428, 32);
			this.txtAnhSP.Name = "txtAnhSP";
			this.txtAnhSP.Size = new System.Drawing.Size(196, 20);
			this.txtAnhSP.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(290, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 22;
			this.label1.Text = "VND";
			// 
			// anhSP
			// 
			this.anhSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.anhSP.Location = new System.Drawing.Point(713, 23);
			this.anhSP.Name = "anhSP";
			this.anhSP.Size = new System.Drawing.Size(178, 166);
			this.anhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.anhSP.TabIndex = 21;
			this.anhSP.TabStop = false;
			// 
			// lblTinhTrang
			// 
			this.lblTinhTrang.AutoSize = true;
			this.lblTinhTrang.Location = new System.Drawing.Point(21, 176);
			this.lblTinhTrang.Name = "lblTinhTrang";
			this.lblTinhTrang.Size = new System.Drawing.Size(55, 13);
			this.lblTinhTrang.TabIndex = 19;
			this.lblTinhTrang.Text = "Tình trạng";
			// 
			// cboTinhTrang
			// 
			this.cboTinhTrang.FormattingEnabled = true;
			this.cboTinhTrang.Location = new System.Drawing.Point(124, 173);
			this.cboTinhTrang.Name = "cboTinhTrang";
			this.cboTinhTrang.Size = new System.Drawing.Size(196, 21);
			this.cboTinhTrang.TabIndex = 18;
			// 
			// cboLoai
			// 
			this.cboLoai.FormattingEnabled = true;
			this.cboLoai.Location = new System.Drawing.Point(430, 173);
			this.cboLoai.Name = "cboLoai";
			this.cboLoai.Size = new System.Drawing.Size(196, 21);
			this.cboLoai.TabIndex = 17;
			// 
			// lblLoai
			// 
			this.lblLoai.AutoSize = true;
			this.lblLoai.Location = new System.Drawing.Point(345, 176);
			this.lblLoai.Name = "lblLoai";
			this.lblLoai.Size = new System.Drawing.Size(27, 13);
			this.lblLoai.TabIndex = 14;
			this.lblLoai.Text = "Loại";
			// 
			// cboThuongHieu
			// 
			this.cboThuongHieu.FormattingEnabled = true;
			this.cboThuongHieu.Location = new System.Drawing.Point(428, 136);
			this.cboThuongHieu.Name = "cboThuongHieu";
			this.cboThuongHieu.Size = new System.Drawing.Size(198, 21);
			this.cboThuongHieu.TabIndex = 13;
			// 
			// lblThuongHieu
			// 
			this.lblThuongHieu.AutoSize = true;
			this.lblThuongHieu.Location = new System.Drawing.Point(345, 140);
			this.lblThuongHieu.Name = "lblThuongHieu";
			this.lblThuongHieu.Size = new System.Drawing.Size(67, 13);
			this.lblThuongHieu.TabIndex = 12;
			this.lblThuongHieu.Text = "Thương hiệu";
			// 
			// richtxtGhiChu
			// 
			this.richtxtGhiChu.Location = new System.Drawing.Point(428, 66);
			this.richtxtGhiChu.Name = "richtxtGhiChu";
			this.richtxtGhiChu.Size = new System.Drawing.Size(198, 56);
			this.richtxtGhiChu.TabIndex = 11;
			this.richtxtGhiChu.Text = "";
			// 
			// lblThongtin
			// 
			this.lblThongtin.AutoSize = true;
			this.lblThongtin.Location = new System.Drawing.Point(345, 73);
			this.lblThongtin.Name = "lblThongtin";
			this.lblThongtin.Size = new System.Drawing.Size(44, 13);
			this.lblThongtin.TabIndex = 10;
			this.lblThongtin.Text = "Ghi chú";
			// 
			// lblAnh
			// 
			this.lblAnh.AutoSize = true;
			this.lblAnh.Location = new System.Drawing.Point(345, 34);
			this.lblAnh.Name = "lblAnh";
			this.lblAnh.Size = new System.Drawing.Size(78, 13);
			this.lblAnh.TabIndex = 8;
			this.lblAnh.Text = "Ảnh Sản Phẩm";
			// 
			// lblBaoHanh
			// 
			this.lblBaoHanh.AutoSize = true;
			this.lblBaoHanh.Location = new System.Drawing.Point(21, 140);
			this.lblBaoHanh.Name = "lblBaoHanh";
			this.lblBaoHanh.Size = new System.Drawing.Size(97, 13);
			this.lblBaoHanh.TabIndex = 7;
			this.lblBaoHanh.Text = "Thời hạn bảo hành";
			// 
			// txtTHBH
			// 
			this.txtTHBH.Location = new System.Drawing.Point(124, 137);
			this.txtTHBH.Name = "txtTHBH";
			this.txtTHBH.Size = new System.Drawing.Size(54, 20);
			this.txtTHBH.TabIndex = 6;
			this.txtTHBH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTHBH_KeyPress);
			// 
			// lblDonGia
			// 
			this.lblDonGia.AutoSize = true;
			this.lblDonGia.Location = new System.Drawing.Point(21, 105);
			this.lblDonGia.Name = "lblDonGia";
			this.lblDonGia.Size = new System.Drawing.Size(44, 13);
			this.lblDonGia.TabIndex = 5;
			this.lblDonGia.Text = "Đơn giá";
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(124, 102);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(165, 20);
			this.txtDonGia.TabIndex = 4;
			this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTHBH_KeyPress);
			// 
			// txtTenSP
			// 
			this.txtTenSP.Location = new System.Drawing.Point(124, 66);
			this.txtTenSP.Name = "txtTenSP";
			this.txtTenSP.Size = new System.Drawing.Size(196, 20);
			this.txtTenSP.TabIndex = 3;
			// 
			// lblTenSP
			// 
			this.lblTenSP.AutoSize = true;
			this.lblTenSP.Location = new System.Drawing.Point(21, 69);
			this.lblTenSP.Name = "lblTenSP";
			this.lblTenSP.Size = new System.Drawing.Size(75, 13);
			this.lblTenSP.TabIndex = 2;
			this.lblTenSP.Text = "Tên sản phẩm";
			// 
			// txtMaSP
			// 
			this.txtMaSP.Location = new System.Drawing.Point(124, 31);
			this.txtMaSP.Name = "txtMaSP";
			this.txtMaSP.Size = new System.Drawing.Size(196, 20);
			this.txtMaSP.TabIndex = 1;
			// 
			// chboxThongTinThem
			// 
			this.chboxThongTinThem.AutoSize = true;
			this.chboxThongTinThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chboxThongTinThem.Location = new System.Drawing.Point(41, 19);
			this.chboxThongTinThem.Name = "chboxThongTinThem";
			this.chboxThongTinThem.Size = new System.Drawing.Size(97, 17);
			this.chboxThongTinThem.TabIndex = 4;
			this.chboxThongTinThem.Text = "Thông tin thêm";
			this.chboxThongTinThem.UseVisualStyleBackColor = true;
			this.chboxThongTinThem.CheckedChanged += new System.EventHandler(this.chboxThongTinThem_CheckedChanged);
			// 
			// txtThongTinThem
			// 
			this.txtThongTinThem.Location = new System.Drawing.Point(271, 44);
			this.txtThongTinThem.Name = "txtThongTinThem";
			this.txtThongTinThem.Size = new System.Drawing.Size(196, 20);
			this.txtThongTinThem.TabIndex = 2;
			this.txtThongTinThem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtThongTinThem_KeyUp);
			// 
			// dgvDSSP
			// 
			this.dgvDSSP.AllowUserToAddRows = false;
			this.dgvDSSP.AllowUserToDeleteRows = false;
			this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column7});
			this.dgvDSSP.Location = new System.Drawing.Point(12, 348);
			this.dgvDSSP.MultiSelect = false;
			this.dgvDSSP.Name = "dgvDSSP";
			this.dgvDSSP.ReadOnly = true;
			this.dgvDSSP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dgvDSSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSSP.Size = new System.Drawing.Size(924, 244);
			this.dgvDSSP.TabIndex = 6;
			this.dgvDSSP.Click += new System.EventHandler(this.dgvDSSP_Click);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "ID_SP";
			this.Column1.HeaderText = "Mã sản phẩm";
			this.Column1.MinimumWidth = 8;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 150;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "TENSP";
			this.Column2.HeaderText = "Tên sản phẩm";
			this.Column2.MinimumWidth = 8;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 150;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "ID_LOAI";
			this.Column3.HeaderText = "Mã loại";
			this.Column3.MinimumWidth = 8;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 150;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "ID_BRAND";
			this.Column4.HeaderText = "Mã thương hiệu";
			this.Column4.MinimumWidth = 8;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 150;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "GIATIEN";
			this.Column5.HeaderText = "Đơn giá";
			this.Column5.MinimumWidth = 8;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 150;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "ID_TINHTRANG";
			this.Column6.HeaderText = "Tình trạng";
			this.Column6.MinimumWidth = 8;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 150;
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "THOIHAN_BH";
			this.Column8.HeaderText = "Thời Hạn Bảo Hành (Tháng)";
			this.Column8.MinimumWidth = 8;
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 150;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "ANH_SP";
			this.Column7.HeaderText = "Ảnh";
			this.Column7.MinimumWidth = 8;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 150;
			// 
			// cboThongTinThem
			// 
			this.cboThongTinThem.FormattingEnabled = true;
			this.cboThongTinThem.Items.AddRange(new object[] {
            "Vi xử lý",
            "Màn hình",
            "Ram",
            "Card đồ họa",
            "Lưu trữ",
            "Pin",
            "Kết nối",
            "Trọng lượng",
            "Hệ điều hành",
            "Màu sắc"});
			this.cboThongTinThem.Location = new System.Drawing.Point(41, 44);
			this.cboThongTinThem.Name = "cboThongTinThem";
			this.cboThongTinThem.Size = new System.Drawing.Size(196, 21);
			this.cboThongTinThem.TabIndex = 19;
			this.cboThongTinThem.SelectedIndexChanged += new System.EventHandler(this.cboThongTinThem_SelectedIndexChanged);
			// 
			// btnLuuTT
			// 
			this.btnLuuTT.Location = new System.Drawing.Point(505, 31);
			this.btnLuuTT.Name = "btnLuuTT";
			this.btnLuuTT.Size = new System.Drawing.Size(53, 31);
			this.btnLuuTT.TabIndex = 20;
			this.btnLuuTT.Text = "Lưu";
			this.btnLuuTT.UseVisualStyleBackColor = true;
			this.btnLuuTT.Click += new System.EventHandler(this.btnLuuTT_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chboxThongTinThem);
			this.groupBox1.Controls.Add(this.btnLuuTT);
			this.groupBox1.Controls.Add(this.cboThongTinThem);
			this.groupBox1.Controls.Add(this.txtThongTinThem);
			this.groupBox1.Location = new System.Drawing.Point(12, 258);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(922, 84);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin thêm";
			// 
			// frmSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(945, 601);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvDSSP);
			this.Controls.Add(this.grboxThongTin);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSanPham";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RightToLeftLayout = true;
			this.Text = "DANH MỤC SẢN PHẨM";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanPham_FormClosing);
			this.Load += new System.EventHandler(this.frmSanPham_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.grboxThongTin.ResumeLayout(false);
			this.grboxThongTin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.anhSP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.GroupBox grboxThongTin;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblBaoHanh;
        private System.Windows.Forms.TextBox txtTHBH;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cboThuongHieu;
        private System.Windows.Forms.Label lblThuongHieu;
        private System.Windows.Forms.RichTextBox richtxtGhiChu;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.PictureBox anhSP;
        private System.Windows.Forms.CheckBox chboxThongTinThem;
        private System.Windows.Forms.TextBox txtThongTinThem;
        private System.Windows.Forms.ComboBox cboThongTinThem;
        private System.Windows.Forms.Button btnLuuTT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnhSP;
        private System.Windows.Forms.Label label2;
    }
}

