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
    public partial class frmLogin : Form
    {
        main handle = new main();
        public string EMAIL;
        public bool LogonSuccessful = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //handle.nguoidung.add("USER001", "duyntp2000@gmail.com", "nguoidung", null, "Nguyễn Duy", "0966740812", "TPHCM", "https://i.imgur.com/8qKkOpe.jpg");
            //handle.save("NGUOIDUNG");
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (IsValidEmail(email))
            {
                int notice = handle.nguoidung.login(email, password);
                if(notice == -1)
                {
                    MessageBox.Show("Người dùng không tồn tại");
                }else if(notice == 0)
                {
                    MessageBox.Show("Sai mật khẩu");
                }
                else if (notice == -2)
                {
                    MessageBox.Show("Bạn không có quyền đăng nhập vào đây");
                }
                else
                {
                    EMAIL = email;
                    LogonSuccessful = true;
                    //MessageBox.Show("Đăng nhập thành công");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email");
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
           
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}
