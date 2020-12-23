using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkProManager.CrystalReports;

namespace ThinkProManager.GUI
{
    public partial class frmInPhieuNhap : Form
    {
        public frmInPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmInPhieuNhap_Load(object sender, EventArgs e)
        {
            ChiTietHD rpt = new ChiTietHD();
            rpt.SetDatabaseLogon("sa", "Pa$$w0rd", "localhost", "THINKPRO");
            //rpt.SetDataSource(tbl);

            //int slSV = tbl.Rows.Count;
            rpt.SetParameterValue("HoTen", "Quỳnh");
            rpt.SetParameterValue("DienThoai", "02382919");
            rpt.SetParameterValue("DiaChi", "Tân Phú");
            rpt.SetParameterValue("ThanhToan", 200000);
            rpt.SetParameterValue("NgayXuatHD", "22/12/2020");

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
