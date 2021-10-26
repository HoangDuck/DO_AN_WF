
namespace BaiGiuXeVer2.Forms.Registers
{
    partial class RegisterManagers
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
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.textBoxSdt = new System.Windows.Forms.TextBox();
            this.labelSdt = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxTenNV = new System.Windows.Forms.TextBox();
            this.labelTenQL = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCreateNewAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BackColor = System.Drawing.Color.White;
            this.textBoxDiaChi.Location = new System.Drawing.Point(215, 188);
            this.textBoxDiaChi.Multiline = true;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(225, 154);
            this.textBoxDiaChi.TabIndex = 99;
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.BackColor = System.Drawing.Color.Black;
            this.labelDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaChi.ForeColor = System.Drawing.Color.White;
            this.labelDiaChi.Location = new System.Drawing.Point(122, 188);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(74, 20);
            this.labelDiaChi.TabIndex = 98;
            this.labelDiaChi.Text = "Địa chỉ:";
            // 
            // textBoxSdt
            // 
            this.textBoxSdt.BackColor = System.Drawing.Color.White;
            this.textBoxSdt.Location = new System.Drawing.Point(215, 478);
            this.textBoxSdt.Name = "textBoxSdt";
            this.textBoxSdt.Size = new System.Drawing.Size(191, 22);
            this.textBoxSdt.TabIndex = 97;
            // 
            // labelSdt
            // 
            this.labelSdt.AutoSize = true;
            this.labelSdt.BackColor = System.Drawing.Color.Black;
            this.labelSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdt.ForeColor = System.Drawing.Color.White;
            this.labelSdt.Location = new System.Drawing.Point(71, 480);
            this.labelSdt.Name = "labelSdt";
            this.labelSdt.Size = new System.Drawing.Size(125, 20);
            this.labelSdt.TabIndex = 96;
            this.labelSdt.Text = "Số điện thoại:";
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.BackColor = System.Drawing.Color.Black;
            this.linkLabelLogin.LinkColor = System.Drawing.Color.White;
            this.linkLabelLogin.Location = new System.Drawing.Point(169, 603);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(178, 17);
            this.linkLabelLogin.TabIndex = 95;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "<<Have an account? Login";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Green;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonRegister.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(103, 537);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(299, 41);
            this.buttonRegister.TabIndex = 94;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(215, 422);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(191, 22);
            this.textBoxPassword.TabIndex = 93;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Black;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(99, 422);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(97, 20);
            this.labelPassword.TabIndex = 92;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.Location = new System.Drawing.Point(215, 367);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(191, 22);
            this.textBoxUsername.TabIndex = 91;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Black;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(96, 367);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(100, 20);
            this.labelUsername.TabIndex = 90;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxTenNV
            // 
            this.textBoxTenNV.BackColor = System.Drawing.Color.White;
            this.textBoxTenNV.Location = new System.Drawing.Point(217, 145);
            this.textBoxTenNV.Name = "textBoxTenNV";
            this.textBoxTenNV.Size = new System.Drawing.Size(223, 22);
            this.textBoxTenNV.TabIndex = 89;
            // 
            // labelTenQL
            // 
            this.labelTenQL.AutoSize = true;
            this.labelTenQL.BackColor = System.Drawing.Color.Black;
            this.labelTenQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenQL.ForeColor = System.Drawing.Color.White;
            this.labelTenQL.Location = new System.Drawing.Point(84, 147);
            this.labelTenQL.Name = "labelTenQL";
            this.labelTenQL.Size = new System.Drawing.Size(112, 20);
            this.labelTenQL.TabIndex = 88;
            this.labelTenQL.Text = "Tên quản lý:";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.White;
            this.textBoxID.Location = new System.Drawing.Point(217, 92);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(110, 22);
            this.textBoxID.TabIndex = 87;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Black;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(168, 94);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(28, 20);
            this.labelID.TabIndex = 86;
            this.labelID.Text = "ID";
            // 
            // labelCreateNewAccount
            // 
            this.labelCreateNewAccount.AutoSize = true;
            this.labelCreateNewAccount.BackColor = System.Drawing.Color.Black;
            this.labelCreateNewAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateNewAccount.ForeColor = System.Drawing.Color.White;
            this.labelCreateNewAccount.Location = new System.Drawing.Point(179, 34);
            this.labelCreateNewAccount.Name = "labelCreateNewAccount";
            this.labelCreateNewAccount.Size = new System.Drawing.Size(223, 26);
            this.labelCreateNewAccount.TabIndex = 85;
            this.labelCreateNewAccount.Text = "Create New Account";
            // 
            // RegisterManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(508, 645);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.textBoxSdt);
            this.Controls.Add(this.labelSdt);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxTenNV);
            this.Controls.Add(this.labelTenQL);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelCreateNewAccount);
            this.Name = "RegisterManagers";
            this.Text = "RegisterManagers";
            this.Load += new System.EventHandler(this.RegisterManagers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.TextBox textBoxSdt;
        private System.Windows.Forms.Label labelSdt;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxTenNV;
        private System.Windows.Forms.Label labelTenQL;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelCreateNewAccount;
    }
}