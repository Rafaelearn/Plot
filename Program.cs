using System;
using System.IO;
using System.Windows.Forms;
namespace Plot
{
    internal static class Program
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
            Application.Run(new FormPlot(new ControlToBitmap(), new WinFormsPlotter()));
        }
    }
}