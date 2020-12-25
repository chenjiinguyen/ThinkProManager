using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkProManager.GUI;

namespace ThinkProManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool Logout = false;
            do
            {
                frmLogin frmLogin = new frmLogin();
                Application.Run(frmLogin);
                if (frmLogin.LogonSuccessful)
                {
                    string IDUSER = frmLogin.IDUSER;
                    frmMain frmMain = new frmMain(IDUSER);
                    Application.Run(frmMain);
                    Logout = frmMain.Logout;
                }
                else
                {
                    Logout = false;
                    Application.Exit();
                }
            } while (Logout);
            
        }
    }
}
