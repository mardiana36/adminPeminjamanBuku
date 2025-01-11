using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uas
{
    internal static class Program
    {
        public static Form1 LoginForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
         static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm = new Form1();
            Application.Run(LoginForm);
            
        }
    }
}
