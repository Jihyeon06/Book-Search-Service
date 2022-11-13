namespace Yeoju_Frist_High_School_Library_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainPage_button_Click(object sender, EventArgs e)
        {
            SideSelect_panel.Height = MainPage_button.Height;
            SideSelect_panel.Top = MainPage_button.Top;
            mainForm1.BringToFront();
        }

        private void BookSearchPage_button_Click(object sender, EventArgs e)
        {
            SideSelect_panel.Height = BookSearchPage_button.Height;
            SideSelect_panel.Top = BookSearchPage_button.Top;
            book_search_page1.BringToFront();
        }

        private void ManagerOnlyPage_button_Click(object sender, EventArgs e)
        {
            SideSelect_panel.Height = ManagerOnlyPage_button.Height;
            SideSelect_panel.Top = ManagerOnlyPage_button.Top;
            login_page1.BringToFront();
        }
    }
}