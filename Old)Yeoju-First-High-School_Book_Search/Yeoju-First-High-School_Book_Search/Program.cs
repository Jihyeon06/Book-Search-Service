using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeoju_First_High_School_Book_Search
{
    internal static class Program
    {
        public static Color banner_color = Color.FromArgb(17, 17, 17);
        public static Color page_bar_color = Color.FromArgb(24, 24, 24);
        public static Color page_side_bar_color = Color.FromArgb(69, 65, 209);
        public static Color page_text_color = Color.Lavender;
        public static Color background_color = Color.FromArgb(34, 34, 34);
        public static string theme_color = "dark";
        public static string jsonFilePath = @"C:\Users\user\Desktop\Book Search Service\setting.json";

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            theme();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoadingScreen());
        }

        public static void theme()
        {
            MessageBox.Show("TEST");
            string json = File.ReadAllText(jsonFilePath);
            JObject jsonDoc = JObject.Parse(json);

            theme_color = jsonDoc["theme_color"].ToString();

            if (theme_color == "dark")
            {
                banner_color = Color.FromArgb(17, 17, 17);
                page_bar_color = Color.FromArgb(24, 24, 24);
                page_side_bar_color = Color.FromArgb(69, 65, 209);
                page_text_color = Color.Lavender;
                background_color = Color.FromArgb(34, 34, 34);
            }
            else if (theme_color == "brown")
            {
                banner_color = Color.FromArgb(145, 85, 73);
                page_bar_color = Color.FromArgb(187, 147, 126);
                page_side_bar_color = Color.FromArgb(86, 60, 35);
                page_text_color = Color.Lavender;
                background_color = Color.FromArgb(240, 240, 240);
            }
            else if (theme_color == "yeoju-first")
            {
                banner_color = Color.FromArgb(121, 5, 36);
                page_bar_color = Color.FromArgb(162, 11, 52);
                page_side_bar_color = Color.FromArgb(99, 34, 47);
                page_text_color = Color.Lavender;
                background_color = Color.FromArgb(215, 43, 90); // 240 240 240
            }
            else
            {
                MessageBox.Show("색상이 존재하지 않음,");
            }
        }
    }
}
