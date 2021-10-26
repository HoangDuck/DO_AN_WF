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

namespace BaiGiuXeVer2.Forms.Workers.KhachHang
{
    public partial class DanhSachKH : Form
    {
        Classes.KhachHang.KhachHang kh = new Classes.KhachHang.KhachHang();
        public DanhSachKH()
        {
            InitializeComponent();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select Id,TenKH,DiaChi,SoDT from Users WHERE CONCAT(TenKH,Id) LIKE'%" + textBoxSearch.Text + "%'");
            if (textBoxSearch.Text == "")
            {
                sqlCommand = new SqlCommand("Select Id,TenKH,DiaChi,SoDT from Users");
            }
            dataGridViewKH.ReadOnly = true;
            dataGridViewKH.RowTemplate.Height = 80;
            dataGridViewKH.DataSource = kh.LayDSKhachHang(sqlCommand);
            dataGridViewKH.AllowUserToAddRows = false;
        }
        private void DanhSachKH_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select Id,TenKH,DiaChi,SoDT from Users");
            DataTable dataTable = kh.LayDSKhachHang(sqlCommand);
            dataGridViewKH.DataSource = dataTable;
            dataGridViewKH.ReadOnly = true;
            dataGridViewKH.AllowUserToAddRows = false;
        }

        private void dataGridViewKH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridViewKH.CurrentRow.Cells[0].Value;
            SuaThongTinKH form = new SuaThongTinKH(id);
            form.Show();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
