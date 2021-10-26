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
    public partial class SuaThongTinKH : Form
    {
        int userID;
        Classes.KhachHang.KhachHang kh = new Classes.KhachHang.KhachHang();
        public SuaThongTinKH()
        {
            InitializeComponent();
        }
        public SuaThongTinKH(int id)
        {
            InitializeComponent();
            this.userID = id;
        }
        private void dataGridViewKH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userID = (int)dataGridViewKH.CurrentRow.Cells[0].Value;
            SqlCommand sqlCommand = new SqlCommand("Select * from Users where Id=@id");
            sqlCommand.Parameters.Add("@id",SqlDbType.Int).Value=userID;
            DataTable dataTable = kh.LayDSKhachHang(sqlCommand);
            textBoxMaKH.Text = userID.ToString().Trim();
            textBoxTenKH.Text = dataTable.Rows[0].ItemArray[1].ToString().Trim();
            textBoxDiaChi.Text = dataTable.Rows[0].ItemArray[2].ToString().Trim();
            textBoxSDT.Text = dataTable.Rows[0].ItemArray[3].ToString().Trim();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxMaKH.Text.Trim());
                string ten = textBoxTenKH.Text.Trim();
                string diaChi = textBoxDiaChi.Text.Trim();
                string sdt = textBoxSDT.Text.Trim();
                if (kh.deleteKhachHang(id))
                {
                    MessageBox.Show("Xóa thông tin thành công", "Xóa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thông tin không thành công", "Xóa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin chưa đầy đủ", "Xóa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxMaKH.Text.Trim());
                string ten = textBoxTenKH.Text.Trim();
                string diaChi = textBoxDiaChi.Text.Trim();
                string sdt = textBoxSDT.Text.Trim();
                if (kh.updateKhachhang(id, ten, diaChi, sdt))
                {
                    MessageBox.Show("Sửa thông tin thành công", "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin không thành công", "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin chưa đầy đủ", "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SuaThongTinKH_Load(object sender, EventArgs e)
        {
            try
            {
                if (userID.ToString().Trim() != "0")
                {
                    SqlCommand command = new SqlCommand("Select * from Users where Id=@id");
                    command.Parameters.Add("@id", SqlDbType.Int).Value = userID;
                    DataTable data = kh.LayDSKhachHang(command);
                    textBoxMaKH.Text = data.Rows[0].ItemArray[0].ToString().Trim();
                    textBoxTenKH.Text = data.Rows[0].ItemArray[1].ToString().Trim();
                    textBoxDiaChi.Text = data.Rows[0].ItemArray[2].ToString().Trim();
                    textBoxSDT.Text = data.Rows[0].ItemArray[3].ToString().Trim();
                }
                SqlCommand sqlCommand = new SqlCommand("Select Id,TenKH,SoDT from Users");
                DataTable dataTable = kh.LayDSKhachHang(sqlCommand);
                dataGridViewKH.DataSource = dataTable;
                dataGridViewKH.ReadOnly = true;
                dataGridViewKH.AllowUserToAddRows = false;
            }
            catch
            {

            }
        }
    }
}
