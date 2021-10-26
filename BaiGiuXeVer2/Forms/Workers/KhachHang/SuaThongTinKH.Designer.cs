
namespace BaiGiuXeVer2.Forms.Workers.KhachHang
{
    partial class SuaThongTinKH
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewKH = new System.Windows.Forms.DataGridView();
            this.labelSoDT = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(110, 382);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(113, 36);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewKH
            // 
            this.dataGridViewKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH.Location = new System.Drawing.Point(450, 45);
            this.dataGridViewKH.Name = "dataGridViewKH";
            this.dataGridViewKH.RowHeadersWidth = 51;
            this.dataGridViewKH.RowTemplate.Height = 24;
            this.dataGridViewKH.Size = new System.Drawing.Size(437, 393);
            this.dataGridViewKH.TabIndex = 20;
            this.dataGridViewKH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKH_CellDoubleClick);
            // 
            // labelSoDT
            // 
            this.labelSoDT.AutoSize = true;
            this.labelSoDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoDT.ForeColor = System.Drawing.Color.White;
            this.labelSoDT.Location = new System.Drawing.Point(95, 320);
            this.labelSoDT.Name = "labelSoDT";
            this.labelSoDT.Size = new System.Drawing.Size(58, 19);
            this.labelSoDT.TabIndex = 19;
            this.labelSoDT.Text = "Số ĐT:";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaChi.ForeColor = System.Drawing.Color.White;
            this.labelDiaChi.Location = new System.Drawing.Point(90, 186);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(68, 19);
            this.labelDiaChi.TabIndex = 18;
            this.labelDiaChi.Text = "Địa chỉ:";
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKH.ForeColor = System.Drawing.Color.White;
            this.labelTenKH.Location = new System.Drawing.Point(28, 134);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(135, 19);
            this.labelTenKH.TabIndex = 17;
            this.labelTenKH.Text = "Tên Khách Hàng:";
            // 
            // labelMaKH
            // 
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaKH.ForeColor = System.Drawing.Color.White;
            this.labelMaKH.Location = new System.Drawing.Point(32, 90);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(132, 19);
            this.labelMaKH.TabIndex = 16;
            this.labelMaKH.Text = "Mã Khách Hàng:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Black;
            this.buttonEdit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(233, 382);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 36);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(185, 320);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(234, 22);
            this.textBoxSDT.TabIndex = 14;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(185, 186);
            this.textBoxDiaChi.Multiline = true;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(234, 114);
            this.textBoxDiaChi.TabIndex = 13;
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Location = new System.Drawing.Point(185, 134);
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(234, 22);
            this.textBoxTenKH.TabIndex = 12;
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(185, 90);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(234, 22);
            this.textBoxMaKH.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // SuaThongTinKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewKH);
            this.Controls.Add(this.labelSoDT);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.labelTenKH);
            this.Controls.Add(this.labelMaKH);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.textBoxTenKH);
            this.Controls.Add(this.textBoxMaKH);
            this.Name = "SuaThongTinKH";
            this.Text = "SuaThongTinKH";
            this.Load += new System.EventHandler(this.SuaThongTinKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewKH;
        private System.Windows.Forms.Label labelSoDT;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.Label label1;
    }
}