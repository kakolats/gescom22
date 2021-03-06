using gescom22.fabrique;
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
    public partial class FrmConnexion : Form
    {
        private Service service = new Service();
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtbLogin.Text.Trim();
            string password = txtbPassword.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Login ou Mot de Passe Obligatoire",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                User user = service.findUserByLoginPassword(login, password);
                if (user == null)
                {
                    lblError.Visible = true;
                }
                else
                {
                    //Redirection vers la page d'accueil
                    switch (user.Role)
                    {
                        case "ROLE_CLIENT":
                            FrmUserMenu frm = new FrmUserMenu(user);
                            frm.Show();
                            this.Hide();
                            break;
                        case "ROLE_RP":
                            FrmRpMenu frm1 = new FrmRpMenu(user);
                            frm1.Show();
                            this.Hide();
                            break;
                        case "ROLE_SECRETAIRE":
                            FrmCommandeValidation frm3 = new FrmCommandeValidation();
                            frm3.Show();
                            this.Hide();
                            break;
                        case "ROLE_COMPTABLE":
                            break;
                        case "ROLE_LIVREUR":
                            FrmMenuLivreur frm2 = new FrmMenuLivreur(user);
                            frm2.Show();
                            this.Hide();
                            break;

                        
                    };
                    /*
                    FrmUserMenu frm = new FrmUserMenu(user);
                    frm.Show();
                    this.Hide();*/

                }

            }
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            txtbLogin.Clear();
            txtbPassword.Clear();
        }

        private void btnAccountCreation_Click(object sender, EventArgs e)
        {

        }
    }
}
