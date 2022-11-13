using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeoju_First_High_School_Book_Search
{
    public partial class mainForm : UserControl
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        Color banner_color = Program.banner_color;
        Color page_bar_color = Program.page_bar_color;
        Color page_side_bar_color = Program.page_side_bar_color;
        Color page_text_color = Program.page_text_color;
        Color background_color = Program.background_color;
        string theme_color = Program.theme_color;

        string jsonFilePath = Program.jsonFilePath;

        public void Theme()
        {
            if (theme_color == "dark")
            {

            }
            else
            {

            }

            label1.ForeColor = page_text_color;

            richTextBox1.ForeColor = page_text_color;
            richTextBox2.ForeColor = page_text_color;

            richTextBox1.BackColor = page_bar_color;
            richTextBox2.BackColor = page_bar_color;
            panel1.BackColor = page_bar_color;


            // 배경
            this.BackColor = background_color;
        }

        private void TextBoxGotFocus(object sender, EventArgs args)
        {
            HideCaret(richTextBox1.Handle);
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Theme();
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void richTextBox2_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }
    }
}
