using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkProManager.handle;

namespace ThinkProManager.GUI
{
    public partial class frmMain : Form
    {
        main handle = new main();
        DataRow user;
        string IDUSER;
        public bool Logout = false;
        public frmMain(string _idUser)
        {
            InitializeComponent();
            IDUSER = _idUser;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            user = handle.nguoidung.findID(IDUSER);
            string idVaiTro = user["ID_VAITRO"].ToString();
            tsmiName.Text = "[" + handle.nguoidung.roleName(idVaiTro) +"] "+ user["HOTEN"].ToString();
            this.Text = handle.nguoidung.roleName(idVaiTro) + " - Ứng Dụng Quản Lý - ThinkPro";
            tsmiHoaDon.Visible = handle.nguoidung.checkRole(idVaiTro, "HOADON");
            tsmiNguoiDung.Visible = handle.nguoidung.checkRole(idVaiTro, "NGUOIDUNG");
            tsmiSanPham.Visible = handle.nguoidung.checkRole(idVaiTro, "SANPHAM");
        }

        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            Logout = true;
            this.Close();
        }

        private void tsmiThongTin_Click(object sender, EventArgs e)
        {
            frmInfo frmInfo = new frmInfo(IDUSER);
            frmInfo.MdiParent = this;
            frmInfo.Show();
        }

        private void tsmiDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau(IDUSER);
            frmDoiMatKhau.MdiParent = this;
            frmDoiMatKhau.Show();
        }

        private void tsmiSanPham_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiNhapHang_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiNguoiDung_Click(object sender, EventArgs e)
        {
            
        }

		private void tsmiQuanLyNhap_Click(object sender, EventArgs e)
		{
            frmPhieuNhap frmPhieuNhap = new frmPhieuNhap(IDUSER);
            frmPhieuNhap.MdiParent = this;
            frmPhieuNhap.Show();
        }

		private void tsmiQuanLySanPham_Click(object sender, EventArgs e)
		{
            frmSanPham frmSanPham = new frmSanPham(IDUSER);
            frmSanPham.MdiParent = this;
            frmSanPham.Show();
        }

		private void tsmiQuanLyNguoiDung_Click(object sender, EventArgs e)
		{
            frmQuanLyNhanVien frmQuanLyNhanVien = new frmQuanLyNhanVien(IDUSER);
            frmQuanLyNhanVien.MdiParent = this;
            frmQuanLyNhanVien.Show();
        }

        private void tsmiNhapHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon(IDUSER);
            frmHoaDon.MdiParent = this;
            frmHoaDon.Show();
        }
    }
}
