using E_MEET.BO;
using E_MEET.Windforms.OutilsWindforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_MEET.Windforms
{
    static class Program
    {
        public static Utilisateur CurrentUser;
        public static Client CurrentClients;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CurrentUser = new Utilisateur();
            CurrentClients = new Client();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new FormSplash();
            form.Show();
            Application.Run();
        }
    }
}
