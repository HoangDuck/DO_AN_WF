using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Managers
{
    public partial class XoaNV : Form
    {
        Classes.NhanVien.QuanLy ql = new Classes.NhanVien.QuanLy();
        public XoaNV()
        {
            InitializeComponent();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text.ToString());
                if(ql.deleteStaff(id))
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên không thành công", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa điền thông tin", "Xóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Close();
        }
    }
}
