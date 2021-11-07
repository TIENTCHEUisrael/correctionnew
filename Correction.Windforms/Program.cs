
using CorrectionCC.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correction.Windforms
{
    static class Program
    {
        public static User currentuser { get; set; }
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Authentification().Show();
            Application.Run();
                                   
        }
    }
}
