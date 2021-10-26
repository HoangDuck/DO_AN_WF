
namespace BaiGiuXeVer2.Forms.Workers.Xe
{
    partial class SuaThongTinXe
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
            this.labelPhat = new System.Windows.Forms.Label();
            this.labelKhachHang = new System.Windows.Forms.Label();
            this.labelPhi = new System.Windows.Forms.Label();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonThang = new System.Windows.Forms.RadioButton();
            this.radioButtonTuan = new System.Windows.Forms.RadioButton();
            this.radioButtonNgay = new System.Windows.Forms.RadioButton();
            this.labelNgayTraXe = new System.Windows.Forms.Label();
            this.dateTimePickerNgayTraXe = new System.Windows.Forms.DateTimePicker();
            this.labelNgayTraXeDK = new System.Windows.Forms.Label();
            this.dateTimePickerNgayTraXeDK = new System.Windows.Forms.DateTimePicker();
            this.labelNgayGuiXe = new System.Windows.Forms.Label();
            this.dateTimePickerNgayGui = new System.Windows.Forms.DateTimePicker();
            this.labelBienXe = new System.Windows.Forms.Label();
            this.pictureBoxHinhXe = new System.Windows.Forms.PictureBox();
            this.groupBoxLoaiXe = new System.Windows.Forms.GroupBox();
            this.radioButtonXeHoi = new System.Windows.Forms.RadioButton();
            this.radioButtonXeMay = new System.Windows.Forms.RadioButton();
            this.radioButtonXeDap = new System.Windows.Forms.RadioButton();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhXe)).BeginInit();
            this.groupBoxLoaiXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPhat
            // 
            this.labelPhat.AutoSize = true;
            this.labelPhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhat.Location = new System.Drawing.Point(22, 463);
            this.labelPhat.Name = "labelPhat";
            this.labelPhat.Size = new System.Drawing.Size(49, 23);
            this.labelPhat.TabIndex = 28;
            this.labelPhat.Text = "Phạt";
            // 
            // labelKhachHang
            // 
            this.labelKhachHang.AutoSize = true;
            this.labelKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhachHang.Location = new System.Drawing.Point(22, 357);
            this.labelKhachHang.Name = "labelKhachHang";
            this.labelKhachHang.Size = new System.Drawing.Size(115, 23);
            this.labelKhachHang.TabIndex = 27;
            this.labelKhachHang.Text = "Khách hàng:";
            // 
            // labelPhi
            // 
            this.labelPhi.AutoSize = true;
            this.labelPhi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhi.Location = new System.Drawing.Point(22, 411);
            this.labelPhi.Name = "labelPhi";
            this.labelPhi.Size = new System.Drawing.Size(38, 23);
            this.labelPhi.TabIndex = 26;
            this.labelPhi.Text = "Phí";
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(833, 11);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 25;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(730, 11);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 24;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonThang);
            this.groupBox1.Controls.Add(this.radioButtonTuan);
            this.groupBox1.Controls.Add(this.radioButtonNgay);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 71);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình thức gửi: ";
            // 
            // radioButtonThang
            // 
            this.radioButtonThang.AutoSize = true;
            this.radioButtonThang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonThang.Location = new System.Drawing.Point(201, 36);
            this.radioButtonThang.Name = "radioButtonThang";
            this.radioButtonThang.Size = new System.Drawing.Size(67, 21);
            this.radioButtonThang.TabIndex = 2;
            this.radioButtonThang.TabStop = true;
            this.radioButtonThang.Text = "Tháng";
            this.radioButtonThang.UseVisualStyleBackColor = true;
            // 
            // radioButtonTuan
            // 
            this.radioButtonTuan.AutoSize = true;
            this.radioButtonTuan.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTuan.Location = new System.Drawing.Point(101, 36);
            this.radioButtonTuan.Name = "radioButtonTuan";
            this.radioButtonTuan.Size = new System.Drawing.Size(59, 21);
            this.radioButtonTuan.TabIndex = 1;
            this.radioButtonTuan.TabStop = true;
            this.radioButtonTuan.Text = "Tuần";
            this.radioButtonTuan.UseVisualStyleBackColor = true;
            // 
            // radioButtonNgay
            // 
            this.radioButtonNgay.AutoSize = true;
            this.radioButtonNgay.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNgay.Location = new System.Drawing.Point(7, 36);
            this.radioButtonNgay.Name = "radioButtonNgay";
            this.radioButtonNgay.Size = new System.Drawing.Size(59, 21);
            this.radioButtonNgay.TabIndex = 0;
            this.radioButtonNgay.TabStop = true;
            this.radioButtonNgay.Text = "Ngày";
            this.radioButtonNgay.UseVisualStyleBackColor = true;
            // 
            // labelNgayTraXe
            // 
            this.labelNgayTraXe.AutoSize = true;
            this.labelNgayTraXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayTraXe.Location = new System.Drawing.Point(23, 297);
            this.labelNgayTraXe.Name = "labelNgayTraXe";
            this.labelNgayTraXe.Size = new System.Drawing.Size(109, 23);
            this.labelNgayTraXe.TabIndex = 23;
            this.labelNgayTraXe.Text = "Ngày trả xe";
            // 
            // dateTimePickerNgayTraXe
            // 
            this.dateTimePickerNgayTraXe.Location = new System.Drawing.Point(26, 323);
            this.dateTimePickerNgayTraXe.Name = "dateTimePickerNgayTraXe";
            this.dateTimePickerNgayTraXe.Size = new System.Drawing.Size(232, 22);
            this.dateTimePickerNgayTraXe.TabIndex = 22;
            // 
            // labelNgayTraXeDK
            // 
            this.labelNgayTraXeDK.AutoSize = true;
            this.labelNgayTraXeDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayTraXeDK.Location = new System.Drawing.Point(24, 246);
            this.labelNgayTraXeDK.Name = "labelNgayTraXeDK";
            this.labelNgayTraXeDK.Size = new System.Drawing.Size(177, 23);
            this.labelNgayTraXeDK.TabIndex = 21;
            this.labelNgayTraXeDK.Text = "Ngày trả xe dự kiến";
            // 
            // dateTimePickerNgayTraXeDK
            // 
            this.dateTimePickerNgayTraXeDK.Location = new System.Drawing.Point(26, 272);
            this.dateTimePickerNgayTraXeDK.Name = "dateTimePickerNgayTraXeDK";
            this.dateTimePickerNgayTraXeDK.Size = new System.Drawing.Size(232, 22);
            this.dateTimePickerNgayTraXeDK.TabIndex = 20;
            // 
            // labelNgayGuiXe
            // 
            this.labelNgayGuiXe.AutoSize = true;
            this.labelNgayGuiXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayGuiXe.Location = new System.Drawing.Point(24, 195);
            this.labelNgayGuiXe.Name = "labelNgayGuiXe";
            this.labelNgayGuiXe.Size = new System.Drawing.Size(86, 23);
            this.labelNgayGuiXe.TabIndex = 19;
            this.labelNgayGuiXe.Text = "Ngày gửi";
            // 
            // dateTimePickerNgayGui
            // 
            this.dateTimePickerNgayGui.Location = new System.Drawing.Point(26, 221);
            this.dateTimePickerNgayGui.Name = "dateTimePickerNgayGui";
            this.dateTimePickerNgayGui.Size = new System.Drawing.Size(232, 22);
            this.dateTimePickerNgayGui.TabIndex = 18;
            // 
            // labelBienXe
            // 
            this.labelBienXe.AutoSize = true;
            this.labelBienXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienXe.Location = new System.Drawing.Point(542, 504);
            this.labelBienXe.Name = "labelBienXe";
            this.labelBienXe.Size = new System.Drawing.Size(0, 23);
            this.labelBienXe.TabIndex = 16;
            // 
            // pictureBoxHinhXe
            // 
            this.pictureBoxHinhXe.Location = new System.Drawing.Point(441, 42);
            this.pictureBoxHinhXe.Name = "pictureBoxHinhXe";
            this.pictureBoxHinhXe.Size = new System.Drawing.Size(467, 444);
            this.pictureBoxHinhXe.TabIndex = 15;
            this.pictureBoxHinhXe.TabStop = false;
            // 
            // groupBoxLoaiXe
            // 
            this.groupBoxLoaiXe.Controls.Add(this.radioButtonXeHoi);
            this.groupBoxLoaiXe.Controls.Add(this.radioButtonXeMay);
            this.groupBoxLoaiXe.Controls.Add(this.radioButtonXeDap);
            this.groupBoxLoaiXe.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoaiXe.Location = new System.Drawing.Point(28, 38);
            this.groupBoxLoaiXe.Name = "groupBoxLoaiXe";
            this.groupBoxLoaiXe.Size = new System.Drawing.Size(281, 71);
            this.groupBoxLoaiXe.TabIndex = 14;
            this.groupBoxLoaiXe.TabStop = false;
            this.groupBoxLoaiXe.Text = "Loại xe: ";
            // 
            // radioButtonXeHoi
            // 
            this.radioButtonXeHoi.AutoSize = true;
            this.radioButtonXeHoi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXeHoi.Location = new System.Drawing.Point(201, 36);
            this.radioButtonXeHoi.Name = "radioButtonXeHoi";
            this.radioButtonXeHoi.Size = new System.Drawing.Size(70, 21);
            this.radioButtonXeHoi.TabIndex = 2;
            this.radioButtonXeHoi.TabStop = true;
            this.radioButtonXeHoi.Text = "Xe hơi";
            this.radioButtonXeHoi.UseVisualStyleBackColor = true;
            // 
            // radioButtonXeMay
            // 
            this.radioButtonXeMay.AutoSize = true;
            this.radioButtonXeMay.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXeMay.Location = new System.Drawing.Point(101, 36);
            this.radioButtonXeMay.Name = "radioButtonXeMay";
            this.radioButtonXeMay.Size = new System.Drawing.Size(76, 21);
            this.radioButtonXeMay.TabIndex = 1;
            this.radioButtonXeMay.TabStop = true;
            this.radioButtonXeMay.Text = "Xe máy";
            this.radioButtonXeMay.UseVisualStyleBackColor = true;
            // 
            // radioButtonXeDap
            // 
            this.radioButtonXeDap.AutoSize = true;
            this.radioButtonXeDap.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXeDap.Location = new System.Drawing.Point(7, 36);
            this.radioButtonXeDap.Name = "radioButtonXeDap";
            this.radioButtonXeDap.Size = new System.Drawing.Size(71, 21);
            this.radioButtonXeDap.TabIndex = 0;
            this.radioButtonXeDap.TabStop = true;
            this.radioButtonXeDap.Text = "Xe đạp";
            this.radioButtonXeDap.UseVisualStyleBackColor = true;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(24, 12);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(38, 23);
            this.labelID.TabIndex = 29;
            this.labelID.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(69, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 30;
            // 
            // SuaThongTinXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 535);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelPhat);
            this.Controls.Add(this.labelKhachHang);
            this.Controls.Add(this.labelPhi);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNgayTraXe);
            this.Controls.Add(this.dateTimePickerNgayTraXe);
            this.Controls.Add(this.labelNgayTraXeDK);
            this.Controls.Add(this.dateTimePickerNgayTraXeDK);
            this.Controls.Add(this.labelNgayGuiXe);
            this.Controls.Add(this.dateTimePickerNgayGui);
            this.Controls.Add(this.labelBienXe);
            this.Controls.Add(this.pictureBoxHinhXe);
            this.Controls.Add(this.groupBoxLoaiXe);
            this.Name = "SuaThongTinXe";
            this.Text = "SuaThongTinXe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHinhXe)).EndInit();
            this.groupBoxLoaiXe.ResumeLayout(false);
            this.groupBoxLoaiXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPhat;
        private System.Windows.Forms.Label labelKhachHang;
        private System.Windows.Forms.Label labelPhi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonThang;
        private System.Windows.Forms.RadioButton radioButtonTuan;
        private System.Windows.Forms.RadioButton radioButtonNgay;
        private System.Windows.Forms.Label labelNgayTraXe;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTraXe;
        private System.Windows.Forms.Label labelNgayTraXeDK;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTraXeDK;
        private System.Windows.Forms.Label labelNgayGuiXe;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayGui;
        private System.Windows.Forms.Label labelBienXe;
        private System.Windows.Forms.PictureBox pictureBoxHinhXe;
        private System.Windows.Forms.GroupBox groupBoxLoaiXe;
        private System.Windows.Forms.RadioButton radioButtonXeHoi;
        private System.Windows.Forms.RadioButton radioButtonXeMay;
        private System.Windows.Forms.RadioButton radioButtonXeDap;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
    }
}