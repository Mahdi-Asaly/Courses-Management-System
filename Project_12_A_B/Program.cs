using Project_12_A_B.CodeLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_A_B
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Handler h = new Handler();

            if (h.ConnectToDB())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Project_Sce.PL.LogIn());
            }
            else
            {
                MessageBox.Show("Cannot connect to Data Base! Please try later.");
            }

        }
        static void OnProcessExit(object sender, EventArgs e)
        {
            Handler h = new Handler();
            h.DisconnectFromDB();
        }
    }
}
