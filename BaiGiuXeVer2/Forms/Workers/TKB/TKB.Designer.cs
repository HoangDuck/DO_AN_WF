
namespace BaiGiuXeVer2.Forms.Workers.TKB
{
    partial class TKB
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
            this.labelTKB = new System.Windows.Forms.Label();
            this.labelCa1 = new System.Windows.Forms.Label();
            this.labelCa2 = new System.Windows.Forms.Label();
            this.labelCa3 = new System.Windows.Forms.Label();
            this.textBoxCa1 = new System.Windows.Forms.TextBox();
            this.textBoxCa2 = new System.Windows.Forms.TextBox();
            this.textBoxCa3 = new System.Windows.Forms.TextBox();
            this.dateTimePickerTKB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelTKB
            // 
            this.labelTKB.AutoSize = true;
            this.labelTKB.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTKB.ForeColor = System.Drawing.Color.White;
            this.labelTKB.Location = new System.Drawing.Point(34, 29);
            this.labelTKB.Name = "labelTKB";
            this.labelTKB.Size = new System.Drawing.Size(317, 43);
            this.labelTKB.TabIndex = 0;
            this.labelTKB.Text = "LỊCH LÀM VIỆC";
            // 
            // labelCa1
            // 
            this.labelCa1.AutoSize = true;
            this.labelCa1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCa1.ForeColor = System.Drawing.Color.White;
            this.labelCa1.Location = new System.Drawing.Point(63, 167);
            this.labelCa1.Name = "labelCa1";
            this.labelCa1.Size = new System.Drawing.Size(71, 26);
            this.labelCa1.TabIndex = 1;
            this.labelCa1.Text = "CA 1:";
            // 
            // labelCa2
            // 
            this.labelCa2.AutoSize = true;
            this.labelCa2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCa2.ForeColor = System.Drawing.Color.White;
            this.labelCa2.Location = new System.Drawing.Point(63, 244);
            this.labelCa2.Name = "labelCa2";
            this.labelCa2.Size = new System.Drawing.Size(71, 26);
            this.labelCa2.TabIndex = 2;
            this.labelCa2.Text = "CA 2:";
            // 
            // labelCa3
            // 
            this.labelCa3.AutoSize = true;
            this.labelCa3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCa3.ForeColor = System.Drawing.Color.White;
            this.labelCa3.Location = new System.Drawing.Point(63, 324);
            this.labelCa3.Name = "labelCa3";
            this.labelCa3.Size = new System.Drawing.Size(71, 26);
            this.labelCa3.TabIndex = 3;
            this.labelCa3.Text = "CA 3:";
            // 
            // textBoxCa1
            // 
            this.textBoxCa1.Location = new System.Drawing.Point(207, 170);
            this.textBoxCa1.Name = "textBoxCa1";
            this.textBoxCa1.ReadOnly = true;
            this.textBoxCa1.Size = new System.Drawing.Size(100, 22);
            this.textBoxCa1.TabIndex = 4;
            this.textBoxCa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCa2
            // 
            this.textBoxCa2.Location = new System.Drawing.Point(207, 244);
            this.textBoxCa2.Name = "textBoxCa2";
            this.textBoxCa2.ReadOnly = true;
            this.textBoxCa2.Size = new System.Drawing.Size(100, 22);
            this.textBoxCa2.TabIndex = 5;
            this.textBoxCa2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCa3
            // 
            this.textBoxCa3.Location = new System.Drawing.Point(207, 324);
            this.textBoxCa3.Name = "textBoxCa3";
            this.textBoxCa3.ReadOnly = true;
            this.textBoxCa3.Size = new System.Drawing.Size(100, 22);
            this.textBoxCa3.TabIndex = 6;
            this.textBoxCa3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePickerTKB
            // 
            this.dateTimePickerTKB.Location = new System.Drawing.Point(42, 104);
            this.dateTimePickerTKB.Name = "dateTimePickerTKB";
            this.dateTimePickerTKB.Size = new System.Drawing.Size(299, 22);
            this.dateTimePickerTKB.TabIndex = 7;
            this.dateTimePickerTKB.ValueChanged += new System.EventHandler(this.dateTimePickerTKB_ValueChanged);
            // 
            // TKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(381, 407);
            this.Controls.Add(this.dateTimePickerTKB);
            this.Controls.Add(this.textBoxCa3);
            this.Controls.Add(this.textBoxCa2);
            this.Controls.Add(this.textBoxCa1);
            this.Controls.Add(this.labelCa3);
            this.Controls.Add(this.labelCa2);
            this.Controls.Add(this.labelCa1);
            this.Controls.Add(this.labelTKB);
            this.Name = "TKB";
            this.Text = "TKB";
            this.Load += new System.EventHandler(this.TKB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTKB;
        private System.Windows.Forms.Label labelCa1;
        private System.Windows.Forms.Label labelCa2;
        private System.Windows.Forms.Label labelCa3;
        private System.Windows.Forms.TextBox textBoxCa1;
        private System.Windows.Forms.TextBox textBoxCa2;
        private System.Windows.Forms.TextBox textBoxCa3;
        private System.Windows.Forms.DateTimePicker dateTimePickerTKB;
    }
}