
namespace BaiGiuXeVer2.Forms.Users
{
    partial class DichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DichVu));
            this.dataGridViewDSHD = new System.Windows.Forms.DataGridView();
            this.buttonThemHD = new System.Windows.Forms.Button();
            this.labelHopDong = new System.Windows.Forms.Label();
            this.buttonHuyHD = new System.Windows.Forms.Button();
            this.pictureBoxHD = new System.Windows.Forms.PictureBox();
            this.labelChuaCoHD = new System.Windows.Forms.Label();
            this.labelChonHopDong = new System.Windows.Forms.Label();
            this.textBoxMaHDHuyHD = new System.Windows.Forms.TextBox();
            this.buttonOkHuyHD = new System.Windows.Forms.Button();
            this.buttonCancelHuyHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDSHD
            // 
            this.dataGridViewDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSHD.Location = new System.Drawing.Point(189, 13);
            this.dataGridViewDSHD.Name = "dataGridViewDSHD";
            this.dataGridViewDSHD.RowHeadersWidth = 51;
            this.dataGridViewDSHD.RowTemplate.Height = 24;
            this.dataGridViewDSHD.Size = new System.Drawing.Size(599, 425);
            this.dataGridViewDSHD.TabIndex = 0;
            this.dataGridViewDSHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSHD_CellDoubleClick);
            // 
            // buttonThemHD
            // 
            this.buttonThemHD.BackColor = System.Drawing.Color.Yellow;
            this.buttonThemHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemHD.Location = new System.Drawing.Point(12, 57);
            this.buttonThemHD.Name = "buttonThemHD";
            this.buttonThemHD.Size = new System.Drawing.Size(171, 46);
            this.buttonThemHD.TabIndex = 1;
            this.buttonThemHD.Text = "Thêm hợp đồng";
            this.buttonThemHD.UseVisualStyleBackColor = false;
            this.buttonThemHD.Click += new System.EventHandler(this.buttonThemHD_Click);
            // 
            // labelHopDong
            // 
            this.labelHopDong.AutoSize = true;
            this.labelHopDong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHopDong.ForeColor = System.Drawing.Color.White;
            this.labelHopDong.Location = new System.Drawing.Point(27, 13);
            this.labelHopDong.Name = "labelHopDong";
            this.labelHopDong.Size = new System.Drawing.Size(141, 26);
            this.labelHopDong.TabIndex = 4;
            this.labelHopDong.Text = "HỢP ĐỒNG";
            // 
            // buttonHuyHD
            // 
            this.buttonHuyHD.BackColor = System.Drawing.Color.Yellow;
            this.buttonHuyHD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuyHD.Location = new System.Drawing.Point(12, 134);
            this.buttonHuyHD.Name = "buttonHuyHD";
            this.buttonHuyHD.Size = new System.Drawing.Size(171, 46);
            this.buttonHuyHD.TabIndex = 5;
            this.buttonHuyHD.Text = "Hủy hợp đồng";
            this.buttonHuyHD.UseVisualStyleBackColor = false;
            this.buttonHuyHD.Click += new System.EventHandler(this.buttonHuyHD_Click);
            // 
            // pictureBoxHD
            // 
            this.pictureBoxHD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHD.Image")));
            this.pictureBoxHD.Location = new System.Drawing.Point(383, 118);
            this.pictureBoxHD.Name = "pictureBoxHD";
            this.pictureBoxHD.Size = new System.Drawing.Size(213, 181);
            this.pictureBoxHD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHD.TabIndex = 7;
            this.pictureBoxHD.TabStop = false;
            // 
            // labelChuaCoHD
            // 
            this.labelChuaCoHD.AutoSize = true;
            this.labelChuaCoHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChuaCoHD.ForeColor = System.Drawing.Color.White;
            this.labelChuaCoHD.Location = new System.Drawing.Point(228, 324);
            this.labelChuaCoHD.Name = "labelChuaCoHD";
            this.labelChuaCoHD.Size = new System.Drawing.Size(536, 26);
            this.labelChuaCoHD.TabIndex = 8;
            this.labelChuaCoHD.Text = "HMMMMM BẠN CHƯA CÓ HỢP ĐỒNG NÀO!!!";
            // 
            // labelChonHopDong
            // 
            this.labelChonHopDong.AutoSize = true;
            this.labelChonHopDong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChonHopDong.ForeColor = System.Drawing.Color.White;
            this.labelChonHopDong.Location = new System.Drawing.Point(12, 187);
            this.labelChonHopDong.Name = "labelChonHopDong";
            this.labelChonHopDong.Size = new System.Drawing.Size(162, 22);
            this.labelChonHopDong.TabIndex = 9;
            this.labelChonHopDong.Text = "Chọn HD:(mã HD)";
            this.labelChonHopDong.Visible = false;
            // 
            // textBoxMaHDHuyHD
            // 
            this.textBoxMaHDHuyHD.Location = new System.Drawing.Point(12, 224);
            this.textBoxMaHDHuyHD.Name = "textBoxMaHDHuyHD";
            this.textBoxMaHDHuyHD.Size = new System.Drawing.Size(171, 22);
            this.textBoxMaHDHuyHD.TabIndex = 10;
            this.textBoxMaHDHuyHD.Visible = false;
            // 
            // buttonOkHuyHD
            // 
            this.buttonOkHuyHD.BackColor = System.Drawing.Color.Green;
            this.buttonOkHuyHD.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOkHuyHD.ForeColor = System.Drawing.Color.White;
            this.buttonOkHuyHD.Location = new System.Drawing.Point(12, 264);
            this.buttonOkHuyHD.Name = "buttonOkHuyHD";
            this.buttonOkHuyHD.Size = new System.Drawing.Size(75, 25);
            this.buttonOkHuyHD.TabIndex = 11;
            this.buttonOkHuyHD.Text = "OK";
            this.buttonOkHuyHD.UseVisualStyleBackColor = false;
            this.buttonOkHuyHD.Visible = false;
            this.buttonOkHuyHD.Click += new System.EventHandler(this.buttonOkHuyHD_Click);
            // 
            // buttonCancelHuyHD
            // 
            this.buttonCancelHuyHD.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelHuyHD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelHuyHD.ForeColor = System.Drawing.Color.White;
            this.buttonCancelHuyHD.Location = new System.Drawing.Point(93, 264);
            this.buttonCancelHuyHD.Name = "buttonCancelHuyHD";
            this.buttonCancelHuyHD.Size = new System.Drawing.Size(90, 25);
            this.buttonCancelHuyHD.TabIndex = 12;
            this.buttonCancelHuyHD.Text = "Cancel";
            this.buttonCancelHuyHD.UseVisualStyleBackColor = false;
            this.buttonCancelHuyHD.Visible = false;
            this.buttonCancelHuyHD.Click += new System.EventHandler(this.buttonCancelHuyHD_Click);
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelHuyHD);
            this.Controls.Add(this.buttonOkHuyHD);
            this.Controls.Add(this.textBoxMaHDHuyHD);
            this.Controls.Add(this.labelChonHopDong);
            this.Controls.Add(this.labelChuaCoHD);
            this.Controls.Add(this.pictureBoxHD);
            this.Controls.Add(this.buttonHuyHD);
            this.Controls.Add(this.labelHopDong);
            this.Controls.Add(this.buttonThemHD);
            this.Controls.Add(this.dataGridViewDSHD);
            this.Name = "DichVu";
            this.Text = "DichVu";
            this.Load += new System.EventHandler(this.DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDSHD;
        private System.Windows.Forms.Button buttonThemHD;
        private System.Windows.Forms.Label labelHopDong;
        private System.Windows.Forms.Button buttonHuyHD;
        private System.Windows.Forms.PictureBox pictureBoxHD;
        private System.Windows.Forms.Label labelChuaCoHD;
        private System.Windows.Forms.Label labelChonHopDong;
        private System.Windows.Forms.TextBox textBoxMaHDHuyHD;
        private System.Windows.Forms.Button buttonOkHuyHD;
        private System.Windows.Forms.Button buttonCancelHuyHD;
    }
}