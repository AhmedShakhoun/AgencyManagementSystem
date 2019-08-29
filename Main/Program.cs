using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string SalesMan;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AMS.PL.Main_Form()); 
        }
    }
}
 