using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SCRLockStarter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);

            // Set the unhandled exception mode to force all Windows Forms errors to go through 
            // our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.Run(new MainForm());
        }

        /// <summary>
        /// Handle any unexpected exceptions silently.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private static void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            //Application.Exit();
            System.Environment.Exit(0);
        }

        /// <summary>
        /// Handle any unexpected exceptions silently.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
