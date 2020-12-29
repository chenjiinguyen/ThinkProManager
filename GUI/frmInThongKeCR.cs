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
using ThinkProManager.CrystalReports;


namespace ThinkProManager.GUI
{
    public partial class frmInThongKeCR : Form
    {
        DataRow user;
        DataTable data;
        DateTime begin;
        DateTime end;
        bool nhapkhau;
        main handle = new main();
        public frmInThongKeCR(bool _nhapkhau,DataRow _user,DataTable _data,DateTime _begin,DateTime _end)
        {
            InitializeComponent();
            user = _user;
            data = _data;
            begin = _begin;
            end = _end;
            nhapkhau = _nhapkhau;
        }

        private void InThongKeCR_Load(object sender, EventArgs e)
        {
            if (data != null)
            {
                if (nhapkhau)
                {
                    ThongKeNhap rpt = new ThongKeNhap();
                    rpt.SetDataSource(data);


                    rpt.SetParameterValue("NhanVienTruc", user.Field<string>("HOTEN"));
                    rpt.SetParameterValue("NgayBatDau", begin);
                    rpt.SetParameterValue("NgayKetThuc", end);
                    rpt.SetParameterValue("TongTien", 0);

                    crystalReportViewer1.ReportSource = rpt;
                    crystalReportViewer1.Refresh();
                }
                else
                {
                    ThongKeXuat rpt = new ThongKeXuat();
                    rpt.SetDataSource(data);


                    rpt.SetParameterValue("NhanVienTruc", user.Field<string>("HOTEN"));
                    rpt.SetParameterValue("NgayBatDau", begin);
                    rpt.SetParameterValue("NgayKetThuc", end);
                    rpt.SetParameterValue("TongTien", 0);

                    crystalReportViewer1.ReportSource = rpt;
                    crystalReportViewer1.Refresh();
                }
                    

                
            }
        }
    }
}
