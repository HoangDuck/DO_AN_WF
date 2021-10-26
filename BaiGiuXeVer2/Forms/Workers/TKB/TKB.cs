using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Workers.TKB
{
    public partial class TKB : Form
    {
        int staffID;
        Classes.NhanVien.NhanVien nv = new Classes.NhanVien.NhanVien();
        public TKB()
        {
            InitializeComponent();
        }
        public TKB(int id)
        {
            InitializeComponent();
            this.staffID = id;
        }
        private void TKB_Load(object sender, EventArgs e)
        {
            this.dateTimePickerTKB_ValueChanged(null, null);
        }

        private void dateTimePickerTKB_ValueChanged(object sender, EventArgs e)
        {
            textBoxCa1.Text = "";
            textBoxCa2.Text = "";
            textBoxCa3.Text = "";
            DataTable data = nv.getTKB(staffID, dateTimePickerTKB.Value);
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
    }
}
