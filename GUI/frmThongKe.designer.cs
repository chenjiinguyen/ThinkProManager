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
            this.btnXemIn = new System.Windows.Forms.Button();
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
            this.grboxPhieu.Location = new System.Drawing.Point(12, 22);
            this.grboxPhieu.Name = "grboxPhieu";
            this.grboxPhieu.Size = new System.Drawing.Size(136, 100);
            this.grboxPhieu.TabIndex = 0;
            this.grboxPhieu.TabStop = false;
            this.grboxPhieu.Text = "Phiếu Nhập/Xuất";
            // 
            // radioPhieuXuat
            // 
            this.radioPhieuXuat.AutoSize = true;
            this.radioPhieuXuat.Location = new System.Drawing.Point(15, 62);
            this.radioPhieuXuat.Name = "radioPhieuXuat";
            this.radioPhieuXuat.Size = new System.Drawing.Size(96, 17);
            this.radioPhieuXuat.TabIndex = 1;
            this.radioPhieuXuat.Text = "Phiếu xuất kho";
            this.radioPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // radioPhieuNhap
            // 
            this.radioPhieuNhap.AutoSize = true;
            this.radioPhieuNhap.Checked = true;
            this.radioPhieuNhap.Location = new System.Drawing.Point(15, 29);
            this.radioPhieuNhap.Name = "radioPhieuNhap";
            this.radioPhieuNhap.Size = new System.Drawing.Size(100, 17);
            this.radioPhieuNhap.TabIndex = 0;
            this.radioPhieuNhap.TabStop = true;
            this.radioPhieuNhap.Text = "Phiếu nhập kho";
            this.radioPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // grboxThangNam
            // 
            this.grboxThangNam.Controls.Add(this.radioNam);
            this.grboxThangNam.Controls.Add(this.radioThang);
            this.grboxThangNam.Location = new System.Drawing.Point(182, 22);
            this.grboxThangNam.Name = "grboxThangNam";
            this.grboxThangNam.Size = new System.Drawing.Size(136, 100);
            this.grboxThangNam.TabIndex = 1;
            this.grboxThangNam.TabStop = false;
            this.grboxThangNam.Text = "Thống kê Tháng/Năm";
            this.grboxThangNam.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(29, 62);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(47, 17);
            this.radioNam.TabIndex = 1;
            this.radioNam.Text = "Năm";
            this.radioNam.UseVisualStyleBackColor = true;
            this.radioNam.CheckedChanged += new System.EventHandler(this.radioThangNam_CheckedChanged);
            // 
            // radioThang
            // 
            this.radioThang.AutoSize = true;
            this.radioThang.Checked = true;
            this.radioThang.Location = new System.Drawing.Point(29, 29);
            this.radioThang.Name = "radioThang";
            this.radioThang.Size = new System.Drawing.Size(56, 17);
            this.radioThang.TabIndex = 0;
            this.radioThang.TabStop = true;
            this.radioThang.Text = "Tháng";
            this.radioThang.UseVisualStyleBackColor = true;
            this.radioThang.CheckedChanged += new System.EventHandler(this.radioThangNam_CheckedChanged);
            // 
            // grboxCombobox
            // 
            this.grboxCombobox.Controls.Add(this.cboThangNam);
            this.grboxCombobox.Location = new System.Drawing.Point(347, 22);
            this.grboxCombobox.Name = "grboxCombobox";
            this.grboxCombobox.Size = new System.Drawing.Size(231, 100);
            this.grboxCombobox.TabIndex = 2;
            this.grboxCombobox.TabStop = false;
            this.grboxCombobox.Text = "Mốc Thời Gian";
            this.grboxCombobox.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cboThangNam
            // 
            this.cboThangNam.FormattingEnabled = true;
            this.cboThangNam.Location = new System.Drawing.Point(26, 43);
            this.cboThangNam.Name = "cboThangNam";
            this.cboThangNam.Size = new System.Drawing.Size(178, 21);
            this.cboThangNam.TabIndex = 0;
            this.cboThangNam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboThangNam_KeyDown);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(605, 39);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(77, 29);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "    Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnXemIn
            // 
            this.btnXemIn.Image = ((System.Drawing.Image)(resources.GetObject("btnXemIn.Image")));
            this.btnXemIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemIn.Location = new System.Drawing.Point(605, 78);
            this.btnXemIn.Name = "btnXemIn";
            this.btnXemIn.Size = new System.Drawing.Size(77, 29);
            this.btnXemIn.TabIndex = 4;
            this.btnXemIn.Text = "  Xem in";
            this.btnXemIn.UseVisualStyleBackColor = true;
            this.btnXemIn.Click += new System.EventHandler(this.btnXemIn_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(12, 147);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.Size = new System.Drawing.Size(671, 335);
            this.dgvData.TabIndex = 5;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 498);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnXemIn);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.grboxCombobox);
            this.Controls.Add(this.grboxThangNam);
            this.Controls.Add(this.grboxPhieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button btnXemIn;
        private System.Windows.Forms.DataGridView dgvData;
    }
}