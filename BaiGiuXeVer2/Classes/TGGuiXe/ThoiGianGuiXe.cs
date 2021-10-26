using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuXeVer2.Classes.TGGuiXe
{
    class ThoiGianGuiXe
    {
        //fields
        private DateTime ngayGui;
        private DateTime ngayPhaiTraXeDK;
        private DateTime ngayTraXeThucTe;
        private bool tre = false;//false la khong tre; true la tre 
        //properties
        public DateTime NgayGui
        {
            get { return this.ngayGui; }
            set { this.ngayGui = value; }
        }
        public DateTime NgayPhaiTraXeDK
        {
            get { return this.ngayPhaiTraXeDK; }
            set { this.ngayPhaiTraXeDK = value; }
        }
        public DateTime NgayTraXeThucTe
        {
            get { return this.ngayTraXeThucTe; }
            set { this.ngayTraXeThucTe = value; }
        }
        public bool Tre
        {
            get { return this.tre; }
            set { this.tre = value; }
        }
        //constructor
        public ThoiGianGuiXe(DateTime ngayGui)
        {
            this.ngayGui = ngayGui;
        }
        //methods
        public void TinhNgayTraXeDK(String hinhThucGui)
        {
            this.ngayPhaiTraXeDK=new DateTime();
            if (hinhThucGui.Trim() == "Ngay")
            {
                this.ngayPhaiTraXeDK = this.ngayGui.AddDays(1);
            }
            if (hinhThucGui.Trim() == "Tuan")
            {
                this.ngayPhaiTraXeDK = this.ngayGui.AddDays(7);
            }
            if(hinhThucGui.Trim()=="Thang")
            {
                this.ngayPhaiTraXeDK = this.ngayGui.AddDays(31);
            }
        }
        public void TraXe(DateTime ngayTraXe)
        {
            this.ngayTraXeThucTe = ngayTraXe;
            if(KTTraXeTre(this.ngayTraXeThucTe,this.ngayPhaiTraXeDK))
            {
                this.tre = true;
            }
            else
            {
                this.tre = false;
            }
        }
        private bool KTTraXeTre(DateTime ngayTraXeThucTe,DateTime ngayTraXeDK)
        {
            if (ngayTraXeThucTe <= ngayTraXeDK)
                return false;
            else
                return true;
        }
    }
}
