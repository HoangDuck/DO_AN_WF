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

namespace BaiGiuXeVer2.Forms.Registers
{
    public partial class RegisterManagers : Form
    {
        Classes.NhanVien.QuanLy ql = new Classes.NhanVien.QuanLy();
        MyDB.MyDBParkLogin myDB = new MyDB.MyDBParkLogin();
        public RegisterManagers()
        {
            InitializeComponent();
        }

        private void RegisterManagers_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Classes.NhanVien.QuanLy ql = new Classes.NhanVien.QuanLy();
            SqlCommand sqlCommand = new SqlCommand("Select Count(*) from Managers");
            int soLuongQL = ql.DemQL(sqlCommand);
            if(soLuongQL>=2)
            {
                MessageBox.Show("Đã đủ người quản lý", "Thêm quản lý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            try
            {
                int maNV = Convert.ToInt32(textBoxID.Text.Trim());
                string tenTho = textBoxTenNV.Text.Trim();
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text.Trim();
                string sdt = textBoxSdt.Text.Trim();
                string diaChi = textBoxDiaChi.Text.Trim();
                if (ql.insertManager(maNV, tenTho, diaChi, sdt, username, password))
                {
                    DateTime t = DateTime.Now;
                    ql.TuDongPhanCongQL(t);
                    MessageBox.Show("Đăng kí thành công", "Thêm quản lý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng kí không thành công", "Thêm quản lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thông tin không đầy đủ", "Thêm quản lý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
