using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkProManager.handle;

namespace ThinkProManager.GUI
{
    public partial class frmThongKe : Form
    {
        main handle = new main();
        DataRow user;
        string IDUSER;
        public frmThongKe(string _IDUSER)
        {
            InitializeComponent();
            IDUSER = _IDUSER;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            user = handle.nguoidung.findID(IDUSER);
            cboThangNam.Text = "";
            cboThangNam.Items.Clear();
            DateTime DateBegin = DateTime.Parse("2000/01/01 00:00:00");
            DateTime DateEnd = DateTime.Now.Date.Add(new TimeSpan(23, 59, 59));
            DateTime dt = DateEnd;
            while (dt >= DateBegin)
            {
                cboThangNam.Items.Add(dt.ToString("MM/yyyy"));
                dt = dt.AddMonths(-1);
            }
        }

        private void radioThangNam_CheckedChanged(object sender, EventArgs e)
        {
            cboThangNam.Text = "";
            cboThangNam.Items.Clear();
            DateTime DateBegin = DateTime.Parse("2000/01/01 00:00:00");
            DateTime DateEnd = DateTime.Now.Date.Add(new TimeSpan(23, 59, 59));
            if (radioNam.Checked)
            {
                DateTime dt = DateEnd;
                while (dt >= DateBegin)
                {
                    cboThangNam.Items.Add(dt.ToString("yyyy"));
                    dt = dt.AddYears(-1);
                }
            }
            else
            {
                DateTime dt = DateEnd;
                while (dt >= DateBegin)
                {
                    cboThangNam.Items.Add(dt.ToString("MM/yyyy"));
                    dt = dt.AddMonths(-1);
                }
            }

        }

        private void cboThangNam_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(cboThangNam.Text.Trim() != "")
            {
                dgvData.DataSource = null;
                string ThangNam = cboThangNam.Text.Trim();
                DateTime begin;
                DateTime end;
                DataTable result;
                string format = "dd/MM/yyyy HH:mm:ss";
                CultureInfo provider = CultureInfo.InvariantCulture;
                if (radioNam.Checked)
                {
                    begin = DateTime.ParseExact("01/01/" + ThangNam + " 00:00:00", format, provider);
                    end = DateTime.ParseExact("31/12/" + ThangNam + " 23:59:59", format, provider);
                }
                else
                {
                    begin = DateTime.ParseExact("01/" + ThangNam + " 00:00:00", format, provider);
                    end = DateTime.ParseExact("01/" + ThangNam + " 23:59:59", format, provider).AddMonths(1).AddDays(-1);
                }

                if (radioPhieuNhap.Checked)
                {
                    result = handle.thongke.ThongKeNhapKho(begin, end);
                    dgvData.DataSource = result;
                    dgvData.Columns[0].HeaderText = "Mã sản phẩm";
                    dgvData.Columns[1].HeaderText = "Tên sản phẩm";
                    dgvData.Columns[2].HeaderText = "Số lượng nhập";
                    dgvData.Columns[3].HeaderText = "Đơn giá nhập";
                }
                else
                {
                    result = handle.thongke.ThongKeXuatKho(begin, end);
                    dgvData.DataSource = result;
                    dgvData.Columns[0].HeaderText = "Mã sản phẩm";
                    dgvData.Columns[1].HeaderText = "Tên sản phẩm";
                    dgvData.Columns[2].HeaderText = "Số lượng bán hàng";
                    dgvData.Columns[3].HeaderText = "Giá bán";
                }
                
                
            }
        }

        private void btnXemIn_Click(object sender, EventArgs e)
        {
            if (cboThangNam.Text.Trim() != "")
            {
                dgvData.DataSource = null;
                string ThangNam = cboThangNam.Text.Trim();
                DateTime begin;
                DateTime end;
                DataTable result;
                string format = "dd/MM/yyyy HH:mm:ss";
                CultureInfo provider = CultureInfo.InvariantCulture;
                bool nhapkhau;
                if (radioNam.Checked)
                {
                    begin = DateTime.ParseExact("01/01/" + ThangNam + " 00:00:00", format, provider);
                    end = DateTime.ParseExact("31/12/" + ThangNam + " 23:59:59", format, provider);
                }
                else
                {
                    begin = DateTime.ParseExact("01/" + ThangNam + " 00:00:00", format, provider);
                    end = DateTime.ParseExact("01/" + ThangNam + " 23:59:59", format, provider).AddMonths(1).AddDays(-1);
                }

                if (radioPhieuNhap.Checked)
                {
                    result = handle.thongke.ThongKeNhapKho(begin, end);
                    nhapkhau = true;
                }
                else
                {
                    result = handle.thongke.ThongKeXuatKho(begin, end);
                    nhapkhau = false;
                }
                frmInThongKeCR frm = new frmInThongKeCR(nhapkhau,user, result, begin, end);
                frm.MdiParent = this.ParentForm;
                frm.Show();

            }

            
        }
    }
}
