using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestePI
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

            Login login = new Login();
            login.ShowDialog();

            if (login.getButtonLogin())
            {
                login.Close();
                Application.Run(new Principal());
            }

            

            
        }
    }
}
