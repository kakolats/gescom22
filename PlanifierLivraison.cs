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
    public partial class PlanifierLivraison : Form
    {
        private Service service = new Service();
        private Commande commande;
        public PlanifierLivraison(Commande commande)
        {
            this.commande = commande;
            InitializeComponent();
        }

        private void loadCboLivreur()
        {
            cboLivreur.DataSource = service.findAllLivreurs();
        }
        
        private void PlanifierLivraison_Load(object sender, EventArgs e)
        {
            loadCboLivreur();
        }

        private void btnPlanifier_Click(object sender, EventArgs e)
        {
            Livraison livraison = new Livraison()
            {
                Date=datePic.Value,
                Etat="EN COURS",
                
            };
            Livreur liv = (Livreur)cboLivreur.SelectedValue;
            service.addLivraison(livraison,commande.Id,liv.Id);
            this.Close();
        }
    }
}
