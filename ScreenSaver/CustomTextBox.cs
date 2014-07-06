using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ScreenSaver
{
    class CustomTextBox : RichTextBox
    {
        bool caret = true;

        public bool CaretON { get { return caret; } set { caret = value; } }

        public bool UndoON { get { return CanUndo; } set { UndoON = value; } }

        [DllImport("user32.dll", EntryPoint = "HideCaret")]

        public static extern long HideCaret(IntPtr hwnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 7;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (!CaretON)
            {
                HideCaret(this.Handle);
            }
        }

        public void ScrollToBottom()
        {
            SendMessage(this.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);
        }
    }
}
