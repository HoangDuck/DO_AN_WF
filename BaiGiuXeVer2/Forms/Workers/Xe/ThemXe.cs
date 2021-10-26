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
    public partial class ThemXe : Form
    {
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        int maKH=-1;
        public ThemXe()
        {
            InitializeComponent();
        }

        public ThemXe(int maKH)
        {
            InitializeComponent();
            this.maKH = maKH;
        }

        private void ThemXe_Load(object sender, EventArgs e)
        {
            if (maKH != -1)
            {
                labelMaKH.Visible = false;
                textBoxMaKH.Visible = false;
            }
            else
            {
                labelMaKH.Visible = true;
                textBoxMaKH.Visible = true;
            }
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif|*.jpg;*.png;*.gif)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxHinhXe.Image = Image.FromFile(open.FileName);
            }
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                //Lay id
                xe.ID = Convert.ToInt32(textBoxID.Text.Trim());
                textBoxID.Text = "";
                //lay ma khach hang
                if(maKH==-1)
                {
                    maKH = Convert.ToInt32(textBoxMaKH.Text.Trim());
                }
                
                //dung cho form them xe ben khach hang
                xe.MaKH = maKH.ToString().Trim();
                
                textBoxMaKH.Text = "";
                //chon loai xe
                if (radioButtonXeMay.Checked)
                {
                    xe.LoaiXe = "Xe may";
                    xe.tenBangXe = "XeMay";
                    radioButtonXeMay.Checked = false;
                }
                else if (radioButtonXeHoi.Checked)
                {
                    xe.LoaiXe = "Xe hoi";
                    xe.tenBangXe = "XeHoi";
                    radioButtonXeHoi.Checked = false;
                }
                else
                {
                    xe.LoaiXe = "Xe dap";
                    xe.tenBangXe = "XeDap";
                    radioButtonXeDap.Checked = false;
                }
                //lay bien so xe
                xe.BienSo = textBoxBienSo.Text.Trim();
                textBoxBienSo.Text = "";
                //lay ngay gui
                xe.DateOfVehicles = new Classes.TGGuiXe.ThoiGianGuiXe(dateTimePickerNgayGui.Value);

                //hinh thuc gui
                if (radioButtonNgay.Checked)
                {
                    xe.HinhThucGui = "Ngay";
                    radioButtonNgay.Checked = false;
                }
                else if (radioButtonTuan.Checked)
                {
                    xe.HinhThucGui = "Tuan";
                    radioButtonTuan.Checked = false;
                }
                else
                {
                    xe.HinhThucGui = "Thang";
                    radioButtonThang.Checked = false;
                }
                //tinh ngay het han du kien
                xe.DateOfVehicles.TinhNgayTraXeDK(xe.HinhThucGui);
                xe.DateOfVehicles.NgayTraXeThucTe = xe.DateOfVehicles.NgayPhaiTraXeDK;
                //tinh chi phi
                xe.ChiPhi = new Classes.ChiPhi.ChiPhi(xe.LoaiXe);
                xe.ChiPhi.TinhTienPhi(xe.HinhThucGui);
                //lay hinh
                pictureBoxHinhXe.Image.Save(xe.Picture, pictureBoxHinhXe.Image.RawFormat);
                pictureBoxHinhXe.Image = null;
                SqlCommand sqlCommand = new SqlCommand("Select * from " + xe.tenBangXe + " where TinhTrangTra=@tinhtrang");
                sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Chua Tra";
                int n = xe.DemXe(sqlCommand);
                if(n<=20)
                {
                    if (xe.KTraXeTonTai(xe))
                        if (xe.ThemXe(xe))
                        {
                            MessageBox.Show("Added successfully", "Add vehicles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ThemXe_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("ERROR", "Add vehicles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    else
                    {
                        MessageBox.Show("Xe này đã tồn tại", "Thêm xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bãi giữ xe đã đầy", "Bãi xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin chưa đầy đủ", "Thêm xe", MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
            }
        }

        private void radioButtonXeHoi_CheckedChanged(object sender, EventArgs e)
        {
            labelBienSo.Visible = true;
            textBoxBienSo.Visible = true;
        }

        private void radioButtonXeMay_CheckedChanged(object sender, EventArgs e)
        {
            labelBienSo.Visible = true;
            textBoxBienSo.Visible = true;
        }

        private void radioButtonXeDap_CheckedChanged(object sender, EventArgs e)
        {
            labelBienSo.Visible = false;
            textBoxBienSo.Visible = false;
        }
    }
}
