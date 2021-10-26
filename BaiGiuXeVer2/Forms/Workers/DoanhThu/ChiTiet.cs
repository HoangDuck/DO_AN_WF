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

namespace BaiGiuXeVer2.Forms.Workers.DoanhThu
{
    public partial class ChiTiet : Form
    {
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        public ChiTiet()
        {
            InitializeComponent();
        }

        private void ChiTiet_Load(object sender, EventArgs e)
        {
            //doanh thu xe dap
            SqlCommand sqlCommand = new SqlCommand("Select * from XeDap where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            DataTable data = xe.LayDSXe(sqlCommand);
            int t = 0;
            for(int i=0;i<data.Rows.Count;i++)
            {
                t += Convert.ToInt32(data.Rows[i].ItemArray[5])+ Convert.ToInt32(data.Rows[i].ItemArray[6]);
            }
            textBoxXeDap.Text = t.ToString();
            //doanh thu xe may
            sqlCommand = new SqlCommand("Select * from XeMay where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            data = xe.LayDSXe(sqlCommand);
            t = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                t += Convert.ToInt32(data.Rows[i].ItemArray[5]) + Convert.ToInt32(data.Rows[i].ItemArray[6]);
            }
            textBoxXeMay.Text = t.ToString();
            //doanh thu xe hoi
            sqlCommand = new SqlCommand("Select * from XeHoi where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            data = xe.LayDSXe(sqlCommand);
            t = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                t += Convert.ToInt32(data.Rows[i].ItemArray[5]) + Convert.ToInt32(data.Rows[i].ItemArray[6]);
            }
            textBoxXeHoi.Text = t.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
