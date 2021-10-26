
namespace BaiGiuXeVer2.Forms.Workers.Xe
{
    partial class ThemXe
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
            this.buttonDangKy = new System.Windows.Forms.Button();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.pictureBoxHinhXe = new System.Windows.Forms.PictureBox();
            this.groupBoxHinhThucGui = new System.Windows.Forms.GroupBox();
            this.radioButtonThang = new System.Windows.Forms.RadioButton();
            this.radioButtonTuan = new System.Windows.Forms.RadioButton();
            this.radioButtonNgay = new System.Windows.Forms.RadioButton();
            this.labelHinhThucGui = new System.Windows.Forms.Label();
            this.dateTimePickerNgayGui = new System.Windows.Forms.DateTimePicker();
            this.labelNgayGui = new System.Windows.Forms.Label();
            this.groupBoxLoaiXe = new System.Windows.Forms.GroupBox();
            this.radioButtonXeDap = new System.Windows.Forms.RadioButton();
            this.radioButtonXeMay = new System.Windows.Forms.RadioButton();
            this.radioButtonXeHoi = new System.Windows.Forms.RadioButton();
            this.labelLoaiXe = new System.Windows.Forms.Label();
            this.textBoxBienSo = new System.Windows.Forms.TextBox();
            this.labelBienSo = new System.Windows.Forms.Label();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhXe)).BeginInit();
            this.groupBoxHinhThucGui.SuspendLayout();
            this.groupBoxLoaiXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDangKy
            // 
            this.buttonDangKy.Location = new System.Drawing.Point(13, 451);
            this.buttonDangKy.Name = "buttonDangKy";
            this.buttonDangKy.Size = new System.Drawing.Size(286, 33);
            this.buttonDangKy.TabIndex = 25;
            this.buttonDangKy.Text = "Đăng ký";
            this.buttonDangKy.UseVisualStyleBackColor = true;
            this.buttonDangKy.Click += new System.EventHandler(this.buttonDangKy_Click);
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Location = new System.Drawing.Point(310, 452);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(504, 32);
            this.buttonUploadImage.TabIndex = 24;
            this.buttonUploadImage.Text = "UPLOAD";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // pictureBoxHinhXe
            // 
            this.pictureBoxHinhXe.Location = new System.Drawing.Point(310, 12);
            this.pictureBoxHinhXe.Name = "pictureBoxHinhXe";
            this.pictureBoxHinhXe.Size = new System.Drawing.Size(504, 433);
            this.pictureBoxHinhXe.TabIndex = 23;
            this.pictureBoxHinhXe.TabStop = false;
            // 
            // groupBoxHinhThucGui
            // 
            this.groupBoxHinhThucGui.Controls.Add(this.radioButtonThang);
            this.groupBoxHinhThucGui.Controls.Add(this.radioButtonTuan);
            this.groupBoxHinhThucGui.Controls.Add(this.radioButtonNgay);
            this.groupBoxHinhThucGui.Location = new System.Drawing.Point(87, 332);
            this.groupBoxHinhThucGui.Name = "groupBoxHinhThucGui";
            this.groupBoxHinhThucGui.Size = new System.Drawing.Size(212, 103);
            this.groupBoxHinhThucGui.TabIndex = 22;
            this.groupBoxHinhThucGui.TabStop = false;
            // 
            // radioButtonThang
            // 
            this.radioButtonThang.AutoSize = true;
            this.radioButtonThang.Location = new System.Drawing.Point(6, 73);
            this.radioButtonThang.Name = "radioButtonThang";
            this.radioButtonThang.Size = new System.Drawing.Size(70, 21);
            this.radioButtonThang.TabIndex = 7;
            this.radioButtonThang.TabStop = true;
            this.radioButtonThang.Text = "Tháng";
            this.radioButtonThang.UseVisualStyleBackColor = true;
            // 
            // radioButtonTuan
            // 
            this.radioButtonTuan.AutoSize = true;
            this.radioButtonTuan.Location = new System.Drawing.Point(6, 45);
            this.radioButtonTuan.Name = "radioButtonTuan";
            this.radioButtonTuan.Size = new System.Drawing.Size(62, 21);
            this.radioButtonTuan.TabIndex = 6;
            this.radioButtonTuan.TabStop = true;
            this.radioButtonTuan.Text = "Tuần";
            this.radioButtonTuan.UseVisualStyleBackColor = true;
            // 
            // radioButtonNgay
            // 
            this.radioButtonNgay.AutoSize = true;
            this.radioButtonNgay.Location = new System.Drawing.Point(6, 18);
            this.radioButtonNgay.Name = "radioButtonNgay";
            this.radioButtonNgay.Size = new System.Drawing.Size(62, 21);
            this.radioButtonNgay.TabIndex = 0;
            this.radioButtonNgay.TabStop = true;
            this.radioButtonNgay.Text = "Ngày";
            this.radioButtonNgay.UseVisualStyleBackColor = true;
            // 
            // labelHinhThucGui
            // 
            this.labelHinhThucGui.AutoSize = true;
            this.labelHinhThucGui.Location = new System.Drawing.Point(21, 312);
            this.labelHinhThucGui.Name = "labelHinhThucGui";
            this.labelHinhThucGui.Size = new System.Drawing.Size(91, 17);
            this.labelHinhThucGui.TabIndex = 20;
            this.labelHinhThucGui.Text = "Hình thức gửi";
            // 
            // dateTimePickerNgayGui
            // 
            this.dateTimePickerNgayGui.Location = new System.Drawing.Point(87, 260);
            this.dateTimePickerNgayGui.Name = "dateTimePickerNgayGui";
            this.dateTimePickerNgayGui.Size = new System.Drawing.Size(212, 22);
            this.dateTimePickerNgayGui.TabIndex = 21;
            // 
            // labelNgayGui
            // 
            this.labelNgayGui.AutoSize = true;
            this.labelNgayGui.Location = new System.Drawing.Point(21, 260);
            this.labelNgayGui.Name = "labelNgayGui";
            this.labelNgayGui.Size = new System.Drawing.Size(64, 17);
            this.labelNgayGui.TabIndex = 19;
            this.labelNgayGui.Text = "Ngày gửi";
            // 
            // groupBoxLoaiXe
            // 
            this.groupBoxLoaiXe.Controls.Add(this.radioButtonXeDap);
            this.groupBoxLoaiXe.Controls.Add(this.radioButtonXeMay);
            this.groupBoxLoaiXe.Controls.Add(this.radioButtonXeHoi);
            this.groupBoxLoaiXe.Location = new System.Drawing.Point(88, 90);
            this.groupBoxLoaiXe.Name = "groupBoxLoaiXe";
            this.groupBoxLoaiXe.Size = new System.Drawing.Size(200, 103);
            this.groupBoxLoaiXe.TabIndex = 18;
            this.groupBoxLoaiXe.TabStop = false;
            // 
            // radioButtonXeDap
            // 
            this.radioButtonXeDap.AutoSize = true;
            this.radioButtonXeDap.Location = new System.Drawing.Point(6, 73);
            this.radioButtonXeDap.Name = "radioButtonXeDap";
            this.radioButtonXeDap.Size = new System.Drawing.Size(74, 21);
            this.radioButtonXeDap.TabIndex = 7;
            this.radioButtonXeDap.TabStop = true;
            this.radioButtonXeDap.Text = "Xe đạp";
            this.radioButtonXeDap.UseVisualStyleBackColor = true;
            this.radioButtonXeDap.CheckedChanged += new System.EventHandler(this.radioButtonXeDap_CheckedChanged);
            // 
            // radioButtonXeMay
            // 
            this.radioButtonXeMay.AutoSize = true;
            this.radioButtonXeMay.Location = new System.Drawing.Point(6, 45);
            this.radioButtonXeMay.Name = "radioButtonXeMay";
            this.radioButtonXeMay.Size = new System.Drawing.Size(76, 21);
            this.radioButtonXeMay.TabIndex = 6;
            this.radioButtonXeMay.TabStop = true;
            this.radioButtonXeMay.Text = "Xe máy";
            this.radioButtonXeMay.UseVisualStyleBackColor = true;
            this.radioButtonXeMay.CheckedChanged += new System.EventHandler(this.radioButtonXeMay_CheckedChanged);
            // 
            // radioButtonXeHoi
            // 
            this.radioButtonXeHoi.AutoSize = true;
            this.radioButtonXeHoi.Location = new System.Drawing.Point(6, 18);
            this.radioButtonXeHoi.Name = "radioButtonXeHoi";
            this.radioButtonXeHoi.Size = new System.Drawing.Size(69, 21);
            this.radioButtonXeHoi.TabIndex = 0;
            this.radioButtonXeHoi.TabStop = true;
            this.radioButtonXeHoi.Text = "Xe hơi";
            this.radioButtonXeHoi.UseVisualStyleBackColor = true;
            this.radioButtonXeHoi.CheckedChanged += new System.EventHandler(this.radioButtonXeHoi_CheckedChanged);
            // 
            // labelLoaiXe
            // 
            this.labelLoaiXe.AutoSize = true;
            this.labelLoaiXe.Location = new System.Drawing.Point(34, 103);
            this.labelLoaiXe.Name = "labelLoaiXe";
            this.labelLoaiXe.Size = new System.Drawing.Size(53, 17);
            this.labelLoaiXe.TabIndex = 17;
            this.labelLoaiXe.Text = "Loại xe";
            // 
            // textBoxBienSo
            // 
            this.textBoxBienSo.Location = new System.Drawing.Point(88, 224);
            this.textBoxBienSo.Name = "textBoxBienSo";
            this.textBoxBienSo.Size = new System.Drawing.Size(211, 22);
            this.textBoxBienSo.TabIndex = 16;
            // 
            // labelBienSo
            // 
            this.labelBienSo.AutoSize = true;
            this.labelBienSo.Location = new System.Drawing.Point(27, 224);
            this.labelBienSo.Name = "labelBienSo";
            this.labelBienSo.Size = new System.Drawing.Size(55, 17);
            this.labelBienSo.TabIndex = 15;
            this.labelBienSo.Text = "Biển số";
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(88, 59);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(211, 22);
            this.textBoxMaKH.TabIndex = 14;
            // 
            // labelMaKH
            // 
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Location = new System.Drawing.Point(35, 59);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(50, 17);
            this.labelMaKH.TabIndex = 13;
            this.labelMaKH.Text = "Mã KH";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(87, 18);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(211, 22);
            this.textBoxID.TabIndex = 27;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(60, 21);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 26;
            this.labelID.Text = "ID";
            // 
            // ThemXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 497);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonDangKy);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.pictureBoxHinhXe);
            this.Controls.Add(this.groupBoxHinhThucGui);
            this.Controls.Add(this.labelHinhThucGui);
            this.Controls.Add(this.dateTimePickerNgayGui);
            this.Controls.Add(this.labelNgayGui);
            this.Controls.Add(this.groupBoxLoaiXe);
            this.Controls.Add(this.labelLoaiXe);
            this.Controls.Add(this.textBoxBienSo);
            this.Controls.Add(this.labelBienSo);
            this.Controls.Add(this.textBoxMaKH);
            this.Controls.Add(this.labelMaKH);
            this.Name = "ThemXe";
            this.Text = "ThemXe";
            this.Load += new System.EventHandler(this.ThemXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhXe)).EndInit();
            this.groupBoxHinhThucGui.ResumeLayout(false);
            this.groupBoxHinhThucGui.PerformLayout();
            this.groupBoxLoaiXe.ResumeLayout(false);
            this.groupBoxLoaiXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDangKy;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.PictureBox pictureBoxHinhXe;
        private System.Windows.Forms.GroupBox groupBoxHinhThucGui;
        private System.Windows.Forms.RadioButton radioButtonThang;
        private System.Windows.Forms.RadioButton radioButtonTuan;
        private System.Windows.Forms.RadioButton radioButtonNgay;
        private System.Windows.Forms.Label labelHinhThucGui;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayGui;
        private System.Windows.Forms.Label labelNgayGui;
        private System.Windows.Forms.GroupBox groupBoxLoaiXe;
        private System.Windows.Forms.RadioButton radioButtonXeDap;
        private System.Windows.Forms.RadioButton radioButtonXeMay;
        private System.Windows.Forms.RadioButton radioButtonXeHoi;
        private System.Windows.Forms.Label labelLoaiXe;
        private System.Windows.Forms.TextBox textBoxBienSo;
        private System.Windows.Forms.Label labelBienSo;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
    }
}