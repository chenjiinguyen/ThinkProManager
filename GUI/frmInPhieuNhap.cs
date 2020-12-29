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
using ThinkProManager.handle;

namespace ThinkProManager.GUI
{
    public partial class frmInPhieuNhap : Form
    {
        main handle = new main();
        public frmInPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmInPhieuNhap_Load(object sender, EventArgs e)
        {
            cbxPhieuNhap.DataSource = handle.get("PHIEUNHAP");
            cbxPhieuNhap.DisplayMember = "ID_PN";
            cbxPhieuNhap.ValueMember = "ID_PN";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string maPN = cbxPhieuNhap.SelectedValue.ToString();
            DataRow pn = handle.phieunhap.find(maPN);
            if(pn != null)
            {
                DataRow nguoidung = handle.nguoidung.findID(pn["ID_NV"].ToString()) ;
                ChiTietPN rpt = new ChiTietPN();

                DataTable CTPN = handle.phieunhap.getTableCTPN(maPN);
                rpt.SetDataSource(CTPN);


                rpt.SetParameterValue("MaPN", maPN);
                rpt.SetParameterValue("HoTen", nguoidung["HOTEN"]);
                rpt.SetParameterValue("DienThoai", nguoidung["DIENTHOAI"]);
                rpt.SetParameterValue("DiaChi", nguoidung["DIACHI"]);
                rpt.SetParameterValue("ThanhToan", CTPN.AsEnumerable().Sum(t=> t.Field<Int64>("THANHTIEN")));
                rpt.SetParameterValue("NgayXuatHD", pn["NGAYNHAP"]);

                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            
        }
    }
}
