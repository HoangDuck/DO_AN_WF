using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Workers.Xe
{
    public partial class SuaThongTinXe : Form
    {
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        public SuaThongTinXe()
        {
            InitializeComponent();
            textBoxID.ReadOnly = true;
        }
        public void SetData(int id,String tenBangXe)
        {
            //lay tu database
            SqlCommand sqlCommand = new SqlCommand("Select * from "+tenBangXe+" where Id=@id");
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            textBoxID.Text = id.ToString();
            DataTable dataTable = xe.LayDSXe(sqlCommand);
            labelPhi.Text ="Phí: "+ dataTable.Rows[0].ItemArray[5].ToString();
            labelPhat.Text ="Phạt: "+ dataTable.Rows[0].ItemArray[6].ToString();
            labelKhachHang.Text ="Khách hàng: "+ dataTable.Rows[0].ItemArray[10].ToString();
            //Truy van loai xe
            if (dataTable.Rows[0].ItemArray[1].ToString() == "Xe hoi    ")
            {
                radioButtonXeHoi.Checked = true;
                labelBienXe.Text = dataTable.Rows[0].ItemArray[7].ToString();
            }
            if (dataTable.Rows[0].ItemArray[1].ToString() == "Xe may    ")
            {
                radioButtonXeMay.Checked = true;
                labelBienXe.Text = dataTable.Rows[0].ItemArray[7].ToString();
            }
            if (dataTable.Rows[0].ItemArray[1].ToString() == "Xe dap    ")
            {
                radioButtonXeDap.Checked = true;
            }
            //Truy van hinh thuc gui
            if (dataTable.Rows[0].ItemArray[9].ToString() == "Ngay      ")
            {
                radioButtonNgay.Checked = true;
            }
            if (dataTable.Rows[0].ItemArray[9].ToString() == "Tuan      ")
            {
                radioButtonTuan.Checked = true;
            }
            if (dataTable.Rows[0].ItemArray[9].ToString() == "Thang     ")
            {
                radioButtonThang.Checked = true;
            }
            //lay thong tin ngay gui
            dateTimePickerNgayGui.Value = (DateTime)dataTable.Rows[0].ItemArray[2];
            dateTimePickerNgayTraXeDK.Value = (DateTime)dataTable.Rows[0].ItemArray[3];
            if (xe.tinhTrangTra==false) {
                labelNgayTraXe.Visible = false;
                dateTimePickerNgayTraXe.Visible = false;    
            }
            else
            {
                labelNgayTraXe.Visible = true;
                dateTimePickerNgayTraXe.Visible = true;
                dateTimePickerNgayTraXe.Value = (DateTime)dataTable.Rows[0].ItemArray[4];
            }
            //set image for picturebox
            byte[] b = (byte[])dataTable.Rows[0].ItemArray[8];
            MemoryStream memoryStream = new MemoryStream(b);
            pictureBoxHinhXe.Image = Image.FromStream(memoryStream);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text.Trim());
            String tenBangXe="";
            if(radioButtonXeDap.Checked)
            {
                tenBangXe = "XeDap";
            }
            else if(radioButtonXeMay.Checked)
            {
                tenBangXe = "XeMay";
            }
            else if(radioButtonXeHoi.Checked)
            {
                tenBangXe = "XeHoi";
            }
            xe.GanDoiTuongTuDataTable(xe, id, tenBangXe);
            xe.DateOfVehicles.NgayGui = dateTimePickerNgayGui.Value;
            xe.DateOfVehicles.NgayPhaiTraXeDK = dateTimePickerNgayTraXeDK.Value;

            if(xe.ChinhSuaThongTinXe(xe))
            {
                MessageBox.Show("Chỉnh sửa thông tin hoàn tất", "Chỉnh sửa thông tin xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thông tin không thành công", "Chỉnh sửa thông tin xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            xe.ID = Convert.ToInt32(textBoxID.Text.Trim());
            if (radioButtonXeDap.Checked)
            {
                xe.tenBangXe = "XeDap";
            }
            else if (radioButtonXeMay.Checked)
            {
                xe.tenBangXe = "XeMay";
            }
            else if (radioButtonXeHoi.Checked)
            {
                xe.tenBangXe = "XeHoi";
            }
            if(xe.XoaXe(xe))
            {
                MessageBox.Show("Xóa thành công", "Xóa thông tin xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Xóa thông tin xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
