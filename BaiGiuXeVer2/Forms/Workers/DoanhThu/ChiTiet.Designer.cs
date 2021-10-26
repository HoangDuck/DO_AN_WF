
namespace BaiGiuXeVer2.Forms.Workers.DoanhThu
{
    partial class ChiTiet
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelXeDap = new System.Windows.Forms.Label();
            this.labelXeMay = new System.Windows.Forms.Label();
            this.labelXeHoi = new System.Windows.Forms.Label();
            this.textBoxXeDap = new System.Windows.Forms.TextBox();
            this.textBoxXeMay = new System.Windows.Forms.TextBox();
            this.textBoxXeHoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(352, 345);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 35);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(230, 40);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(324, 37);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "TỔNG DOANH THU";
            // 
            // labelXeDap
            // 
            this.labelXeDap.AutoSize = true;
            this.labelXeDap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXeDap.Location = new System.Drawing.Point(46, 122);
            this.labelXeDap.Name = "labelXeDap";
            this.labelXeDap.Size = new System.Drawing.Size(326, 26);
            this.labelXeDap.TabIndex = 7;
            this.labelXeDap.Text = "TỔNG DOANH THU XE ĐẠP";
            // 
            // labelXeMay
            // 
            this.labelXeMay.AutoSize = true;
            this.labelXeMay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXeMay.Location = new System.Drawing.Point(38, 192);
            this.labelXeMay.Name = "labelXeMay";
            this.labelXeMay.Size = new System.Drawing.Size(334, 26);
            this.labelXeMay.TabIndex = 8;
            this.labelXeMay.Text = "TỔNG DOANH THU XE MÁY";
            // 
            // labelXeHoi
            // 
            this.labelXeHoi.AutoSize = true;
            this.labelXeHoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXeHoi.Location = new System.Drawing.Point(48, 265);
            this.labelXeHoi.Name = "labelXeHoi";
            this.labelXeHoi.Size = new System.Drawing.Size(324, 26);
            this.labelXeHoi.TabIndex = 9;
            this.labelXeHoi.Text = "TỔNG DOANH THU XE HƠI";
            // 
            // textBoxXeDap
            // 
            this.textBoxXeDap.Location = new System.Drawing.Point(415, 125);
            this.textBoxXeDap.Name = "textBoxXeDap";
            this.textBoxXeDap.ReadOnly = true;
            this.textBoxXeDap.Size = new System.Drawing.Size(222, 22);
            this.textBoxXeDap.TabIndex = 10;
            // 
            // textBoxXeMay
            // 
            this.textBoxXeMay.Location = new System.Drawing.Point(415, 192);
            this.textBoxXeMay.Name = "textBoxXeMay";
            this.textBoxXeMay.ReadOnly = true;
            this.textBoxXeMay.Size = new System.Drawing.Size(222, 22);
            this.textBoxXeMay.TabIndex = 11;
            // 
            // textBoxXeHoi
            // 
            this.textBoxXeHoi.Location = new System.Drawing.Point(415, 265);
            this.textBoxXeHoi.Name = "textBoxXeHoi";
            this.textBoxXeHoi.ReadOnly = true;
            this.textBoxXeHoi.Size = new System.Drawing.Size(222, 22);
            this.textBoxXeHoi.TabIndex = 12;
            // 
            // ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.textBoxXeHoi);
            this.Controls.Add(this.textBoxXeMay);
            this.Controls.Add(this.textBoxXeDap);
            this.Controls.Add(this.labelXeHoi);
            this.Controls.Add(this.labelXeMay);
            this.Controls.Add(this.labelXeDap);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelTotal);
            this.Name = "ChiTiet";
            this.Text = "ChiTiet";
            this.Load += new System.EventHandler(this.ChiTiet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelXeDap;
        private System.Windows.Forms.Label labelXeMay;
        private System.Windows.Forms.Label labelXeHoi;
        private System.Windows.Forms.TextBox textBoxXeDap;
        private System.Windows.Forms.TextBox textBoxXeMay;
        private System.Windows.Forms.TextBox textBoxXeHoi;
    }
}