using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace BaiGiuXeVer2.Forms.Workers
{
    public partial class Menu : Form
    {
        int staffID;
        Classes.NhanVien.NhanVien nv = new Classes.NhanVien.NhanVien();
        public Menu(int id)
        {
            InitializeComponent();
            this.staffID = id;
        }
        //menu danh sach xe
        private void danhSachXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xe.DanhSachXe form = new Xe.DanhSachXe();
            form.Show();
        }

        private void themXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workers.Xe.ThemXe form = new Workers.Xe.ThemXe();
            form.Show();
        }

        private void traXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workers.Xe.TraXe form = new Xe.TraXe();
            form.Show();
        }

        private void suaThongTinXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workers.Xe.ChonXe form = new Xe.ChonXe();
            form.Show();
        }

        private void thongKeSoXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workers.Xe.ThongKe form = new Xe.ThongKe();
            form.Show();
        }

        //menu danh sach khach hang
        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang.DanhSachKH form = new KhachHang.DanhSachKH();
            form.Show();
        }
        private void sửaThôngTinKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang.SuaThongTinKH form = new KhachHang.SuaThongTinKH();
            form.Show();
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registers.RegisterUsers form = new Registers.RegisterUsers(false);
            form.Show();
        }

        //Menu doanh thu
        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThu.ChiTiet form = new DoanhThu.ChiTiet();
            form.Show();
        }

        private void tổngHợpDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThu.DoanhThu form = new DoanhThu.DoanhThu();
            form.Show();
        }
        //tkb
        private void tKBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKB.TKB form = new TKB.TKB(staffID);
            form.Show();
        }


        //Menu thong tin nhan vien
        private void chiTiếtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTinNV.ThongTinNV thongtin = new ThongTinNV.ThongTinNV(staffID);
            thongtin.Show();
        }

        //Dang xuat
        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                labelTime.Text = DateTime.Now.ToString("T");
            }));

        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timerTG.Start();
            DateTime dateTime = DateTime.Now;
            int hour = dateTime.Hour;
            string ca = "";
            if(hour>=7 && hour<=11)
            {
                ca = "1";
            }    
            else if(hour>=11&& hour<=14)
            {
                ca = "2";
            }
            else if(hour>=18 && hour <=22)
            {
                ca = "3";
            }
            else
            {
                MessageBox.Show("Bạn đang ngoài giờ làm", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (nv.checkin(staffID, ca, dateTime, dateTime))
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
                if (nv.updatecheckin(staffID, ca, dateTime, dateTime))
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
            timerTG.Stop();
            DateTime dateTime = DateTime.Now;
            int hour = dateTime.Hour;
            string ca = "";
            if (hour >= 7 && hour <= 11)
            {
                ca = "1";
            }
            else if (hour >= 11 && hour <= 14)
            {
                ca = "2";
            }
            else if (hour >= 18 && hour <= 22)
            {
                ca = "3";
            }
            else
            {
                
                MessageBox.Show("Bạn đang ngoài giờ làm", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (nv.checkout(staffID, ca, dateTime, dateTime))
                {
                    MessageBox.Show("Check-out successfully!\n"+nv.TinhLuong(staffID,dateTime)+" VND", "Check - in", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonXoaTK_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa tài khoản này không", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (nv.deleteStaff(staffID))
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

        private void timerTG_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("T");
        }

        private void buttonDSTGLV_Click(object sender, EventArgs e)
        {
            Luong form = new Luong(staffID);
            form.Show();
        }
    }
}
