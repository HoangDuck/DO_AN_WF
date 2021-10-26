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
    public partial class ChonXe : Form
    {
        String tenBangXe = "XeDap";
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        public ChonXe()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonXeMay.Checked)
                {
                    tenBangXe = "XeMay";
                }
                else if (radioButtonXeHoi.Checked)
                {
                    tenBangXe = "XeHoi";
                }
                else
                {
                    tenBangXe = "XeDap";
                }
                SqlCommand sqlCommand = new SqlCommand("Select Count(*) from " + tenBangXe + " where Id=@id and TinhTrangTra=@tinhtrang");
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(textBoxID.Text.Trim());
                sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
                int soLuong = xe.DemXe(sqlCommand);
                if (soLuong > 0)
                {
                    SuaThongTinXe form = new SuaThongTinXe();
                    form.SetData(Convert.ToInt32(textBoxID.Text.Trim()), tenBangXe);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Xe này không tồn tại", "Chọn xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Chỉnh sửa thông tin xe", "Chỉnh thông tin xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
