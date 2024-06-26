using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);


        public Form1()
        {
            InitializeComponent();
        }

        private void siticoneTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = siticoneTrackBar1.Value.ToString();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (siticoneButton1.Text.Contains("Enable"))
            {
                siticoneButton1.Text = "Disable";
            }
            else if (siticoneButton1.Text.Contains("Disable"))
            {
                siticoneButton1.Text = "Enable";
            }
        }

        private void siticoneButton1_TextChanged(object sender, EventArgs e)
        {
            if(siticoneButton1.Text.Contains("Enable"))
            {
                timer1.Stop();
            }
            else if(siticoneButton1.Text.Contains("Disable"))
            {
                timer1.Start();
            }   
        }

        int min;
        int max;
        IntPtr hWnd;
        string currentWindow;

        public string getActiveWindowName()
        {
            try
            {
                var activeHandle = GetForegroundWindow();
                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (activeHandle == clsProcess.MainWindowHandle)
                    {
                        string porcessName = clsProcess.MainWindowTitle;
                        return porcessName;
                    }
                }
            }
            catch
            {

            }

            return null;
        }
        private void Random_Tick(object sender, EventArgs e)
        {
            if (siticoneButton1.Text.Contains("Disable"))
            {
                min = siticoneTrackBar1.Value - 6;
                max = siticoneTrackBar1.Value + 6;
                Random rnd = new Random();
                siticoneTrackBar2.Value = (rnd.Next(min, max));
            }   
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval = 1000 / siticoneTrackBar2.Value;
            }
            catch
            {

            }
            if (siticoneButton1.Text.Contains("disable"))
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process p in processes)
                {
                    hWnd = FindWindow(null, p.MainWindowTitle);
                }

                string currentWindow = getActiveWindowName();
                if(currentWindow == null)
                {
                    return;
                }

                if (currentWindow.Contains("Banana"))
                {
                    if(MouseButtons == MouseButtons.Left)
                    {
                        PostMessage(hWnd, 0x02, 0, 0);
                        await Task.Delay(30);
                        PostMessage(hWnd, 0x04, 0, 0);
                    }
                }
            }

        }
    }
}
