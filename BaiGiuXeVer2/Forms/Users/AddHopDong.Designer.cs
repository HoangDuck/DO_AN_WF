namespace BaiGiuXeVer2
{
    partial class AddHopDong
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
            this.labelSoHD = new System.Windows.Forms.Label();
            this.labelNgayKi = new System.Windows.Forms.Label();
            this.labelNgayHetHan = new System.Windows.Forms.Label();
            this.labelIDXe = new System.Windows.Forms.Label();
            this.labelIDKH = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxKH = new System.Windows.Forms.TextBox();
            this.textBoxSoHD = new System.Windows.Forms.TextBox();
            this.textBoxXe = new System.Windows.Forms.TextBox();
            this.dateTimePickerKi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHethan = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSelectXe = new System.Windows.Forms.Button();
            this.labelChonHD = new System.Windows.Forms.Label();
            this.comboBoxLoaiHD = new System.Windows.Forms.ComboBox();
            this.labelCHD = new System.Windows.Forms.Label();
            this.labelGiaiThichHD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSoHD
            // 
            this.labelSoHD.AutoSize = true;
            this.labelSoHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoHD.Location = new System.Drawing.Point(43, 490);
            this.labelSoHD.Name = "labelSoHD";
            this.labelSoHD.Size = new System.Drawing.Size(111, 19);
            this.labelSoHD.TabIndex = 0;
            this.labelSoHD.Text = "Số Hợp Đồng:";
            this.labelSoHD.Visible = false;
            // 
            // labelNgayKi
            // 
            this.labelNgayKi.AutoSize = true;
            this.labelNgayKi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayKi.Location = new System.Drawing.Point(93, 364);
            this.labelNgayKi.Name = "labelNgayKi";
            this.labelNgayKi.Size = new System.Drawing.Size(71, 19);
            this.labelNgayKi.TabIndex = 1;
            this.labelNgayKi.Text = "Ngày kí:";
            // 
            // labelNgayHetHan
            // 
            this.labelNgayHetHan.AutoSize = true;
            this.labelNgayHetHan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayHetHan.Location = new System.Drawing.Point(55, 410);
            this.labelNgayHetHan.Name = "labelNgayHetHan";
            this.labelNgayHetHan.Size = new System.Drawing.Size(109, 19);
            this.labelNgayHetHan.TabIndex = 2;
            this.labelNgayHetHan.Text = "Ngày hết hạn:";
            // 
            // labelIDXe
            // 
            this.labelIDXe.AutoSize = true;
            this.labelIDXe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDXe.Location = new System.Drawing.Point(90, 324);
            this.labelIDXe.Name = "labelIDXe";
            this.labelIDXe.Size = new System.Drawing.Size(74, 19);
            this.labelIDXe.TabIndex = 3;
            this.labelIDXe.Text = "Chọn xe:";
            // 
            // labelIDKH
            // 
            this.labelIDKH.AutoSize = true;
            this.labelIDKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDKH.Location = new System.Drawing.Point(38, 449);
            this.labelIDKH.Name = "labelIDKH";
            this.labelIDKH.Size = new System.Drawing.Size(126, 19);
            this.labelIDKH.TabIndex = 4;
            this.labelIDKH.Text = "ID Khách Hàng:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(300, 533);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 32);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxKH
            // 
            this.textBoxKH.Location = new System.Drawing.Point(191, 448);
            this.textBoxKH.Name = "textBoxKH";
            this.textBoxKH.ReadOnly = true;
            this.textBoxKH.Size = new System.Drawing.Size(156, 22);
            this.textBoxKH.TabIndex = 6;
            // 
            // textBoxSoHD
            // 
            this.textBoxSoHD.Location = new System.Drawing.Point(191, 490);
            this.textBoxSoHD.Name = "textBoxSoHD";
            this.textBoxSoHD.ReadOnly = true;
            this.textBoxSoHD.Size = new System.Drawing.Size(253, 22);
            this.textBoxSoHD.TabIndex = 7;
            this.textBoxSoHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSoHD.Visible = false;
            // 
            // textBoxXe
            // 
            this.textBoxXe.Location = new System.Drawing.Point(194, 323);
            this.textBoxXe.Name = "textBoxXe";
            this.textBoxXe.ReadOnly = true;
            this.textBoxXe.Size = new System.Drawing.Size(156, 22);
            this.textBoxXe.TabIndex = 8;
            this.textBoxXe.TextChanged += new System.EventHandler(this.textBoxXe_TextChanged);
            // 
            // dateTimePickerKi
            // 
            this.dateTimePickerKi.Location = new System.Drawing.Point(193, 359);
            this.dateTimePickerKi.Name = "dateTimePickerKi";
            this.dateTimePickerKi.Size = new System.Drawing.Size(253, 22);
            this.dateTimePickerKi.TabIndex = 10;
            this.dateTimePickerKi.ValueChanged += new System.EventHandler(this.dateTimePickerKi_ValueChanged);
            // 
            // dateTimePickerHethan
            // 
            this.dateTimePickerHethan.Location = new System.Drawing.Point(193, 405);
            this.dateTimePickerHethan.Name = "dateTimePickerHethan";
            this.dateTimePickerHethan.Size = new System.Drawing.Size(253, 22);
            this.dateTimePickerHethan.TabIndex = 11;
            this.dateTimePickerHethan.ValueChanged += new System.EventHandler(this.dateTimePickerHethan_ValueChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(56, 533);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 32);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSelectXe
            // 
            this.buttonSelectXe.BackColor = System.Drawing.Color.Blue;
            this.buttonSelectXe.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectXe.ForeColor = System.Drawing.Color.White;
            this.buttonSelectXe.Location = new System.Drawing.Point(356, 323);
            this.buttonSelectXe.Name = "buttonSelectXe";
            this.buttonSelectXe.Size = new System.Drawing.Size(91, 23);
            this.buttonSelectXe.TabIndex = 13;
            this.buttonSelectXe.Text = "Select Xe";
            this.buttonSelectXe.UseVisualStyleBackColor = false;
            this.buttonSelectXe.Click += new System.EventHandler(this.buttonSelectXe_Click);
            // 
            // labelChonHD
            // 
            this.labelChonHD.AutoSize = true;
            this.labelChonHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChonHD.Location = new System.Drawing.Point(22, 91);
            this.labelChonHD.Name = "labelChonHD";
            this.labelChonHD.Size = new System.Drawing.Size(132, 19);
            this.labelChonHD.TabIndex = 14;
            this.labelChonHD.Text = "Chọn Hợp Đồng:";
            // 
            // comboBoxLoaiHD
            // 
            this.comboBoxLoaiHD.FormattingEnabled = true;
            this.comboBoxLoaiHD.Location = new System.Drawing.Point(191, 90);
            this.comboBoxLoaiHD.Name = "comboBoxLoaiHD";
            this.comboBoxLoaiHD.Size = new System.Drawing.Size(253, 24);
            this.comboBoxLoaiHD.TabIndex = 15;
            this.comboBoxLoaiHD.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoaiHD_SelectedIndexChanged);
            // 
            // labelCHD
            // 
            this.labelCHD.AutoSize = true;
            this.labelCHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCHD.Location = new System.Drawing.Point(122, 37);
            this.labelCHD.Name = "labelCHD";
            this.labelCHD.Size = new System.Drawing.Size(219, 26);
            this.labelCHD.TabIndex = 16;
            this.labelCHD.Text = "CHỌN HỢP ĐỒNG";
            // 
            // labelGiaiThichHD
            // 
            this.labelGiaiThichHD.AutoSize = true;
            this.labelGiaiThichHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaiThichHD.Location = new System.Drawing.Point(22, 132);
            this.labelGiaiThichHD.Name = "labelGiaiThichHD";
            this.labelGiaiThichHD.Size = new System.Drawing.Size(81, 19);
            this.labelGiaiThichHD.TabIndex = 17;
            this.labelGiaiThichHD.Text = "Chú thích";
            // 
            // AddHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 575);
            this.Controls.Add(this.labelGiaiThichHD);
            this.Controls.Add(this.labelCHD);
            this.Controls.Add(this.comboBoxLoaiHD);
            this.Controls.Add(this.labelChonHD);
            this.Controls.Add(this.buttonSelectXe);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dateTimePickerHethan);
            this.Controls.Add(this.dateTimePickerKi);
            this.Controls.Add(this.textBoxXe);
            this.Controls.Add(this.textBoxSoHD);
            this.Controls.Add(this.textBoxKH);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelIDKH);
            this.Controls.Add(this.labelIDXe);
            this.Controls.Add(this.labelNgayHetHan);
            this.Controls.Add(this.labelNgayKi);
            this.Controls.Add(this.labelSoHD);
            this.Name = "AddHopDong";
            this.Text = "AddHopDong";
            this.Load += new System.EventHandler(this.AddHopDong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoHD;
        private System.Windows.Forms.Label labelNgayKi;
        private System.Windows.Forms.Label labelNgayHetHan;
        private System.Windows.Forms.Label labelIDXe;
        private System.Windows.Forms.Label labelIDKH;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxKH;
        private System.Windows.Forms.TextBox textBoxSoHD;
        private System.Windows.Forms.TextBox textBoxXe;
        private System.Windows.Forms.DateTimePicker dateTimePickerKi;
        private System.Windows.Forms.DateTimePicker dateTimePickerHethan;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSelectXe;
        private System.Windows.Forms.Label labelChonHD;
        private System.Windows.Forms.ComboBox comboBoxLoaiHD;
        private System.Windows.Forms.Label labelCHD;
        private System.Windows.Forms.Label labelGiaiThichHD;
    }
}