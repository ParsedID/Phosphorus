using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCRLockStarter
{
    public partial class MainForm : Form
    {
        System.Windows.Forms.Timer FadeInTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer FadeOutTimer = new System.Windows.Forms.Timer();

        public MainForm()
        {
            InitializeComponent();

            nIcon.ContextMenuStrip = ctMenu;

            FadeInTimer.Enabled = false;
            FadeOutTimer.Enabled = false;
            FadeInTimer.Interval = 25;
            FadeOutTimer.Interval = 25;
            FadeInTimer.Tick += FadeInTimer_Tick;
            FadeOutTimer.Tick += FadeOutTimer_Tick;

            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
        }

        bool canExit = false;
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)

        {
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                if (!canExit)
                {
                    if (FadeOutTimer.Enabled)
                        FadeOutTimer.Stop();
                    FadeOutTimer.Start();

                    e.Cancel = true;
                    return;
                }
                else if (this.Opacity > 0)
                {
                    if (FadeOutTimer.Enabled)
                        FadeOutTimer.Stop();
                    FadeOutTimer.Start();

                    e.Cancel = true;
                    return;
                }
                else
                {
                    SystemEvents.SessionSwitch -= SystemEvents_SessionSwitch;
                }
            }
            else
            {
                SystemEvents.SessionSwitch -= SystemEvents_SessionSwitch;
            }
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            else
                FadeInTimer.Stop();
        }

        private void FadeOutTimer_Tick(object sender, EventArgs e)
        {
            if (FadeInTimer.Enabled)
                FadeInTimer.Stop();
            if (this.Opacity > 0)
                this.Opacity -= 0.05;
            if (this.Opacity == 0)
            {
                if (!canExit)
                {
                    FadeOutTimer.Stop();
                    this.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    FadeOutTimer.Stop();
                    this.Close();
                }
            }
        }

        static void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionLock)
                Functions.TurnOnScreenSaver();
        }

        private void nIcon_DoubleClick(object Sender, EventArgs e)
        {
            this.Opacity = 0.01;
            FadeInTimer.Start();

            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.CenterToScreen();

            this.Activate();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.01;
            FadeInTimer.Start();

            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.CenterToScreen();

            this.Activate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canExit = true;
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.jeusnik.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ParsedID");
        }
    }
}
