using System;
using System.Windows.Forms;

namespace Doggo.GameThingy
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
            Form1 myForm = new Form1();
            myForm.Show();
            myForm.GameLoop();
        }
    }
}
