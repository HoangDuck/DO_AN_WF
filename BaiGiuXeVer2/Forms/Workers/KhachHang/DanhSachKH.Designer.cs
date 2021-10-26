
namespace BaiGiuXeVer2.Forms.Workers.KhachHang
{
    partial class DanhSachKH
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelDSKH = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewKH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(501, 414);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(206, 22);
            this.textBoxSearch.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(713, 414);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelDSKH
            // 
            this.labelDSKH.AutoSize = true;
            this.labelDSKH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDSKH.ForeColor = System.Drawing.Color.White;
            this.labelDSKH.Location = new System.Drawing.Point(195, 22);
            this.labelDSKH.Name = "labelDSKH";
            this.labelDSKH.Size = new System.Drawing.Size(387, 32);
            this.labelDSKH.TabIndex = 7;
            this.labelDSKH.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(12, 406);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(153, 34);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // dataGridViewKH
            // 
            this.dataGridViewKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewKH.Name = "dataGridViewKH";
            this.dataGridViewKH.RowHeadersWidth = 51;
            this.dataGridViewKH.RowTemplate.Height = 24;
            this.dataGridViewKH.Size = new System.Drawing.Size(776, 332);
            this.dataGridViewKH.TabIndex = 5;
            this.dataGridViewKH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKH_CellDoubleClick);
            // 
            // DanhSachKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelDSKH);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridViewKH);
            this.Name = "DanhSachKH";
            this.Text = "DanhSachKH";
            this.Load += new System.EventHandler(this.DanhSachKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelDSKH;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewKH;
    }
}