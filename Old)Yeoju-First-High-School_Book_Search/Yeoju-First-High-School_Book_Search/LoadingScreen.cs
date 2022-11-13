using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeoju_First_High_School_Book_Search
{
    public partial class LoadingScreen : Form
    {
        string FreeBanner_path = "./FreeBanner.exe";
        string fileurl_Webhook = "./Webhooks.txt";
        string fileurl_Embed = "./embed.json";
        string setting_path = "./Setting.json";
        string setting_path1 = "./Bunifu_UI_v1.52.dll";
        string setting_path2 = "./MySql.Data.dll";
        string setting_path3 = "./Newtonsoft.Json.dll";
        string setting_path4 = "./System.Buffers.dll";
        string setting_path5 = "./System.Interactive.Async.dll";
        string setting_path6 = "./System.Linq.Async.dll";
        string setting_path7 = "./Ubiety.Dns.Core.dll";
        string setting_path8 = "./Zstandard.Net.dll";
        string backup_path = "./backup";
        string setting_path9 = "./FreeBanner Converter.exe";

        int testint = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void DelaySystem(int MS)
        {
            DateTime dtAfter = DateTime.Now;
            TimeSpan dtDuration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime dtThis = dtAfter.Add(dtDuration);
            while (dtThis >= dtAfter)
            {
                System.Windows.Forms.Application.DoEvents();
                dtAfter = DateTime.Now;

            }
        }

        public LoadingScreen()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer2.Start();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public void loading()
        {
            if (testint == 0)
            {
                testint = 1;
                int Pint = (panel3.Width / 806) * 100;
                int int1 = 806 / 12; // 불러와야하는 갯수


                DelaySystem(4000);
                try
                {
                    FileInfo json1 = new FileInfo(FreeBanner_path);
                    panel3.Width = int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'FreeBanner.exe' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'FreeBanner.exe' 불러오기 실패";
                    DelaySystem(100);
                }

                try
                {
                    FileInfo json1 = new FileInfo(fileurl_Embed);
                    panel3.Width = int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'embed.json' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'embed.json' 불러오기 실패";
                    DelaySystem(100);
                }

                try
                {
                    FileInfo json1 = new FileInfo(setting_path);
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'Setting.json' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'Setting.json' 불러오기 실패";
                    DelaySystem(100);
                }

                try
                {
                    FileInfo json1 = new FileInfo(fileurl_Webhook);
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'Webhooks.txt' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'Webhooks.txt' 불러오기 실패";
                    DelaySystem(100);
                }

                try
                {
                    FileInfo json1 = new FileInfo(setting_path1);
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'Bunifu_UI_v1.52.dll' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'Bunifu_UI_v1.52.dll' 불러오기 실패";
                    DelaySystem(100);
                }

                try
                {
                    FileInfo json1 = new FileInfo(setting_path2);
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'MySql.Data.dll' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'MySql.Data.dll' 불러오기 실패";
                    DelaySystem(100);
                }

                try
                {
                    FileInfo json1 = new FileInfo(setting_path3);
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'Newtonsoft.Json.dll' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'Newtonsoft.Json.dll' 불러오기 실패";
                    DelaySystem(100);
                }

                try
                {
                    FileInfo json1 = new FileInfo(setting_path5);
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'System.Interactive.Async.dll' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'System.Interactive.Async.dll' 불러오기 실패";
                    DelaySystem(100);
                }

                try
                {
                    FileInfo json1 = new FileInfo(setting_path6);
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'System.Linq.Async.dll' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'System.Linq.Async.dll' 불러오기 실패";
                    DelaySystem(100);
                }

                try
                {
                    FileInfo json1 = new FileInfo(setting_path7);
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'Ubiety.Dns.Core.dll' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'Ubiety.Dns.Core.dll' 불러오기 실패";
                    DelaySystem(100);
                }

                try
                {
                    FileInfo json1 = new FileInfo(setting_path8);
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'Zstandard.Net.dll' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'Zstandard.Net.dll' 불러오기 실패";
                    DelaySystem(100);
                }

                try
                {
                    FileInfo json1 = new FileInfo(backup_path);
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'backup' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'backup' 불러오기 실패";
                    DelaySystem(100);
                }

                try
                {
                    FileInfo json1 = new FileInfo(setting_path9);
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'FreeBanner Converter.exe' 불러오기 성공";
                    DelaySystem(10);
                }
                catch
                {
                    panel3.Width = panel3.Width + int1; // 806이 최대
                    Pint = (panel3.Width / 806) * 100;
                    label1.Text = "(" + Pint + "%)";
                    label2.Text = "'FreeBanner Converter.exe' 불러오기 실패";
                    DelaySystem(100);
                }

                DelaySystem(500);


                label1.Text = "(100%)";
                label2.Text = "도서검색 프로그램 로딩 성공!";

                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            

            panel3.Width = 0; // 806이 최대
            int Pint = (panel3.Width / 806) * 100;
            label1.Text = "(" + Pint + "%)";
            label2.Text = "프리배너기 실행중...";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loading();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.005;
            if (this.Opacity == 1)
            {
                timer2.Enabled = false;   
            }
        }
    }
}
