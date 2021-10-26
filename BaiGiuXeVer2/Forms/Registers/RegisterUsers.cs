using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Registers
{
    public partial class RegisterUsers : Form
    {
        Classes.KhachHang.KhachHang kh = new Classes.KhachHang.KhachHang();
        bool mode=true;//true la dang ki account,false la them kh do nv nhap
        public RegisterUsers()
        {
            InitializeComponent();
        }
        public RegisterUsers(bool mode)
        {
            InitializeComponent();
            this.mode = mode;
        }
        private void RegisterUsers_Load(object sender, EventArgs e)
        {
            if(!mode)
            {
                labelCreateNewAccount.Text = "Thêm khách hàng";
                buttonRegister.Text = "Thêm";
                linkLabelLogin.Visible = false;
            }    
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int maNV = Convert.ToInt32(textBoxID.Text.Trim());
                string tenTho = textBoxTenNV.Text.Trim();
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text.Trim();
                string sdt = textBoxSdt.Text.Trim();
                string diaChi = textBoxDiaChi.Text.Trim();
                if (kh.themKhachHang(maNV, tenTho, diaChi, sdt, username, password))
                {
                    MessageBox.Show("Đăng kí thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng kí không thành công", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không đầy đủ", "Thêm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void labelDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSdt_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTenTho_Click(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void labelCreateNewAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
