using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPing
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll ", EntryPoint = "FindWindow")]
        private static extern int FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll ", EntryPoint = "GetSystemMenu")]
        extern static IntPtr GetSystemMenu(IntPtr hWnd, IntPtr bRevert);
        [DllImport("user32.dll ", EntryPoint = "RemoveMenu")]
        extern static int RemoveMenu(IntPtr hMenu, int nPos, int flags);

        PingTool pingTool;
        Ini ini;
        public Form1()
        {
            InitializeComponent();
            var appender=new RichTextBoxAppender();
            appender.rbx = this.richTextBox1;
            AppLogger.AddAppender(appender);
            ini = new Ini("config/params.ini");
            string host = ini.GetValue("host");
            int intervals = int.Parse(ini.GetValue("interval")) ;
            pingTool = new PingTool(host,intervals);
            pingTool.isTimerEnabled = true;
            View();
            

        }

        private void View()
        {
            this.tbxHost.Text= pingTool.Host;
            this.tbxInterval.Text =pingTool.Intervals.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Log");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ini.WriteValue("host",pingTool.Host);
            ini.WriteValue("interval",pingTool.Intervals.ToString());
            ini.Save();
            pingTool.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tbxHost.Enabled = false;
            tbxInterval.Enabled = false;
            pingTool.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tbxHost.Enabled = true;
            tbxInterval.Enabled = true;
            pingTool.Stop();
        }

        private void tbxHost_TextChanged(object sender, EventArgs e)
        {
            pingTool.Host=this.tbxHost.Text;
        }

        private void tbxInterval_TextChanged(object sender, EventArgs e)
        {
            pingTool.Intervals = long.Parse(this.tbxInterval.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int WINDOW_HANDLER = FindWindow(null, this.Text);
            //禁用控制台关闭按钮           
            IntPtr CLOSE_MENU = GetSystemMenu((IntPtr)WINDOW_HANDLER, IntPtr.Zero);
            int SC_CLOSE = 0xF060;
            RemoveMenu(CLOSE_MENU, SC_CLOSE, 0x0);
        }
    }
}
