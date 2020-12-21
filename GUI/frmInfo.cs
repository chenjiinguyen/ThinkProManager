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
    public partial class frmInfo : Form
    {
        main handle = new main();
        DataRow user;
        string Email;
        public frmInfo(string _Email)
        {
            InitializeComponent();
            Email = _Email;
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            user = handle.nguoidung.findEmail(Email);
            string idVaiTro = user["ID_VAITRO"].ToString();
            pbAvatar.Load(user["AVATAR"].ToString());
            txtHoTen.Text = user["HOTEN"].ToString();
            txtVaiTro.Text = handle.nguoidung.roleName(idVaiTro);
            txtSDT.Text = user["DIENTHOAI"].ToString();
            txtEmail.Text = Email;
        }
    }
}
