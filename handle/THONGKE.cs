using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProManager.handle
{
    class THONGKE
    {
        DataSet data;
        DataTable _HOADON;
        DataTable _CHITIETHD;
        DataTable _PHIEUNHAP;
        DataTable _CHITIETPN;
        public THONGKE(DataSet _data)
        {
            data = _data;
            _PHIEUNHAP = data.Tables["PHIEUNHAP"];
            _CHITIETPN = data.Tables["CHITIETPN"];
            _HOADON = data.Tables["HOADON"];
            _CHITIETHD = data.Tables["CHITIETHD"];
        }

        public DataTable ThongKeNhapKho(DateTime begin,DateTime end)
        {
            DataTable result = new CrystalReports.THINKPRODataset.ThongKeNKDataTable().Clone();
            foreach (DataRow SP in data.Tables["SANPHAM"].Rows)
            {
                List<int> GIANHAP = new List<int>();
                DataRow NK = result.NewRow();
                NK["MASP"] = SP["ID_SP"];
                NK["TENSP"] = SP["TENSP"];
                NK["SOLUONGNHAP"] = 0;
                foreach (DataRow CTPN in _CHITIETPN.Rows)
                {
                    if(NK["MASP"].ToString() == CTPN["ID_SP"].ToString())
                    {
                        DataRow PN = _PHIEUNHAP.AsEnumerable().SingleOrDefault(t => t.Field<string>("ID_PN") == CTPN.Field<string>("ID_PN"));
                        if (PN != null)
                        {
                            if (DateTime.Compare(begin, PN.Field<DateTime>("NGAYNHAP")) <= 0 && DateTime.Compare(PN.Field<DateTime>("NGAYNHAP"), end) <= 0)
                            {
                                GIANHAP.Add(CTPN.Field<int>("DONGIANHAP"));
                                NK["SOLUONGNHAP"] = NK.Field<int>("SOLUONGNHAP") + CTPN.Field<int>("SOLUONGNHAP");
                            }
                        }
                    }
                    
                }
                if(NK.Field<int>("SOLUONGNHAP") > 0)
                {
                    NK["GIANHAP"] = GIANHAP.Average();
                    result.Rows.Add(NK);
                }
            }

            return result;
        }

        public DataTable ThongKeXuatKho(DateTime begin, DateTime end)
        {
            DataTable result = new CrystalReports.THINKPRODataset.ThongKeXKDataTable().Clone();
            foreach (DataRow SP in data.Tables["SANPHAM"].Rows)
            {
                DataRow XK = result.NewRow();
                XK["MASP"] = SP["ID_SP"];
                XK["TENSP"] = SP["TENSP"];
                XK["SOLUONGXUAT"] = 0;
                XK["GIABAN"] = SP.Field<int>("GIATIEN");
                foreach(DataRow CTHD in _CHITIETHD.Rows)
                {
                    if (XK["MASP"].ToString() == CTHD["ID_SP"].ToString())
                    {
                        DataRow HD = _HOADON.AsEnumerable().SingleOrDefault(t => t.Field<string>("ID_HD") == CTHD.Field<string>("ID_HD"));
                        if (HD != null)
                        {
                            if (DateTime.Compare(begin, HD.Field<DateTime>("NGAYLAPHD")) <= 0 && DateTime.Compare(HD.Field<DateTime>("NGAYLAPHD"), end) <= 0)
                            {
                                XK["SOLUONGXUAT"] = XK.Field<int>("SOLUONGXUAT") + CTHD.Field<int>("SOLUONG");
                            }
                        }
                    }
                }
                if(XK.Field<int>("SOLUONGXUAT") > 0)
                {
                    result.Rows.Add(XK);
                }
            }

            return result;
        }


    }
}
