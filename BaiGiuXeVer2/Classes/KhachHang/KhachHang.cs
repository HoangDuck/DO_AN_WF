using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuXeVer2.Classes.KhachHang
{
    class KhachHang
    {
        MyDB.MyDBParkLogin myDB = new MyDB.MyDBParkLogin();
        public DataTable LayDSKhachHang(SqlCommand command)
        {
            command.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        }
        public bool themKhachHang(int maKH, string tenKH, string diachi, string sdt,string uname,string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Users values(@maKH,@tenKH,@diachi,@sdt,@uname,@pass)", myDB.GetSqlConnection);
            command.Parameters.Add("@maKH", SqlDbType.Int).Value = maKH;
            command.Parameters.Add("@tenKH", SqlDbType.NChar).Value = tenKH;
            command.Parameters.Add("@diachi", SqlDbType.NChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.NChar).Value = sdt;
            command.Parameters.Add("@uname", SqlDbType.NChar).Value = uname;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            myDB.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.ClosedConnection();
                return true;
            }
            else
            {
                myDB.ClosedConnection();
                return false;
            }
        }

        public bool khachhangExist(int maKH)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Users where Id=@maKH", myDB.GetSqlConnection);
            command.Parameters.Add("@maKH", SqlDbType.Int).Value = maKH;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool deleteKhachHang(int makh)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Users WHERE Id=@maKH", myDB.GetSqlConnection);
            command.Parameters.Add("@makh", SqlDbType.Int).Value = makh;
            myDB.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.ClosedConnection();
                return true;
            }
            else
            {
                myDB.ClosedConnection();
                return false;
            }
        }
        public bool updateKhachhang(int maKH, string tenKH, string diachi, string sdt)
        {
            SqlCommand command = new SqlCommand("UPDATE Users SET TenKH=@tenKH,DiaChi=@diachi,SoDT=@sdt WHERE Id=@maKH", myDB.GetSqlConnection);
            command.Parameters.Add("@maKH", SqlDbType.Int).Value = maKH;
            command.Parameters.Add("@tenKH", SqlDbType.VarChar).Value = tenKH;
            command.Parameters.Add("@diachi", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.Int).Value = sdt;
            myDB.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.ClosedConnection();
                return true;
            }
            else
            {
                myDB.ClosedConnection();
                return false;
            }
        }
    }
}
