using System;
using System.Windows.Forms;

namespace schedule1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Change settings in Properties to enable windows forms instead of console
            Console.WriteLine("Console works");
            // StartForms();
        }

        static void StartForms()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
