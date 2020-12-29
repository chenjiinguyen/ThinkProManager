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
        public string IDUSER;
        public bool LogonSuccessful = false;
        public frmLogin()
        {
            InitializeComponent();

            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (handle.nguoidung.IsValidEmail(email))
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
                    DataRow user = handle.nguoidung.findEmail(email);
                    IDUSER = user["ID_USER"].ToString().Trim();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //IDUSER = "USER001";
            //LogonSuccessful = true;

            //this.Close();
        }
    }
}
