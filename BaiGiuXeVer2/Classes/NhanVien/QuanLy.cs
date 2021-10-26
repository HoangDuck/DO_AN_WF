using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuXeVer2.Classes.NhanVien
{
    class QuanLy:NhanVien
    {
        int ca1;
        int ca2;
        int ca3;
        public QuanLy()
        {
            this.ca1 = 1;
            this.ca2 = 1;
            this.ca3 = 1;
        }
        public bool insertManager(int id, string ten, string diaChi, string sdt, string uname, string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Managers]" +
                "values(@id,@tentho,@gioitinh,@phone,@uname,@pass)", myDB.GetSqlConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tentho", SqlDbType.NChar).Value = ten;
            command.Parameters.Add("@gioitinh", SqlDbType.NChar).Value = diaChi;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = sdt;
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
        public bool deleteManager(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Managers WHERE Id=@id", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            myDB.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                myDB.ClosedConnection();
                DateTime t = DateTime.Now;
                TuDongPhanCongQL(t);
                return true;
            }
            else
            {
                myDB.ClosedConnection();
                return false;
            }
        }
        public DataTable getManager(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * FROM Managers WHERE Id=@id", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            return data;
        }
        public bool updateManager(int id, string ten, string diaChi, string sdt)
        {
            SqlCommand command = new SqlCommand("UPDATE Managers SET" +
                " TenTho=@ten,DiaChi=@gt,SoDT=@sdt where Id=@id", myDB.GetSqlConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@ten", SqlDbType.NChar).Value = ten;
            command.Parameters.Add("@diachi", SqlDbType.NChar).Value = diaChi;
            command.Parameters.Add("@sdt", SqlDbType.NChar).Value = sdt;
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
        public int DemQL(SqlCommand sqlCommand)
        {
            sqlCommand.Connection = myDB.GetSqlConnection;
            myDB.OpenConnection();
            int soLuongQL = Convert.ToInt32(sqlCommand.ExecuteScalar());
            myDB.ClosedConnection();
            return soLuongQL;
        }
        public DataTable getAllManagers()
        {
            SqlCommand sqlCommand = new SqlCommand("Select * FROM ParkLogin.dbo.Managers", myDB.GetSqlConnection);
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            return data;
        }
        //chia ca
        public void TuDongPhanCongQL(DateTime dateTime)
        {
            MyDB.MyDBChuyenMon myDB = new MyDB.MyDBChuyenMon();
            SqlCommand sqlCommand = new SqlCommand("Delete from Works.dbo.PCQL", myDB.GetSqlConnection);
            myDB.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() >= 0)
            {
                myDB.ClosedConnection();
                for (int i = 0; i < 7; i++)
                {
                    PhanCongQL(dateTime);
                    dateTime = dateTime.AddDays(1);
                }
            }
            else
            {
                myDB.ClosedConnection();
                return;
            }
        }
        public void PhanCongQL(DateTime dateTime)
        {
            SqlCommand sqlCommand = new SqlCommand("select Count(*) from ParkLogin.dbo.Managers");
            int n = this.DemQL(sqlCommand);
            DataTable data = this.getAllManagers();
            if (n == 1)
            {
                int id = (int)data.Rows[0].ItemArray[0];
                PhanCaQL(id, 1, 1, 1, dateTime);
            }
            else if (n == 2)
            {
                for(int i=0;i<2;i++)
                {
                    int id = (int)data.Rows[i].ItemArray[0];
                    PhanCaQL(id, ca1, ca2, ca3, dateTime);
                    if(ca1==1&&i==0)
                    {
                        ca1 = 0;
                        ca2 = 0;
                        ca3 = 0;
                    }
                    else if(ca1==0&&i==1)
                    {
                        ca1 = 0;
                        ca2 = 0;
                        ca3 = 0;
                    }else if(ca1==0&&i==0)
                    {
                        ca1 = 1;
                        ca2 = 1;
                        ca3 = 1;
                    }
                    else
                    {
                        ca1 = 1;
                        ca2 = 1;
                        ca3 = 1;
                    }
                }    
            }
        }
        public void PhanCaQL(int maNV, int ca1, int ca2, int ca3, DateTime dateTime)
        {
            MyDB.MyDBChuyenMon myDB = new MyDB.MyDBChuyenMon();
            SqlCommand command = new SqlCommand("INSERT INTO Works.dbo.PCQL([MaNV],[ca1],[ca2],[ca3],[Ngay]) VALUES (@MNV,@C1,@C2,@C3,@ngay)", myDB.GetSqlConnection);
            command.Parameters.Add("@MNV", SqlDbType.Int).Value = maNV;
            command.Parameters.Add("@C1", SqlDbType.Int).Value = ca1;
            command.Parameters.Add("@C2", SqlDbType.Int).Value = ca2;
            command.Parameters.Add("@C3", SqlDbType.Int).Value = ca3;
            command.Parameters.Add("@ngay", SqlDbType.Date).Value = dateTime;
            myDB.OpenConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDB.ClosedConnection();
            }
            else
            {
                myDB.ClosedConnection();
            }
        }
        public DataTable getTKBQL(int id, DateTime dateTime)
        {
            MyDB.MyDBChuyenMon myDB = new MyDB.MyDBChuyenMon();
            SqlCommand sqlCommand = new SqlCommand("Select * FROM Works.dbo.PCQL WHERE MaNV=@id and Ngay=@ngay", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlCommand.Parameters.Add("@ngay", SqlDbType.Date).Value = dateTime;
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            return data;
        }
        //check in
        public bool checkinql(int id,DateTime in_time, DateTime day)
        {
            MyDB.MyDBChuyenMon checkIn = new MyDB.MyDBChuyenMon();
            SqlCommand command = new SqlCommand();
            command.Connection = checkIn.GetSqlConnection;
            checkIn.OpenConnection();
            command.CommandText = "Insert into Works.dbo.TinhCongQL([Id],[Ngay],[CheckIn],[TotalTime]) values(@ID,@time,@_in,@totaltime)";
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@_in", SqlDbType.DateTime).Value = in_time;
            command.Parameters.Add("@time", SqlDbType.Date).Value = day;
            command.Parameters.Add("@totaltime", SqlDbType.Int).Value = 0;
            if ((command.ExecuteNonQuery() == 1))
            {
                checkIn.ClosedConnection();
                return true;
            }
            else
            {
                checkIn.ClosedConnection();
                return false;
            }
        }
        //update check in
        public bool updatecheckinql(int id,DateTime in_time, DateTime day)
        {
            MyDB.MyDBChuyenMon checkIn = new MyDB.MyDBChuyenMon();
            SqlCommand command = new SqlCommand();
            command.Connection = checkIn.GetSqlConnection;
            checkIn.OpenConnection();
            command.CommandText = "UPDATE TinhCongQL SET [CheckIn]=@_in WHERE [Id]=@ID AND Ngay=@time And [CheckIn] is null";
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@_in", SqlDbType.DateTime).Value = in_time;
            command.Parameters.Add("@time", SqlDbType.Date).Value = day;
            if ((command.ExecuteNonQuery() == 1))
            {
                checkIn.ClosedConnection();
                return true;
            }
            else
            {
                checkIn.ClosedConnection();
                return false;
            }
        }
        //check out
        public bool checkoutql(int id,DateTime in_time, DateTime day)
        {
            MyDB.MyDBChuyenMon checkOut = new MyDB.MyDBChuyenMon();
            SqlCommand command = new SqlCommand();
            command.Connection = checkOut.GetSqlConnection;
            checkOut.OpenConnection();
            int time = this.TinhTongTGQL(id,in_time);
            command.CommandText = "UPDATE TinhCongQL SET [CheckOut]=@_in,[TotalTime]=@totaltime WHERE [Id]=@ID AND Ngay=@time And [CheckOut] is null And [CheckIn] is not null";
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@_in", SqlDbType.DateTime).Value = in_time;
            command.Parameters.Add("@time", SqlDbType.Date).Value = day;
            command.Parameters.Add("@totaltime", SqlDbType.Int).Value = time;
            if ((command.ExecuteNonQuery() == 1))
            {
                checkOut.ClosedConnection();
                return true;
            }
            else
            {
                checkOut.ClosedConnection();
                return false;
            }
        }
        public int TinhTongTGQL(int id,DateTime dateTime)
        {
            int t = 0;
            MyDB.MyDBChuyenMon checkOut = new MyDB.MyDBChuyenMon();
            SqlCommand command = new SqlCommand();
            command.Connection = checkOut.GetSqlConnection;
            command.CommandText = "select * from Works.dbo.TinhCongQL where Id=@id and Ngay=@time";
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@time", SqlDbType.Date).Value = dateTime;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            int time = Convert.ToInt32(data.Rows[0].ItemArray[4].ToString());
            CultureInfo culture = new CultureInfo("en-US");
            String myDate = data.Rows[0].ItemArray[2].ToString();
            DateTime checkInTime = DateTime.Parse(myDate, culture);
            TimeSpan timeSpan = dateTime - checkInTime;
            t = time;
            t += (int)timeSpan.TotalSeconds;
            return t;
        }
        public int TinhLuongQL(int id, DateTime dateTime)
        {
            int t = 0;
            MyDB.MyDBChuyenMon checkOut = new MyDB.MyDBChuyenMon();
            SqlCommand command = new SqlCommand();
            command.Connection = checkOut.GetSqlConnection;
            command.CommandText = "select * from Works.dbo.TinhCongQL where Id=@id and Ngay=@time";
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@time", SqlDbType.Date).Value = dateTime;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            t = (Convert.ToInt32(data.Rows[0].ItemArray[4].ToString()) / 3600) * 50000;
            return t;
        }
    }
}
