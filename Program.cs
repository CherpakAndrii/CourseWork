using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controller;
using WinFormsApp1.Model;
using WinFormsApp1.View;
using Range = WinFormsApp1.Model.Range;


namespace WinFormsApp1
{
    static class Program
    {
        public static bool Form1Closed = true;
        public static int InequalityCounter = 0;
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
                InequalitiesFactory.SetInequalities();
                InequalityCounter = 0;
                Application.Run(new ResultForm());
            }
        }
    }
}