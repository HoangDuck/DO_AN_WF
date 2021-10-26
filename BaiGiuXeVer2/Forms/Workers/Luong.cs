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

namespace BaiGiuXeVer2.Forms.Workers
{
    public partial class Luong : Form
    {
        int staffID;
        public Luong(int id)
        {
            InitializeComponent();
            this.staffID = id;
        }

        private void Luong_Load(object sender, EventArgs e)
        {
            dataGridViewTinhCong.DataSource = null;
            dataGridViewTinhCong.ReadOnly = true;
            dataGridViewTinhCong.RowTemplate.Height = 80;
            dataGridViewTinhCong.AllowUserToAddRows = false;
            MyDB.MyDBChuyenMon myDBChuyenMon = new MyDB.MyDBChuyenMon();
            SqlCommand sqlCommand = new SqlCommand("Select * from TinhCong where Id=@id", myDBChuyenMon.GetSqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = staffID;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            dataGridViewTinhCong.DataSource = data;
            labelLuong.Visible = true;
            int luong = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                luong += Convert.ToInt32(data.Rows[i].ItemArray[8].ToString()) / 3600 * 50000;
            }
            labelLuong.Text = "Lương: " + luong + " VND";
        }
    }
}
