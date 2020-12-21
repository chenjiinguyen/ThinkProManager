using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkProManager.handle
{
    class main
    {

        DataSet data = new DataSet();
        SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=THINKPRO;Persist Security Info=True;User ID=sa;Password=Pa$$w0rd");
        Dictionary<string, SqlDataAdapter> da = new Dictionary<string, SqlDataAdapter>();
        List<string> listTableName = new List<string> { "NGUOIDUNG", "HOADON", "NHACUNGCAP", "SANPHAM", "THONGTIN", "TINHTRANG", "VAITRO", "THUONGHIEU", "CHITIETHD", "LOAI" };
        public NGUOIDUNG nguoidung;
        public main()
        {
            foreach(string tableName in listTableName)
            {
                da.Add(tableName, new SqlDataAdapter("SELECT * FROM " + tableName, cnn));
                da[tableName].Fill(data, tableName);
            }

            nguoidung = new NGUOIDUNG(data);
        }

        public DataTable get(string _TableName)
        {
            return data.Tables[_TableName];
        }

        public bool save(string _TableName)
        {
            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(da[_TableName]);
                da[_TableName].Update(data, _TableName);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
