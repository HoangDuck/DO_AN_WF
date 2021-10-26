using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
namespace BaiGiuXeVer2.Forms.Users
{
    public partial class ThanhToan : Form
    {
        int userID;
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        Classes.HopDong.HopDong hd = new Classes.HopDong.HopDong();
        public ThanhToan()
        {
            InitializeComponent();
        }
        public ThanhToan(int id)
        {
            InitializeComponent();
            this.userID = id;
        }
        private void ThanhToan_Load(object sender, EventArgs e)
        {
            //Chi phi hien tai
            //Chi phi xe dap
            SqlCommand sqlCommand = new SqlCommand("Select * from XeDap where TinhTrangTra=@tinhtrang and MaKH=@makh");
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            System.Data.DataTable thongke = xe.LayDSXe(sqlCommand);
            int t = 0;
            for (int i = 0; i < thongke.Rows.Count; i++)
            {
                t += Convert.ToInt32(thongke.Rows[i].ItemArray[5]) + Convert.ToInt32(thongke.Rows[i].ItemArray[6]);
            }
            textBoxXeDap.Text =t.ToString();
            //Chi phi xe may
            t = 0;
            sqlCommand = new SqlCommand("Select * from XeMay where TinhTrangTra=@tinhtrang and MaKH=@makh");
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            thongke = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < thongke.Rows.Count; i++)
            {
                t += Convert.ToInt32(thongke.Rows[i].ItemArray[5]) + Convert.ToInt32(thongke.Rows[i].ItemArray[6]);
            }
            textBoxXeMay.Text = t.ToString();
            //Chi phi xe hoi
            t = 0;
            sqlCommand = new SqlCommand("Select * from XeHoi where TinhTrangTra=@tinhtrang and MaKH=@makh");
            sqlCommand.Parameters.Add("@makh", SqlDbType.Int).Value = userID;
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            thongke = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < thongke.Rows.Count; i++)
            {
                t += Convert.ToInt32(thongke.Rows[i].ItemArray[5]) + Convert.ToInt32(thongke.Rows[i].ItemArray[6]);
            }
            textBoxXeHoi.Text =t.ToString();
            //chi phi dich vu
            t = 0;
            thongke = hd.LayCPDV(userID);
            for (int i = 0; i < thongke.Rows.Count; i++)
            {
                t += Convert.ToInt32(thongke.Rows[i].ItemArray[0]);
            }
            textBoxCPDV.Text = t.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonHoaDon_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Export_Data_To_Word(string fileName)
        {
            Microsoft.Office.Interop.Word.Application objWord = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document objDoc = objWord.Documents.Add();
            //tua de hoa don thanh toan
            Microsoft.Office.Interop.Word.Paragraph objPara;
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "HÓA ĐƠN THANH TOÁN\n";
            objPara.Range.Font.Name = "Times New Roman";
            objPara.Range.Font.Size = 18;
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objPara.Range.Bold = 1;
            objPara.Range.InsertParagraphAfter();
            //muc chi phi cac xe
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "Chi phí các xe:";
            objPara.Range.Font.Name = "Times New Roman";
            objPara.Range.Font.Size = 11;
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.Bold = 1;
            objPara.Range.Italic = 1;
            objPara.Range.InsertParagraphAfter();
            //muc Xe dap
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "- Xe đạp:" + Convert.ToInt32(textBoxXeDap.Text.ToString().Trim())+" VND" ;
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.Bold = 0;
            objPara.Range.Italic = 0;
            objPara.Range.InsertParagraphAfter();
            //xe may
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "- Xe máy:" + Convert.ToInt32(textBoxXeMay.Text.ToString().Trim()) + " VND";
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.Bold = 0;
            objPara.Range.Italic = 0;
            objPara.Range.InsertParagraphAfter();
            //xe hoi
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "- Xe hơi:" + Convert.ToInt32(textBoxXeHoi.Text.ToString().Trim()) + " VND";
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.Bold = 0;
            objPara.Range.Italic = 0;
            objPara.Range.InsertParagraphAfter();
            
            //muc chi phi dich vu
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "Chi phí dịch vụ";
            objPara.Range.Font.Name = "Times New Roman";
            objPara.Range.Font.Size = 11;
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.Bold = 1;
            objPara.Range.Italic = 1;
            objPara.Range.InsertParagraphAfter();
            //chi phi cho dich vu
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "- Chi phí dịch vụ: " + Convert.ToInt32(textBoxCPDV.Text.ToString().Trim()) + " VND";
            objPara.Range.Font.Name = "Times New Roman";
            objPara.Range.Font.Size = 11;
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.Bold = 0;
            objPara.Range.Italic = 0;
            objPara.Range.InsertParagraphAfter();
            //luu file
            objWord.Visible = true;
            objWord.WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateNormal;
            objDoc.SaveAs(fileName);
        }
    }
}
