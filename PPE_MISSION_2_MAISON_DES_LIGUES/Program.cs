using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PPE_MISSION_2_MAISON_DES_LIGUES
{
    static class Program
    {
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new conexion());
        }
    }
}
