
namespace BaiGiuXeVer2.Forms.Workers
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.menuStripCuaTho = new System.Windows.Forms.MenuStrip();
            this.xEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaThongTinXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeSoXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinKHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngHợpDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giờLàmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tKBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.buttonXoaTK = new System.Windows.Forms.Button();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.groupBoxChart = new System.Windows.Forms.GroupBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerTG = new System.Windows.Forms.Timer(this.components);
            this.buttonDSTGLV = new System.Windows.Forms.Button();
            this.menuStripCuaTho.SuspendLayout();
            this.groupBoxChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripCuaTho
            // 
            this.menuStripCuaTho.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCuaTho.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xEToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.doanhThuToolStripMenuItem,
            this.giờLàmToolStripMenuItem,
            this.thôngTinNhânViênToolStripMenuItem});
            this.menuStripCuaTho.Location = new System.Drawing.Point(0, 0);
            this.menuStripCuaTho.Name = "menuStripCuaTho";
            this.menuStripCuaTho.Size = new System.Drawing.Size(800, 28);
            this.menuStripCuaTho.TabIndex = 0;
            // 
            // xEToolStripMenuItem
            // 
            this.xEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSachXeToolStripMenuItem,
            this.themXeToolStripMenuItem,
            this.traXeToolStripMenuItem,
            this.suaThongTinXeToolStripMenuItem,
            this.thongKeSoXeToolStripMenuItem});
            this.xEToolStripMenuItem.Name = "xEToolStripMenuItem";
            this.xEToolStripMenuItem.Size = new System.Drawing.Size(40, 24);
            this.xEToolStripMenuItem.Text = "Xe";
            // 
            // danhSachXeToolStripMenuItem
            // 
            this.danhSachXeToolStripMenuItem.Name = "danhSachXeToolStripMenuItem";
            this.danhSachXeToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.danhSachXeToolStripMenuItem.Text = "Danh sách xe";
            this.danhSachXeToolStripMenuItem.Click += new System.EventHandler(this.danhSachXeToolStripMenuItem_Click);
            // 
            // themXeToolStripMenuItem
            // 
            this.themXeToolStripMenuItem.Name = "themXeToolStripMenuItem";
            this.themXeToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.themXeToolStripMenuItem.Text = "Thêm xe";
            this.themXeToolStripMenuItem.Click += new System.EventHandler(this.themXeToolStripMenuItem_Click);
            // 
            // traXeToolStripMenuItem
            // 
            this.traXeToolStripMenuItem.Name = "traXeToolStripMenuItem";
            this.traXeToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.traXeToolStripMenuItem.Text = "Trả xe";
            this.traXeToolStripMenuItem.Click += new System.EventHandler(this.traXeToolStripMenuItem_Click);
            // 
            // suaThongTinXeToolStripMenuItem
            // 
            this.suaThongTinXeToolStripMenuItem.Name = "suaThongTinXeToolStripMenuItem";
            this.suaThongTinXeToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.suaThongTinXeToolStripMenuItem.Text = "Sửa thông tin xe";
            this.suaThongTinXeToolStripMenuItem.Click += new System.EventHandler(this.suaThongTinXeToolStripMenuItem_Click);
            // 
            // thongKeSoXeToolStripMenuItem
            // 
            this.thongKeSoXeToolStripMenuItem.Name = "thongKeSoXeToolStripMenuItem";
            this.thongKeSoXeToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.thongKeSoXeToolStripMenuItem.Text = "Thống kê số xe";
            this.thongKeSoXeToolStripMenuItem.Click += new System.EventHandler(this.thongKeSoXeToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchKháchHàngToolStripMenuItem,
            this.sửaThôngTinKHToolStripMenuItem,
            this.thêmKháchHàngToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // danhSáchKháchHàngToolStripMenuItem
            // 
            this.danhSáchKháchHàngToolStripMenuItem.Name = "danhSáchKháchHàngToolStripMenuItem";
            this.danhSáchKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.danhSáchKháchHàngToolStripMenuItem.Text = "Danh sách khách hàng";
            this.danhSáchKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.danhSáchKháchHàngToolStripMenuItem_Click);
            // 
            // sửaThôngTinKHToolStripMenuItem
            // 
            this.sửaThôngTinKHToolStripMenuItem.Name = "sửaThôngTinKHToolStripMenuItem";
            this.sửaThôngTinKHToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.sửaThôngTinKHToolStripMenuItem.Text = "Sửa thông tin KH";
            this.sửaThôngTinKHToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinKHToolStripMenuItem_Click);
            // 
            // thêmKháchHàngToolStripMenuItem
            // 
            this.thêmKháchHàngToolStripMenuItem.Name = "thêmKháchHàngToolStripMenuItem";
            this.thêmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.thêmKháchHàngToolStripMenuItem.Text = "Thêm khách hàng";
            this.thêmKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thêmKháchHàngToolStripMenuItem_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtToolStripMenuItem,
            this.tổngHợpDoanhThuToolStripMenuItem});
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // chiTiếtToolStripMenuItem
            // 
            this.chiTiếtToolStripMenuItem.Name = "chiTiếtToolStripMenuItem";
            this.chiTiếtToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.chiTiếtToolStripMenuItem.Text = "Chi tiết";
            this.chiTiếtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtToolStripMenuItem_Click);
            // 
            // tổngHợpDoanhThuToolStripMenuItem
            // 
            this.tổngHợpDoanhThuToolStripMenuItem.Name = "tổngHợpDoanhThuToolStripMenuItem";
            this.tổngHợpDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.tổngHợpDoanhThuToolStripMenuItem.Text = "Tổng hợp doanh thu";
            this.tổngHợpDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.tổngHợpDoanhThuToolStripMenuItem_Click);
            // 
            // giờLàmToolStripMenuItem
            // 
            this.giờLàmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tKBToolStripMenuItem});
            this.giờLàmToolStripMenuItem.Name = "giờLàmToolStripMenuItem";
            this.giờLàmToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.giờLàmToolStripMenuItem.Text = "Giờ làm";
            // 
            // tKBToolStripMenuItem
            // 
            this.tKBToolStripMenuItem.Name = "tKBToolStripMenuItem";
            this.tKBToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.tKBToolStripMenuItem.Text = "TKB";
            this.tKBToolStripMenuItem.Click += new System.EventHandler(this.tKBToolStripMenuItem_Click);
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            this.thôngTinNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtToolStripMenuItem1});
            this.thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            this.thôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.thôngTinNhânViênToolStripMenuItem.Text = "Thông tin nhân viên";
            // 
            // chiTiếtToolStripMenuItem1
            // 
            this.chiTiếtToolStripMenuItem1.Name = "chiTiếtToolStripMenuItem1";
            this.chiTiếtToolStripMenuItem1.Size = new System.Drawing.Size(139, 26);
            this.chiTiếtToolStripMenuItem1.Text = "Chi tiết";
            this.chiTiếtToolStripMenuItem1.Click += new System.EventHandler(this.chiTiếtToolStripMenuItem1_Click);
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.BackColor = System.Drawing.Color.Red;
            this.buttonDangXuat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangXuat.ForeColor = System.Drawing.Color.White;
            this.buttonDangXuat.Location = new System.Drawing.Point(676, 0);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(123, 27);
            this.buttonDangXuat.TabIndex = 1;
            this.buttonDangXuat.Text = "Đăng xuất";
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // buttonXoaTK
            // 
            this.buttonXoaTK.BackColor = System.Drawing.Color.Red;
            this.buttonXoaTK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaTK.ForeColor = System.Drawing.Color.White;
            this.buttonXoaTK.Location = new System.Drawing.Point(12, 411);
            this.buttonXoaTK.Name = "buttonXoaTK";
            this.buttonXoaTK.Size = new System.Drawing.Size(140, 27);
            this.buttonXoaTK.TabIndex = 2;
            this.buttonXoaTK.Text = "Xóa tài khoản";
            this.buttonXoaTK.UseVisualStyleBackColor = false;
            this.buttonXoaTK.Click += new System.EventHandler(this.buttonXoaTK_Click);
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.Navy;
            this.buttonCheckIn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.ForeColor = System.Drawing.Color.White;
            this.buttonCheckIn.Location = new System.Drawing.Point(12, 42);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(140, 27);
            this.buttonCheckIn.TabIndex = 3;
            this.buttonCheckIn.Text = "CHECK IN";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.BackColor = System.Drawing.Color.Navy;
            this.buttonCheckOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckOut.ForeColor = System.Drawing.Color.White;
            this.buttonCheckOut.Location = new System.Drawing.Point(12, 85);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(140, 27);
            this.buttonCheckOut.TabIndex = 4;
            this.buttonCheckOut.Text = "CHECK OUT";
            this.buttonCheckOut.UseVisualStyleBackColor = false;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // groupBoxChart
            // 
            this.groupBoxChart.Controls.Add(this.labelTime);
            this.groupBoxChart.Location = new System.Drawing.Point(170, 42);
            this.groupBoxChart.Name = "groupBoxChart";
            this.groupBoxChart.Size = new System.Drawing.Size(618, 396);
            this.groupBoxChart.TabIndex = 5;
            this.groupBoxChart.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(196, 159);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(289, 55);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00 AM";
            // 
            // timerTG
            // 
            this.timerTG.Tick += new System.EventHandler(this.timerTG_Tick);
            // 
            // buttonDSTGLV
            // 
            this.buttonDSTGLV.BackColor = System.Drawing.Color.Navy;
            this.buttonDSTGLV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDSTGLV.ForeColor = System.Drawing.Color.White;
            this.buttonDSTGLV.Location = new System.Drawing.Point(12, 130);
            this.buttonDSTGLV.Name = "buttonDSTGLV";
            this.buttonDSTGLV.Size = new System.Drawing.Size(140, 27);
            this.buttonDSTGLV.TabIndex = 30;
            this.buttonDSTGLV.Text = "DSTGLV";
            this.buttonDSTGLV.UseVisualStyleBackColor = false;
            this.buttonDSTGLV.Click += new System.EventHandler(this.buttonDSTGLV_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDSTGLV);
            this.Controls.Add(this.groupBoxChart);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.buttonXoaTK);
            this.Controls.Add(this.buttonDangXuat);
            this.Controls.Add(this.menuStripCuaTho);
            this.MainMenuStrip = this.menuStripCuaTho;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStripCuaTho.ResumeLayout(false);
            this.menuStripCuaTho.PerformLayout();
            this.groupBoxChart.ResumeLayout(false);
            this.groupBoxChart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripCuaTho;
        private System.Windows.Forms.ToolStripMenuItem xEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSachXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaThongTinXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeSoXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinKHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổngHợpDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giờLàmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tKBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtToolStripMenuItem1;
        private System.Windows.Forms.Button buttonDangXuat;
        private System.Windows.Forms.Button buttonXoaTK;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.GroupBox groupBoxChart;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerTG;
        private System.Windows.Forms.Button buttonDSTGLV;
    }
}