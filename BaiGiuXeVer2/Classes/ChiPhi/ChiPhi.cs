using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuXeVer2.Classes.ChiPhi
{
    class ChiPhi
    {
        //fields
        private int tienPhi;
        private int tienPhat;
        private int tongTien;
        //properties
        public int TienPhi
        {
            get { return this.tienPhi; }
            set { this.tienPhi = value; }
        }
        public int TienPhat
        {
            get { return this.tienPhat; }
            set { this.tienPhat = value; }
        }
        public int TongTien
        {
            get { return this.tongTien; }
            set { this.tongTien = value; }
        }
        //constructors
        public ChiPhi(string loaiXe)
        {
            if(loaiXe=="Xe dap")
            {
                this.tienPhi = 3000;
            }
            if(loaiXe=="Xe may")
            {
                this.tienPhi = 5000;
            }
            if(loaiXe=="Xe hoi")
            {
                this.tienPhi = 20000;
            }
        }
        //methods
        public void TinhTienPhi(String hinhThucGui)
        {
            if (hinhThucGui == "Ngay")
            {
                this.tienPhi = this.tienPhi * 8;
            }
            if (hinhThucGui == "Tuan")
            {
                this.tienPhi = this.tienPhi * 24;
            }
            if(hinhThucGui=="Thang")
            {
                this.tienPhi = this.tienPhi * 48;
            }
        }
        public void TinhTienPhat(String hinhThucGui)
        {
            if (hinhThucGui.Trim() == "Ngay")
            {
                this.tienPhat = this.tienPhi * 3;
            }
            if (hinhThucGui.Trim() == "Tuan")
            {
                this.tienPhat = this.tienPhi * 2;
            }
            if (hinhThucGui.Trim() == "Thang")
            {
                this.tienPhat = this.tienPhi * 4;
            }
        }
    }
}
