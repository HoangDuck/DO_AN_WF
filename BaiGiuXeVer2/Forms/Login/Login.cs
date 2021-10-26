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

namespace BaiGiuXeVer2.Forms.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String tableName = "";
            if (radioButtonUser.Checked)
            {
                tableName = "Users";
            }
            else if (radioButtonWorkers.Checked)
            {
                tableName = "Workers";
            }
            else
            {
                tableName = "Managers";
            }
            if (tableName != "")
            {
                MyDB.MyDBParkLogin myDBLogin = new MyDB.MyDBParkLogin();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM " + tableName + " WHERE Username=@User AND Password=@Pass", myDBLogin.GetSqlConnection);
                sqlCommand.Parameters.Add("@User", SqlDbType.VarChar).Value = textUser.Text;
                sqlCommand.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textPassword.Text;
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    int loginID = (int)dataTable.Rows[0].ItemArray[0];
                    this.DialogResult = DialogResult.OK;
                    if (tableName == "Users")
                    {
                        Users.MenuUsers form = new Users.MenuUsers(loginID);
                        form.Show();
                    }
                    else if(tableName == "Workers")
                    {
                        Workers.Menu form = new Workers.Menu(loginID);
                        form.Show();
                    }
                    else
                    {
                        Managers.MenuManagers form = new Managers.MenuManagers(loginID);
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or password", "Login errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please choose object", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabelNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButtonUser.Checked)
            {
                Registers.RegisterUsers form = new Registers.RegisterUsers();
                form.Show();
            }
            else if (radioButtonWorkers.Checked)
            {
                Registers.RegisterWorkers form = new Registers.RegisterWorkers();
                form.Show();
            }
            else if(radioButtonManagers.Checked)
            {
                Registers.RegisterManagers form = new Registers.RegisterManagers();
                form.Show();
            }
            else
            {
                MessageBox.Show("Please choose object", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            radioButtonUser.Checked = true;
        }
    }
}
