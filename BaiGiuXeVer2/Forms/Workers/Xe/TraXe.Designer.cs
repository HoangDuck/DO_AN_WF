
namespace BaiGiuXeVer2.Forms.Workers.Xe
{
    partial class TraXe
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelChonIDXe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonXeHoi = new System.Windows.Forms.RadioButton();
            this.radioButtonXeMay = new System.Windows.Forms.RadioButton();
            this.radioButtonXeDap = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(69, 220);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(16, 192);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(195, 22);
            this.textBoxID.TabIndex = 6;
            // 
            // labelChonIDXe
            // 
            this.labelChonIDXe.AutoSize = true;
            this.labelChonIDXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChonIDXe.Location = new System.Drawing.Point(12, 165);
            this.labelChonIDXe.Name = "labelChonIDXe";
            this.labelChonIDXe.Size = new System.Drawing.Size(87, 23);
            this.labelChonIDXe.TabIndex = 5;
            this.labelChonIDXe.Text = "Chọn ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonXeHoi);
            this.groupBox1.Controls.Add(this.radioButtonXeMay);
            this.groupBox1.Controls.Add(this.radioButtonXeDap);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại xe";
            // 
            // radioButtonXeHoi
            // 
            this.radioButtonXeHoi.AutoSize = true;
            this.radioButtonXeHoi.Location = new System.Drawing.Point(19, 98);
            this.radioButtonXeHoi.Name = "radioButtonXeHoi";
            this.radioButtonXeHoi.Size = new System.Drawing.Size(85, 27);
            this.radioButtonXeHoi.TabIndex = 2;
            this.radioButtonXeHoi.TabStop = true;
            this.radioButtonXeHoi.Text = "Xe hơi";
            this.radioButtonXeHoi.UseVisualStyleBackColor = true;
            // 
            // radioButtonXeMay
            // 
            this.radioButtonXeMay.AutoSize = true;
            this.radioButtonXeMay.Location = new System.Drawing.Point(19, 64);
            this.radioButtonXeMay.Name = "radioButtonXeMay";
            this.radioButtonXeMay.Size = new System.Drawing.Size(94, 27);
            this.radioButtonXeMay.TabIndex = 1;
            this.radioButtonXeMay.TabStop = true;
            this.radioButtonXeMay.Text = "Xe máy";
            this.radioButtonXeMay.UseVisualStyleBackColor = true;
            // 
            // radioButtonXeDap
            // 
            this.radioButtonXeDap.AutoSize = true;
            this.radioButtonXeDap.Checked = true;
            this.radioButtonXeDap.Location = new System.Drawing.Point(19, 30);
            this.radioButtonXeDap.Name = "radioButtonXeDap";
            this.radioButtonXeDap.Size = new System.Drawing.Size(89, 27);
            this.radioButtonXeDap.TabIndex = 0;
            this.radioButtonXeDap.TabStop = true;
            this.radioButtonXeDap.Text = "Xe đạp";
            this.radioButtonXeDap.UseVisualStyleBackColor = true;
            // 
            // TraXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 264);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelChonIDXe);
            this.Controls.Add(this.groupBox1);
            this.Name = "TraXe";
            this.Text = "TraXe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelChonIDXe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonXeHoi;
        private System.Windows.Forms.RadioButton radioButtonXeMay;
        private System.Windows.Forms.RadioButton radioButtonXeDap;
    }
}