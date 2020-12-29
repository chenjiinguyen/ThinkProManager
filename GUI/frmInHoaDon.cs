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
    public partial class frmInHoaDon : Form
    {
        main handle = new main();
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            cbxHoaDon.DataSource = handle.get("HOADON");
            cbxHoaDon.DisplayMember = "ID_HD";
            cbxHoaDon.ValueMember = "ID_HD";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string maHD = cbxHoaDon.SelectedValue.ToString();
            DataRow hd = handle.hoadon.findHD(maHD);
            if(hd != null)
            {
                DataRow nguoidung = handle.nguoidung.findID(hd["ID_USER"].ToString()) ;
                ChiTietHD rpt = new ChiTietHD();

                DataTable CTHD = handle.hoadon.getTableCTHD(maHD);
                rpt.SetDataSource(CTHD);

                rpt.SetParameterValue("MaHD", maHD);
                rpt.SetParameterValue("HoTen", nguoidung["HOTEN"]);
                rpt.SetParameterValue("DienThoai", nguoidung["DIENTHOAI"]);
                rpt.SetParameterValue("DiaChi", nguoidung["DIACHI"]);
                rpt.SetParameterValue("ThanhToan", CTHD.AsEnumerable().Sum(t=> t.Field<int>("THANHTIEN")));
                rpt.SetParameterValue("NgayXuatHD", hd["NGAYLAPHD"]);

                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            
        }
    }
}
