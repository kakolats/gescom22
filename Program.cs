using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gescom22
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            GesDataContainer data = new GesDataContainer();
            Client client = new Client()
            {
                Adresse = "Medina Rue 31X2",
                Solde = 0,
                Login = "client",
                Password = "1234",
                NomComplet = "Gon Freecs",
                Telephone = "77 777 77 77",
                Role="ROLE_CLIENT"
            };
            data.User.Add(client);
            data.SaveChanges();
            */
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmConnexion());
        }
    }
}
