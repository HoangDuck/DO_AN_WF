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

namespace BaiGiuXeVer2.Forms.Managers
{
    public partial class MenuManagers : Form
    {
        Classes.NhanVien.QuanLy ql = new Classes.NhanVien.QuanLy();
        int managerID;
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        Classes.NhanVien.NhanVien nv = new Classes.NhanVien.NhanVien();
        public MenuManagers()
        {
            InitializeComponent();
        }
        public MenuManagers(int id)
        {
            InitializeComponent();
            this.managerID = id;
        }
        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            int hour = dateTime.Hour;
            if (hour < 7 || hour > 22)
            {
                MessageBox.Show("Bạn đang ngoài giờ làm", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (ql.checkinql(managerID,dateTime, dateTime))
                {
                    MessageBox.Show("Check-in successfully!", "Check - in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Check-in failed!!!", "Check - in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                if (ql.updatecheckinql(managerID,dateTime, dateTime))
                {
                    MessageBox.Show("Check-in successfully!", "Check - in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Check-in failed!!!", "Check - in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            int hour = dateTime.Hour;
            if (hour < 7 || hour > 22)
            {
                MessageBox.Show("Bạn đang ngoài giờ làm", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (ql.checkoutql(managerID, dateTime, dateTime))
                {
                    MessageBox.Show("Check-out successfully!\n" + ql.TinhLuongQL(managerID, dateTime)+" VND", "Check - in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Check-out failed!!!", "Check - out", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonDSNV_Click(object sender, EventArgs e)
        {
            this.buttonHuyTKB_Click(null, null);
            dataGridViewTable.ReadOnly = true;
            dataGridViewTable.RowTemplate.Height = 80;
            dataGridViewTable.AllowUserToAddRows = false;
            dataGridViewTable.DataSource = nv.getAllStaffs();
            dataGridViewTable.Columns[0].HeaderText = "ID";
            dataGridViewTable.Columns[1].HeaderText = "Tên thợ";
            dataGridViewTable.Columns[2].HeaderText = "Giới tính";
            dataGridViewTable.Columns[3].HeaderText = "Số điện thoại";
            dataGridViewTable.Columns[4].HeaderText = "Mã chuyên môn";
            buttonXoaNV.Visible = true;
            buttonTKB.Visible = true;
            buttonTKBQL.Visible = false;
            buttonDSXe.Visible = false;
            buttonHuyDSNV.Visible = true;
            labelLuong.Visible = false;
        }

        private void buttonXoaNV_Click(object sender, EventArgs e)
        {
            XoaNV form = new XoaNV();
            form.Show();
            dataGridViewTable.DataSource = null;
            this.buttonDSNV_Click(null, null);
        }

        private void buttonTKB_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = null;
            dataGridViewTable.ReadOnly = true;
            dataGridViewTable.RowTemplate.Height = 80;
            dataGridViewTable.AllowUserToAddRows = false;
            MyDB.MyDBChuyenMon myDB = new MyDB.MyDBChuyenMon();
            SqlCommand sqlCommand = new SqlCommand("Select * FROM PhanCong", myDB.GetSqlConnection);
            DataTable data = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(data);
            dataGridViewTable.DataSource = data;
        }

        private void MenuManagers_Load(object sender, EventArgs e)
        {

        }

        private void buttonDSXe_Click(object sender, EventArgs e)
        {
            //giao dien
            buttonCheckIn.Visible = false;
            buttonCheckOut.Visible = false;
            buttonDSNV.Visible = false;
            buttonTKB.Visible = false;
            buttonXoaNV.Visible = false;
            buttonTKBQL.Visible = false;
            buttonHuy.Visible = true;
            labelChonXe.Visible = true;
            radioButtonXeDap.Visible = true;
            radioButtonXeMay.Visible = true;
            radioButtonXeHoi.Visible = true;
            labelLuong.Visible = false;
            //danh sach xe dap
            this.radioButtonXeDap_CheckedChanged(null, null);
        }

        private void buttonTKBQL_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = null;
            dataGridViewTable.Visible = false;
            labelCa1.Visible = true;
            labelCa2.Visible = true;
            labelCa3.Visible = true;
            textBoxCa1.Visible = true;
            textBoxCa2.Visible = true;
            textBoxCa3.Visible = true;
            labelLuong.Visible = false;
            dateTimePickerTKB.Visible = true;
            dateTimePickerTKB.Value = DateTime.Now;
            this.dateTimePickerTKB_ValueChanged(null, null);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonXoaTK_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa tài khoản này không", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (ql.deleteManager(managerID))
                {
                    MessageBox.Show("Xóa thành công", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            buttonCheckIn.Visible = true;
            buttonCheckOut.Visible = true;
            buttonDSNV.Visible = true;
            buttonTKB.Visible = true;
            buttonXoaNV.Visible = true;
            buttonTKBQL.Visible = true;
            buttonHuy.Visible = false;
            labelChonXe.Visible = false;
            radioButtonXeDap.Visible = false;
            radioButtonXeMay.Visible = false;
            radioButtonXeHoi.Visible = false;
            labelLuong.Visible = false;
            dataGridViewTable.DataSource = null;
        }

        private void radioButtonXeDap_CheckedChanged(object sender, EventArgs e)
        {
            //danh sach xe dap
            dataGridViewTable.DataSource = null;
            dataGridViewTable.ReadOnly = true;
            dataGridViewTable.RowTemplate.Height = 80;
            dataGridViewTable.AllowUserToAddRows = false;
            xe.tenBangXe = "XeDap";
            SqlCommand sqlCommand = new SqlCommand("Select Id,NgayGui,NgayHetHanDK,Phi,Phat,Anh,HinhThucGui,MaKH from [" + xe.tenBangXe + "] where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            dataGridViewTable.DataSource = xe.LayDSXe(sqlCommand);    
        }

        private void radioButtonXeMay_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = null;
            dataGridViewTable.ReadOnly = true;
            dataGridViewTable.RowTemplate.Height = 80;
            dataGridViewTable.AllowUserToAddRows = false;
            xe.tenBangXe = "XeMay";
            SqlCommand sqlCommand = new SqlCommand("Select Id,NgayGui,NgayHetHanDK,Phi,Phat,BienXe,Anh,HinhThucGui,MaKH from [" + xe.tenBangXe + "] where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            dataGridViewTable.DataSource = xe.LayDSXe(sqlCommand);
        }

        private void radioButtonXeHoi_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = null;
            dataGridViewTable.ReadOnly = true;
            dataGridViewTable.RowTemplate.Height = 80;
            dataGridViewTable.AllowUserToAddRows = false;
            xe.tenBangXe = "XeHoi";
            SqlCommand sqlCommand = new SqlCommand("Select Id,NgayGui,NgayHetHanDK,Phi,Phat,BienXe,Anh,HinhThucGui,MaKH from [" + xe.tenBangXe + "] where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
            dataGridViewTable.DataSource = xe.LayDSXe(sqlCommand);
        }

        private void buttonHuyDSNV_Click(object sender, EventArgs e)
        {
            buttonXoaNV.Visible = false;
            buttonTKB.Visible = false;
            buttonTKBQL.Visible = true;
            buttonDSXe.Visible = true;
            buttonHuyDSNV.Visible = false;
            dataGridViewTable.DataSource = null;
        }

        private void dateTimePickerTKB_ValueChanged(object sender, EventArgs e)
        {
            textBoxCa1.Text = "";
            textBoxCa2.Text = "";
            textBoxCa3.Text = "";
            DataTable data = ql.getTKBQL(managerID, dateTimePickerTKB.Value);
            if (data.Rows.Count != 0)
            {
                if (Convert.ToInt32(data.Rows[0].ItemArray[1]) == 1)
                {
                    textBoxCa1.Text = "X";
                }
                if (Convert.ToInt32(data.Rows[0].ItemArray[2]) == 1)
                {
                    textBoxCa2.Text = "X";
                }
                if (Convert.ToInt32(data.Rows[0].ItemArray[3]) == 1)
                {
                    textBoxCa3.Text = "X";
                }
            }
        }

        private void buttonHuyTKB_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = null;
            dataGridViewTable.Visible = true ;
            labelCa1.Visible = false;
            labelCa2.Visible = false;
            labelCa3.Visible = false;
            textBoxCa1.Visible = false;
            textBoxCa2.Visible = false;
            textBoxCa3.Visible = false;
            dateTimePickerTKB.Visible = false;
        }

        private void buttonDSTGLV_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = null;
            dataGridViewTable.ReadOnly = true;
            dataGridViewTable.RowTemplate.Height = 80;
            dataGridViewTable.AllowUserToAddRows = false;
            MyDB.MyDBChuyenMon myDBChuyenMon = new MyDB.MyDBChuyenMon();
            SqlCommand sqlCommand = new SqlCommand("Select * from TinhCongQL where Id=@id",myDBChuyenMon.GetSqlConnection);
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = managerID;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            dataGridViewTable.DataSource = data;
            labelLuong.Visible = true;
            int luong = 0;
            for(int i=0;i<data.Rows.Count;i++)
            {
                luong += Convert.ToInt32(data.Rows[i].ItemArray[4].ToString()) / 3600 * 50000;
            }
            labelLuong.Text = "Lương: " + luong + " VND";
        }
    }
}
