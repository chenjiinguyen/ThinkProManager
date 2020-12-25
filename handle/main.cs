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
        //SqlConnection cnn = new SqlConnection("Data Source=localhost;Initial Catalog=THINKPRO;Persist Security Info=True;User ID=sa;Password=Pa$$w0rd");
        SqlConnection cnn = new SqlConnection("Data Source=PC-020\\SQLEXPRESS;Initial Catalog=THINKPRO;Integrated Security=True");

        Dictionary<string, SqlDataAdapter> da = new Dictionary<string, SqlDataAdapter>();
        List<string> listTableName = new List<string> { "NGUOIDUNG", "HOADON", "NHACUNGCAP", "SANPHAM", "THONGTIN", "TINHTRANG", "VAITRO", "THUONGHIEU", "CHITIETHD", "LOAI","PHIEUNHAP","CHITIETPN","NHANVIEN" };
        public NGUOIDUNG nguoidung;
        public SANPHAM sanpham;
        public PHIEUNHAP phieunhap;
        public HOADON hoadon;
        public main()
        {
            foreach(string tableName in listTableName)
            {
                da.Add(tableName, new SqlDataAdapter("SELECT * FROM " + tableName, cnn));
                da[tableName].Fill(data, tableName);
            }

            nguoidung = new NGUOIDUNG(data);
            sanpham = new SANPHAM(data);
            phieunhap = new PHIEUNHAP(data);
            hoadon = new HOADON(data);
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

        public static DataTable _JoinDataTables(DataTable t1, DataTable t2, params Func<DataRow, DataRow, bool>[] joinOn)
        {
            DataTable result = new DataTable();
            foreach (DataColumn col in t1.Columns)
            {
                if (result.Columns[col.ColumnName] == null)
                    result.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataColumn col in t2.Columns)
            {
                if (result.Columns[col.ColumnName] == null)
                    result.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row1 in t1.Rows)
            {
                var joinRows = t2.AsEnumerable().Where(row2 =>
                {
                    foreach (var parameter in joinOn)
                    {
                        if (!parameter(row1, row2)) return false;
                    }
                    return true;
                });
                foreach (DataRow fromRow in joinRows)
                {
                    DataRow insertRow = result.NewRow();
                    foreach (DataColumn col1 in t1.Columns)
                    {
                        insertRow[col1.ColumnName] = row1[col1.ColumnName];
                    }
                    foreach (DataColumn col2 in t2.Columns)
                    {
                        insertRow[col2.ColumnName] = fromRow[col2.ColumnName];
                    }
                    result.Rows.Add(insertRow);
                }
            }
            return result;
        }

        public DataTable JoinDataTables(DataTable t1, DataTable t2, params Func<DataRow, DataRow, bool>[] joinOn)
        {
            DataTable result = new DataTable();
            foreach (DataColumn col in t1.Columns)
            {
                if (result.Columns[col.ColumnName] == null)
                    result.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataColumn col in t2.Columns)
            {
                if (result.Columns[col.ColumnName] == null)
                    result.Columns.Add(col.ColumnName, col.DataType);
            }
            foreach (DataRow row1 in t1.Rows)
            {
                var joinRows = t2.AsEnumerable().Where(row2 =>
                {
                    foreach (var parameter in joinOn)
                    {
                        if (!parameter(row1, row2)) return false;
                    }
                    return true;
                });
                foreach (DataRow fromRow in joinRows)
                {
                    DataRow insertRow = result.NewRow();
                    foreach (DataColumn col1 in t1.Columns)
                    {
                        insertRow[col1.ColumnName] = row1[col1.ColumnName];
                    }
                    foreach (DataColumn col2 in t2.Columns)
                    {
                        insertRow[col2.ColumnName] = fromRow[col2.ColumnName];
                    }
                    result.Rows.Add(insertRow);
                }
            }
            return result;
        }
    }
}
