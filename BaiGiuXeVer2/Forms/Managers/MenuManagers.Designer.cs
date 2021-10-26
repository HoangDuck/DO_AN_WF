
namespace BaiGiuXeVer2.Forms.Managers
{
    partial class MenuManagers
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
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonXoaTK = new System.Windows.Forms.Button();
            this.buttonXoaNV = new System.Windows.Forms.Button();
            this.buttonDSNV = new System.Windows.Forms.Button();
            this.buttonTKB = new System.Windows.Forms.Button();
            this.buttonTKBQL = new System.Windows.Forms.Button();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.labelQL = new System.Windows.Forms.Label();
            this.buttonDSXe = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.labelChonXe = new System.Windows.Forms.Label();
            this.radioButtonXeDap = new System.Windows.Forms.RadioButton();
            this.radioButtonXeMay = new System.Windows.Forms.RadioButton();
            this.radioButtonXeHoi = new System.Windows.Forms.RadioButton();
            this.buttonHuyDSNV = new System.Windows.Forms.Button();
            this.dateTimePickerTKB = new System.Windows.Forms.DateTimePicker();
            this.textBoxCa3 = new System.Windows.Forms.TextBox();
            this.textBoxCa2 = new System.Windows.Forms.TextBox();
            this.textBoxCa1 = new System.Windows.Forms.TextBox();
            this.labelCa3 = new System.Windows.Forms.Label();
            this.labelCa2 = new System.Windows.Forms.Label();
            this.labelCa1 = new System.Windows.Forms.Label();
            this.buttonHuyTKB = new System.Windows.Forms.Button();
            this.buttonDSTGLV = new System.Windows.Forms.Button();
            this.labelLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.BackColor = System.Drawing.Color.Red;
            this.buttonDangXuat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangXuat.ForeColor = System.Drawing.Color.White;
            this.buttonDangXuat.Location = new System.Drawing.Point(12, 378);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(152, 27);
            this.buttonDangXuat.TabIndex = 2;
            this.buttonDangXuat.Text = "Đăng xuất";
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.BackColor = System.Drawing.Color.Navy;
            this.buttonCheckOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckOut.ForeColor = System.Drawing.Color.White;
            this.buttonCheckOut.Location = new System.Drawing.Point(12, 164);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(152, 27);
            this.buttonCheckOut.TabIndex = 7;
            this.buttonCheckOut.Text = "CHECK OUT";
            this.buttonCheckOut.UseVisualStyleBackColor = false;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.Navy;
            this.buttonCheckIn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.ForeColor = System.Drawing.Color.White;
            this.buttonCheckIn.Location = new System.Drawing.Point(12, 121);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(152, 27);
            this.buttonCheckIn.TabIndex = 6;
            this.buttonCheckIn.Text = "CHECK IN";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonXoaTK
            // 
            this.buttonXoaTK.BackColor = System.Drawing.Color.Red;
            this.buttonXoaTK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaTK.ForeColor = System.Drawing.Color.White;
            this.buttonXoaTK.Location = new System.Drawing.Point(12, 411);
            this.buttonXoaTK.Name = "buttonXoaTK";
            this.buttonXoaTK.Size = new System.Drawing.Size(152, 27);
            this.buttonXoaTK.TabIndex = 5;
            this.buttonXoaTK.Text = "Xóa tài khoản";
            this.buttonXoaTK.UseVisualStyleBackColor = false;
            this.buttonXoaTK.Click += new System.EventHandler(this.buttonXoaTK_Click);
            // 
            // buttonXoaNV
            // 
            this.buttonXoaNV.BackColor = System.Drawing.Color.Navy;
            this.buttonXoaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaNV.ForeColor = System.Drawing.Color.White;
            this.buttonXoaNV.Location = new System.Drawing.Point(12, 253);
            this.buttonXoaNV.Name = "buttonXoaNV";
            this.buttonXoaNV.Size = new System.Drawing.Size(152, 27);
            this.buttonXoaNV.TabIndex = 9;
            this.buttonXoaNV.Text = "Xóa nhân viên";
            this.buttonXoaNV.UseVisualStyleBackColor = false;
            this.buttonXoaNV.Visible = false;
            this.buttonXoaNV.Click += new System.EventHandler(this.buttonXoaNV_Click);
            // 
            // buttonDSNV
            // 
            this.buttonDSNV.BackColor = System.Drawing.Color.Navy;
            this.buttonDSNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDSNV.ForeColor = System.Drawing.Color.White;
            this.buttonDSNV.Location = new System.Drawing.Point(12, 210);
            this.buttonDSNV.Name = "buttonDSNV";
            this.buttonDSNV.Size = new System.Drawing.Size(152, 27);
            this.buttonDSNV.TabIndex = 8;
            this.buttonDSNV.Text = "DS Nhân viên";
            this.buttonDSNV.UseVisualStyleBackColor = false;
            this.buttonDSNV.Click += new System.EventHandler(this.buttonDSNV_Click);
            // 
            // buttonTKB
            // 
            this.buttonTKB.BackColor = System.Drawing.Color.Navy;
            this.buttonTKB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTKB.ForeColor = System.Drawing.Color.White;
            this.buttonTKB.Location = new System.Drawing.Point(12, 297);
            this.buttonTKB.Name = "buttonTKB";
            this.buttonTKB.Size = new System.Drawing.Size(152, 27);
            this.buttonTKB.TabIndex = 10;
            this.buttonTKB.Text = "TKB Nhân viên";
            this.buttonTKB.UseVisualStyleBackColor = false;
            this.buttonTKB.Visible = false;
            this.buttonTKB.Click += new System.EventHandler(this.buttonTKB_Click);
            // 
            // buttonTKBQL
            // 
            this.buttonTKBQL.BackColor = System.Drawing.Color.Navy;
            this.buttonTKBQL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTKBQL.ForeColor = System.Drawing.Color.White;
            this.buttonTKBQL.Location = new System.Drawing.Point(12, 253);
            this.buttonTKBQL.Name = "buttonTKBQL";
            this.buttonTKBQL.Size = new System.Drawing.Size(152, 27);
            this.buttonTKBQL.TabIndex = 11;
            this.buttonTKBQL.Text = "TKB Quản lý";
            this.buttonTKBQL.UseVisualStyleBackColor = false;
            this.buttonTKBQL.Click += new System.EventHandler(this.buttonTKBQL_Click);
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(182, 73);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.RowHeadersWidth = 51;
            this.dataGridViewTable.RowTemplate.Height = 24;
            this.dataGridViewTable.Size = new System.Drawing.Size(918, 365);
            this.dataGridViewTable.TabIndex = 12;
            // 
            // labelQL
            // 
            this.labelQL.AutoSize = true;
            this.labelQL.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQL.ForeColor = System.Drawing.Color.White;
            this.labelQL.Location = new System.Drawing.Point(415, 18);
            this.labelQL.Name = "labelQL";
            this.labelQL.Size = new System.Drawing.Size(192, 43);
            this.labelQL.TabIndex = 13;
            this.labelQL.Text = "QUẢN LÝ";
            // 
            // buttonDSXe
            // 
            this.buttonDSXe.BackColor = System.Drawing.Color.Navy;
            this.buttonDSXe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDSXe.ForeColor = System.Drawing.Color.White;
            this.buttonDSXe.Location = new System.Drawing.Point(12, 299);
            this.buttonDSXe.Name = "buttonDSXe";
            this.buttonDSXe.Size = new System.Drawing.Size(152, 27);
            this.buttonDSXe.TabIndex = 14;
            this.buttonDSXe.Text = "DS Xe";
            this.buttonDSXe.UseVisualStyleBackColor = false;
            this.buttonDSXe.Click += new System.EventHandler(this.buttonDSXe_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.Color.Purple;
            this.buttonHuy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.ForeColor = System.Drawing.Color.White;
            this.buttonHuy.Location = new System.Drawing.Point(12, 299);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(152, 27);
            this.buttonHuy.TabIndex = 15;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Visible = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // labelChonXe
            // 
            this.labelChonXe.AutoSize = true;
            this.labelChonXe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChonXe.ForeColor = System.Drawing.Color.White;
            this.labelChonXe.Location = new System.Drawing.Point(28, 135);
            this.labelChonXe.Name = "labelChonXe";
            this.labelChonXe.Size = new System.Drawing.Size(122, 26);
            this.labelChonXe.TabIndex = 16;
            this.labelChonXe.Text = "CHỌN XE";
            this.labelChonXe.Visible = false;
            // 
            // radioButtonXeDap
            // 
            this.radioButtonXeDap.AutoSize = true;
            this.radioButtonXeDap.Checked = true;
            this.radioButtonXeDap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXeDap.ForeColor = System.Drawing.Color.White;
            this.radioButtonXeDap.Location = new System.Drawing.Point(49, 172);
            this.radioButtonXeDap.Name = "radioButtonXeDap";
            this.radioButtonXeDap.Size = new System.Drawing.Size(80, 23);
            this.radioButtonXeDap.TabIndex = 17;
            this.radioButtonXeDap.TabStop = true;
            this.radioButtonXeDap.Text = "Xe đạp";
            this.radioButtonXeDap.UseVisualStyleBackColor = true;
            this.radioButtonXeDap.Visible = false;
            this.radioButtonXeDap.CheckedChanged += new System.EventHandler(this.radioButtonXeDap_CheckedChanged);
            // 
            // radioButtonXeMay
            // 
            this.radioButtonXeMay.AutoSize = true;
            this.radioButtonXeMay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXeMay.ForeColor = System.Drawing.Color.White;
            this.radioButtonXeMay.Location = new System.Drawing.Point(49, 215);
            this.radioButtonXeMay.Name = "radioButtonXeMay";
            this.radioButtonXeMay.Size = new System.Drawing.Size(84, 23);
            this.radioButtonXeMay.TabIndex = 18;
            this.radioButtonXeMay.Text = "Xe máy";
            this.radioButtonXeMay.UseVisualStyleBackColor = true;
            this.radioButtonXeMay.Visible = false;
            this.radioButtonXeMay.CheckedChanged += new System.EventHandler(this.radioButtonXeMay_CheckedChanged);
            // 
            // radioButtonXeHoi
            // 
            this.radioButtonXeHoi.AutoSize = true;
            this.radioButtonXeHoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXeHoi.ForeColor = System.Drawing.Color.White;
            this.radioButtonXeHoi.Location = new System.Drawing.Point(49, 259);
            this.radioButtonXeHoi.Name = "radioButtonXeHoi";
            this.radioButtonXeHoi.Size = new System.Drawing.Size(78, 23);
            this.radioButtonXeHoi.TabIndex = 19;
            this.radioButtonXeHoi.Text = "Xe hơi";
            this.radioButtonXeHoi.UseVisualStyleBackColor = true;
            this.radioButtonXeHoi.Visible = false;
            this.radioButtonXeHoi.CheckedChanged += new System.EventHandler(this.radioButtonXeHoi_CheckedChanged);
            // 
            // buttonHuyDSNV
            // 
            this.buttonHuyDSNV.BackColor = System.Drawing.Color.Purple;
            this.buttonHuyDSNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuyDSNV.ForeColor = System.Drawing.Color.White;
            this.buttonHuyDSNV.Location = new System.Drawing.Point(12, 341);
            this.buttonHuyDSNV.Name = "buttonHuyDSNV";
            this.buttonHuyDSNV.Size = new System.Drawing.Size(152, 27);
            this.buttonHuyDSNV.TabIndex = 20;
            this.buttonHuyDSNV.Text = "Hủy";
            this.buttonHuyDSNV.UseVisualStyleBackColor = false;
            this.buttonHuyDSNV.Visible = false;
            this.buttonHuyDSNV.Click += new System.EventHandler(this.buttonHuyDSNV_Click);
            // 
            // dateTimePickerTKB
            // 
            this.dateTimePickerTKB.Location = new System.Drawing.Point(825, 45);
            this.dateTimePickerTKB.Name = "dateTimePickerTKB";
            this.dateTimePickerTKB.Size = new System.Drawing.Size(275, 22);
            this.dateTimePickerTKB.TabIndex = 21;
            this.dateTimePickerTKB.Visible = false;
            this.dateTimePickerTKB.ValueChanged += new System.EventHandler(this.dateTimePickerTKB_ValueChanged);
            // 
            // textBoxCa3
            // 
            this.textBoxCa3.Location = new System.Drawing.Point(578, 294);
            this.textBoxCa3.Name = "textBoxCa3";
            this.textBoxCa3.ReadOnly = true;
            this.textBoxCa3.Size = new System.Drawing.Size(100, 22);
            this.textBoxCa3.TabIndex = 27;
            this.textBoxCa3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCa3.Visible = false;
            // 
            // textBoxCa2
            // 
            this.textBoxCa2.Location = new System.Drawing.Point(578, 214);
            this.textBoxCa2.Name = "textBoxCa2";
            this.textBoxCa2.ReadOnly = true;
            this.textBoxCa2.Size = new System.Drawing.Size(100, 22);
            this.textBoxCa2.TabIndex = 26;
            this.textBoxCa2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCa2.Visible = false;
            // 
            // textBoxCa1
            // 
            this.textBoxCa1.Location = new System.Drawing.Point(578, 140);
            this.textBoxCa1.Name = "textBoxCa1";
            this.textBoxCa1.ReadOnly = true;
            this.textBoxCa1.Size = new System.Drawing.Size(100, 22);
            this.textBoxCa1.TabIndex = 25;
            this.textBoxCa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCa1.Visible = false;
            // 
            // labelCa3
            // 
            this.labelCa3.AutoSize = true;
            this.labelCa3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCa3.ForeColor = System.Drawing.Color.White;
            this.labelCa3.Location = new System.Drawing.Point(434, 294);
            this.labelCa3.Name = "labelCa3";
            this.labelCa3.Size = new System.Drawing.Size(71, 26);
            this.labelCa3.TabIndex = 24;
            this.labelCa3.Text = "CA 3:";
            this.labelCa3.Visible = false;
            // 
            // labelCa2
            // 
            this.labelCa2.AutoSize = true;
            this.labelCa2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCa2.ForeColor = System.Drawing.Color.White;
            this.labelCa2.Location = new System.Drawing.Point(434, 214);
            this.labelCa2.Name = "labelCa2";
            this.labelCa2.Size = new System.Drawing.Size(71, 26);
            this.labelCa2.TabIndex = 23;
            this.labelCa2.Text = "CA 2:";
            this.labelCa2.Visible = false;
            // 
            // labelCa1
            // 
            this.labelCa1.AutoSize = true;
            this.labelCa1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCa1.ForeColor = System.Drawing.Color.White;
            this.labelCa1.Location = new System.Drawing.Point(434, 137);
            this.labelCa1.Name = "labelCa1";
            this.labelCa1.Size = new System.Drawing.Size(71, 26);
            this.labelCa1.TabIndex = 22;
            this.labelCa1.Text = "CA 1:";
            this.labelCa1.Visible = false;
            // 
            // buttonHuyTKB
            // 
            this.buttonHuyTKB.BackColor = System.Drawing.Color.Purple;
            this.buttonHuyTKB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuyTKB.ForeColor = System.Drawing.Color.White;
            this.buttonHuyTKB.Location = new System.Drawing.Point(481, 362);
            this.buttonHuyTKB.Name = "buttonHuyTKB";
            this.buttonHuyTKB.Size = new System.Drawing.Size(152, 27);
            this.buttonHuyTKB.TabIndex = 28;
            this.buttonHuyTKB.Text = "Hủy";
            this.buttonHuyTKB.UseVisualStyleBackColor = false;
            this.buttonHuyTKB.Visible = false;
            this.buttonHuyTKB.Click += new System.EventHandler(this.buttonHuyTKB_Click);
            // 
            // buttonDSTGLV
            // 
            this.buttonDSTGLV.BackColor = System.Drawing.Color.Navy;
            this.buttonDSTGLV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDSTGLV.ForeColor = System.Drawing.Color.White;
            this.buttonDSTGLV.Location = new System.Drawing.Point(12, 83);
            this.buttonDSTGLV.Name = "buttonDSTGLV";
            this.buttonDSTGLV.Size = new System.Drawing.Size(152, 27);
            this.buttonDSTGLV.TabIndex = 29;
            this.buttonDSTGLV.Text = "DSTGLV";
            this.buttonDSTGLV.UseVisualStyleBackColor = false;
            this.buttonDSTGLV.Click += new System.EventHandler(this.buttonDSTGLV_Click);
            // 
            // labelLuong
            // 
            this.labelLuong.AutoSize = true;
            this.labelLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLuong.ForeColor = System.Drawing.Color.White;
            this.labelLuong.Location = new System.Drawing.Point(862, 45);
            this.labelLuong.Name = "labelLuong";
            this.labelLuong.Size = new System.Drawing.Size(103, 23);
            this.labelLuong.TabIndex = 30;
            this.labelLuong.Text = "labelLuong";
            this.labelLuong.Visible = false;
            // 
            // MenuManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1112, 456);
            this.Controls.Add(this.labelLuong);
            this.Controls.Add(this.buttonDSTGLV);
            this.Controls.Add(this.buttonHuyTKB);
            this.Controls.Add(this.textBoxCa3);
            this.Controls.Add(this.textBoxCa2);
            this.Controls.Add(this.textBoxCa1);
            this.Controls.Add(this.labelCa3);
            this.Controls.Add(this.labelCa2);
            this.Controls.Add(this.labelCa1);
            this.Controls.Add(this.dateTimePickerTKB);
            this.Controls.Add(this.buttonHuyDSNV);
            this.Controls.Add(this.radioButtonXeHoi);
            this.Controls.Add(this.radioButtonXeMay);
            this.Controls.Add(this.radioButtonXeDap);
            this.Controls.Add(this.labelChonXe);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonDSXe);
            this.Controls.Add(this.labelQL);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.buttonTKBQL);
            this.Controls.Add(this.buttonTKB);
            this.Controls.Add(this.buttonXoaNV);
            this.Controls.Add(this.buttonDSNV);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.buttonXoaTK);
            this.Controls.Add(this.buttonDangXuat);
            this.Name = "MenuManagers";
            this.Text = "MenuManagers";
            this.Load += new System.EventHandler(this.MenuManagers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDangXuat;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button buttonXoaTK;
        private System.Windows.Forms.Button buttonXoaNV;
        private System.Windows.Forms.Button buttonDSNV;
        private System.Windows.Forms.Button buttonTKB;
        private System.Windows.Forms.Button buttonTKBQL;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Label labelQL;
        private System.Windows.Forms.Button buttonDSXe;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label labelChonXe;
        private System.Windows.Forms.RadioButton radioButtonXeDap;
        private System.Windows.Forms.RadioButton radioButtonXeMay;
        private System.Windows.Forms.RadioButton radioButtonXeHoi;
        private System.Windows.Forms.Button buttonHuyDSNV;
        private System.Windows.Forms.DateTimePicker dateTimePickerTKB;
        private System.Windows.Forms.TextBox textBoxCa3;
        private System.Windows.Forms.TextBox textBoxCa2;
        private System.Windows.Forms.TextBox textBoxCa1;
        private System.Windows.Forms.Label labelCa3;
        private System.Windows.Forms.Label labelCa2;
        private System.Windows.Forms.Label labelCa1;
        private System.Windows.Forms.Button buttonHuyTKB;
        private System.Windows.Forms.Button buttonDSTGLV;
        private System.Windows.Forms.Label labelLuong;
    }
}