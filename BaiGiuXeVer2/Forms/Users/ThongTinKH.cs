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
    public partial class ThongTinKH : Form
    {
        int userID;
        Classes.KhachHang.KhachHang kh = new Classes.KhachHang.KhachHang();
        public ThongTinKH()
        {
            InitializeComponent();
        }
        public ThongTinKH(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void ThongTinKH_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Users where Id=@id");
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = userID;
            DataTable data = kh.LayDSKhachHang(sqlCommand);
            textBoxMaKH.Text = userID.ToString();
            textBoxTenKH.Text = data.Rows[0].ItemArray[1].ToString().Trim();
            textBoxDiaChi.Text = data.Rows[0].ItemArray[2].ToString().Trim();
            textBoxSDT.Text = data.Rows[0].ItemArray[3].ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxMaKH.Text.Trim());
                string ten = textBoxTenKH.Text.Trim();
                string diaChi = textBoxDiaChi.Text.Trim();
                string sdt = textBoxSDT.Text.Trim();
                if(kh.updateKhachhang(id,ten,diaChi,sdt))
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
    }
}
