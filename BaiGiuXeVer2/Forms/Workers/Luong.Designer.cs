
namespace BaiGiuXeVer2.Forms.Workers
{
    partial class Luong
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
            this.dataGridViewTinhCong = new System.Windows.Forms.DataGridView();
            this.labelLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTinhCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTinhCong
            // 
            this.dataGridViewTinhCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTinhCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTinhCong.Location = new System.Drawing.Point(13, 52);
            this.dataGridViewTinhCong.Name = "dataGridViewTinhCong";
            this.dataGridViewTinhCong.RowHeadersWidth = 51;
            this.dataGridViewTinhCong.RowTemplate.Height = 24;
            this.dataGridViewTinhCong.Size = new System.Drawing.Size(775, 386);
            this.dataGridViewTinhCong.TabIndex = 0;
            // 
            // labelLuong
            // 
            this.labelLuong.AutoSize = true;
            this.labelLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLuong.ForeColor = System.Drawing.Color.Black;
            this.labelLuong.Location = new System.Drawing.Point(484, 18);
            this.labelLuong.Name = "labelLuong";
            this.labelLuong.Size = new System.Drawing.Size(103, 23);
            this.labelLuong.TabIndex = 31;
            this.labelLuong.Text = "labelLuong";
            this.labelLuong.Visible = false;
            // 
            // Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLuong);
            this.Controls.Add(this.dataGridViewTinhCong);
            this.Name = "Luong";
            this.Text = "Luong";
            this.Load += new System.EventHandler(this.Luong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTinhCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTinhCong;
        private System.Windows.Forms.Label labelLuong;
    }
}