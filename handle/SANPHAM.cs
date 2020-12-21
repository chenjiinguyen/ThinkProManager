using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProManager.handle
{
    class SANPHAM
    {
        DataSet data;
        DataTable _SANPHAM;
        public SANPHAM(DataSet _data)
        {
            data = _data;
            _SANPHAM = data.Tables["SANPHAM"];
            _SANPHAM.PrimaryKey = new DataColumn[] { _SANPHAM.Columns["ID_SP"] };
        }

        public bool add(string _idSP, string _idBrand, string _idLoai, string _tenSP, string _anhSP, 
                    int _giaTien, string _idTinhTrang, int _thoiHanBH, string _thongTin)
        {
            try
            {
                DataRow row = _SANPHAM.NewRow();
                row["ID_SP"] = _idSP;
                row["ID_BRAND"] = _idBrand;
                row["ID_LOAI"] = _idLoai;
                row["TENSP"] = _tenSP;
                row["ANH_SP"] = _anhSP;
                row["GIATIEN"] = _giaTien;
                row["SOLUONG"] = 0;
                row["DONVITINH"] = "VND";
                row["ID_TINHTRANG"] = _idTinhTrang;
                row["THOIHAN_BH"] = _thoiHanBH;
                row["THONGTIN"] = _thongTin;
                _SANPHAM.Rows.Add(row);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
