using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeoju_First_High_School_Book_Search
{
    public partial class Login_page : UserControl
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var workbook = new XLWorkbook(@"C:\Users\gk304\Desktop\library\Book list.xlsx");  // 기존 엑셀 열기
            var worksheet = workbook.Worksheet(1);  // 첫번째 sheet열기
            var Title_data = "";

            foreach (IXLRow row in worksheet.Rows())
            {
                Title_data += "=========================\n" + row.Cell(1).Value + "\n" + row.Cell(2).Value + "\n" + row.Cell(3).Value + "\n" + row.Cell(4).Value + "\n" + row.Cell(5).Value + "\n=========================\n";
            }
            richTextBox1.Text += Title_data;

            Form1.test();
        }

        private void Login_page_Load(object sender, EventArgs e)
        {

        }
    }
}
