using E_MEET.BO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace E_MEET.Windforms
{
    static class Program
    {
        public static Utilisateur CurrentUser;
        public static Client CurrentClients;
        public static List<Client> curclients;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CurrentUser = new Utilisateur();
            CurrentClients = new Client();
            curclients = new List<Client>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new FormSplash();
            form.Show();
            Application.Run();
        }
    }
}
