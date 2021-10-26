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

namespace BaiGiuXeVer2
{
    public partial class AddHopDong : Form
    {
        int userID;
        string tenBangXe="";
        Classes.HopDong.HopDong hd = new Classes.HopDong.HopDong();
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        string maHD;//de kieu string r chuyen thanh kieu int khi dua vao database
        string maDVDcChon;//dung de gop ma hd
        string maKH;//dung de gop ma hd
        string maXe;//dung de gop ma hd
        DateTime ngayKiHD;
        DateTime ngayHetHanHD;
        public AddHopDong()
        {
            InitializeComponent();
        }
        public AddHopDong(int id)
        {
            InitializeComponent();
            this.userID = id;
            maKH = id.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int maHD = Convert.ToInt32(textBoxSoHD.Text);
                DateTime ngayki = dateTimePickerKi.Value;
                DateTime ngayhet = dateTimePickerHethan.Value;
                int maxe = Convert.ToInt32(textBoxXe.Text);
                int maKH = Convert.ToInt32(textBoxKH.Text);
                int maDV,chiPhi;
                if(comboBoxLoaiHD.SelectedIndex==0)
                {
                    maDV = 1;
                    chiPhi = 100000;
                }    
                else if(comboBoxLoaiHD.SelectedIndex==1)
                {
                    maDV = 2;
                    chiPhi = 200000;
                }
                else
                {
                    Exception ex = new Exception();
                    throw ex;
                }
                int maTho=0;
                if (!hd.hopdongExist(maHD))
                {
                    if (hd.ThemHD(maHD,ngayki,ngayhet,maxe,maKH)&&hd.ThemDVVaoHD(maDV,maHD,chiPhi,maTho))
                    {
                        MessageBox.Show("Chèn thành công", "Thêm hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chèn không thành công", "Thêm hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Hợp đồng đã tồn tại\n Hãy thử lại sau!", "Add Hop Dong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin chưa đầy đủ", "Thêm hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelectXe_Click(object sender, EventArgs e)
        {
            bool mode;//true la dich vu cho cty thue xe,false la dich vu muon xe
            if (maDVDcChon=="1")
            {
                mode = true;
            }
            else if(maDVDcChon=="2")
            {
                mode = false;
            }
            else
            {
                MessageBox.Show("Chưa chọn dịch vụ", "Chọn xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Forms.Users.SelectXe chonXe = new Forms.Users.SelectXe(userID,mode);
            var temp = chonXe.ShowDialog();
            if (temp == DialogResult.OK)
            {
                textBoxXe.Text = chonXe.ID.ToString();
                tenBangXe = "XeHoi";
                xe.GanDoiTuongTuDataTable(xe, chonXe.ID, tenBangXe);
                dateTimePickerKi.Value = ngayKiHD;
                ngayHetHanHD= xe.DateOfVehicles.NgayPhaiTraXeDK; 
                dateTimePickerHethan.Value = ngayHetHanHD;
            }
        }

        private void AddHopDong_Load(object sender, EventArgs e)
        {
            textBoxKH.Text = this.userID.ToString().Trim();
            comboBoxLoaiHD.Items.Add("Cho công ty thuê xe");
            comboBoxLoaiHD.Items.Add("Mướn xe");
            comboBoxLoaiHD.SelectedItem = null;
            this.ngayKiHD = DateTime.Now;
        }

        private void comboBoxLoaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxLoaiHD.SelectedIndex==0)
            {
                labelGiaiThichHD.Text = "Dịch vụ này xe của bạn được giữ tại công ty \n" +
                    "và sử dụng xe của bạn để cho khách hàng khác thuê.\n" +
                    "Chi phí của dịch vụ này bao gồm:\n" +
                    "Chi phí dịch vụ trông coi xe(được tính như \n" +
                    "giá gửi xe bình thường); rửa và sửa xe(100000d)";
                maDVDcChon = "1";
                this.textBoxXe_TextChanged(null, null);
            }
            else
            {
                labelGiaiThichHD.Text = "Dịch vụ này cho bạn mướn xe của công ty";
                maDVDcChon = "2";
                this.textBoxXe_TextChanged(null, null);
            }
        }

        private void textBoxXe_TextChanged(object sender, EventArgs e)
        {
            if(textBoxXe.Text.ToString().Trim()!="")
            {
                maXe = textBoxXe.Text.ToString().Trim();
                maHD = maKH + maXe + maDVDcChon;
                labelSoHD.Visible = true;
                textBoxSoHD.Visible = true;
                textBoxSoHD.Text = maHD.ToString();
            }
            else
            {
                maXe = "";
                maHD = "";
                textBoxSoHD.Text = "";
                labelSoHD.Visible = false;
                textBoxSoHD.Visible = false;
            }
        }

        private void dateTimePickerHethan_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePickerHethan.Value>ngayHetHanHD||dateTimePickerHethan.Value<dateTimePickerKi.Value)
            {
                MessageBox.Show("Không được chọn ngày này", "Chọn ngày", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerHethan.Value = ngayHetHanHD;
            }    
        }

        private void dateTimePickerKi_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerKi.Value > dateTimePickerHethan.Value || dateTimePickerKi.Value < ngayKiHD)
            {
                MessageBox.Show("Không được chọn ngày này", "Chọn ngày", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerKi.Value = ngayKiHD;
            }
        }
    }
}
