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
    public partial class RegisterWorkers : Form
    {
        Classes.NhanVien.NhanVien nv = new Classes.NhanVien.NhanVien();
        public RegisterWorkers()
        {
            InitializeComponent();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int maNV = Convert.ToInt32(textBoxID.Text.Trim());
                string tenTho = textBoxTenNV.Text.Trim();
                string gioiTinh = "Nam";
                if (radioButtonNu.Checked)
                {
                    gioiTinh = "Nu";
                }
                int maCV = Convert.ToInt32(comboBoxCongViec.SelectedValue);
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text.Trim();
                string sdt = textBoxSdt.Text.Trim();
                if(nv.insertStaff(maNV,tenTho,gioiTinh,sdt,maCV,username,password))
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thêm NV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công", "Thêm NV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không đầy đủ", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RegisterWorkers_Load(object sender, EventArgs e)
        {
            radioButtonNam.Checked = true;
            SqlCommand sqlCommand = new SqlCommand("Select * from CongViec");
            MyDB.MyDBChuyenMon myDBChuyenMon = new MyDB.MyDBChuyenMon();
            sqlCommand.Connection = myDBChuyenMon.GetSqlConnection;
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            comboBoxCongViec.DataSource = data;
            comboBoxCongViec.DisplayMember = "TenChuyenMon";
            comboBoxCongViec.ValueMember = "MaChuyenMon";
            comboBoxCongViec.SelectedItem = null;
        }
    }
}
