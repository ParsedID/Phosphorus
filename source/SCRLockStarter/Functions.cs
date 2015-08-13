using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SCRLockStarter
{
    class Functions
    {
        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        private static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        private const int SC_SCREENSAVE = 0xF140;
        private const int WM_SYSCOMMAND = 0x0112;

        public static void TurnOnScreenSaver()
        {
            SendMessage(GetDesktopWindow(), WM_SYSCOMMAND, SC_SCREENSAVE, 0);
        }
    }
}
