using System;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;
using Yeoju_First_High_School_Book_Search.Properties;

namespace Yeoju_First_High_School_Book_Search
{
    public partial class Book_search_page : UserControl
    {
        Color banner_color = Program.banner_color;
        Color page_bar_color = Program.page_bar_color;
        Color page_side_bar_color = Program.page_side_bar_color;
        Color page_text_color = Program.page_text_color;
        Color background_color = Program.background_color;
        string theme_color = Program.theme_color;

        public void Theme()
        {
            if (theme_color == "dark")
            {
                button1.Image = Resources.white_home;
            }
            else
            {
                button1.Image = Resources.black_home;
            }

            label1.ForeColor = page_text_color;

            button1.ForeColor = page_text_color;
            textBox1.ForeColor = page_text_color;
            listBox1.ForeColor = page_text_color;
            comboBox1.ForeColor = page_text_color;

            button1.BackColor = page_bar_color;
            textBox1.BackColor = page_bar_color;
            listBox1.BackColor = page_bar_color;
            comboBox1.BackColor = page_bar_color;

            // 배경
            this.BackColor = background_color;
        }

        string Book_data = "";
        string[] books;

        public Book_search_page()
        {
            InitializeComponent();
        }

        private void Book_search_page_Load(object sender, EventArgs e)
        {
            Theme();

            comboBox1.SelectedIndex = 0;

            var workbook = new XLWorkbook(@"C:\Users\user\Desktop\Book Search Service\Book_list.xlsm");  // 기존 엑셀 열기
            var worksheet = workbook.Worksheet(1);  // 첫번째 sheet열기

            foreach (IXLRow row in worksheet.Rows())
            {
                Book_data += row.Cell(1).Value + "\n";
            }

            books = Book_data.Split('\n');

            foreach (var book in books)
            {
                listBox1.Items.Add(book);
            }
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
