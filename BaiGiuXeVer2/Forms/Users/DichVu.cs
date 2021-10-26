using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Users
{
    public partial class DichVu : Form
    {
        int maKH;
        Classes.HopDong.HopDong hd = new Classes.HopDong.HopDong();
        public DichVu()
        {
            InitializeComponent();
        }
        public DichVu(int maKH)
        {
            InitializeComponent();
            this.maKH = maKH;
        }
        private void DichVu_Load(object sender, EventArgs e)
        {
            DataTable dataTable = hd.LayTTHD(maKH);
            if(dataTable.Rows.Count==0)
            {
                dataGridViewDSHD.Visible = false;
                buttonHuyHD.Visible = false;
            }    
            else
            {
                pictureBoxHD.Visible = false;
                labelChuaCoHD.Visible = false;
                dataGridViewDSHD.DataSource = dataTable;
                dataGridViewDSHD.AllowUserToAddRows = false;
                dataGridViewDSHD.ReadOnly = true;
            }
        }

        private void buttonHuyHD_Click(object sender, EventArgs e)
        {
                labelChonHopDong.Visible = true;
                textBoxMaHDHuyHD.Visible = true;
                buttonOkHuyHD.Visible = true;
                buttonCancelHuyHD.Visible = true;
        }

        private void buttonOkHuyHD_Click(object sender, EventArgs e)
        {
            try
            {
                int idHD = Convert.ToInt32(textBoxMaHDHuyHD.Text.Trim());
                if ((MessageBox.Show("Are you sure you wanna delete this Contract?", "Delete Contract", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (hd.XoaHD(idHD))
                    {
                        MessageBox.Show("Contract Deleted", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Contract cannot be deleted", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập mã hợp đồng");
            }
        }

        private void buttonCancelHuyHD_Click(object sender, EventArgs e)
        {
            labelChonHopDong.Visible = false;
            textBoxMaHDHuyHD.Visible = false;
            buttonOkHuyHD.Visible = false;
            buttonCancelHuyHD.Visible = false;
        }


        private void buttonOKEditHD_Click(object sender, EventArgs e)
        {
            EditHopDong form = new EditHopDong();
            form.Show();
            this.DichVu_Load(null,null);
        }

        private void buttonThemHD_Click(object sender, EventArgs e)
        {
            AddHopDong form = new AddHopDong(maKH);
            form.Show();
            this.DichVu_Load(null, null);
        }

        private void dataGridViewDSHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string soHD = dataGridViewDSHD.CurrentRow.Cells[0].ToString().Trim();
            if (labelChonHopDong.Visible)
                textBoxMaHDHuyHD.Text = soHD;
        }
    }
}
