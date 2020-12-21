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
        string Email;
        public bool Logout = false;
        public frmMain(string _Email)
        {
            InitializeComponent();
            Email = _Email;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            user = handle.nguoidung.findEmail(Email);
            string idVaiTro = user["ID_VAITRO"].ToString();
            tsmiName.Text = "[" + handle.nguoidung.roleName(idVaiTro) +"] "+ user["HOTEN"].ToString();
            this.Text = handle.nguoidung.roleName(idVaiTro) + " - Ứng Dụng Quản Lý - ThinkPro";
            tsmiHoaDon.Enabled = handle.nguoidung.checkRole(idVaiTro, "HOADON");
            tsmiNguoiDung.Enabled = handle.nguoidung.checkRole(idVaiTro, "NGUOIDUNG");
        }

        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            Logout = true;
            this.Close();
        }

        private void tsmiThongTin_Click(object sender, EventArgs e)
        {
            frmInfo frmInfo = new frmInfo(Email);
            frmInfo.MdiParent = this;
            frmInfo.Show();
        }

        private void tsmiDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau(Email);
            frmDoiMatKhau.MdiParent = this;
            frmDoiMatKhau.Show();
        }
    }
}
