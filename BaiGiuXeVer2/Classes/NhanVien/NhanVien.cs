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
    class NhanVien
    {
        protected MyDB.MyDBParkLogin myDB = new MyDB.MyDBParkLogin();
        int ca1;
        int ca2;
        int ca3;
        public NhanVien()
        {
            this.ca1 = 1;
            this.ca2 = 0;
            this.ca3 = 1;
        }
        public bool insertStaff(int id,string ten,string gioitinh,string sdt,int macv,string uname,string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Workers]" +
                "values(@id,@tentho,@gioitinh,@phone,@macv,@uname,@pass)", myDB.GetSqlConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tentho", SqlDbType.NChar).Value = ten;
            command.Parameters.Add("@gioitinh", SqlDbType.NChar).Value = gioitinh;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = sdt;
            command.Parameters.Add("@macv", SqlDbType.Int).Value = macv;
            command.Parameters.Add("@uname", SqlDbType.NChar).Value = uname;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            myDB.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.ClosedConnection();
                TuDongPhanCong(DateTime.Now);
                return true;
            }
            else
            {
                myDB.ClosedConnection();
                return false;
            }
        }
        public bool deleteStaff(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Workers WHERE Id=@id", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            myDB.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                myDB.ClosedConnection();
                TuDongPhanCong(DateTime.Now);
                return true;
            }
            else
            {
                myDB.ClosedConnection();
                return false;
            }
        }
        public DataTable getStaff(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * FROM Workers WHERE Id=@id", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            return data;
        }
        public DataTable getAllStaffs()
        {
            SqlCommand sqlCommand = new SqlCommand("Select * FROM Workers", myDB.GetSqlConnection);
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            return data;
        }
        public bool updateStaff(int id,string ten,string gioitinh,string sdt,int macv)
        {
            SqlCommand command = new SqlCommand("UPDATE [Workers] SET" +
                " TenTho=@ten,GioiTinh=@gt,SoDT=@sdt,MaChuyenMon=@macv where Id=@id", myDB.GetSqlConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@ten", SqlDbType.NChar).Value = ten;
            command.Parameters.Add("@gt", SqlDbType.NChar).Value = gioitinh;
            command.Parameters.Add("@sdt", SqlDbType.NChar).Value = sdt;
            command.Parameters.Add("@macv", SqlDbType.Int).Value = macv;
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
        public int DemNV(SqlCommand sqlCommand)
        {
            sqlCommand.Connection = myDB.GetSqlConnection;
            myDB.OpenConnection();
            int soLuongNV = Convert.ToInt32(sqlCommand.ExecuteScalar());
            myDB.ClosedConnection();
            return soLuongNV;
        }
        //chia ca
        public void ChonCa(int ca1,int ca2,int ca3)
        {
            if(ca1==1&&ca2==0&&ca3==1)
            {
                this.ca1 = 1;
                this.ca2 = 1;
                this.ca3 = 0;
            }    
            else if(ca1 == 1 && ca2 == 1 && ca3 == 0)
            {
                this.ca1 = 0;
                this.ca2 = 1;
                this.ca3 = 1;
            }
            else if (ca1 == 0 && ca2 == 1 && ca3 == 1)
            {
                this.ca1 = 1;
                this.ca2 = 0;
                this.ca3 = 1;
            }
        }
        public void TuDongPhanCong(DateTime dateTime)
        {
            MyDB.MyDBChuyenMon myDB = new MyDB.MyDBChuyenMon();
            SqlCommand sqlCommand = new SqlCommand("Delete from PhanCong", myDB.GetSqlConnection);
            myDB.OpenConnection();
            if(sqlCommand.ExecuteNonQuery()>=0)
            {
                myDB.ClosedConnection();
                for(int i=0;i<7;i++)
                {
                    PhanCong(dateTime);
                    dateTime = dateTime.AddDays(1);
                }    
            }
            else
            {
                myDB.ClosedConnection();
                return;
            }
        }
        public void PhanCong(DateTime dateTime)
        {
            SqlCommand sqlCommand = new SqlCommand("select Count(*) from Workers");
            int n = this.DemNV(sqlCommand);
            DataTable data = this.getAllStaffs();
            if (n>2)
            {
                MyDB.MyDBChuyenMon myDB = new MyDB.MyDBChuyenMon();
                sqlCommand = new SqlCommand("Select Count(*) from PhanCong",myDB.GetSqlConnection);
                myDB.OpenConnection();
                int soCa = (int)sqlCommand.ExecuteScalar();
                myDB.ClosedConnection();
                if(soCa!=0)
                {
                    //
                    sqlCommand = new SqlCommand("Select * from PhanCong",myDB.GetSqlConnection);
                    myDB.OpenConnection();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    myDB.ClosedConnection();
                    this.ca1 = Convert.ToInt32(dataTable.Rows[soCa - n].ItemArray[1]);
                    this.ca2 = Convert.ToInt32(dataTable.Rows[soCa - n].ItemArray[2]);
                    this.ca3 = Convert.ToInt32(dataTable.Rows[soCa - n].ItemArray[3]);
                    ChonCa(ca1, ca2, ca3);
                    //
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        int id = Convert.ToInt32(data.Rows[i].ItemArray[0]);
                        PhanCa(id, ca1, ca2, ca3, dateTime);
                        ChonCa(ca1, ca2, ca3);
                    }
                }
                else if(soCa==0)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        int id = Convert.ToInt32(data.Rows[i].ItemArray[0]);
                        PhanCa(id, ca1, ca2, ca3, dateTime);
                        ChonCa(ca1, ca2, ca3);
                    }
                }   
            }    
            else if(n<3)
            {
                for(int i=0;i<data.Rows.Count;i++)
                {
                    int id =Convert.ToInt32(data.Rows[i].ItemArray[0]);
                    int ca1 = 1;
                    int ca2 = 1;
                    int ca3 = 1;
                    PhanCa(id, ca1, ca2, ca3, dateTime);
                }    
            }    
        }
        public void PhanCa(int maNV, int ca1, int ca2, int ca3,DateTime dateTime)
        {
            MyDB.MyDBChuyenMon myDB = new MyDB.MyDBChuyenMon();
            SqlCommand command = new SqlCommand("INSERT INTO PhanCong([MaNV],[ca1],[ca2],[ca3],[Ngay]) VALUES (@MNV,@C1,@C2,@C3,@ngay)", myDB.GetSqlConnection);
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
        public DataTable getTKB(int id,DateTime dateTime)
        {
            MyDB.MyDBChuyenMon myDB = new MyDB.MyDBChuyenMon();
            SqlCommand sqlCommand = new SqlCommand("Select * FROM PhanCong WHERE MaNV=@id and Ngay=@ngay", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlCommand.Parameters.Add("@ngay", SqlDbType.Date).Value = dateTime;
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            return data;
        }
        //check in
        public bool checkin(int id, string ca, DateTime in_time, DateTime day)
        {
            MyDB.MyDBChuyenMon checkIn = new MyDB.MyDBChuyenMon();
            SqlCommand command = new SqlCommand();
            command.Connection = checkIn.GetSqlConnection;
            checkIn.OpenConnection();
            switch (ca)
            {
                case "1":
                    command.CommandText = "Insert into Works.dbo.TinhCong([Id],[Ngay],[Ca1In],[TotalTime]) values(@ID,@time,@_in,@totaltime)";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.DateTime).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.Date).Value = day;
                    command.Parameters.Add("@totaltime", SqlDbType.Int).Value = 0;
                    break;
                case "2":
                    command.CommandText = "Insert into Works.dbo.TinhCong([Id],[Ngay],[Ca2In],[TotalTime]) values(@ID,@time,@_in,@totaltime)";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.DateTime).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.Date).Value = day;
                    command.Parameters.Add("@totaltime", SqlDbType.Int).Value = 0;
                    break;
                case "3":
                    command.CommandText = "Insert into Works.dbo.TinhCong([Id],[Ngay],[Ca3In],[TotalTime]) values(@ID,@time,@_in,@totaltime)";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.DateTime).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.Date).Value = day;
                    command.Parameters.Add("@totaltime", SqlDbType.Int).Value = 0;
                    break;
            }
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
        public bool updatecheckin(int id, string ca, DateTime in_time, DateTime day)
        {
            MyDB.MyDBChuyenMon checkIn = new MyDB.MyDBChuyenMon();
            SqlCommand command = new SqlCommand();
            command.Connection = checkIn.GetSqlConnection;
            checkIn.OpenConnection();
            switch (ca)
            {
                case "1":
                    command.CommandText = "UPDATE TinhCong SET [Ca1In]=@_in WHERE [Id]=@ID AND Ngay=@time And [Ca1In] is null";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.DateTime).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.Date).Value = day;
                    break;
                case "2":
                    command.CommandText = "UPDATE TinhCong SET [Ca2In]=@_in WHERE [Id]=@ID AND Ngay=@time And [Ca2In] is null";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.DateTime).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.Date).Value = day;
                    break;
                case "3":
                    command.CommandText = "UPDATE TinhCong SET [Ca3In]=@_in WHERE [Id]=@ID AND Ngay=@time And [Ca3In] is null";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.DateTime).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.Date).Value = day;
                    break;
            }
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
        public bool checkout(int id, string ca, DateTime in_time, DateTime day)
        {
            MyDB.MyDBChuyenMon checkOut = new MyDB.MyDBChuyenMon();
            SqlCommand command = new SqlCommand();
            command.Connection = checkOut.GetSqlConnection;
            checkOut.OpenConnection();
            switch (ca.Trim())
            {
                case "1":
                    int time = this.TinhTongTG(id, ca, in_time);
                    command.CommandText = "UPDATE TinhCong SET [Ca1Out]=@_in,[TotalTime]=@totaltime WHERE [Id]=@ID AND Ngay=@time And [Ca1Out] is null And [Ca1In] is not null";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.DateTime).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.Date).Value = day;
                    command.Parameters.Add("@totaltime", SqlDbType.Int).Value = time;
                    break;
                case "2":
                    time = this.TinhTongTG(id, ca, in_time);
                    command.CommandText = "UPDATE TinhCong SET [Ca2Out]=@_in,[TotalTime]=@totaltime WHERE [Id]=@ID AND Ngay=@time And [Ca2Out] is null And [Ca2In] is not null";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.DateTime).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.Date).Value = day;
                    command.Parameters.Add("@totaltime", SqlDbType.Int).Value = time;
                    break;
                case "3":
                    time = this.TinhTongTG(id, ca, in_time);
                    command.CommandText = "UPDATE TinhCong SET [Ca3Out]=@_in,[TotalTime]=@totaltime WHERE [Id]=@ID AND Ngay=@time And [Ca3Out] is null And [Ca3In] is not null";
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@_in", SqlDbType.DateTime).Value = in_time;
                    command.Parameters.Add("@time", SqlDbType.Date).Value = day;
                    command.Parameters.Add("@totaltime", SqlDbType.Int).Value = time;
                    break;
            }
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
        public int TinhTongTG(int id,string ca,DateTime dateTime)
        {
            int t = 0;
            MyDB.MyDBChuyenMon checkOut = new MyDB.MyDBChuyenMon();
            SqlCommand command = new SqlCommand();
            command.Connection = checkOut.GetSqlConnection;
            command.CommandText = "select * from Works.dbo.TinhCong where Id=@id and Ngay=@time";
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@time", SqlDbType.Date).Value = dateTime;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            switch (ca.Trim())
            {
                case "1":
                    int time = Convert.ToInt32(data.Rows[0].ItemArray[8].ToString());
                    //checkInTime = Convert.ToDateTime(data.Rows[0].ItemArray[6].ToString());
                    CultureInfo culture = new CultureInfo("en-US");
                    String myDate = data.Rows[0].ItemArray[2].ToString();
                    DateTime checkInTime = DateTime.Parse(myDate, culture);
                    TimeSpan timeSpan = dateTime - checkInTime;
                    t= (int)timeSpan.TotalSeconds;
                    break;
                case "2":
                    time = Convert.ToInt32(data.Rows[0].ItemArray[8].ToString());
                    //checkInTime = Convert.ToDateTime(data.Rows[0].ItemArray[6].ToString());
                    culture = new CultureInfo("en-US");
                    myDate = data.Rows[0].ItemArray[4].ToString();
                    checkInTime = DateTime.Parse(myDate, culture);
                    timeSpan = dateTime - checkInTime;
                    t = time;
                    t += (int)timeSpan.TotalSeconds;
                    break;
                case "3":
                    time = Convert.ToInt32(data.Rows[0].ItemArray[8].ToString());
                    //checkInTime = Convert.ToDateTime(data.Rows[0].ItemArray[6].ToString());
                    culture = new CultureInfo("en-US");
                    myDate = data.Rows[0].ItemArray[6].ToString();
                    checkInTime = DateTime.Parse(myDate, culture); 
                    timeSpan = dateTime - checkInTime;
                    t = time;
                    t += (int)timeSpan.TotalSeconds;
                    break;
            }
            return t;
        }
        public int TinhLuong(int id,DateTime dateTime)
        {
            int t = 0;
            MyDB.MyDBChuyenMon checkOut = new MyDB.MyDBChuyenMon();
            SqlCommand command = new SqlCommand();
            command.Connection = checkOut.GetSqlConnection;
            command.CommandText = "select * from Works.dbo.TinhCong where Id=@id and Ngay=@time";
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@time", SqlDbType.Date).Value = dateTime;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            t = (Convert.ToInt32(data.Rows[0].ItemArray[8].ToString())/3600)*50000;
            return t;
        }
    }
}
