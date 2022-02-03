using gescom22.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gescom22
{
    public partial class FrmRegister : Form
    {
        private Service service=new Service();
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void lblRetour_Click(object sender, EventArgs e)
        {

        }

        private void btnCreation_Click(object sender, EventArgs e)
        {
            string login = txtbLogin.Text.Trim();
            string password = txtbPassword.Text;
            string nomComplet = txtbNomComplet.Text.Trim();
            string adresse = txtbAdresse.Text;
            string telephone = txtbTelephone.Text.Trim();
            string role = "ROLE_CLIENT";
            if (string.IsNullOrEmpty(login)
                ||string.IsNullOrEmpty(password)
                ||string.IsNullOrEmpty(nomComplet)
                || string.IsNullOrEmpty(adresse)
                || string.IsNullOrEmpty(telephone))
            {
                MessageBox.Show("Champs Obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Client client = new Client()
                {
                    Login=login,
                    Password=password,
                    NomComplet=nomComplet,
                    Adresse=adresse,
                    Role=role,
                    Telephone=telephone,
                    Solde=0
                };
                service.addClient(client);
                MessageBox.Show("Compte créé avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
