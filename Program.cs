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
            Livreur livreur = new Livreur()
            {
                Matricule="MAT002",
                Login = "livreur1",
                Password = "1234",
                NomComplet = "Gon Freec",
                Telephone = "77 999 99 99",
                Role="ROLE_LIVREUR"
            };
            data.User.Add(livreur);
            data.SaveChanges();*/
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmConnexion());
        }
    }
}
