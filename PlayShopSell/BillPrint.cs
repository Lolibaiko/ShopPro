using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayShopSell
{
    public partial class BillPrint : Form
    {
        int idBill;
        DataGridView billGrid;
        double billSum;
        public BillPrint(DataGridView grid , int id, double sum)
        {
            InitializeComponent();
            idBill = id;
            billGrid = grid;
            billSum = sum;
            Print();
        }

        string Correction(string str, int pattern)
        {
            int res = pattern - str.Length;
            for (int i=0; i < res; i++)
            {
                str += " ";
            }
            return str;
        } 

        void Print()
        {
            richTextBox_Print.AppendText(Environment.NewLine + "Рахунок номер: " + idBill.ToString());
            richTextBox_Print.AppendText(Environment.NewLine + "Дата: " + DateTime.Now);
            richTextBox_Print.AppendText(Environment.NewLine + "_______________________________________________________________________________________________");
            richTextBox_Print.AppendText(Environment.NewLine + "|№   |Назва                         |Кількість |До             |Ціна(грн)      |Сума(грн)      |");
            richTextBox_Print.AppendText(Environment.NewLine + "_______________________________________________________________________________________________");
            for (int i = 0; i < billGrid.Rows.Count; i++)
            {
                if (billGrid.Rows[i].Cells[3].Value == null)
                    billGrid.Rows[i].Cells[3].Value = " ";
                else
                {
                    billGrid.Rows[i].Cells[3].Value = String.Format("{0:dd-MM-yyyy}", Convert.ToDateTime(billGrid.Rows[i].Cells[3].Value));
                }
                richTextBox_Print.AppendText(Environment.NewLine + "|" + Correction(billGrid.Rows[i].Cells[0].Value.ToString(), 4) +"|"+
                    Correction(billGrid.Rows[i].Cells[1].Value.ToString(), 30) +"|"+ Correction(billGrid.Rows[i].Cells[2].Value.ToString(), 10) +"|"+
                    Correction(billGrid.Rows[i].Cells[3].Value.ToString(), 15) + "|" + Correction(billGrid.Rows[i].Cells[4].Value.ToString(), 15) + "|" +
                    Correction(billGrid.Rows[i].Cells[5].Value.ToString(), 15) + "|");
                richTextBox_Print.AppendText(Environment.NewLine + "_______________________________________________________________________________________________");
            }
            richTextBox_Print.AppendText(Environment.NewLine + "\nВсього до оплати: " + billSum +"грн.");


            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPrint = new PrintDocument();
            printDialog.Document = documentToPrint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(richTextBox_Print.Text);
                documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
                documentToPrint.Print();
            }

        }
        private void DocumentToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(richTextBox_Print.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string Line = null;
            Font PrintFont = this.richTextBox_Print.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
                Count++;
            }

            if (Line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();
        }
    }
}
