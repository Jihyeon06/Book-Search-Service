using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yeoju_First_High_School_Book_Search
{
    public partial class Administrator_only_page : UserControl
    {
        private string ip = "127.0.0.1";
        private int port = 25101;
        private Socket socket;  // 소켓
        private Thread receiveThread;    // 대화 수신용

        Color banner_color = Program.banner_color;
        Color page_bar_color = Program.page_bar_color;
        Color page_side_bar_color = Program.page_side_bar_color;
        Color page_text_color = Program.page_text_color;
        Color background_color = Program.background_color;
        string theme_color = Program.theme_color;

        public Administrator_only_page()
        {
            InitializeComponent();

            textBox1.Focus();
            Log("클라이언트 로드됨!!");
        }

        public void Theme()
        {
            checkBox1.ForeColor = page_text_color;

            checkBox3.ForeColor = page_text_color;
            checkBox3.ForeColor = page_text_color;
            checkBox5.ForeColor = page_text_color;

            // 배경
            this.BackColor = background_color;
        }

        private void Administrator_only_page_Load(object sender, EventArgs e)
        {
            //Theme();

            if (theme_color == "dark")
            {
                checkBox3.Checked = true;
            }
            else if (theme_color == "brown")
            {
                checkBox5.Checked = true;
            }
            else if (theme_color == "yeoju-first")
            {
                checkBox4.Checked = true;
            }
        }

        public void Theme_set(string theme_name)
        {
            string json = File.ReadAllText(Program.jsonFilePath);
            JObject jsonDoc = JObject.Parse(json);

            jsonDoc["theme_color"] = theme_name;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonDoc, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(Program.jsonFilePath, output);
            theme_color = theme_name;
            Program.theme_color = theme_name;
            Program.theme();

            banner_color = Program.banner_color;
            page_bar_color = Program.page_bar_color;
            page_side_bar_color = Program.page_side_bar_color;
            page_text_color = Program.page_text_color;
            background_color = Program.background_color;
        }

        public bool Get_checkBox_check()
        {
            if (checkBox3.Checked == false && checkBox5.Checked == false && checkBox4.Checked == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // 다크 테마
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (Get_checkBox_check())
            {
                if (checkBox3.Checked == true)
                {
                    checkBox5.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                checkBox3.Checked = true;
            }

        }

        // 브라운 테마
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (Get_checkBox_check())
            {
                if (checkBox5.Checked == true)
                {
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                }
            }
            else
            {
                checkBox5.Checked = true;
            }
        }

        // 여주제일 테마
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (Get_checkBox_check())
            {
                if (checkBox4.Checked == true)
                {
                    checkBox3.Checked = false;
                    checkBox5.Checked = false;
                }
            }
            else
            {
                checkBox4.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                Theme_set("dark");
            }
            else if (checkBox5.Checked == true)
            {
                Theme_set("brown");
            }
            else if (checkBox4.Checked == true)
            {
                Theme_set("yeoju-first");
            }

            Application.Restart();
        }

        private void Log(string msg)
        {
            listBox1.Items.Add(string.Format("[{0}]{1}", DateTime.Now.ToString(), msg));
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // 서버 연결
            IPAddress ipaddress = IPAddress.Parse(ip);
            IPEndPoint endPoint = new IPEndPoint(ipaddress, port);

            socket = new Socket(

                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );

            // 연결하기
            Log("서버에 연결 시도중...");
            socket.Connect(endPoint);
            Log("서버에 접속됨");

            // Receive 스레드 처리(서버 <--> 클라이언트)
            receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void Receive()
        {
            while (true)
            {
                // 연결된 클라이언트가 보낸 데이터 수신
                byte[] receiveBuffer = new byte[512];
                int length = socket.Receive(receiveBuffer, receiveBuffer.Length, SocketFlags.None);
                string msg = Encoding.UTF8.GetString(receiveBuffer, 0, length);
                ShowMsg("상대]" + msg);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // 메시지 전송하기(공백이 아니고, Enter 눌렀을때)
            if (textBox1.Text.Trim() != "" && e.KeyCode == Keys.Enter)
            {
                byte[] sendBuffer = Encoding.UTF8.GetBytes(textBox1.Text.Trim());
                socket.Send(sendBuffer);
                Log("메시지 전송됨");
                ShowMsg("나]" + textBox1.Text);
                textBox1.Text = ""; // 초기화
            }
        }

        // 송수신 메시지들 대화창에 출력
        private void ShowMsg(string msg)
        {
            // richTextBox에서 개행이 정상적으로 작용되지 않으면
            // 아래처럼 따로따로
            this.Invoke(new MethodInvoker(delegate ()
            {
                richTextBox1.AppendText(msg);
                richTextBox1.AppendText("\r\n");

                // 입력된 텍스트에 맞게 스크롤을 내려준다.
                //this.Activate();
                richTextBox1.Focus();

                // 캐럿(커서)를 텍스트박스의 끝으로 내려준다.
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();   // 스크럴을 캐럿(커서)위치에 맞춰준다.
            }));
        }
    }
}
