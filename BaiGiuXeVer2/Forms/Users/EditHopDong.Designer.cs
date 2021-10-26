namespace BaiGiuXeVer2
{
    partial class EditHopDong
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dataGridViewHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerKi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHet = new System.Windows.Forms.DateTimePicker();
            this.textBoxHD = new System.Windows.Forms.TextBox();
            this.textBoxXe = new System.Windows.Forms.TextBox();
            this.textBoxKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(30, 389);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 68);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Yellow;
            this.buttonEdit.Location = new System.Drawing.Point(232, 389);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(119, 68);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridViewHD
            // 
            this.dataGridViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHD.Location = new System.Drawing.Point(405, 73);
            this.dataGridViewHD.Name = "dataGridViewHD";
            this.dataGridViewHD.RowHeadersWidth = 51;
            this.dataGridViewHD.RowTemplate.Height = 24;
            this.dataGridViewHD.Size = new System.Drawing.Size(374, 384);
            this.dataGridViewHD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Hợp Đồng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày Kí:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã xe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã Khách hàng:";
            // 
            // dateTimePickerKi
            // 
            this.dateTimePickerKi.Location = new System.Drawing.Point(144, 152);
            this.dateTimePickerKi.Name = "dateTimePickerKi";
            this.dateTimePickerKi.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerKi.TabIndex = 8;
            // 
            // dateTimePickerHet
            // 
            this.dateTimePickerHet.Location = new System.Drawing.Point(144, 216);
            this.dateTimePickerHet.Name = "dateTimePickerHet";
            this.dateTimePickerHet.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerHet.TabIndex = 9;
            // 
            // textBoxHD
            // 
            this.textBoxHD.Location = new System.Drawing.Point(144, 94);
            this.textBoxHD.Name = "textBoxHD";
            this.textBoxHD.Size = new System.Drawing.Size(158, 22);
            this.textBoxHD.TabIndex = 10;
            // 
            // textBoxXe
            // 
            this.textBoxXe.Location = new System.Drawing.Point(144, 270);
            this.textBoxXe.Name = "textBoxXe";
            this.textBoxXe.Size = new System.Drawing.Size(158, 22);
            this.textBoxXe.TabIndex = 11;
            // 
            // textBoxKH
            // 
            this.textBoxKH.Location = new System.Drawing.Point(144, 331);
            this.textBoxKH.Name = "textBoxKH";
            this.textBoxKH.Size = new System.Drawing.Size(158, 22);
            this.textBoxKH.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 34);
            this.label6.TabIndex = 13;
            this.label6.Text = "Edit Contract";
            // 
            // EditHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxKH);
            this.Controls.Add(this.textBoxXe);
            this.Controls.Add(this.textBoxHD);
            this.Controls.Add(this.dateTimePickerHet);
            this.Controls.Add(this.dateTimePickerKi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewHD);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Name = "EditHopDong";
            this.Text = "EditHopDong";
            this.Load += new System.EventHandler(this.EditHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridViewHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerKi;
        private System.Windows.Forms.DateTimePicker dateTimePickerHet;
        private System.Windows.Forms.TextBox textBoxHD;
        private System.Windows.Forms.TextBox textBoxXe;
        private System.Windows.Forms.TextBox textBoxKH;
        private System.Windows.Forms.Label label6;
    }
}