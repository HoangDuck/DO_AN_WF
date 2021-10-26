using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuXeVer2.Classes.HopDong
{
    class HopDong
    {
        MyDB.MyDBChuyenMon myDB = new MyDB.MyDBChuyenMon();
        int soHD;
        int maLoaiXe;
        public HopDong()
        {

        }
        public HopDong(int soHD)
        {
            this.soHD = soHD;
        }
        public HopDong(int soHD,int maLX)
        {
            this.soHD = soHD;
            this.maLoaiXe = maLX;
        }
        //CRUD hop dong 
        public bool ThemHD(int soHD,DateTime ngayKi,DateTime ngayHetHan,int maXe,int maKH)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert into [HopDong] values(@sohd,@ngayki,@ngayhethan,@maxe,@makh)",myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@sohd", SqlDbType.Int).Value = soHD;
            sqlCommand.Parameters.Add("@ngayki", SqlDbType.DateTime).Value = ngayKi;
            sqlCommand.Parameters.Add("@ngayhethan", SqlDbType.DateTime).Value = ngayHetHan;
            sqlCommand.Parameters.Add("@maxe", SqlDbType.Int).Value = maXe;
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = maKH;
            myDB.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
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
        public bool ChinhSuaHD(int soHD, DateTime ngayKi, DateTime ngayHetHan, int maXe, int maKH)
        {
            SqlCommand sqlCommand = new SqlCommand("Update [HopDong] SET SoHD=@sohd,NgayKi=@ngayki,NgayHetHan=@ngayhethan,MaXe=@maxe,MaKH=@makh)", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@sohd", SqlDbType.Int).Value = soHD;
            sqlCommand.Parameters.Add("@ngayki", SqlDbType.DateTime).Value = ngayKi;
            sqlCommand.Parameters.Add("@ngayhethan", SqlDbType.DateTime).Value = ngayHetHan;
            sqlCommand.Parameters.Add("@maxe", SqlDbType.Int).Value = maXe;
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = maKH;
            myDB.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
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
        public bool XoaHD(int soHD)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete from [HopDong] where SoHD=@sohd", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@sohd", SqlDbType.Int).Value = soHD;
            myDB.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
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
        public DataTable LayTTHD()
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from " +
            "Works.dbo.HopDong inner join Works.dbo.ChiTietHD " +
            "on HopDong.SoHD = ChiTietHD.SoHD " +
            "inner join Works.dbo.DichVu on ChiTietHD.IdDV = DichVu.IdDV");
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            return data;
        }
        public DataTable LayTTHD(int maKH)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from " +
            "Works.dbo.HopDong inner join Works.dbo.ChiTietHD " +
            "on HopDong.SoHD = ChiTietHD.SoHD " +
            "inner join Works.dbo.DichVu on ChiTietHD.IdDV = DichVu.IdDV where MaKH=@makh",myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = maKH;
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            return data;
        }
        public bool hopdongExist(int maHD)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HopDong where SoHD=@mahopdong", myDB.GetSqlConnection);
            command.Parameters.Add("@mahopdong", SqlDbType.Int).Value = maHD;
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
        //CRUD Dich vu voi hop dong
        public bool ThemDVVaoHD(int maDV,int soHD,int chiPhi,int maTho)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert into [ChiTietHD] values(@maDV,@soHD,@chiPhi,@maTho)", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@soHD", SqlDbType.Int).Value = soHD;
            sqlCommand.Parameters.Add("@maDV", SqlDbType.Int).Value = maDV;
            sqlCommand.Parameters.Add("@chiPhi", SqlDbType.Int).Value = chiPhi;
            sqlCommand.Parameters.Add("@maTho", SqlDbType.Int).Value = maTho;
            myDB.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
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
        public bool ChinhSuaDV(int maDV, int soHD, int chiPhi, int maTho)
        {
            SqlCommand sqlCommand = new SqlCommand("Update [ChiTietHD] set IdDV=@maDV,SoHD=@soHD,ChiPhi=@chiPhi,MaTho=@maTho", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@soHD", SqlDbType.Int).Value = soHD;
            sqlCommand.Parameters.Add("@maDV", SqlDbType.Int).Value = maDV;
            sqlCommand.Parameters.Add("@chiPhi", SqlDbType.Int).Value = chiPhi;
            sqlCommand.Parameters.Add("@maTho", SqlDbType.Int).Value = maTho;
            myDB.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
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
        public bool XoaDV(int soHD,int maDV)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete from [ChiTietHD] where SoHD=@sohd and IdDV=@maDV", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@sohd", SqlDbType.Int).Value = soHD;
            sqlCommand.Parameters.Add("@maDV", SqlDbType.Int).Value = maDV;
            myDB.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
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
        public DataTable LayTTDV(int soHD,int maDV)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from " +
            "Works.dbo.HopDong inner join Works.dbo.ChiTietHD " +
            "on HopDong.SoHD = ChiTietHD.SoHD " +
            "inner join Works.dbo.DichVu on ChiTietHD.IdDV = DichVu.IdDV where DichVu.IdDV=@maDV and HopDong.SoHD=@soHD",myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@soHD", SqlDbType.Int).Value = soHD;
            sqlCommand.Parameters.Add("@maDV", SqlDbType.Int).Value = maDV;
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            return data;
        }
        public DataTable LayCPDV(int maKH)
        {
            SqlCommand sqlCommand = new SqlCommand("Select ChiPhi from Works.dbo.HopDong inner join Works.dbo.ChiTietHD"+
            " on HopDong.SoHD = ChiTietHD.SoHD" +
            " where MaKH = @makh", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = maKH;
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            return data;
        }
    }
}
