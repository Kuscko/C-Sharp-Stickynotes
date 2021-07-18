using C_Sharp_Stickynotes.Presentation;
using System;
using System.Windows.Forms;

namespace C_Sharp_Stickynotes
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmStickyNote());
        }
    }
}
