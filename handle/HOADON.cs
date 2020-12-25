using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProManager.handle
{
    class HOADON
    {

        DataSet data;
        DataTable _HOADON;
        DataTable _CHITIETHD;
        public HOADON(DataSet _data)
        {
            data = _data;
            _HOADON = data.Tables["HOADON"];
            _CHITIETHD = data.Tables["CHITIETHD"];
            _HOADON.PrimaryKey = new DataColumn[] { _HOADON.Columns["ID_HD"] };
            _CHITIETHD.PrimaryKey = new DataColumn[] { _CHITIETHD.Columns["ID_HD"], _CHITIETHD.Columns["ID_SP"] };
        }

        public bool add(string _idHD,string _idUser, DateTime _ngayLapHD, string _idNV)
        {
            try
            {
                DataRow row = _HOADON.NewRow();
                row["ID_HD"] = _idHD;
                row["ID_USER"] = _idUser;
                row["NGAYLAPHD"] = _ngayLapHD;
                row["ID_NV"] = _idNV;
                _HOADON.Rows.Add(row);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool update(string _idHD, string _idUser, DateTime _ngayLapHD, string _idNV)
        {
            try
            {
                DataRow row = _HOADON.Rows.Find(_idHD);
                row["ID_USER"] = _idUser;
                row["NGAYLAPHD"] = _ngayLapHD;
                row["ID_NV"] = _idNV;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(string _idHD)
        {
            try
            {
                DataRow row = _HOADON.Rows.Find(_idHD);
                row.Delete();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool addCTHD(string _idHD, string _idSP, int _soLuong)
        {
            try
            {
                DataRow row = _CHITIETHD.NewRow();
                row["ID_HD"] = _idHD;
                row["ID_SP"] = _idSP;
                row["SOLUONG"] = _soLuong;
                _CHITIETHD.Rows.Add(row);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool updateCTHD(string _idHD, string _idSP, int _soLuong)
        {
            try
            {
                DataRow row = _CHITIETHD.Rows.Find(new object[] { _idHD , _idSP });
                row["SOLUONG"] = _soLuong;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteCTHD(string _idHD, string _idSP)
        {
            try
            {
                DataRow row = _CHITIETHD.Rows.Find(new object[] { _idHD, _idSP });
                row.Delete();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataRow findHD(string _idHD)
        {
            return _HOADON.Rows.Find(_idHD);
        }

        public DataTable findCTHD(string _idHD)
        {
            DataTable result = _CHITIETHD.Clone();
            DataRow[] Rows = _CHITIETHD.Select("ID_HD = '" + _idHD + "'");
            foreach(DataRow row in Rows)
            {
                result.ImportRow(row);
            }
            return result;
        }

        public DataTable getTableCTHD(string _idHD)
        {
            DataTable CTHD = findCTHD(_idHD);
            DataTable result = main._JoinDataTables(CTHD, data.Tables["SANPHAM"], (row1, row2) => row1.Field<string>("ID_SP") == row2.Field<string>("ID_SP"));
            DataTable final = main._JoinDataTables(result, data.Tables["THUONGHIEU"], (row1, row2) => row1.Field<string>("ID_BRAND") == row2.Field<string>("ID_BRAND"));
            DataColumn column = new DataColumn();
            column.ColumnName = "THANHTIEN";
            final.Columns.Add(column);
            final.Columns["THANHTIEN"].Expression = "SOLUONG*GIATIEN";
            return final;
        }



        public string GeneratorID()
        {
            DateTime DateTimeNow = DateTime.Now.Date.Add(new TimeSpan(0, 0, 0));
            DataRow[] rowList = _HOADON.AsEnumerable().OrderByDescending(x => x.Field<DateTime>("NGAYLAPHD")).ToArray();
            int Int_Old_ID = 0;
            if (rowList.Count() > 0)
            {
                DataRow row = rowList[0];
                if (row != null)
                {
                    string Old_ID = row["ID_HD"].ToString().Substring(10, 4);
                    Int_Old_ID = int.Parse(Old_ID);
                }
            }

            string prefixValue = "HD";
            string prefixDate = DateTimeNow.ToString("yyyyMMdd");
            string prefixNumber = (Int_Old_ID + 1).ToString("D" + 4);

            return prefixValue + prefixDate+ prefixNumber;
        }
    }
}
