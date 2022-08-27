using DiscordSetup.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace DiscordSetup
{
    public partial class FMain : Form
    {
        static bool isRunning = true;
        static bool bypassOBS = false;
        static bool hideOnOBS = false;

        public FMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Thread thr = new Thread(kbrd);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void siticoneButton1_Click(object sender, EventArgs e)
        {
            isRunning = false;
            await Task.Delay(1000);
            Process.GetCurrentProcess().Kill();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rnbwChecker_Tick(object sender, EventArgs e)
        {
            if (rnbw.Checked == true)
            {
                var rn = new Random();
                var r = rn.Next(0, 255);
                var g = rn.Next(0, 255);
                var b = rn.Next(0, 255);
                var a = rn.Next(0, 255);
                label1.ForeColor = Color.FromArgb(r, g, b, a);
                label3.ForeColor = Color.FromArgb(r, g, b, a);
                siticoneButton1.ForeColor = Color.FromArgb(r, g,b, a);
                siticoneButton2.ForeColor = Color.FromArgb(r, g, b, a);
                siticoneCheckBox2.ForeColor = Color.FromArgb(r, g, b, a);
                rnbw.ForeColor = Color.FromArgb(r, g, b, a);
                rnbw.CheckMarkColor = Color.FromArgb(r, g,b,a);
                siticoneCheckBox2.CheckMarkColor = Color.FromArgb(r, g, b, a);
                ssedRn.ForeColor = Color.FromArgb(r, g, b, a);
                ssedRn.CheckMarkColor = Color.FromArgb(r, g, b, a);
                bypOBS.ForeColor = Color.FromArgb(r,g, b, a);
                bypOBS.CheckMarkColor = Color.FromArgb(r, g, b, a);
            }
            else
            {
                label1.ForeColor = Color.FromArgb(52, 52, 76);
                label3.ForeColor = Color.FromArgb(52, 52, 76);
                siticoneButton1.ForeColor = Color.FromArgb(52, 52, 76);
                siticoneButton2.ForeColor = Color.FromArgb(52, 52, 76);
                siticoneCheckBox2.ForeColor = Color.FromArgb(52, 52, 76);
                rnbw.ForeColor = Color.FromArgb(52, 52, 76);
                rnbw.CheckMarkColor = Color.White;
                siticoneCheckBox2.CheckMarkColor = Color.White;
                ssedRn.ForeColor = Color.FromArgb(52, 52, 76);
                ssedRn.CheckMarkColor = Color.White;
                bypOBS.ForeColor = Color.FromArgb(52, 52, 76);
                bypOBS.CheckMarkColor = Color.White;
            }
          
           
        }

        private void rnbw_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void siticoneCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox2.Checked)
            {
                ShowInTaskbar = false;
            }
            else
            {
                ShowInTaskbar = true;
            }
        }

        private void ssedRn_CheckedChanged(object sender, EventArgs e)
        {
            if (ssedRn.Checked)
            {
                // ^^ thats bad, so, we'll hide meteor real good.
                recov.Visible = true;
                recovText.Visible = true;
                slf.Visible = true;
            }
            else
            {
                recov.Visible = false;
                recovText.Visible = false;
                slf.Visible=false;
            }
        }

        private void slf_Click(object sender, EventArgs e)
        {
            if (recovText.Text.Contains(" "))
            {
                MessageBox.Show("No spaces!");
            }
            else
            {
                Settings.Default.recoveryContent = recovText.Text;
                Settings.Default.Save();
            }
        }
        [STAThread]
        private void kbrd()
        {
            while (isRunning)
            {
                Thread.Sleep(55);
                if (bypassOBS)
                {
                   
                    if ((Keyboard.GetKeyStates(Key.RightCtrl) & KeyStates.Down) > 0)
                    {
                        Thread.Sleep(1000);
                        Show();
                        TopMost = true;
                        TopMost = false;
                        Focus();

                    
                    }
                }
            }
        }

        private void bypOBS_CheckedChanged(object sender, EventArgs e)
        {
            if (bypOBS.Checked )
            {
                bypassOBS = true;
            }
            else
            {
                bypassOBS = false;
            }
        }

        private async void obs_Tick(object sender, EventArgs e)
        {
            if (siticoneCheckBox2.Checked)
            {
                int nullptr = 0;
                Process[] procs = Process.GetProcessesByName("obs64");
                // obs detected! hiding!
                if (procs.Length == nullptr)
                {

                }
                else
                {
                    await Task.Delay(900);
                    if (!hideOnOBS)
                    {

                    }
                    else
                    {
                        await Task.Delay(2000);
                        Hide();
                    }
                }
            }
        }

        private void hideOBS_Click(object sender, EventArgs e)
        {

        }

        private void hideOBS_CheckedChanged(object sender, EventArgs e)
        {
            if (hideOBS.Checked)
            {
                hideOnOBS = true;
            }
            else
            {
                hideOnOBS = false;
            }
        }
    }
}
