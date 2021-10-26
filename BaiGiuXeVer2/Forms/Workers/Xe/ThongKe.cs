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

namespace BaiGiuXeVer2.Forms.Workers.Xe
{
    public partial class ThongKe : Form
    {
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select Count(*) from XeDap where tinhTrangTra='Da Tra'");
            textBoxXeDapDaTra.Text= xe.DemXe(sqlCommand).ToString();
            sqlCommand = new SqlCommand("Select Count(*) from XeDap where tinhTrangTra='Chua Tra'");
            textBoxXeDapChuaTra.Text = xe.DemXe(sqlCommand).ToString();
            sqlCommand = new SqlCommand("Select Count(*) from XeMay where tinhTrangTra='Da Tra'");
            textBoxXeMayDaTra.Text = xe.DemXe(sqlCommand).ToString();
            sqlCommand = new SqlCommand("Select Count(*) from XeMay where tinhTrangTra='Chua Tra'");
            textBoxXeMayChuaTra.Text = xe.DemXe(sqlCommand).ToString();
            sqlCommand = new SqlCommand("Select Count(*) from XeHoi where tinhTrangTra='Da Tra'");
            textBoxXeHoiDaTra.Text = xe.DemXe(sqlCommand).ToString();
            sqlCommand = new SqlCommand("Select Count(*) from XeHoi where tinhTrangTra='Chua Tra'");
            textBoxXeHoiChuaTra.Text = xe.DemXe(sqlCommand).ToString();
            //doanh thu hien tai
            sqlCommand = new SqlCommand("Select * from XeDap where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            DataTable data = xe.LayDSXe(sqlCommand);
            int t = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                t += Convert.ToInt32(data.Rows[i].ItemArray[5]) + Convert.ToInt32(data.Rows[i].ItemArray[6]);
            }
            //doanh thu xe may
            sqlCommand = new SqlCommand("Select * from XeMay where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            data = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                t += Convert.ToInt32(data.Rows[i].ItemArray[5]) + Convert.ToInt32(data.Rows[i].ItemArray[6]);
            }
            //doanh thu xe hoi
            sqlCommand = new SqlCommand("Select * from XeHoi where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            data = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                t += Convert.ToInt32(data.Rows[i].ItemArray[5]) + Convert.ToInt32(data.Rows[i].ItemArray[6]);
            }
            labelDoanhThuDK.Text = "Doanh thu hiện tại: " + t.ToString();
        }
    }
}
