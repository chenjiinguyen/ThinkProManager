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
        DataTable _THONGTIN;
        public SANPHAM(DataSet _data)
        {
            data = _data;
            _SANPHAM = data.Tables["SANPHAM"];
            _THONGTIN = data.Tables["THONGTIN"];
            _SANPHAM.PrimaryKey = new DataColumn[] { _SANPHAM.Columns["ID_SP"] };
            _THONGTIN.PrimaryKey = new DataColumn[] { _THONGTIN.Columns["ID_SP"] };
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

        public bool update(string _idSP, string _idBrand, string _idLoai, string _tenSP, string _anhSP,
                    int _giaTien, string _idTinhTrang, int _thoiHanBH, string _thongTin)
        {
            try
            {
                DataRow row = _SANPHAM.Rows.Find(_idSP);
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
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataRow find(string _idSP)
        {
            return _SANPHAM.Rows.Find(_idSP);
        }

        public bool delete(string _idSP)
        {
            try
            {
                if(findThongTin(_idSP) != null)
                {
                    deleteThongTin(_idSP);
                }
                _SANPHAM.Rows.Find(_idSP).Delete();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addThongTin(string _idSP, string _viXuLy, string _manHinh, string _ram, string _cardDoHoa,
                    string _luuTru, string _pin, string _ketNoi, string _trongLuong, string _heDieuHanh, string _mauSac)
        {
            try
            {
                DataRow row = _THONGTIN.NewRow();
                row["ID_SP"] = _idSP;
                row["VIXULY"] = (_viXuLy.Trim().Length > 0) ? _viXuLy: null ;
                row["MANHINH"] = (_manHinh.Trim().Length > 0) ? _manHinh : null;
                row["RAM"] = (_ram.Trim().Length > 0) ? _ram : null;
                row["CARDDOHOA"] = (_cardDoHoa.Trim().Length > 0) ? _cardDoHoa : null;
                row["LUUTRU"] = (_luuTru.Trim().Length > 0) ? _luuTru : null;
                row["PIN"] = (_pin.Trim().Length > 0) ? _pin : null;
                row["KETNOI"] = (_ketNoi.Trim().Length > 0) ? _ketNoi : null;
                row["TRONGLUONG"] = (_trongLuong.Trim().Length > 0) ? _trongLuong : null;
                row["HEDIEUHANH"] = (_heDieuHanh.Trim().Length > 0) ? _heDieuHanh : null;
                row["MAUSAC"] = (_mauSac.Trim().Length > 0) ? _mauSac : null;
                _THONGTIN.Rows.Add(row);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addThongTin(DataRow row)
        {
            try
            {
                row["VIXULY"] = (row["VIXULY"].ToString().Trim().Length > 0) ? row["VIXULY"].ToString() : null;
                row["MANHINH"] = (row["MANHINH"].ToString().Trim().Length > 0) ? row["MANHINH"].ToString() : null;
                row["RAM"] = (row["RAM"].ToString().Trim().Length > 0) ? row["RAM"].ToString() : null;
                row["CARDDOHOA"] = (row["CARDDOHOA"].ToString().Trim().Length > 0) ? row["CARDDOHOA"].ToString() : null;
                row["LUUTRU"] = (row["LUUTRU"].ToString().Trim().Length > 0) ? row["LUUTRU"].ToString() : null;
                row["PIN"] = (row["PIN"].ToString().Trim().Length > 0) ? row["PIN"].ToString() : null;
                row["KETNOI"] = (row["KETNOI"].ToString().Trim().Length > 0) ? row["KETNOI"].ToString() : null;
                row["TRONGLUONG"] = (row["TRONGLUONG"].ToString().Trim().Length > 0) ? row["TRONGLUONG"].ToString() : null;
                row["HEDIEUHANH"] = (row["HEDIEUHANH"].ToString().Trim().Length > 0) ? row["HEDIEUHANH"].ToString() : null;
                row["MAUSAC"] = (row["MAUSAC"].ToString().Trim().Length > 0) ? row["MAUSAC"].ToString() : null;
                _THONGTIN.Rows.Add(row);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool updateThongTin(string _idSP, string _viXuLy, string _manHinh, string _ram, string _cardDoHoa,
                    string _luuTru, string _pin, string _ketNoi, string _trongLuong, string _heDieuHanh, string _mauSac)
        {
            try
            {
                DataRow row = _THONGTIN.Rows.Find(_idSP);
                row["ID_SP"] = _idSP;
                row["VIXULY"] = (_viXuLy.Trim().Length > 0) ? _viXuLy : null;
                row["MANHINH"] = (_manHinh.Trim().Length > 0) ? _manHinh : null;
                row["RAM"] = (_ram.Trim().Length > 0) ? _ram : null;
                row["CARDDOHOA"] = (_cardDoHoa.Trim().Length > 0) ? _cardDoHoa : null;
                row["LUUTRU"] = (_luuTru.Trim().Length > 0) ? _luuTru : null;
                row["PIN"] = (_pin.Trim().Length > 0) ? _pin : null;
                row["KETNOI"] = (_ketNoi.Trim().Length > 0) ? _ketNoi : null;
                row["TRONGLUONG"] = (_trongLuong.Trim().Length > 0) ? _trongLuong : null;
                row["HEDIEUHANH"] = (_heDieuHanh.Trim().Length > 0) ? _heDieuHanh : null;
                row["MAUSAC"] = (_mauSac.Trim().Length > 0) ? _mauSac : null;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool updateThongTin(DataRow _row)
        {
            try
            {
                DataRow row = _THONGTIN.Rows.Find(_row["ID_SP"].ToString());
                row["VIXULY"] = (_row["VIXULY"].ToString().Trim().Length > 0) ? _row["VIXULY"].ToString() : null;
                row["MANHINH"] = (_row["MANHINH"].ToString().Trim().Length > 0) ? _row["MANHINH"].ToString() : null;
                row["RAM"] = (_row["RAM"].ToString().Trim().Length > 0) ? _row["RAM"].ToString() : null;
                row["CARDDOHOA"] = (_row["CARDDOHOA"].ToString().Trim().Length > 0) ? _row["CARDDOHOA"].ToString() : null;
                row["LUUTRU"] = (_row["LUUTRU"].ToString().Trim().Length > 0) ? _row["LUUTRU"].ToString() : null;
                row["PIN"] = (_row["PIN"].ToString().Trim().Length > 0) ? _row["PIN"].ToString() : null;
                row["KETNOI"] = (_row["KETNOI"].ToString().Trim().Length > 0) ? _row["KETNOI"].ToString() : null;
                row["TRONGLUONG"] = (_row["TRONGLUONG"].ToString().Trim().Length > 0) ? _row["TRONGLUONG"].ToString() : null;
                row["HEDIEUHANH"] = (_row["HEDIEUHANH"].ToString().Trim().Length > 0) ? _row["HEDIEUHANH"].ToString() : null;
                row["MAUSAC"] = (_row["MAUSAC"].ToString().Trim().Length > 0) ? _row["MAUSAC"].ToString() : null;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public DataRow findThongTin(string _idSP)
        {
            return _THONGTIN.Rows.Find(_idSP);
        }

        public bool deleteThongTin(string _idSP)
        {
            try
            {
                _THONGTIN.Rows.Find(_idSP).Delete();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
