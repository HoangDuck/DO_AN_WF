
namespace BaiGiuXeVer2.Forms.Workers.ThongTinNV
{
    partial class ThongTinNV
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
            this.comboBoxCongViec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxGioiTinh = new System.Windows.Forms.GroupBox();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.textBoxTenNV = new System.Windows.Forms.TextBox();
            this.labelTenTho = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxSdt = new System.Windows.Forms.TextBox();
            this.labelSdt = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelCreateNewAccount = new System.Windows.Forms.Label();
            this.groupBoxGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCongViec
            // 
            this.comboBoxCongViec.FormattingEnabled = true;
            this.comboBoxCongViec.Location = new System.Drawing.Point(218, 299);
            this.comboBoxCongViec.Name = "comboBoxCongViec";
            this.comboBoxCongViec.Size = new System.Drawing.Size(191, 24);
            this.comboBoxCongViec.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Chọn công việc";
            // 
            // groupBoxGioiTinh
            // 
            this.groupBoxGioiTinh.Controls.Add(this.radioButtonNu);
            this.groupBoxGioiTinh.Controls.Add(this.radioButtonNam);
            this.groupBoxGioiTinh.Location = new System.Drawing.Point(220, 197);
            this.groupBoxGioiTinh.Name = "groupBoxGioiTinh";
            this.groupBoxGioiTinh.Size = new System.Drawing.Size(200, 67);
            this.groupBoxGioiTinh.TabIndex = 69;
            this.groupBoxGioiTinh.TabStop = false;
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
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
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
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGioiTinh.ForeColor = System.Drawing.Color.White;
            this.labelGioiTinh.Location = new System.Drawing.Point(113, 197);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(86, 20);
            this.labelGioiTinh.TabIndex = 68;
            this.labelGioiTinh.Text = "Giới tính:";
            // 
            // textBoxTenNV
            // 
            this.textBoxTenNV.Location = new System.Drawing.Point(220, 140);
            this.textBoxTenNV.Name = "textBoxTenNV";
            this.textBoxTenNV.Size = new System.Drawing.Size(223, 22);
            this.textBoxTenNV.TabIndex = 67;
            // 
            // labelTenTho
            // 
            this.labelTenTho.AutoSize = true;
            this.labelTenTho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenTho.ForeColor = System.Drawing.Color.White;
            this.labelTenTho.Location = new System.Drawing.Point(121, 142);
            this.labelTenTho.Name = "labelTenTho";
            this.labelTenTho.Size = new System.Drawing.Size(78, 20);
            this.labelTenTho.TabIndex = 66;
            this.labelTenTho.Text = "Tên thợ:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(220, 87);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(110, 22);
            this.textBoxID.TabIndex = 65;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(171, 89);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(28, 20);
            this.labelID.TabIndex = 64;
            this.labelID.Text = "ID";
            // 
            // textBoxSdt
            // 
            this.textBoxSdt.Location = new System.Drawing.Point(218, 358);
            this.textBoxSdt.Name = "textBoxSdt";
            this.textBoxSdt.Size = new System.Drawing.Size(191, 22);
            this.textBoxSdt.TabIndex = 73;
            // 
            // labelSdt
            // 
            this.labelSdt.AutoSize = true;
            this.labelSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdt.ForeColor = System.Drawing.Color.White;
            this.labelSdt.Location = new System.Drawing.Point(74, 360);
            this.labelSdt.Name = "labelSdt";
            this.labelSdt.Size = new System.Drawing.Size(125, 20);
            this.labelSdt.TabIndex = 72;
            this.labelSdt.Text = "Số điện thoại:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Green;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonEdit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(110, 424);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(299, 41);
            this.buttonEdit.TabIndex = 74;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelCreateNewAccount
            // 
            this.labelCreateNewAccount.AutoSize = true;
            this.labelCreateNewAccount.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateNewAccount.ForeColor = System.Drawing.Color.White;
            this.labelCreateNewAccount.Location = new System.Drawing.Point(132, 25);
            this.labelCreateNewAccount.Name = "labelCreateNewAccount";
            this.labelCreateNewAccount.Size = new System.Drawing.Size(288, 26);
            this.labelCreateNewAccount.TabIndex = 75;
            this.labelCreateNewAccount.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // ThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(534, 495);
            this.Controls.Add(this.labelCreateNewAccount);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxSdt);
            this.Controls.Add(this.labelSdt);
            this.Controls.Add(this.comboBoxCongViec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxGioiTinh);
            this.Controls.Add(this.labelGioiTinh);
            this.Controls.Add(this.textBoxTenNV);
            this.Controls.Add(this.labelTenTho);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Name = "ThongTinNV";
            this.Text = "ThongTinNV";
            this.Load += new System.EventHandler(this.ThongTinNV_Load);
            this.groupBoxGioiTinh.ResumeLayout(false);
            this.groupBoxGioiTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCongViec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxGioiTinh;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.TextBox textBoxTenNV;
        private System.Windows.Forms.Label labelTenTho;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxSdt;
        private System.Windows.Forms.Label labelSdt;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelCreateNewAccount;
    }
}