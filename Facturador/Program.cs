/*
 * Tlacaelel iCPAC
 * 2021
 * tlacaelel.icpac@gmail.com
 * https://github.com/icpac/Facturador
 * */
using System;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace Facturador
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Main app = new Main();

            if (ConfigurationManager.ConnectionStrings["ConnectionString"] != null)
            {
                app.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }

            Application.Run(app);
        }
    }
}
