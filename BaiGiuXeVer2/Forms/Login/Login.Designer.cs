
namespace BaiGiuXeVer2.Forms.Login
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.radioButtonWorkers = new System.Windows.Forms.RadioButton();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.linkLabelNewUser = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.radioButtonManagers = new System.Windows.Forms.RadioButton();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonWorkers
            // 
            this.radioButtonWorkers.AutoSize = true;
            this.radioButtonWorkers.BackColor = System.Drawing.Color.Black;
            this.radioButtonWorkers.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWorkers.ForeColor = System.Drawing.Color.White;
            this.radioButtonWorkers.Location = new System.Drawing.Point(228, 296);
            this.radioButtonWorkers.Name = "radioButtonWorkers";
            this.radioButtonWorkers.Size = new System.Drawing.Size(59, 21);
            this.radioButtonWorkers.TabIndex = 36;
            this.radioButtonWorkers.TabStop = true;
            this.radioButtonWorkers.Text = "Staff";
            this.radioButtonWorkers.UseVisualStyleBackColor = false;
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.BackColor = System.Drawing.Color.Black;
            this.radioButtonUser.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUser.ForeColor = System.Drawing.Color.White;
            this.radioButtonUser.Location = new System.Drawing.Point(72, 296);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(57, 21);
            this.radioButtonUser.TabIndex = 35;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "User";
            this.radioButtonUser.UseVisualStyleBackColor = false;
            // 
            // linkLabelNewUser
            // 
            this.linkLabelNewUser.AutoSize = true;
            this.linkLabelNewUser.BackColor = System.Drawing.Color.Black;
            this.linkLabelNewUser.Location = new System.Drawing.Point(231, 337);
            this.linkLabelNewUser.Name = "linkLabelNewUser";
            this.linkLabelNewUser.Size = new System.Drawing.Size(75, 17);
            this.linkLabelNewUser.TabIndex = 33;
            this.linkLabelNewUser.TabStop = true;
            this.linkLabelNewUser.Text = "New user?";
            this.linkLabelNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelNewUser_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Blue;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(288, 217);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(149, 41);
            this.buttonLogin.TabIndex = 32;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(67, 217);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(149, 41);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.Black;
            this.textPassword.ForeColor = System.Drawing.Color.White;
            this.textPassword.Location = new System.Drawing.Point(288, 153);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(153, 22);
            this.textPassword.TabIndex = 30;
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.Black;
            this.textUser.ForeColor = System.Drawing.Color.White;
            this.textUser.Location = new System.Drawing.Point(288, 71);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(153, 22);
            this.textUser.TabIndex = 29;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Black;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(60, 139);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(156, 38);
            this.labelPassword.TabIndex = 28;
            this.labelPassword.Text = "Password";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Black;
            this.labelUser.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(60, 55);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(165, 38);
            this.labelUser.TabIndex = 27;
            this.labelUser.Text = "Username";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(309, 31);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(304, 90);
            this.labelLogin.TabIndex = 26;
            this.labelLogin.Text = "LOGIN";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBoxLogin.Controls.Add(this.radioButtonManagers);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.linkLabelNewUser);
            this.groupBoxLogin.Controls.Add(this.labelUser);
            this.groupBoxLogin.Controls.Add(this.radioButtonWorkers);
            this.groupBoxLogin.Controls.Add(this.labelPassword);
            this.groupBoxLogin.Controls.Add(this.radioButtonUser);
            this.groupBoxLogin.Controls.Add(this.textUser);
            this.groupBoxLogin.Controls.Add(this.buttonCancel);
            this.groupBoxLogin.Controls.Add(this.textPassword);
            this.groupBoxLogin.Location = new System.Drawing.Point(176, 139);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(525, 377);
            this.groupBoxLogin.TabIndex = 37;
            this.groupBoxLogin.TabStop = false;
            // 
            // radioButtonManagers
            // 
            this.radioButtonManagers.AutoSize = true;
            this.radioButtonManagers.BackColor = System.Drawing.Color.Black;
            this.radioButtonManagers.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonManagers.ForeColor = System.Drawing.Color.White;
            this.radioButtonManagers.Location = new System.Drawing.Point(371, 296);
            this.radioButtonManagers.Name = "radioButtonManagers";
            this.radioButtonManagers.Size = new System.Drawing.Size(83, 21);
            this.radioButtonManagers.TabIndex = 37;
            this.radioButtonManagers.TabStop = true;
            this.radioButtonManagers.Text = "Manager";
            this.radioButtonManagers.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(874, 586);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonWorkers;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.LinkLabel linkLabelNewUser;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.RadioButton radioButtonManagers;
    }
}