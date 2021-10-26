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
    public partial class TraXe : Form
    {
        public TraXe()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Xe.Xe xe = new Classes.Xe.Xe();
                if (radioButtonXeMay.Checked)
                {
                    xe.tenBangXe = "XeMay";
                }
                else if (radioButtonXeHoi.Checked)
                {
                    xe.tenBangXe = "XeHoi";
                }
                else
                {
                    xe.tenBangXe = "XeDap";
                }
                xe.ID = Convert.ToInt32(textBoxID.Text.Trim());
                SqlCommand sqlCommand = new SqlCommand("Select Count(*) from " + xe.tenBangXe + " where Id=@id and TinhTrangTra=@tinhtrang");
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = xe.ID;
                sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
                int soLuong = xe.DemXe(sqlCommand);
                if (soLuong > 0)
                {
                    xe.GanDoiTuongTuDataTable(xe, xe.ID, xe.tenBangXe);
                    xe.DateOfVehicles.TraXe(DateTime.Now);
                    DateTime temp = xe.DateOfVehicles.NgayTraXeThucTe;
                    if (xe.DateOfVehicles.Tre)
                        xe.ChiPhi.TinhTienPhat(xe.HinhThucGui);
                    int t = xe.ChiPhi.TienPhat;
                    xe.tinhTrangTra = true;
                    xe.ChinhSuaThongTinXe(xe);
                    MessageBox.Show("Trả xe thành công", "Trả xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xe này không tồn tại", "Chọn xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin chưa đầy đủ", "Trả xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
