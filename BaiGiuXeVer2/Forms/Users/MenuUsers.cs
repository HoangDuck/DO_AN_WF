using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Users
{
    public partial class MenuUsers : Form
    {
        int userID;
        Classes.KhachHang.KhachHang kh = new Classes.KhachHang.KhachHang();
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        public MenuUsers(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuUsers_Load(object sender, EventArgs e)
        {
            //chao mung
            SqlCommand sqlCommand = new SqlCommand("Select * from Users where Id=@id");
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = userID;
            DataTable data = kh.LayDSKhachHang(sqlCommand);
            labelWelcomeback.Text = "Welcome back " + data.Rows[0].ItemArray[1].ToString().Trim()+" !!!!";
            //thong ke so xe va chi phi cua khach hang
            sqlCommand = new SqlCommand("Select Count(*) from XeDap where tinhTrangTra='Chua Tra' and MaKH=@makh");
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
            labelXeDap.Text = "Xe đạp: "+xe.DemXe(sqlCommand).ToString();
            sqlCommand = new SqlCommand("Select Count(*) from XeMay where tinhTrangTra='Chua Tra' and MaKH=@makh");
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
            labelXeMay.Text = "Xe máy: " + xe.DemXe(sqlCommand).ToString();
            sqlCommand = new SqlCommand("Select Count(*) from XeHoi where tinhTrangTra='Chua Tra' and MaKH=@makh");
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
            labelXeHoi.Text = "Xe hơi: " + xe.DemXe(sqlCommand).ToString();
            //Chi phi hien tai
            //dChi phi xe dap
            sqlCommand = new SqlCommand("Select * from XeDap where TinhTrangTra=@tinhtrang and MaKH=@makh");
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            DataTable thongke = xe.LayDSXe(sqlCommand);
            int t = 0;
            for (int i = 0; i < thongke.Rows.Count; i++)
            {
                t += Convert.ToInt32(thongke.Rows[i].ItemArray[5]) + Convert.ToInt32(thongke.Rows[i].ItemArray[6]);
            }
            labelCPXeDap.Text = "Xe đạp: " + t.ToString();
            //Chi phi xe may
            t = 0;
            sqlCommand = new SqlCommand("Select * from XeMay where TinhTrangTra=@tinhtrang and MaKH=@makh");
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            thongke = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < thongke.Rows.Count; i++)
            {
                t += Convert.ToInt32(thongke.Rows[i].ItemArray[5]) + Convert.ToInt32(thongke.Rows[i].ItemArray[6]);
            }
            labelCPXeMay.Text = "Xe máy: " + t.ToString();
            //Chi phi xe hoi
            t = 0;
            sqlCommand = new SqlCommand("Select * from XeHoi where TinhTrangTra=@tinhtrang and MaKH=@makh");
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            thongke = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < thongke.Rows.Count; i++)
            {
                t += Convert.ToInt32(thongke.Rows[i].ItemArray[5]) + Convert.ToInt32(thongke.Rows[i].ItemArray[6]);
            }
            labelCPXeHoi.Text = "Xe hơi: " + t.ToString();
            string dichVuDaSD = "";
            //dich vu da su dung
            SqlCommand command = new SqlCommand("select * from DSXE.dbo.XeHoi"+
            " inner join"+
            " Works.dbo.HopDong on Id = MaXe"+
            " inner join"+
            " Works.dbo.ChiTietHD on HopDong.SoHD = ChiTietHD.SoHD"+
            " where"+
            " IdDV = 1 and DSXE.dbo.XeHoi.MaKH = @makh");
            command.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
            thongke = xe.LayDSXe(command);
            if(thongke.Rows.Count>0)
            {
                dichVuDaSD = "Cho công ty thuê xe; ";
            }    
            //dich vu da su dung va thong ke so xe da muon
            command = new SqlCommand("select * from DSXE.dbo.XeHoi" +
            " inner join" +
            " Works.dbo.HopDong on Id = MaXe" +
            " inner join" +
            " Works.dbo.ChiTietHD on HopDong.SoHD = ChiTietHD.SoHD" +
            " where" +
            " IdDV = 2 and DSXE.dbo.XeHoi.MaKH = @makh");
            command.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
            thongke = xe.LayDSXe(command);
            if (thongke.Rows.Count > 0)
            {
                dichVuDaSD += "Mướn xe";
            }
            labelDichVu.Text = dichVuDaSD;
            labelXeThue.Text = "Số thuê đang mướn "+thongke.Rows.Count.ToString()+" xe";
        }

        private void buttonThemXe_Click(object sender, EventArgs e)
        {
            Workers.Xe.ThemXe form = new Workers.Xe.ThemXe(userID);
            form.Show();
            this.MenuUsers_Load(null, null);
        }

        private void buttonTraXe_Click(object sender, EventArgs e)
        {
            Workers.Xe.TraXe form = new Workers.Xe.TraXe();
            form.Show();
            this.MenuUsers_Load(null, null);
        }

        private void buttonDSXe_Click(object sender, EventArgs e)
        {
            Workers.Xe.DanhSachXe form = new Workers.Xe.DanhSachXe(userID);
            form.Show();
        }

        private void buttonTTKH_Click(object sender, EventArgs e)
        {
            Users.ThongTinKH form = new ThongTinKH(userID);
            form.Show();
            this.MenuUsers_Load(null, null);
        }

        private void buttonDichVu_Click(object sender, EventArgs e)
        {
            Users.DichVu form = new DichVu(userID);
            form.Show();
            this.MenuUsers_Load(null, null);
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            Users.ThanhToan form = new ThanhToan(userID);
            form.Show();
            this.MenuUsers_Load(null, null);
        }

        private void buttonXoaTK_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa tài khoản này không", "Xóa tài khoản", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (kh.deleteKhachHang(userID))
                {
                    MessageBox.Show("Xóa thành công", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }   
        }
    }
}
