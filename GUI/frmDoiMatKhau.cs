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
    public partial class frmDoiMatKhau : Form
    {
        main handle = new main();
        DataRow user;
        string IDUSER;
        public frmDoiMatKhau(string _idUser)
        {
            InitializeComponent();
            IDUSER = _idUser;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            user = handle.nguoidung.findID(IDUSER);
            pbAvatar.Load(user["AVATAR"].ToString());
            txtHoTen.Text = user["HOTEN"].ToString();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string password_old = txtMKCU.Text.Trim();
            string password_new = txtMKMOI.Text.Trim();
            string password_confirm = txtXNMK.Text.Trim();
            if(password_new == password_confirm)
            {
                string Email = user["EMAIL"].ToString().Trim();
                int notice = handle.nguoidung.updatePassword(Email, password_old, password_new);
                if(notice == 0)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng");
                    
                }
                else if(notice == 1)
                {
                    handle.save("NGUOIDUNG");
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng với Mật khẩu mới");
            }

        }

        
    }
}
