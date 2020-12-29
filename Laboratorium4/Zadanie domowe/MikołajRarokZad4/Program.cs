using MikołajRarokZad4.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikołajRarokZad4
{
    static class Program
    {
        public static string loginType;

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new FormLogin());

            if (loginType == "admin")
                Application.Run(new FormAdmin());
            if (loginType == "catering")
                Application.Run(new FormCatering());
            if (loginType == "receptionist")
                Application.Run(new FormReception());
        }
    }
}
