
namespace BaiGiuXeVer2.Forms.Users
{
    partial class ThongTinKH
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
            this.labelSdt = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.labelTTKH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSdt
            // 
            this.labelSdt.AutoSize = true;
            this.labelSdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdt.ForeColor = System.Drawing.Color.White;
            this.labelSdt.Location = new System.Drawing.Point(91, 316);
            this.labelSdt.Name = "labelSdt";
            this.labelSdt.Size = new System.Drawing.Size(58, 19);
            this.labelSdt.TabIndex = 30;
            this.labelSdt.Text = "Số ĐT:";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaChi.ForeColor = System.Drawing.Color.White;
            this.labelDiaChi.Location = new System.Drawing.Point(91, 186);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(68, 19);
            this.labelDiaChi.TabIndex = 29;
            this.labelDiaChi.Text = "Địa chỉ:";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.ForeColor = System.Drawing.Color.White;
            this.labelTen.Location = new System.Drawing.Point(24, 135);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(135, 19);
            this.labelTen.TabIndex = 28;
            this.labelTen.Text = "Tên Khách Hàng:";
            // 
            // labelMaKH
            // 
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaKH.ForeColor = System.Drawing.Color.White;
            this.labelMaKH.Location = new System.Drawing.Point(27, 90);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(132, 19);
            this.labelMaKH.TabIndex = 27;
            this.labelMaKH.Text = "Mã Khách Hàng:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Indigo;
            this.buttonEdit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(116, 370);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(192, 37);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(187, 316);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(225, 22);
            this.textBoxSDT.TabIndex = 25;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(187, 186);
            this.textBoxDiaChi.Multiline = true;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(225, 109);
            this.textBoxDiaChi.TabIndex = 24;
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Location = new System.Drawing.Point(187, 134);
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(225, 22);
            this.textBoxTenKH.TabIndex = 23;
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(187, 90);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.ReadOnly = true;
            this.textBoxMaKH.Size = new System.Drawing.Size(225, 22);
            this.textBoxMaKH.TabIndex = 22;
            // 
            // labelTTKH
            // 
            this.labelTTKH.AutoSize = true;
            this.labelTTKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTKH.ForeColor = System.Drawing.Color.White;
            this.labelTTKH.Location = new System.Drawing.Point(95, 30);
            this.labelTTKH.Name = "labelTTKH";
            this.labelTTKH.Size = new System.Drawing.Size(264, 23);
            this.labelTTKH.TabIndex = 32;
            this.labelTTKH.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // ThongTinKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(448, 428);
            this.Controls.Add(this.labelTTKH);
            this.Controls.Add(this.labelSdt);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.labelMaKH);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.textBoxTenKH);
            this.Controls.Add(this.textBoxMaKH);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ThongTinKH";
            this.Text = "ThongTinKH";
            this.Load += new System.EventHandler(this.ThongTinKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSdt;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.Label labelTTKH;
    }
}