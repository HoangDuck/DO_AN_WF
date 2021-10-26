
namespace BaiGiuXeVer2.Forms.Workers.DoanhThu
{
    partial class DoanhThu
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
            this.labelPhi = new System.Windows.Forms.Label();
            this.buttonTongHop = new System.Windows.Forms.Button();
            this.textBoxTongDoanhThu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(119, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 75);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPhi
            // 
            this.labelPhi.AutoSize = true;
            this.labelPhi.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhi.Location = new System.Drawing.Point(191, 54);
            this.labelPhi.Name = "labelPhi";
            this.labelPhi.Size = new System.Drawing.Size(393, 45);
            this.labelPhi.TabIndex = 2;
            this.labelPhi.Text = "TỔNG DOANH THU";
            // 
            // buttonTongHop
            // 
            this.buttonTongHop.BackColor = System.Drawing.Color.Lime;
            this.buttonTongHop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTongHop.ForeColor = System.Drawing.Color.White;
            this.buttonTongHop.Location = new System.Drawing.Point(474, 326);
            this.buttonTongHop.Name = "buttonTongHop";
            this.buttonTongHop.Size = new System.Drawing.Size(150, 75);
            this.buttonTongHop.TabIndex = 4;
            this.buttonTongHop.Text = "Tổng hợp";
            this.buttonTongHop.UseVisualStyleBackColor = false;
            this.buttonTongHop.Click += new System.EventHandler(this.buttonTongHop_Click);
            // 
            // textBoxTongDoanhThu
            // 
            this.textBoxTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongDoanhThu.Location = new System.Drawing.Point(184, 192);
            this.textBoxTongDoanhThu.Multiline = true;
            this.textBoxTongDoanhThu.Name = "textBoxTongDoanhThu";
            this.textBoxTongDoanhThu.ReadOnly = true;
            this.textBoxTongDoanhThu.Size = new System.Drawing.Size(400, 62);
            this.textBoxTongDoanhThu.TabIndex = 5;
            this.textBoxTongDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTongDoanhThu);
            this.Controls.Add(this.buttonTongHop);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelPhi);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPhi;
        private System.Windows.Forms.Button buttonTongHop;
        private System.Windows.Forms.TextBox textBoxTongDoanhThu;
    }
}