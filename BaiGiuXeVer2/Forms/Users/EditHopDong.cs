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
    public partial class EditHopDong : Form
    {
        public EditHopDong()
        {
            InitializeComponent();
        }
        Classes.HopDong.HopDong hd = new Classes.HopDong.HopDong();

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int maHD = Convert.ToInt32(textBoxHD.Text);
            DateTime ngayki = dateTimePickerKi.Value;
            DateTime ngayhet = dateTimePickerHet.Value;
            int maXe = Convert.ToInt32(textBoxXe.Text);
            int maKH = Convert.ToInt32(textBoxKH.Text);
            if (!hd.hopdongExist(maHD))
            {
                MessageBox.Show("This Contract is already exist", "Edit Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (hd.ChinhSuaHD(maHD,ngayki,ngayhet,maXe,maKH))
            {
                MessageBox.Show("Contract Update", "Edit Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Contract not updated", "Edit Contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditHopDong_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from hopdong");
            //dataGridViewHD.DataSource = hd.LayTTHD(command);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int maHD = Convert.ToInt32(textBoxHD.Text);
                if ((MessageBox.Show("Are you sure you wanna delete this Contract?", "Delete Contract", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (hd.XoaHD(maHD))
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
                MessageBox.Show("Please enter a valid ID", "Delete Contract", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
