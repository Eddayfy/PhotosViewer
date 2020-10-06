using System;
using System.Windows.Forms;

namespace PhotosViewer
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

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 0)
                Application.Run(new PhotosViewer(args));
            else
                Application.Run(new PhotosViewer());
        }
    }
}
