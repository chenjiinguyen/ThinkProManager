using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ThinkProManager.handle
{
    class NGUOIDUNG
    {

        DataSet data;
        DataTable _NGUOIDUNG;
        DataTable _NHANVIEN;
        string DefautPassword = "thinkpro";
        public NGUOIDUNG(DataSet _data)
        {
            data = _data;
            _NGUOIDUNG = data.Tables["NGUOIDUNG"];
            _NHANVIEN = data.Tables["NHANVIEN"];

            _NGUOIDUNG.PrimaryKey = new DataColumn[] { _NGUOIDUNG.Columns["ID_USER"] };
            _NHANVIEN.PrimaryKey = new DataColumn[] { _NHANVIEN.Columns["ID_USER"] };
        }

        public bool add(string _idUser, string _email, string _idRole, string _hoTen, string _dienThoai, string _diaChi, string _gioiTinh, string _avatar)
        {
            try
            {
                DataRow row = _NGUOIDUNG.NewRow();
                row["ID_USER"] = _idUser;
                row["ID_VAITRO"] = _idRole;
                row["HOTEN"] = _hoTen;
                row["DIENTHOAI"] = _dienThoai;
                row["EMAIL"] = _email;
                row["MATKHAU"] = MD5Password(DefautPassword);
                row["DIACHI"] = _diaChi;
                row["GIOITINH"] = _gioiTinh;
                row["AVATAR"] = _avatar;
                _NGUOIDUNG.Rows.Add(row);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool update(string _idUser, string _email, string _idRole, string _hoTen, string _dienThoai, string _diaChi, string _gioiTinh, string _avatar)
        {
            try
            {
                DataRow row = findID(_idUser);
                row["ID_USER"] = _idUser;
                row["ID_VAITRO"] = _idRole;
                row["HOTEN"] = _hoTen;
                row["DIENTHOAI"] = _dienThoai;
                row["EMAIL"] = _email;
                row["DIACHI"] = _diaChi;
                row["GIOITINH"] = _gioiTinh;
                row["AVATAR"] = _avatar;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool delete(string _idUser)
        {
            try
            {
                if (findNV(_idUser) != null)
                    deleteNV(_idUser);
                findID(_idUser).Delete();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public bool addNV(string _idNV, string _heSoLuong, bool _trangThai)
        {
            try
            {
                DataRow row = _NHANVIEN.NewRow();
                row["ID_USER"] = _idNV;
                row["HESOLUONG"] = _heSoLuong;
                row["TINHTRANG"] = _trangThai;
                _NHANVIEN.Rows.Add(row);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool addNV(DataRow _input)
        {
            try
            {
                DataRow row = _NHANVIEN.NewRow();
                row["ID_USER"] = _input["ID_USER"];
                row["HESOLUONG"] = _input["HESOLUONG"];
                row["TINHTRANG"] = _input["TINHTRANG"];
                _NHANVIEN.Rows.Add(row);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool updateNV(string _idNV, string _heSoLuong, bool _trangThai)
        {
            try
            {
                DataRow row = findNV(_idNV);
                row["HESOLUONG"] = _heSoLuong;
                row["TINHTRANG"] = _trangThai;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool updateNV(DataRow _input)
        {
            try
            {
                DataRow row = findNV(_input["ID_USER"].ToString());
                row["HESOLUONG"] = _input["HESOLUONG"];
                row["TINHTRANG"] = _input["TINHTRANG"];
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool deleteNV(string _idNV)
        {
            try
            {
                findNV(_idNV).Delete();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public int login(string _email, string _password)
        {
            DataRow user = findEmail(_email);
            if(user != null)
            {
                string password_encrypt =  MD5Password(_password);
                if(user["MATKHAU"].ToString() == password_encrypt)
                {
                    bool role = checkRole(user["ID_VAITRO"].ToString(), "DANGNHAP");
                    if(role == true)
                    {
                        return 1;
                    }
                    else
                    {
                        return -2;
                    }
                    
                    
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }

            
        }

        public int updatePassword(string _email, string _password_old, string _password_new)
        {
            DataRow user = findEmail(_email);
            if (user != null)
            {
                string password_encrypt = MD5Password(_password_old);
                if (user["MATKHAU"].ToString() == password_encrypt)
                {
                    _NGUOIDUNG.Rows.Find(user["ID_USER"])["MATKHAU"] = MD5Password(_password_new);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }


        }


        public DataRow findID(string _idUser)
        {
            return _NGUOIDUNG.Rows.Find(_idUser);
        }

        public DataRow findNV(string _idUser)
        {
            return _NHANVIEN.Rows.Find(_idUser);
        }

        public DataRow findEmail(string _email)
        {
            return _NGUOIDUNG.AsEnumerable().SingleOrDefault(row => row.Field<string>("EMAIL") == _email);
        }

        public bool checkRole(string _idRole, string _RoleName)
        {
            DataRow vaitro = data.Tables["VAITRO"].AsEnumerable().Single(row => row.Field<string>("ID_VAITRO") == _idRole);
            return (bool)vaitro[_RoleName];
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public string roleName(string _idRole)
        {
            DataRow vaitro = data.Tables["VAITRO"].AsEnumerable().Single(row => row.Field<string>("ID_VAITRO") == _idRole);
            return vaitro["TENVAITRO"].ToString();
        }

        private string MD5Password(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }

    }
}
