
namespace BaiGiuXeVer2.Forms.Registers
{
    partial class RegisterWorkers
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
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.textBoxTenNV = new System.Windows.Forms.TextBox();
            this.labelTenTho = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCreateNewAccount = new System.Windows.Forms.Label();
            this.groupBoxGioiTinh = new System.Windows.Forms.GroupBox();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCongViec = new System.Windows.Forms.ComboBox();
            this.textBoxSdt = new System.Windows.Forms.TextBox();
            this.labelSdt = new System.Windows.Forms.Label();
            this.groupBoxGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.LinkColor = System.Drawing.Color.White;
            this.linkLabelLogin.Location = new System.Drawing.Point(136, 603);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(178, 17);
            this.linkLabelLogin.TabIndex = 60;
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
            this.buttonRegister.Location = new System.Drawing.Point(70, 537);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(299, 41);
            this.buttonRegister.TabIndex = 59;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(182, 422);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(191, 22);
            this.textBoxPassword.TabIndex = 55;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(66, 422);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(97, 20);
            this.labelPassword.TabIndex = 54;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(182, 367);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(191, 22);
            this.textBoxUsername.TabIndex = 53;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(63, 367);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(100, 20);
            this.labelUsername.TabIndex = 52;
            this.labelUsername.Text = "Username:";
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGioiTinh.ForeColor = System.Drawing.Color.White;
            this.labelGioiTinh.Location = new System.Drawing.Point(77, 202);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(86, 20);
            this.labelGioiTinh.TabIndex = 50;
            this.labelGioiTinh.Text = "Giới tính:";
            // 
            // textBoxTenNV
            // 
            this.textBoxTenNV.Location = new System.Drawing.Point(184, 145);
            this.textBoxTenNV.Name = "textBoxTenNV";
            this.textBoxTenNV.Size = new System.Drawing.Size(223, 22);
            this.textBoxTenNV.TabIndex = 49;
            // 
            // labelTenTho
            // 
            this.labelTenTho.AutoSize = true;
            this.labelTenTho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenTho.ForeColor = System.Drawing.Color.White;
            this.labelTenTho.Location = new System.Drawing.Point(85, 147);
            this.labelTenTho.Name = "labelTenTho";
            this.labelTenTho.Size = new System.Drawing.Size(78, 20);
            this.labelTenTho.TabIndex = 48;
            this.labelTenTho.Text = "Tên thợ:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(184, 92);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(110, 22);
            this.textBoxID.TabIndex = 47;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(135, 94);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(28, 20);
            this.labelID.TabIndex = 46;
            this.labelID.Text = "ID";
            // 
            // labelCreateNewAccount
            // 
            this.labelCreateNewAccount.AutoSize = true;
            this.labelCreateNewAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateNewAccount.ForeColor = System.Drawing.Color.White;
            this.labelCreateNewAccount.Location = new System.Drawing.Point(146, 34);
            this.labelCreateNewAccount.Name = "labelCreateNewAccount";
            this.labelCreateNewAccount.Size = new System.Drawing.Size(223, 26);
            this.labelCreateNewAccount.TabIndex = 45;
            this.labelCreateNewAccount.Text = "Create New Account";
            // 
            // groupBoxGioiTinh
            // 
            this.groupBoxGioiTinh.Controls.Add(this.radioButtonNu);
            this.groupBoxGioiTinh.Controls.Add(this.radioButtonNam);
            this.groupBoxGioiTinh.Location = new System.Drawing.Point(184, 202);
            this.groupBoxGioiTinh.Name = "groupBoxGioiTinh";
            this.groupBoxGioiTinh.Size = new System.Drawing.Size(200, 67);
            this.groupBoxGioiTinh.TabIndex = 61;
            this.groupBoxGioiTinh.TabStop = false;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNam.ForeColor = System.Drawing.Color.White;
            this.radioButtonNam.Location = new System.Drawing.Point(30, 22);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(57, 21);
            this.radioButtonNam.TabIndex = 0;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNu.ForeColor = System.Drawing.Color.White;
            this.radioButtonNu.Location = new System.Drawing.Point(117, 22);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(46, 21);
            this.radioButtonNu.TabIndex = 1;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Chọn công việc";
            // 
            // comboBoxCongViec
            // 
            this.comboBoxCongViec.FormattingEnabled = true;
            this.comboBoxCongViec.Location = new System.Drawing.Point(182, 304);
            this.comboBoxCongViec.Name = "comboBoxCongViec";
            this.comboBoxCongViec.Size = new System.Drawing.Size(191, 24);
            this.comboBoxCongViec.TabIndex = 63;
            // 
            // textBoxSdt
            // 
            this.textBoxSdt.Location = new System.Drawing.Point(182, 478);
            this.textBoxSdt.Name = "textBoxSdt";
            this.textBoxSdt.Size = new System.Drawing.Size(191, 22);
            this.textBoxSdt.TabIndex = 65;
            // 
            // labelSdt
            // 
            this.labelSdt.AutoSize = true;
            this.labelSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdt.ForeColor = System.Drawing.Color.White;
            this.labelSdt.Location = new System.Drawing.Point(38, 480);
            this.labelSdt.Name = "labelSdt";
            this.labelSdt.Size = new System.Drawing.Size(125, 20);
            this.labelSdt.TabIndex = 64;
            this.labelSdt.Text = "Số điện thoại:";
            // 
            // RegisterWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(446, 643);
            this.Controls.Add(this.textBoxSdt);
            this.Controls.Add(this.labelSdt);
            this.Controls.Add(this.comboBoxCongViec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxGioiTinh);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelGioiTinh);
            this.Controls.Add(this.textBoxTenNV);
            this.Controls.Add(this.labelTenTho);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelCreateNewAccount);
            this.Name = "RegisterWorkers";
            this.Text = "RegisterWorkers";
            this.Load += new System.EventHandler(this.RegisterWorkers_Load);
            this.groupBoxGioiTinh.ResumeLayout(false);
            this.groupBoxGioiTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.TextBox textBoxTenNV;
        private System.Windows.Forms.Label labelTenTho;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelCreateNewAccount;
        private System.Windows.Forms.GroupBox groupBoxGioiTinh;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCongViec;
        private System.Windows.Forms.TextBox textBoxSdt;
        private System.Windows.Forms.Label labelSdt;
    }
}