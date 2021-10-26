using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaiGiuXeVer2.Classes;
namespace BaiGiuXeVer2.Classes.Xe
{
    class Xe
    {
        //fields
        private int id;
        private String maKH;
        private String loaiXe;
        private String bienSo;
        private BaiGiuXeVer2.Classes.TGGuiXe.ThoiGianGuiXe dateOfVehicle;
        private ChiPhi.ChiPhi chiPhi;
        private String hinhThucGui;
        private MemoryStream picture;
        MyDB.MyDBXe myDB = new MyDB.MyDBXe();
        public String tenBangXe="XeDap";
        public bool tinhTrangTra = false;//false la chua; true la da tra
        //properties
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public String MaKH
        {
            get { return this.maKH; }
            set { this.maKH = value; }
        }
        public String LoaiXe
        {
            get { return this.loaiXe; }
            set { this.loaiXe = value; }
        }
        public String BienSo
        {
            get { return this.bienSo; }
            set { this.bienSo = value; }
        }
        public TGGuiXe.ThoiGianGuiXe DateOfVehicles
        {
            get { return this.dateOfVehicle; }
            set { this.dateOfVehicle = value; }
        }
        public String HinhThucGui
        {
            get { return this.hinhThucGui; }
            set { this.hinhThucGui = value; }
        }
        public MemoryStream Picture
        {
            get { return this.picture; }
            set { this.picture = value; }
        }
        public ChiPhi.ChiPhi ChiPhi
        {
            get { return this.chiPhi; }
            set { this.chiPhi = value; }
        }
        //constructor
        public Xe()
        {
            this.picture = new MemoryStream();
        }
        //methods
        public DataTable LayDSXe(SqlCommand sqlCommand)
        {
            sqlCommand.Connection = myDB.GetSqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            return data;
        }
        public bool ThemXe(Xe xe)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ["+xe.tenBangXe+"]" +
                "values(@id,@loaixe,@ngaygui,@ngayhethandk,@ngaytraxe,@phi,@phat,@bienso,@anh,@hinhthucgui,@makh,@tinhtrang)", myDB.GetSqlConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = xe.id;
            command.Parameters.Add("@makh", SqlDbType.VarChar).Value = xe.maKH;
            command.Parameters.Add("@phi", SqlDbType.Int).Value = xe.ChiPhi.TienPhi;
            command.Parameters.Add("@phat", SqlDbType.Int).Value = xe.ChiPhi.TienPhat;
            command.Parameters.Add("@ngaytraxe", SqlDbType.Date).Value = xe.DateOfVehicles.NgayTraXeThucTe;
            command.Parameters.Add("@ngayhethandk", SqlDbType.Date).Value = xe.DateOfVehicles.NgayPhaiTraXeDK;
            command.Parameters.Add("@loaixe", SqlDbType.VarChar).Value = xe.loaiXe;
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = xe.bienSo;
            command.Parameters.Add("@ngaygui", SqlDbType.DateTime).Value = xe.DateOfVehicles.NgayGui;
            command.Parameters.Add("@hinhthucgui", SqlDbType.VarChar).Value = xe.hinhThucGui;
            command.Parameters.Add("@anh", SqlDbType.Image).Value = xe.picture.ToArray();
            if (xe.tinhTrangTra)
            {
                command.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            }
            else
            {
                command.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            }
            myDB.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.CloseConnection();
                return true;
            }
            else
            {
                myDB.CloseConnection();
                return false;
            }
        }
        public bool ChinhSuaThongTinXe(Xe xe)
        {
            SqlCommand command = new SqlCommand("UPDATE "+xe.tenBangXe+" SET" +
                " LoaiXe=@loaixe,NgayGui=@ngaygui,NgayHetHanDK=@ngayhethandk,NgayTraXe=@ngaytraxe,Phi=@phi,Phat=@phat,BienXe=@bienso,Anh=@anh,HinhThucGui=@hinhthucgui,MaKH=@makh,TinhTrangTra=@tinhtrang where Id=@id and TinhTrangTra=@tinhtrangbandau", myDB.GetSqlConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = xe.id;
            command.Parameters.Add("@makh", SqlDbType.VarChar).Value = xe.maKH;
            command.Parameters.Add("@phi", SqlDbType.Int).Value = xe.ChiPhi.TienPhi;
            command.Parameters.Add("@phat", SqlDbType.Int).Value = xe.ChiPhi.TienPhat;
            command.Parameters.Add("@ngaytraxe", SqlDbType.Date).Value = xe.DateOfVehicles.NgayTraXeThucTe;
            command.Parameters.Add("@ngayhethandk", SqlDbType.Date).Value = xe.DateOfVehicles.NgayPhaiTraXeDK;
            command.Parameters.Add("@loaixe", SqlDbType.VarChar).Value = xe.loaiXe;
            command.Parameters.Add("@bienso", SqlDbType.VarChar).Value = xe.bienSo;
            command.Parameters.Add("@ngaygui", SqlDbType.DateTime).Value = xe.DateOfVehicles.NgayGui;
            command.Parameters.Add("@hinhthucgui", SqlDbType.VarChar).Value = xe.hinhThucGui;
            command.Parameters.Add("@anh", SqlDbType.Image).Value = xe.picture.ToArray();
            command.Parameters.Add("@tinhtrangbandau", SqlDbType.NChar).Value = "Chua Tra";
            if (xe.tinhTrangTra)
            {
                command.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            }
            else
            {
                command.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            }
            myDB.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                myDB.CloseConnection();
                return true;
            }
            else
            {
                myDB.CloseConnection();
                return false;
            }
        }
        public bool XoaXe(Xe xe)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM "+xe.tenBangXe+" WHERE Id=@id and TinhTrangTra=@tinhtrang", myDB.GetSqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            myDB.OpenConnection();
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                myDB.CloseConnection() ;
                return true;
            }
            else
            {
                myDB.CloseConnection();
                return false;
            }
        }
        public int DemXe(SqlCommand sqlCommand)
        {
            sqlCommand.Connection = myDB.GetSqlConnection;
            myDB.OpenConnection();
            int soLuongXe = Convert.ToInt32(sqlCommand.ExecuteScalar());
            myDB.CloseConnection();
            return soLuongXe;
        }
        public void GanDoiTuongTuDataTable(Xe xe,int id,string tenBangXe)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from [" + tenBangXe + "] where Id=@id");
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DataTable dataTable = this.LayDSXe(sqlCommand);
            xe.ID = Convert.ToInt32(dataTable.Rows[0].ItemArray[0]);
            xe.LoaiXe = dataTable.Rows[0].ItemArray[1].ToString().Trim();
            CultureInfo culture = new CultureInfo("en-US");
            String data = dataTable.Rows[0].ItemArray[2].ToString();
            DateTime t= Convert.ToDateTime(dataTable.Rows[0].ItemArray[2].ToString(), culture);
            int c= Convert.ToInt32(dataTable.Rows[0].ItemArray[5]);
            xe.dateOfVehicle = new Classes.TGGuiXe.ThoiGianGuiXe(Convert.ToDateTime(dataTable.Rows[0].ItemArray[2].ToString(), culture));
            xe.DateOfVehicles.NgayPhaiTraXeDK = Convert.ToDateTime(dataTable.Rows[0].ItemArray[3].ToString(), culture);
            xe.DateOfVehicles.NgayTraXeThucTe = Convert.ToDateTime(dataTable.Rows[0].ItemArray[4].ToString(), culture);
            xe.BienSo = dataTable.Rows[0].ItemArray[7].ToString();
            byte[] b = (byte[])dataTable.Rows[0].ItemArray[8];
            xe.Picture = new MemoryStream(b);
            xe.HinhThucGui = dataTable.Rows[0].ItemArray[9].ToString().Trim();
            xe.ChiPhi = new ChiPhi.ChiPhi(xe.HinhThucGui);
            xe.ChiPhi.TienPhi = Convert.ToInt32(dataTable.Rows[0].ItemArray[5]);
            xe.ChiPhi.TienPhat = Convert.ToInt32(dataTable.Rows[0].ItemArray[6]);
            xe.MaKH = dataTable.Rows[0].ItemArray[10].ToString();
            if (dataTable.Rows[0].ItemArray[11].ToString().Trim() == "Da Tra")
            {
                xe.tinhTrangTra = true;
            }
            else
            {
                xe.tinhTrangTra = false;
            }
        }
        public bool KTraXeTonTai(Xe xe)
        {
            if(xe.tenBangXe=="XeDap")
            {
                SqlCommand sqlCommand = new SqlCommand("Select * from [" + xe.tenBangXe + "] where TinhTrangTra=@tinhtrang and Id=@id");
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = xe.ID;
                sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
                if(xe.LayDSXe(sqlCommand).Rows.Count>0)
                {
                    return false;
                }    
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("Select * from [" + xe.tenBangXe + "] where TinhTrangTra=@tinhtrang and (Id=@id or BienXe=@Bienso)");
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = xe.ID;
                sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
                sqlCommand.Parameters.Add("@Bienso", SqlDbType.NChar).Value = xe.BienSo;
                if (xe.LayDSXe(sqlCommand).Rows.Count > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

