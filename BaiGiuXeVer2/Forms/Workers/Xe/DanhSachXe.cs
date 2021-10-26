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
    public partial class DanhSachXe : Form
    {
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        int maKH;
        string maKHSQL = "";
        public DanhSachXe()
        {
            InitializeComponent();
            this.DanhSachXe_Load(null, null);
        }
        public DanhSachXe(int maKH)
        {
            InitializeComponent();
            this.maKH = maKH;
            maKHSQL = " and MaKH=@maKH";
            this.DanhSachXe_Load(null, null);
        }
        private void DanhSachXe_Load(object sender, EventArgs e)
        {
            this.radioButtonXeDap_CheckedChanged(null, null);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string bienSo = "";
            if(radioButtonXeDap.Checked)
            {
                bienSo = "";
            }
            else
            {
                bienSo = ",BienXe";
            }
            SqlCommand sqlCommand = new SqlCommand("Select Id,NgayGui,NgayHetHanDK,Phi,Phat,Anh,HinhThucGui,MaKH"+bienSo+" from " + xe.tenBangXe+" WHERE CONCAT(Id,LoaiXe) LIKE'%" + textBoxSearch.Text + "%'"+" and TinhTrangTra=@tinhtrang"+maKHSQL);
            if (textBoxSearch.Text == "")
            {
                sqlCommand = new SqlCommand("Select Id,NgayGui,NgayHetHanDK,Phi,Phat,Anh,HinhThucGui,MaKH" + bienSo + " from " + xe.tenBangXe + " where TinhTrangTra=@tinhtrang"+maKHSQL);
            }
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            if (maKHSQL.Trim() != "")
            {
                sqlCommand.Parameters.Add("@maKH", SqlDbType.Int).Value = maKH;
            }
            dataGridViewDSXe.ReadOnly = true;
            dataGridViewDSXe.RowTemplate.Height = 80;
            dataGridViewDSXe.DataSource = xe.LayDSXe(sqlCommand);
            dataGridViewDSXe.AllowUserToAddRows = false;
        }

        private void dataGridViewDSXe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SuaThongTinXe form = new SuaThongTinXe();
            String tenBangXe = "";
            string t = dataGridViewDSXe.CurrentRow.Cells[1].ToString();
            if (radioButtonXeDap.Checked)
            {
                tenBangXe = "XeDap";
            }else if(radioButtonXeMay.Checked)
            {
                tenBangXe = "XeMay";
            }else if(radioButtonXeHoi.Checked)
            {
                tenBangXe = "XeHoi";
            }
            form.SetData(Convert.ToInt32(dataGridViewDSXe.CurrentRow.Cells[0].Value), tenBangXe);
            form.Show();
        }

        private void radioButtonXeDap_CheckedChanged(object sender, EventArgs e)
        {
            xe.tenBangXe = "XeDap";
            SqlCommand sqlCommand = new SqlCommand("Select Id,NgayGui,NgayHetHanDK,Phi,Phat,Anh,HinhThucGui,MaKH from [" + xe.tenBangXe + "] where TinhTrangTra=@tinhtrang"+maKHSQL);
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            if(maKHSQL.Trim()!="")
            {
                sqlCommand.Parameters.Add("@maKH", SqlDbType.Int).Value = maKH;
            }
            dataGridViewDSXe.DataSource = xe.LayDSXe(sqlCommand);
            dataGridViewDSXe.ReadOnly = true;
            dataGridViewDSXe.RowTemplate.Height = 80;
            dataGridViewDSXe.AllowUserToAddRows = false;
        }

        private void radioButtonXeMay_CheckedChanged(object sender, EventArgs e)
        {
            xe.tenBangXe = "XeMay";
            SqlCommand sqlCommand = new SqlCommand("Select Id,NgayGui,NgayHetHanDK,Phi,Phat,BienXe,Anh,HinhThucGui,MaKH from [" + xe.tenBangXe + "] where TinhTrangTra=@tinhtrang"+maKHSQL);
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            if (maKHSQL.Trim() != "")
            {
                sqlCommand.Parameters.Add("@maKH", SqlDbType.Int).Value = maKH;
            }
            dataGridViewDSXe.DataSource = xe.LayDSXe(sqlCommand);
            dataGridViewDSXe.ReadOnly = true;
            dataGridViewDSXe.RowTemplate.Height = 80;
            dataGridViewDSXe.AllowUserToAddRows = false;
        }

        private void radioButtonXeHoi_CheckedChanged(object sender, EventArgs e)
        {
            xe.tenBangXe = "XeHoi";
            SqlCommand sqlCommand = new SqlCommand("Select Id,NgayGui,NgayHetHanDK,Phi,Phat,BienXe,Anh,HinhThucGui,MaKH from [" + xe.tenBangXe + "] where TinhTrangTra=@tinhtrang"+maKHSQL);
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            if (maKHSQL.Trim() != "")
            {
                sqlCommand.Parameters.Add("@maKH", SqlDbType.Int).Value = maKH;
            }
            dataGridViewDSXe.DataSource = xe.LayDSXe(sqlCommand);
            dataGridViewDSXe.ReadOnly = true;
            dataGridViewDSXe.RowTemplate.Height = 80;
            dataGridViewDSXe.AllowUserToAddRows = false;
        }
    }
}
