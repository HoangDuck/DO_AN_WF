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

namespace BaiGiuXeVer2.Forms.Workers.DoanhThu
{
    public partial class DoanhThu : Form
    {
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from XeDap where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            DataTable data = xe.LayDSXe(sqlCommand);
            int t = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                t += Convert.ToInt32(data.Rows[i].ItemArray[5]) + Convert.ToInt32(data.Rows[i].ItemArray[6]);
            }
            //doanh thu xe may
            sqlCommand = new SqlCommand("Select * from XeMay where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            data = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                t += Convert.ToInt32(data.Rows[i].ItemArray[5]) + Convert.ToInt32(data.Rows[i].ItemArray[6]);
            }
            //doanh thu xe hoi
            sqlCommand = new SqlCommand("Select * from XeHoi where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            data = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                t += Convert.ToInt32(data.Rows[i].ItemArray[5]) + Convert.ToInt32(data.Rows[i].ItemArray[6]);
            }
            textBoxTongDoanhThu.Text = t.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTongHop_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from XeDap where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            DataTable dataXeDap = xe.LayDSXe(sqlCommand);
            int t = 0;
            for (int i = 0; i < dataXeDap.Rows.Count; i++)
            {
                t += Convert.ToInt32(dataXeDap.Rows[i].ItemArray[5]) + Convert.ToInt32(dataXeDap.Rows[i].ItemArray[6]);
            }
            //doanh thu xe may
            sqlCommand = new SqlCommand("Select * from XeMay where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            DataTable dataXeMay = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < dataXeMay.Rows.Count; i++)
            {
                t += Convert.ToInt32(dataXeMay.Rows[i].ItemArray[5]) + Convert.ToInt32(dataXeMay.Rows[i].ItemArray[6]);
            }
            //doanh thu xe hoi
            sqlCommand = new SqlCommand("Select * from XeHoi where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            DataTable dataXeHoi = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < dataXeHoi.Rows.Count; i++)
            {
                t += Convert.ToInt32(dataXeHoi.Rows[i].ItemArray[5]) + Convert.ToInt32(dataXeHoi.Rows[i].ItemArray[6]);
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(t,dataXeDap,dataXeMay,dataXeHoi, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Export_Data_To_Word(int t, DataTable dataXeDap, DataTable dataXeMay, DataTable dataXeHoi, string fileName)
        {
            Microsoft.Office.Interop.Word.Application objWord = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document objDoc = objWord.Documents.Add();
            //tua de bang diem sinh vien
            Microsoft.Office.Interop.Word.Paragraph objPara;
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "TỔNG CHI PHÍ";
            objPara.Range.Font.Name = "Times New Roman";
            objPara.Range.Font.Size = 18;
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objPara.Range.Bold = 1;
            objPara.Range.InsertParagraphAfter();
            //muc Chi phi xe dap
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "Xe đạp";
            objPara.Range.Font.Name = "Times New Roman";
            objPara.Range.Font.Size = 11;
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.Bold = 1;
            objPara.Range.Italic = 1;
            objPara.Range.InsertParagraphAfter();
            for(int i=0;i<dataXeDap.Rows.Count;i++)
            {
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "+ ID: " + Convert.ToInt32(dataXeDap.Rows[0].ItemArray[0].ToString());
                objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                objPara.Range.Bold = 0;
                objPara.Range.Italic = 0;
                objPara.Range.InsertParagraphAfter();
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "Phí: " + Convert.ToInt32(dataXeDap.Rows[0].ItemArray[5].ToString()) + " VND";
                objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                objPara.Range.Bold = 0;
                objPara.Range.Italic = 0;
                objPara.Range.InsertParagraphAfter();
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "Phạt: " + Convert.ToInt32(dataXeDap.Rows[0].ItemArray[6].ToString()) + " VND";
                objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                objPara.Range.Bold = 0;
                objPara.Range.Italic = 0;
                objPara.Range.InsertParagraphAfter();
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "Mã khách hàng: " + Convert.ToInt32(dataXeDap.Rows[0].ItemArray[10].ToString());
                objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                objPara.Range.Bold = 0;
                objPara.Range.Italic = 0;
                objPara.Range.InsertParagraphAfter();
            }    
            //muc Chi phi xe may
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "Xe máy";
            objPara.Range.Font.Name = "Times New Roman";
            objPara.Range.Font.Size = 11;
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.Bold = 1;
            objPara.Range.Italic = 1;
            objPara.Range.InsertParagraphAfter();
            for (int i = 0; i < dataXeMay.Rows.Count; i++)
            {
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "+ ID: " + Convert.ToInt32(dataXeDap.Rows[0].ItemArray[0].ToString());
                objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                objPara.Range.Bold = 0;
                objPara.Range.Italic = 0;
                objPara.Range.InsertParagraphAfter();
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "Phí: " + Convert.ToInt32(dataXeDap.Rows[0].ItemArray[5].ToString()) + " VND";
                objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                objPara.Range.Bold = 0;
                objPara.Range.Italic = 0;
                objPara.Range.InsertParagraphAfter();
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "Phạt: " + Convert.ToInt32(dataXeDap.Rows[0].ItemArray[6].ToString()) + " VND";
                objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                objPara.Range.Bold = 0;
                objPara.Range.Italic = 0;
                objPara.Range.InsertParagraphAfter();
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "Mã khách hàng: " + Convert.ToInt32(dataXeDap.Rows[0].ItemArray[10].ToString());
                objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                objPara.Range.Bold = 0;
                objPara.Range.Italic = 0;
                objPara.Range.InsertParagraphAfter();
            }
            //muc Chi phi xe hoi
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "Xe hơi";
            objPara.Range.Font.Name = "Times New Roman";
            objPara.Range.Font.Size = 11;
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.Bold = 1;
            objPara.Range.Italic = 1;
            objPara.Range.InsertParagraphAfter();
            for (int i = 0; i < dataXeHoi.Rows.Count; i++)
            {
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "+ ID: " + Convert.ToInt32(dataXeDap.Rows[0].ItemArray[0].ToString());
                objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                objPara.Range.Bold = 0;
                objPara.Range.Italic = 0;
                objPara.Range.InsertParagraphAfter();
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "Phí: " + Convert.ToInt32(dataXeDap.Rows[0].ItemArray[5].ToString()) + " VND";
                objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                objPara.Range.Bold = 0;
                objPara.Range.Italic = 0;
                objPara.Range.InsertParagraphAfter();
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "Phạt: " + Convert.ToInt32(dataXeDap.Rows[0].ItemArray[6].ToString()) + " VND";
                objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                objPara.Range.Bold = 0;
                objPara.Range.Italic = 0;
                objPara.Range.InsertParagraphAfter();
                objPara = objDoc.Paragraphs.Add();
                objPara.Range.Text = "Mã khách hàng: " + Convert.ToInt32(dataXeDap.Rows[0].ItemArray[10].ToString());
                objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                objPara.Range.Bold = 0;
                objPara.Range.Italic = 0;
                objPara.Range.InsertParagraphAfter();
            }
            //muc Chi phi xe
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "Tổng chi phí tất cả xe";
            objPara.Range.Font.Name = "Times New Roman";
            objPara.Range.Font.Size = 11;
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.Bold = 1;
            objPara.Range.Italic = 1;
            objPara.Range.InsertParagraphAfter();
            //muc thanh tien
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "Thành tiền: " + t.ToString()+" VND";
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
