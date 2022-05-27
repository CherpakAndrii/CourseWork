using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    static class Program
    {
        public static bool Form1Closed = true, Form2Closed = true;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            if (!Form1Closed)
            {
                foreach (string line in InequalitiesFactory.Sources)
                {
                    MessageBox.Show(line);
                }
            }
        }
    }
}