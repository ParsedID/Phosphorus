using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;

namespace ScreenSaver
{
    public partial class ScreenSaverForm : Form
    {
        #region Win32 API functions

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        #endregion

        private Point mouseLocation;
        private bool previewMode = false;
        private Random rand = new Random();

        private string source = string.Empty;
        private string separator = string.Empty;
        private int minSpeed = 0;
        private int maxSpeed = 0;
        private bool trimON = false;
        private string settingsError = string.Empty;
        private string divider = string.Empty;

        // You could make an SQL CE DB in Application.UserAppDataPath with codefirst approach and use that instead of lists (with DB editor in settings)...

        private List<string> textList = new List<string>();
        private List<char> currentText = new List<char>();

        public ScreenSaverForm()
        {
            InitializeComponent();
        }

        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        public ScreenSaverForm(IntPtr PreviewWndHandle)
        {
            InitializeComponent();

            SetParent(this.Handle, PreviewWndHandle);

            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            previewMode = true;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (string s in source.Split('|'))
            {
                if (File.Exists(s))
                    using (StreamReader sr = new StreamReader(s, Encoding.Default))
                    {
                        string chars = string.Empty;

                        while (sr.Peek() >= 0)
                        {
                            char c = (char)sr.Read();

                            bool separates = false;

                            foreach (char x in separator)
                            {
                                if (c == x)
                                    separates = true;
                            }

                            if (separates)
                            {
                                if (trimON)
                                {
                                    if (chars.Trim().Length != 0)
                                        if (divider == string.Empty)
                                            textList.Add(chars.Trim() + "\r\n");
                                        else
                                            textList.Add(chars.Trim() + "\r\n" + divider + "\r\n");
                                    chars = string.Empty;
                                }
                                else
                                {
                                    if (chars.Trim().Length != 0)
                                        textList.Add(chars);
                                    chars = string.Empty;
                                }

                                continue;
                            }

                            chars += c;
                        }
                    }
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Guess you could show this progress somewhere if you wanted...
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // After you read everything from the files you could randomize the order of the strings in another list and display them from first to last in a cycle to prevent random repetition...
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            LoadSettings();

            if (previewMode)
                textBox.Font = new Font(textBox.Font.Name, textBox.Font.Size / 10);

            Cursor.Hide();
            #if !DEBUG
            TopMost = true;
            #endif

            if (settingsError != string.Empty)
            {
                textBox.AppendText("Configuration error:\r\n" + settingsError);
                return;
            }

            backgroundWorker.RunWorkerAsync();

            writeTimer.Interval = 250;
            writeTimer.Tick += new EventHandler(writeTimer_Tick);
            writeTimer.Start();
        }

        private void LoadSettings()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\PhosphorusScreenSaver");
                if (registryKey != null)
                {
                    if ((string)registryKey.GetValue("source") != null)
                    {
                        source = (string)registryKey.GetValue("source");
                        if (source == string.Empty)
                            settingsError = "Source setting empty!\r\n";
                    }
                    else
                        settingsError = "Source setting empty!\r\n";
                    if ((string)registryKey.GetValue("separator") != null)
                    {
                        separator = (string)registryKey.GetValue("separator");
                        if (separator == string.Empty)
                            settingsError = "Separator setting empty!\r\n";
                    }
                    else
                        settingsError = "Separator setting empty!\r\n";
                    if ((string)registryKey.GetValue("minSpeed") != null)
                    {
                        if ((string)registryKey.GetValue("minSpeed") != string.Empty)
                        {
                        minSpeed = Convert.ToInt32((string)registryKey.GetValue("minSpeed"));
                        if (minSpeed <= 0)
                            settingsError = "Minimum speed must be greater than 0!\r\n";
                        }
                        else
                            settingsError = "Minimum speed setting empty!\r\n";
                    }
                    else
                        settingsError = "Minimum speed setting empty!\r\n";
                    if ((string)registryKey.GetValue("maxSpeed") != null)
                    {
                        if ((string)registryKey.GetValue("maxSpeed") != string.Empty)
                        {
                            maxSpeed = Convert.ToInt32((string)registryKey.GetValue("maxSpeed"));
                            if (maxSpeed <= 0 || maxSpeed < minSpeed)
                                settingsError = "Maximum speed must be greater than or equal to minimum speed!\r\n";
                        }
                        else
                            settingsError = "Maximum speed setting empty!\r\n";
                    }
                    else
                        settingsError = "Maximum speed setting empty!\r\n";
                    if ((string)registryKey.GetValue("font") != null)
                    {
                        if ((string)registryKey.GetValue("font") != string.Empty)
                        {
                            var fcv = new FontConverter();
                            textBox.Font = fcv.ConvertFromString((string)registryKey.GetValue("font")) as Font;
                        }
                    }
                    if ((string)registryKey.GetValue("color") != null)
                        if ((string)registryKey.GetValue("color") != string.Empty)
                            textBox.ForeColor = Color.FromName((string)registryKey.GetValue("color"));
                    if ((string)registryKey.GetValue("canvas") != null)
                        if ((string)registryKey.GetValue("canvas") != string.Empty)
                            textBox.BackColor = Color.FromName((string)registryKey.GetValue("canvas"));
                    if ((string)registryKey.GetValue("trim") != null)
                        if ((string)registryKey.GetValue("trim") != string.Empty)
                            trimON = Convert.ToBoolean((string)registryKey.GetValue("trim"));
                        else
                            trimON = false;
                    else
                        trimON = false;
                    if ((string)registryKey.GetValue("divider") != null)
                    {
                        divider = (string)registryKey.GetValue("divider");
                    }
                    if ((string)registryKey.GetValue("caret") != null)
                        if ((string)registryKey.GetValue("caret") != string.Empty)
                            textBox.CaretON = Convert.ToBoolean((string)registryKey.GetValue("caret"));
                        else
                            textBox.CaretON = false;
                    else
                        textBox.CaretON = false;
                }
                else
                    settingsError = "No settings key found!\r\n";
            }
            catch (Exception ex)
            {
                settingsError += ex.Message + "\r\n";
            }
        }

        private void writeTimer_Tick(object sender, System.EventArgs e)
        {
            if (currentText.Count == 0)
                if (textList.Count == 0)
                    return;
                else
                {
                    if (textBox.Text.Length > 256000)
                        textBox.Clear();
                    currentText.AddRange(textList[rand.Next(0, textList.Count)].ToCharArray());
                }
            textBox.AppendText(currentText[0].ToString());
            textBox.ScrollToBottom();
            currentText.RemoveAt(0);

            writeTimer.Interval = rand.Next(minSpeed, maxSpeed);
        }

        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!previewMode)
            {
                if (!mouseLocation.IsEmpty)
                {
                    if (Math.Abs(mouseLocation.X - e.X) > 5 || Math.Abs(mouseLocation.Y - e.Y) > 5)
                        Application.Exit();
                }

                mouseLocation = e.Location;
            }
        }

        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!previewMode)
                Application.Exit();
        }

        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!previewMode)
                Application.Exit();
        }

        private void ScreenSaverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker.IsBusy)
                backgroundWorker.CancelAsync();
            if (writeTimer.Enabled)
                writeTimer.Stop();
        }
    }
}
