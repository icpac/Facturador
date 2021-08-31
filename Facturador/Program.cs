/*
 * Tlacaelel iCPAC
 * 2021
 * tlacaelel.icpac@gmail.com
 * https://github.com/icpac/Facturador
 * */
using System;
using System.Windows.Forms;

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
            Application.Run(new Main());
        }
    }
}
