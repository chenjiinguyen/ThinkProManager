namespace ThinkProManager.GUI
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.grboxPhieu = new System.Windows.Forms.GroupBox();
            this.radioPhieuXuat = new System.Windows.Forms.RadioButton();
            this.radioPhieuNhap = new System.Windows.Forms.RadioButton();
            this.grboxThangNam = new System.Windows.Forms.GroupBox();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioThang = new System.Windows.Forms.RadioButton();
            this.grboxCombobox = new System.Windows.Forms.GroupBox();
            this.cboThangNam = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.grboxPhieu.SuspendLayout();
            this.grboxThangNam.SuspendLayout();
            this.grboxCombobox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // grboxPhieu
            // 
            this.grboxPhieu.Controls.Add(this.radioPhieuXuat);
            this.grboxPhieu.Controls.Add(this.radioPhieuNhap);
            this.grboxPhieu.Location = new System.Drawing.Point(18, 34);
            this.grboxPhieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grboxPhieu.Name = "grboxPhieu";
            this.grboxPhieu.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grboxPhieu.Size = new System.Drawing.Size(204, 154);
            this.grboxPhieu.TabIndex = 0;
            this.grboxPhieu.TabStop = false;
            this.grboxPhieu.Text = "Phiếu Nhập/Xuất";
            // 
            // radioPhieuXuat
            // 
            this.radioPhieuXuat.AutoSize = true;
            this.radioPhieuXuat.Location = new System.Drawing.Point(22, 95);
            this.radioPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioPhieuXuat.Name = "radioPhieuXuat";
            this.radioPhieuXuat.Size = new System.Drawing.Size(138, 24);
            this.radioPhieuXuat.TabIndex = 1;
            this.radioPhieuXuat.Text = "Phiếu xuất kho";
            this.radioPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // radioPhieuNhap
            // 
            this.radioPhieuNhap.AutoSize = true;
            this.radioPhieuNhap.Checked = true;
            this.radioPhieuNhap.Location = new System.Drawing.Point(22, 45);
            this.radioPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioPhieuNhap.Name = "radioPhieuNhap";
            this.radioPhieuNhap.Size = new System.Drawing.Size(144, 24);
            this.radioPhieuNhap.TabIndex = 0;
            this.radioPhieuNhap.TabStop = true;
            this.radioPhieuNhap.Text = "Phiếu nhập kho";
            this.radioPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // grboxThangNam
            // 
            this.grboxThangNam.Controls.Add(this.radioNam);
            this.grboxThangNam.Controls.Add(this.radioThang);
            this.grboxThangNam.Location = new System.Drawing.Point(273, 34);
            this.grboxThangNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grboxThangNam.Name = "grboxThangNam";
            this.grboxThangNam.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grboxThangNam.Size = new System.Drawing.Size(204, 154);
            this.grboxThangNam.TabIndex = 1;
            this.grboxThangNam.TabStop = false;
            this.grboxThangNam.Text = "Thống kê Tháng/Năm";
            this.grboxThangNam.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(44, 95);
            this.radioNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(67, 24);
            this.radioNam.TabIndex = 1;
            this.radioNam.Text = "Năm";
            this.radioNam.UseVisualStyleBackColor = true;
            this.radioNam.CheckedChanged += new System.EventHandler(this.radioThangNam_CheckedChanged);
            // 
            // radioThang
            // 
            this.radioThang.AutoSize = true;
            this.radioThang.Checked = true;
            this.radioThang.Location = new System.Drawing.Point(44, 45);
            this.radioThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioThang.Name = "radioThang";
            this.radioThang.Size = new System.Drawing.Size(79, 24);
            this.radioThang.TabIndex = 0;
            this.radioThang.TabStop = true;
            this.radioThang.Text = "Tháng";
            this.radioThang.UseVisualStyleBackColor = true;
            this.radioThang.CheckedChanged += new System.EventHandler(this.radioThangNam_CheckedChanged);
            // 
            // grboxCombobox
            // 
            this.grboxCombobox.Controls.Add(this.cboThangNam);
            this.grboxCombobox.Location = new System.Drawing.Point(520, 34);
            this.grboxCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grboxCombobox.Name = "grboxCombobox";
            this.grboxCombobox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grboxCombobox.Size = new System.Drawing.Size(346, 154);
            this.grboxCombobox.TabIndex = 2;
            this.grboxCombobox.TabStop = false;
            this.grboxCombobox.Text = "Mốc Thời Gian";
            this.grboxCombobox.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cboThangNam
            // 
            this.cboThangNam.FormattingEnabled = true;
            this.cboThangNam.Location = new System.Drawing.Point(39, 66);
            this.cboThangNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboThangNam.Name = "cboThangNam";
            this.cboThangNam.Size = new System.Drawing.Size(265, 28);
            this.cboThangNam.TabIndex = 0;
            this.cboThangNam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboThangNam_KeyDown);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(908, 60);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(116, 45);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "    Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(908, 120);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "  Xem in";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(18, 226);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.Size = new System.Drawing.Size(1006, 515);
            this.dgvData.TabIndex = 5;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 766);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.grboxCombobox);
            this.Controls.Add(this.grboxThangNam);
            this.Controls.Add(this.grboxPhieu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThongKe";
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.grboxPhieu.ResumeLayout(false);
            this.grboxPhieu.PerformLayout();
            this.grboxThangNam.ResumeLayout(false);
            this.grboxThangNam.PerformLayout();
            this.grboxCombobox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxPhieu;
        private System.Windows.Forms.RadioButton radioPhieuXuat;
        private System.Windows.Forms.RadioButton radioPhieuNhap;
        private System.Windows.Forms.GroupBox grboxThangNam;
        private System.Windows.Forms.GroupBox grboxCombobox;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioThang;
        private System.Windows.Forms.ComboBox cboThangNam;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvData;
    }
}