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

namespace BaiGiuXeVer2.Forms.Workers.ThongTinNV
{
    public partial class ThongTinNV : Form
    {
        int staffID;
        Classes.NhanVien.NhanVien nv = new Classes.NhanVien.NhanVien();
        public ThongTinNV(int id)
        {
            InitializeComponent();
            this.staffID = id;
        }

        private void ThongTinNV_Load(object sender, EventArgs e)
        {
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
            //id
            DataTable dataNV = nv.getStaff(staffID);
            textBoxID.Text = staffID.ToString();
            textBoxTenNV.Text = dataNV.Rows[0].ItemArray[1].ToString();
            string gioitinh = dataNV.Rows[0].ItemArray[2].ToString().Trim();
            if(gioitinh=="Nam")
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
            comboBoxCongViec.SelectedValue = Convert.ToInt32(dataNV.Rows[0].ItemArray[4].ToString().Trim());
            textBoxSdt.Text = dataNV.Rows[0].ItemArray[3].ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                staffID = Convert.ToInt32(textBoxID.Text.ToString().Trim());
                string ten = textBoxTenNV.Text.Trim();
                string gioitinh = "Nam";
                if(radioButtonNu.Checked)
                {
                    gioitinh = "Nu";
                }
                int macv = Convert.ToInt32(comboBoxCongViec.SelectedValue);
                string sdt = textBoxSdt.Text.Trim();
                if(nv.updateStaff(staffID,ten,gioitinh,sdt,macv))
                {
                    MessageBox.Show("Sửa thành công", "Chỉnh sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Chỉnh sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thông tin chưa đầy đủ", "Chỉnh sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.ToString(), "Chỉnh sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
