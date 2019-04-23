using System;
using System.Windows.Forms;
using schedule1;

namespace schedule.forms.framework
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
            StartForms();
        }

        static void StartForms()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
