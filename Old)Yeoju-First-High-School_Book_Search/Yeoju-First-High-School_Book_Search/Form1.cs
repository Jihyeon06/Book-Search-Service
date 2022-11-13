using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yeoju_First_High_School_Book_Search.Properties;

namespace Yeoju_First_High_School_Book_Search
{
    public partial class Form1 : Form
    {
        Color banner_color = Program.banner_color;
        Color page_bar_color = Program.page_bar_color;
        Color page_side_bar_color = Program.page_side_bar_color;
        Color page_text_color = Program.page_text_color;
        Color background_color = Program.background_color;
        string theme_color = Program.theme_color;

        string jsonFilePath = Program.jsonFilePath;

        public static Form1 f;

        public static void test()
        {
            Form1.f.administrator_only_page1.BringToFront();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public void Theme()
        {
            /*
            if (theme_color == "dark")
            {
                button1.Image = Resources.white_home;
                button2.Image = Resources.white_book;
                button3.Image = Resources.white_lock;
            }
            else
            {
                button1.Image = Resources.black_home;
                button2.Image = Resources.black_book;
                button3.Image = Resources.black_lock;
            }
            */

            panel2.BackColor = banner_color;
            SidePanel.BackColor = page_side_bar_color;
            panel1.BackColor = page_bar_color;

            // 버튼
            button1.ForeColor = page_text_color;
            button2.ForeColor = page_text_color;
            button3.ForeColor = page_text_color;

            // 배경
            this.BackColor = background_color;
        }

        public Form1()
        {
            InitializeComponent();

            mainForm1.BringToFront();
            f = this;

            Theme();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = false; // 나중에 true 로 바꿀것

            //comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            mainForm1.BringToFront();
            this.Alert("됬따!", Form_Alert.enmType.Success);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            book_search_page1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            login_page1.BringToFront();
        }

        private void mainForm1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
