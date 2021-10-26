
namespace BaiGiuXeVer2.Forms.Users
{
    partial class SelectXe
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
            this.labelChonXe = new System.Windows.Forms.Label();
            this.dataGridViewDSXe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSXe)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChonXe
            // 
            this.labelChonXe.AutoSize = true;
            this.labelChonXe.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChonXe.Location = new System.Drawing.Point(166, 23);
            this.labelChonXe.Name = "labelChonXe";
            this.labelChonXe.Size = new System.Drawing.Size(451, 38);
            this.labelChonXe.TabIndex = 3;
            this.labelChonXe.Text = "Hãy chọn xe mà bạn muốn";
            // 
            // dataGridViewDSXe
            // 
            this.dataGridViewDSXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSXe.Location = new System.Drawing.Point(12, 81);
            this.dataGridViewDSXe.Name = "dataGridViewDSXe";
            this.dataGridViewDSXe.RowHeadersWidth = 51;
            this.dataGridViewDSXe.RowTemplate.Height = 24;
            this.dataGridViewDSXe.Size = new System.Drawing.Size(776, 357);
            this.dataGridViewDSXe.TabIndex = 2;
            this.dataGridViewDSXe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSXe_CellDoubleClick);
            // 
            // SelectXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelChonXe);
            this.Controls.Add(this.dataGridViewDSXe);
            this.Name = "SelectXe";
            this.Text = "Selection";
            this.Load += new System.EventHandler(this.Selection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChonXe;
        private System.Windows.Forms.DataGridView dataGridViewDSXe;
    }
}