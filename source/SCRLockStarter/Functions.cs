using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SCRLockStarter
{
    class Functions
    {
        [DllImport("User32.dll")]
        public static extern int SendMessage
            (IntPtr hWnd,
            uint Msg,
            uint wParam,
            uint lParam);
        public const uint WM_SYSCOMMAND = 0x112;
        public const uint SC_SCREENSAVE = 0xF140;
        public enum SpecialHandles
        {
            HWND_DESKTOP = 0x0,
            HWND_BROADCAST = 0xFFFF
        }
        public static void TurnOnScreenSaver()
        {
            SendMessage(
                new IntPtr((int)SpecialHandles.HWND_BROADCAST),
                WM_SYSCOMMAND,
                SC_SCREENSAVE,
                0);
        }
    }
}
