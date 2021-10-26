using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Users
{
    public partial class SelectXe : Form
    {
        int userID;
        int idXe;
        bool mode;//true la dich vu cho cty thue xe,false la dich vu muon xe
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        public SelectXe()
        {
            InitializeComponent();
        }
        public SelectXe(bool mode)
        {
            InitializeComponent();
            this.mode = mode;
        }
        public SelectXe(int id)
        {
            InitializeComponent();
            this.userID = id;
        }
        public SelectXe(int id,bool mode)
        {
            InitializeComponent();
            this.userID = id;
            this.mode = mode;
        }
        public int ID
        {
            get { return this.idXe; }
        }
        private void Selection_Load(object sender, EventArgs e)
        {
            dataGridViewDSXe.ReadOnly = true;
            dataGridViewDSXe.AllowUserToAddRows = false;
            if(this.mode)
            {
                //SqlCommand command = new SqlCommand("Select Id,NgayGui,NgayHetHanDK,BienXe,Anh from XeHoi where MaKH=@makh");
                SqlCommand command = new SqlCommand("select Id,NgayGui,NgayHetHanDK,BienXe from DSXE.dbo.XeHoi"+
                " except"+
                " select Id, NgayGui, NgayHetHanDK, BienXe from DSXE.dbo.XeHoi"+
                " inner join"+
                " Works.dbo.HopDong on Id = MaXe"+
                " where DSXE.dbo.XeHoi.MaKH = @makh");
                command.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
                dataGridViewDSXe.DataSource = xe.LayDSXe(command);
            }
            else
            {
                SqlCommand command = new SqlCommand("select Id, NgayGui, NgayHetHanDK, BienXe from DSXE.dbo.XeHoi" +
                " inner join" +
                " Works.dbo.HopDong on Id = MaXe" +
                " inner join" +
                " Works.dbo.ChiTietHD on HopDong.SoHD = ChiTietHD.SoHD" +
                " where IdDV = 1" +
                " except" +
                " select Id, NgayGui, NgayHetHanDK, BienXe from DSXE.dbo.XeHoi" +
                " inner join" +
                " Works.dbo.HopDong on Id = MaXe" +
                " inner join" +
                " Works.dbo.ChiTietHD on HopDong.SoHD = ChiTietHD.SoHD" +
                " where IdDV = 2");
                //command.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
                dataGridViewDSXe.DataSource = xe.LayDSXe(command);
            }   
        }

        private void dataGridViewDSXe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idXe = Convert.ToInt32(dataGridViewDSXe.CurrentRow.Cells[0].Value);
            this.DialogResult = DialogResult.OK;
            Close();
        }

    }
}
