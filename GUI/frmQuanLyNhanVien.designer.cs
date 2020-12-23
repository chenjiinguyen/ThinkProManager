namespace ThinkProManager.GUI
{
    partial class frmQuanLyNhanVien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhanVien));
			this.label5 = new System.Windows.Forms.Label();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
			this.ID_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EMAILS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AVATAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cboGioiTinh = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cboChucVu = new System.Windows.Forms.ComboBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.txtAvatar = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pboxAvatar = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnthem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnxoa = new System.Windows.Forms.ToolStripMenuItem();
			this.btnsua = new System.Windows.Forms.ToolStripMenuItem();
			this.btnluu = new System.Windows.Forms.ToolStripMenuItem();
			this.btnin = new System.Windows.Forms.ToolStripMenuItem();
			this.btnthoat = new System.Windows.Forms.ToolStripMenuItem();
			this.gboxNV = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtHeSoLuong = new System.Windows.Forms.TextBox();
			this.rdbDiLam = new System.Windows.Forms.RadioButton();
			this.rdbDaNghi = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.chbxNhanVien = new System.Windows.Forms.CheckBox();
			this.btnClear = new System.Windows.Forms.ToolStripButton();
			this.gbxThongTinNguoiDung = new System.Windows.Forms.GroupBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnLuuNV = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.gboxNV.SuspendLayout();
			this.gbxThongTinNguoiDung.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 167);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 22;
			this.label5.Text = "Điện thoại";
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(88, 166);
			this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(192, 20);
			this.txtSDT.TabIndex = 23;
			// 
			// dgvNguoiDung
			// 
			this.dgvNguoiDung.AllowUserToAddRows = false;
			this.dgvNguoiDung.AllowUserToDeleteRows = false;
			this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_USER,
            this.HOTEN,
            this.EMAILS,
            this.GIOITINH,
            this.DIENTHOAI,
            this.DIACHI,
            this.AVATAR});
			this.dgvNguoiDung.Location = new System.Drawing.Point(11, 309);
			this.dgvNguoiDung.Margin = new System.Windows.Forms.Padding(2);
			this.dgvNguoiDung.MultiSelect = false;
			this.dgvNguoiDung.Name = "dgvNguoiDung";
			this.dgvNguoiDung.ReadOnly = true;
			this.dgvNguoiDung.RowTemplate.Height = 24;
			this.dgvNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvNguoiDung.Size = new System.Drawing.Size(762, 254);
			this.dgvNguoiDung.TabIndex = 26;
			this.dgvNguoiDung.Click += new System.EventHandler(this.dgvNguoiDung_Click);
			// 
			// ID_USER
			// 
			this.ID_USER.DataPropertyName = "ID_USER";
			this.ID_USER.HeaderText = "Mã người dùng";
			this.ID_USER.Name = "ID_USER";
			this.ID_USER.ReadOnly = true;
			// 
			// HOTEN
			// 
			this.HOTEN.DataPropertyName = "HOTEN";
			this.HOTEN.HeaderText = "Họ tên";
			this.HOTEN.Name = "HOTEN";
			this.HOTEN.ReadOnly = true;
			// 
			// EMAILS
			// 
			this.EMAILS.DataPropertyName = "EMAIL";
			this.EMAILS.HeaderText = "Email";
			this.EMAILS.Name = "EMAILS";
			this.EMAILS.ReadOnly = true;
			// 
			// GIOITINH
			// 
			this.GIOITINH.DataPropertyName = "GIOITINH";
			this.GIOITINH.HeaderText = "Giới tính";
			this.GIOITINH.Name = "GIOITINH";
			this.GIOITINH.ReadOnly = true;
			// 
			// DIENTHOAI
			// 
			this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
			this.DIENTHOAI.HeaderText = "Điện thoại";
			this.DIENTHOAI.Name = "DIENTHOAI";
			this.DIENTHOAI.ReadOnly = true;
			// 
			// DIACHI
			// 
			this.DIACHI.DataPropertyName = "DIACHI";
			this.DIACHI.HeaderText = "Địa chỉ";
			this.DIACHI.Name = "DIACHI";
			this.DIACHI.ReadOnly = true;
			// 
			// AVATAR
			// 
			this.AVATAR.DataPropertyName = "AVATAR";
			this.AVATAR.HeaderText = "Avatar";
			this.AVATAR.Name = "AVATAR";
			this.AVATAR.ReadOnly = true;
			// 
			// cboGioiTinh
			// 
			this.cboGioiTinh.FormattingEnabled = true;
			this.cboGioiTinh.Location = new System.Drawing.Point(87, 237);
			this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(2);
			this.cboGioiTinh.Name = "cboGioiTinh";
			this.cboGioiTinh.Size = new System.Drawing.Size(192, 21);
			this.cboGioiTinh.TabIndex = 25;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 239);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 24;
			this.label6.Text = "Giới tính";
			// 
			// cboChucVu
			// 
			this.cboChucVu.FormattingEnabled = true;
			this.cboChucVu.Location = new System.Drawing.Point(387, 38);
			this.cboChucVu.Margin = new System.Windows.Forms.Padding(2);
			this.cboChucVu.Name = "cboChucVu";
			this.cboChucVu.Size = new System.Drawing.Size(192, 21);
			this.cboChucVu.TabIndex = 21;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(88, 132);
			this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(192, 20);
			this.txtDiaChi.TabIndex = 19;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(88, 100);
			this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(192, 20);
			this.txtHoTen.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 133);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Địa chỉ";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 102);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Họ tên";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 38);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Mã Nhân Viên";
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(88, 36);
			this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(192, 20);
			this.txtMaNV.TabIndex = 15;
			// 
			// txtAvatar
			// 
			this.txtAvatar.Location = new System.Drawing.Point(87, 201);
			this.txtAvatar.Margin = new System.Windows.Forms.Padding(2);
			this.txtAvatar.Name = "txtAvatar";
			this.txtAvatar.Size = new System.Drawing.Size(192, 20);
			this.txtAvatar.TabIndex = 29;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 202);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 28;
			this.label7.Text = "Avatar";
			// 
			// pboxAvatar
			// 
			this.pboxAvatar.Location = new System.Drawing.Point(606, 19);
			this.pboxAvatar.Name = "pboxAvatar";
			this.pboxAvatar.Size = new System.Drawing.Size(140, 154);
			this.pboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pboxAvatar.TabIndex = 30;
			this.pboxAvatar.TabStop = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem,
            this.btnsua,
            this.btnxoa,
            this.btnluu,
            this.btnClear,
            this.btnin,
            this.btnthoat});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(784, 25);
			this.toolStrip1.TabIndex = 31;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnthem
			// 
			this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
			this.btnthem.Name = "btnthem";
			this.btnthem.Size = new System.Drawing.Size(63, 25);
			this.btnthem.Text = "Thêm";
			this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
			// 
			// btnxoa
			// 
			this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
			this.btnxoa.Name = "btnxoa";
			this.btnxoa.Size = new System.Drawing.Size(55, 25);
			this.btnxoa.Text = "Xoá";
			this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
			// 
			// btnsua
			// 
			this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
			this.btnsua.Name = "btnsua";
			this.btnsua.Size = new System.Drawing.Size(53, 25);
			this.btnsua.Text = "Sửa";
			this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
			// 
			// btnluu
			// 
			this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
			this.btnluu.Name = "btnluu";
			this.btnluu.Size = new System.Drawing.Size(55, 25);
			this.btnluu.Text = "Lưu";
			this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
			// 
			// btnin
			// 
			this.btnin.Image = ((System.Drawing.Image)(resources.GetObject("btnin.Image")));
			this.btnin.Name = "btnin";
			this.btnin.Size = new System.Drawing.Size(45, 25);
			this.btnin.Text = "In";
			// 
			// btnthoat
			// 
			this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
			this.btnthoat.Name = "btnthoat";
			this.btnthoat.Size = new System.Drawing.Size(64, 25);
			this.btnthoat.Text = "Thoát";
			// 
			// gboxNV
			// 
			this.gboxNV.Controls.Add(this.btnLuuNV);
			this.gboxNV.Controls.Add(this.rdbDaNghi);
			this.gboxNV.Controls.Add(this.rdbDiLam);
			this.gboxNV.Controls.Add(this.txtHeSoLuong);
			this.gboxNV.Controls.Add(this.label10);
			this.gboxNV.Controls.Add(this.label9);
			this.gboxNV.Location = new System.Drawing.Point(305, 109);
			this.gboxNV.Name = "gboxNV";
			this.gboxNV.Size = new System.Drawing.Size(282, 124);
			this.gboxNV.TabIndex = 32;
			this.gboxNV.TabStop = false;
			this.gboxNV.Text = "Nhân Viên";
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 26);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 13);
			this.label9.TabIndex = 33;
			this.label9.Text = "Hệ Số Lương";
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(8, 59);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(59, 13);
			this.label10.TabIndex = 34;
			this.label10.Text = "Tình Trạng";
			// 
			// txtHeSoLuong
			// 
			this.txtHeSoLuong.Location = new System.Drawing.Point(82, 22);
			this.txtHeSoLuong.Margin = new System.Windows.Forms.Padding(2);
			this.txtHeSoLuong.Name = "txtHeSoLuong";
			this.txtHeSoLuong.Size = new System.Drawing.Size(192, 20);
			this.txtHeSoLuong.TabIndex = 35;
			this.txtHeSoLuong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHeSoLuong_KeyUp);
			// 
			// rdbDiLam
			// 
			this.rdbDiLam.AutoSize = true;
			this.rdbDiLam.Location = new System.Drawing.Point(82, 58);
			this.rdbDiLam.Name = "rdbDiLam";
			this.rdbDiLam.Size = new System.Drawing.Size(58, 17);
			this.rdbDiLam.TabIndex = 36;
			this.rdbDiLam.TabStop = true;
			this.rdbDiLam.Text = "Đi Làm";
			this.rdbDiLam.UseVisualStyleBackColor = true;
			this.rdbDiLam.CheckedChanged += new System.EventHandler(this.rdbDiLam_CheckedChanged);
			// 
			// rdbDaNghi
			// 
			this.rdbDaNghi.AutoSize = true;
			this.rdbDaNghi.Location = new System.Drawing.Point(160, 58);
			this.rdbDaNghi.Name = "rdbDaNghi";
			this.rdbDaNghi.Size = new System.Drawing.Size(64, 17);
			this.rdbDaNghi.TabIndex = 37;
			this.rdbDaNghi.TabStop = true;
			this.rdbDaNghi.Text = "Đã Nghỉ";
			this.rdbDaNghi.UseVisualStyleBackColor = true;
			this.rdbDaNghi.CheckedChanged += new System.EventHandler(this.rdbDaNghi_CheckedChanged);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(309, 41);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Chức vụ";
			// 
			// chbxNhanVien
			// 
			this.chbxNhanVien.AutoSize = true;
			this.chbxNhanVien.Location = new System.Drawing.Point(305, 83);
			this.chbxNhanVien.Name = "chbxNhanVien";
			this.chbxNhanVien.Size = new System.Drawing.Size(76, 17);
			this.chbxNhanVien.TabIndex = 33;
			this.chbxNhanVien.Text = "Nhân Viên";
			this.chbxNhanVien.UseVisualStyleBackColor = true;
			this.chbxNhanVien.CheckedChanged += new System.EventHandler(this.chbxNhanVien_CheckedChanged);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
			this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(68, 22);
			this.btnClear.Text = "Loại Bỏ";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// gbxThongTinNguoiDung
			// 
			this.gbxThongTinNguoiDung.Controls.Add(this.txtEmail);
			this.gbxThongTinNguoiDung.Controls.Add(this.label8);
			this.gbxThongTinNguoiDung.Controls.Add(this.chbxNhanVien);
			this.gbxThongTinNguoiDung.Controls.Add(this.pboxAvatar);
			this.gbxThongTinNguoiDung.Controls.Add(this.gboxNV);
			this.gbxThongTinNguoiDung.Controls.Add(this.txtMaNV);
			this.gbxThongTinNguoiDung.Controls.Add(this.label1);
			this.gbxThongTinNguoiDung.Controls.Add(this.label2);
			this.gbxThongTinNguoiDung.Controls.Add(this.txtAvatar);
			this.gbxThongTinNguoiDung.Controls.Add(this.label3);
			this.gbxThongTinNguoiDung.Controls.Add(this.label7);
			this.gbxThongTinNguoiDung.Controls.Add(this.txtHoTen);
			this.gbxThongTinNguoiDung.Controls.Add(this.label5);
			this.gbxThongTinNguoiDung.Controls.Add(this.txtDiaChi);
			this.gbxThongTinNguoiDung.Controls.Add(this.txtSDT);
			this.gbxThongTinNguoiDung.Controls.Add(this.label4);
			this.gbxThongTinNguoiDung.Controls.Add(this.cboChucVu);
			this.gbxThongTinNguoiDung.Controls.Add(this.cboGioiTinh);
			this.gbxThongTinNguoiDung.Controls.Add(this.label6);
			this.gbxThongTinNguoiDung.Location = new System.Drawing.Point(12, 28);
			this.gbxThongTinNguoiDung.Name = "gbxThongTinNguoiDung";
			this.gbxThongTinNguoiDung.Size = new System.Drawing.Size(761, 276);
			this.gbxThongTinNguoiDung.TabIndex = 34;
			this.gbxThongTinNguoiDung.TabStop = false;
			this.gbxThongTinNguoiDung.Text = "Thông Tin Người Dùng";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(88, 66);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(192, 20);
			this.txtEmail.TabIndex = 35;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 67);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 13);
			this.label8.TabIndex = 34;
			this.label8.Text = "Email";
			// 
			// btnLuuNV
			// 
			this.btnLuuNV.Location = new System.Drawing.Point(11, 88);
			this.btnLuuNV.Name = "btnLuuNV";
			this.btnLuuNV.Size = new System.Drawing.Size(75, 23);
			this.btnLuuNV.TabIndex = 38;
			this.btnLuuNV.Text = "Lưu";
			this.btnLuuNV.UseVisualStyleBackColor = true;
			this.btnLuuNV.Click += new System.EventHandler(this.btnLuuNV_Click);
			// 
			// frmQuanLyNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(784, 574);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.dgvNguoiDung);
			this.Controls.Add(this.gbxThongTinNguoiDung);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "frmQuanLyNhanVien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản Lý Nhân Viên";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyNhanVien_FormClosing);
			this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.gboxNV.ResumeLayout(false);
			this.gboxNV.PerformLayout();
			this.gbxThongTinNguoiDung.ResumeLayout(false);
			this.gbxThongTinNguoiDung.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtAvatar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pboxAvatar;
		private System.Windows.Forms.DataGridView dgvNguoiDung;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_USER;
		private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
		private System.Windows.Forms.DataGridViewTextBoxColumn EMAILS;
		private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
		private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
		private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
		private System.Windows.Forms.DataGridViewTextBoxColumn AVATAR;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnthem;
		private System.Windows.Forms.ToolStripMenuItem btnxoa;
		private System.Windows.Forms.ToolStripMenuItem btnsua;
		private System.Windows.Forms.ToolStripMenuItem btnluu;
		private System.Windows.Forms.ToolStripMenuItem btnin;
		private System.Windows.Forms.ToolStripMenuItem btnthoat;
		private System.Windows.Forms.GroupBox gboxNV;
		private System.Windows.Forms.TextBox txtHeSoLuong;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RadioButton rdbDaNghi;
		private System.Windows.Forms.RadioButton rdbDiLam;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chbxNhanVien;
		private System.Windows.Forms.ToolStripButton btnClear;
		private System.Windows.Forms.GroupBox gbxThongTinNguoiDung;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnLuuNV;
	}
}

