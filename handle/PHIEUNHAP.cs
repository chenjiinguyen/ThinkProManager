using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProManager.handle
{
    class PHIEUNHAP
    {
        DataSet data;
        DataTable _PHIEUNHAP;
        DataTable _CHITIETPN;
        public PHIEUNHAP(DataSet _data)
        {
            data = _data;
            _PHIEUNHAP = data.Tables["PHIEUNHAP"];
            _CHITIETPN = data.Tables["CHITIETPN"];
            _PHIEUNHAP.PrimaryKey = new DataColumn[] { _PHIEUNHAP.Columns["ID_PN"] };
            _CHITIETPN.PrimaryKey = new DataColumn[] { _CHITIETPN.Columns["ID_PN"], _CHITIETPN.Columns["ID_SP"] };
        }

        public bool add(string _idPN, string _idNhanVien, string _idNCC)
        {
            try
            {
                DataRow row = _PHIEUNHAP.NewRow();
                row["ID_PN"] = _idPN;
                row["ID_NV"] = _idNhanVien;
                row["ID_NCC"] = _idNCC;
                row["NGAYNHAP"] = DateTime.Now;
                _PHIEUNHAP.Rows.Add(row);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool update(string _idPN, string _idNhanVien, string _idNCC)
        {
            try
            {
                DataRow row = _PHIEUNHAP.Rows.Find(_idPN);
                row["ID_NV"] = _idNhanVien;
                row["ID_NCC"] = _idNCC;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool delete(string _idPN)
        {
            try
            {
                deleteCTPN(_idPN);
                _PHIEUNHAP.Rows.Find(_idPN).Delete();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataRow find(string _idPN)
        {
            return _PHIEUNHAP.Rows.Find(_idPN);
        }

        public bool addCTPN(string _idPN, string _idSP, int _soLuong, int _donGia)
        {
            try
            {
                DataRow row = _CHITIETPN.NewRow();
                row["ID_PN"] = _idPN;
                row["ID_SP"] = _idSP;
                row["SOLUONGNHAP"] = _soLuong;
                row["DONGIANHAP"] = _donGia;
                _CHITIETPN.Rows.Add(row);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool updateCTPN(string _idPN, string _idSP, int _soLuong, int _donGia)
        {
            try
            {
                DataRow row = findCTPN(_idPN, _idSP);
                row["SOLUONGNHAP"] = _soLuong;
                row["DONGIANHAP"] = _donGia;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteCTPN(string _idPN)
        {
            try
            {
                foreach(DataRow row in _CHITIETPN.Rows)
                {
                    if (row["ID_PN"] == _idPN)
                        row.Delete();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataRow findCTPN(string _idPN,string _idSP)
        {
            return _CHITIETPN.Rows.Find(new object[] { _idPN, _idSP });
        }

        public long ThanhTien(string _idPN)
        {
            long result = 0;
            DataRow[] listRow = _CHITIETPN.Select("ID_PN = '" + _idPN + "'");
            foreach (DataRow row in listRow)
            {
                result += row.Field<int>("DONGIANHAP") * row.Field<int>("SOLUONGNHAP");
            }
            return result;
        }

        public string GeneratorID()
        {
            string I = "I";
            DateTime DateTimeNow = DateTime.Now.Date.Add(new TimeSpan(0, 0, 0));
            DataRow[] rowList = _PHIEUNHAP.AsEnumerable().OrderByDescending(x => x.Field<DateTime>("NGAYNHAP")).ToArray();
            int Int_Old_ID = 0;
            if(rowList.Count() > 0)
            {
                DataRow row = rowList[0];
                if (row != null)
                {
                    string Old_ID = row["ID_PN"].ToString().Split('I')[1];
                    Int_Old_ID = int.Parse(Old_ID);
                }
            }
            
            string prefixValue = "NP";
            string prefixDate = DateTimeNow.ToString("yyyyMMdd");
            string prefixNumber = (Int_Old_ID + 1).ToString("D" + 4);
            
            return prefixValue + prefixDate + I + prefixNumber;
        }
    }
}
