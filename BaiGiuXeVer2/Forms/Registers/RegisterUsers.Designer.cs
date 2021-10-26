
namespace BaiGiuXeVer2.Forms.Registers
{
    partial class RegisterUsers
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
            this.textBoxSdt = new System.Windows.Forms.TextBox();
            this.labelSdt = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxTenNV = new System.Windows.Forms.TextBox();
            this.labelTenTho = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCreateNewAccount = new System.Windows.Forms.Label();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSdt
            // 
            this.textBoxSdt.Location = new System.Drawing.Point(211, 457);
            this.textBoxSdt.Name = "textBoxSdt";
            this.textBoxSdt.Size = new System.Drawing.Size(191, 22);
            this.textBoxSdt.TabIndex = 82;
            this.textBoxSdt.TextChanged += new System.EventHandler(this.textBoxSdt_TextChanged);
            // 
            // labelSdt
            // 
            this.labelSdt.AutoSize = true;
            this.labelSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdt.ForeColor = System.Drawing.Color.White;
            this.labelSdt.Location = new System.Drawing.Point(67, 459);
            this.labelSdt.Name = "labelSdt";
            this.labelSdt.Size = new System.Drawing.Size(125, 20);
            this.labelSdt.TabIndex = 81;
            this.labelSdt.Text = "Số điện thoại:";
            this.labelSdt.Click += new System.EventHandler(this.labelSdt_Click);
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.LinkColor = System.Drawing.Color.White;
            this.linkLabelLogin.Location = new System.Drawing.Point(165, 582);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(178, 17);
            this.linkLabelLogin.TabIndex = 77;
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
            this.buttonRegister.Location = new System.Drawing.Point(99, 516);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(299, 41);
            this.buttonRegister.TabIndex = 76;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(211, 401);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(191, 22);
            this.textBoxPassword.TabIndex = 75;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(95, 401);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(97, 20);
            this.labelPassword.TabIndex = 74;
            this.labelPassword.Text = "Password:";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(211, 346);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(191, 22);
            this.textBoxUsername.TabIndex = 73;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(92, 346);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(100, 20);
            this.labelUsername.TabIndex = 72;
            this.labelUsername.Text = "Username:";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // textBoxTenNV
            // 
            this.textBoxTenNV.Location = new System.Drawing.Point(213, 124);
            this.textBoxTenNV.Name = "textBoxTenNV";
            this.textBoxTenNV.Size = new System.Drawing.Size(223, 22);
            this.textBoxTenNV.TabIndex = 70;
            this.textBoxTenNV.TextChanged += new System.EventHandler(this.textBoxTenNV_TextChanged);
            // 
            // labelTenTho
            // 
            this.labelTenTho.AutoSize = true;
            this.labelTenTho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenTho.ForeColor = System.Drawing.Color.White;
            this.labelTenTho.Location = new System.Drawing.Point(45, 126);
            this.labelTenTho.Name = "labelTenTho";
            this.labelTenTho.Size = new System.Drawing.Size(147, 20);
            this.labelTenTho.TabIndex = 69;
            this.labelTenTho.Text = "Tên khách hàng:";
            this.labelTenTho.Click += new System.EventHandler(this.labelTenTho_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(213, 71);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(110, 22);
            this.textBoxID.TabIndex = 68;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(164, 73);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(28, 20);
            this.labelID.TabIndex = 67;
            this.labelID.Text = "ID";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // labelCreateNewAccount
            // 
            this.labelCreateNewAccount.AutoSize = true;
            this.labelCreateNewAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateNewAccount.ForeColor = System.Drawing.Color.White;
            this.labelCreateNewAccount.Location = new System.Drawing.Point(175, 13);
            this.labelCreateNewAccount.Name = "labelCreateNewAccount";
            this.labelCreateNewAccount.Size = new System.Drawing.Size(223, 26);
            this.labelCreateNewAccount.TabIndex = 66;
            this.labelCreateNewAccount.Text = "Create New Account";
            this.labelCreateNewAccount.Click += new System.EventHandler(this.labelCreateNewAccount_Click);
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(211, 167);
            this.textBoxDiaChi.Multiline = true;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(225, 154);
            this.textBoxDiaChi.TabIndex = 84;
            this.textBoxDiaChi.TextChanged += new System.EventHandler(this.textBoxDiaChi_TextChanged);
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaChi.ForeColor = System.Drawing.Color.White;
            this.labelDiaChi.Location = new System.Drawing.Point(118, 167);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(74, 20);
            this.labelDiaChi.TabIndex = 83;
            this.labelDiaChi.Text = "Địa chỉ:";
            this.labelDiaChi.Click += new System.EventHandler(this.labelDiaChi_Click);
            // 
            // RegisterUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 630);
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
            this.Controls.Add(this.labelTenTho);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelCreateNewAccount);
            this.Name = "RegisterUsers";
            this.Text = "RegisterUsers";
            this.Load += new System.EventHandler(this.RegisterUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSdt;
        private System.Windows.Forms.Label labelSdt;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxTenNV;
        private System.Windows.Forms.Label labelTenTho;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelCreateNewAccount;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label labelDiaChi;
    }
}