
namespace BaiGiuXeVer2.Forms.Workers.Xe
{
    partial class DanhSachXe
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
            this.dataGridViewDSXe = new System.Windows.Forms.DataGridView();
            this.radioButtonXeDap = new System.Windows.Forms.RadioButton();
            this.radioButtonXeMay = new System.Windows.Forms.RadioButton();
            this.radioButtonXeHoi = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDSXe
            // 
            this.dataGridViewDSXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSXe.Location = new System.Drawing.Point(13, 40);
            this.dataGridViewDSXe.Name = "dataGridViewDSXe";
            this.dataGridViewDSXe.RowHeadersWidth = 51;
            this.dataGridViewDSXe.RowTemplate.Height = 24;
            this.dataGridViewDSXe.Size = new System.Drawing.Size(1030, 520);
            this.dataGridViewDSXe.TabIndex = 0;
            this.dataGridViewDSXe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSXe_CellDoubleClick);
            // 
            // radioButtonXeDap
            // 
            this.radioButtonXeDap.AutoSize = true;
            this.radioButtonXeDap.Checked = true;
            this.radioButtonXeDap.Location = new System.Drawing.Point(12, 11);
            this.radioButtonXeDap.Name = "radioButtonXeDap";
            this.radioButtonXeDap.Size = new System.Drawing.Size(74, 21);
            this.radioButtonXeDap.TabIndex = 1;
            this.radioButtonXeDap.TabStop = true;
            this.radioButtonXeDap.Text = "Xe đạp";
            this.radioButtonXeDap.UseVisualStyleBackColor = true;
            this.radioButtonXeDap.CheckedChanged += new System.EventHandler(this.radioButtonXeDap_CheckedChanged);
            // 
            // radioButtonXeMay
            // 
            this.radioButtonXeMay.AutoSize = true;
            this.radioButtonXeMay.Location = new System.Drawing.Point(92, 11);
            this.radioButtonXeMay.Name = "radioButtonXeMay";
            this.radioButtonXeMay.Size = new System.Drawing.Size(76, 21);
            this.radioButtonXeMay.TabIndex = 2;
            this.radioButtonXeMay.Text = "Xe máy";
            this.radioButtonXeMay.UseVisualStyleBackColor = true;
            this.radioButtonXeMay.CheckedChanged += new System.EventHandler(this.radioButtonXeMay_CheckedChanged);
            // 
            // radioButtonXeHoi
            // 
            this.radioButtonXeHoi.AutoSize = true;
            this.radioButtonXeHoi.Location = new System.Drawing.Point(174, 11);
            this.radioButtonXeHoi.Name = "radioButtonXeHoi";
            this.radioButtonXeHoi.Size = new System.Drawing.Size(69, 21);
            this.radioButtonXeHoi.TabIndex = 3;
            this.radioButtonXeHoi.Text = "Xe hơi";
            this.radioButtonXeHoi.UseVisualStyleBackColor = true;
            this.radioButtonXeHoi.CheckedChanged += new System.EventHandler(this.radioButtonXeHoi_CheckedChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(622, 11);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(302, 22);
            this.textBoxSearch.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(930, 11);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(113, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // DanhSachXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 572);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.radioButtonXeHoi);
            this.Controls.Add(this.radioButtonXeMay);
            this.Controls.Add(this.radioButtonXeDap);
            this.Controls.Add(this.dataGridViewDSXe);
            this.Name = "DanhSachXe";
            this.Text = "DanhSachXe";
            this.Load += new System.EventHandler(this.DanhSachXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDSXe;
        private System.Windows.Forms.RadioButton radioButtonXeDap;
        private System.Windows.Forms.RadioButton radioButtonXeMay;
        private System.Windows.Forms.RadioButton radioButtonXeHoi;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}