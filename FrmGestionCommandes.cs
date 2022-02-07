using gescom22.fabrique;
using gescom22.Services;
using gescom22.utils;
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
    public partial class FrmGestionCommandes : Form
    {
        private Service service = new Service();
        private Commande cmdeSelected;
        public FrmGestionCommandes()
        {
            InitializeComponent();
        }

        private void FrmGestionCommandes_Load(object sender, EventArgs e)
        {
            loadTableViewCommandes();
            loadComboBox();
        }

        private void loadTableViewCommandes(string etat="VALIDE")
        {
            dtgvCommande.AutoGenerateColumns = false;
            dtgvCommande.DataSource = service.findAllCommandesByEtat(etat);

        }
        private void loadTableViewDetails(int idCommande)
        {
            dtgvDetail.AutoGenerateColumns = false;
            dtgvDetail.DataSource = service.showDetailsCommandeByIdCommande(idCommande);
        }

        private void loadComboBox()
        {
            List<String> strings = new List<string>();
            strings.Add("VALIDE");
            strings.Add("STANDBY");
            cboFiltre.DataSource = strings;
        }

        private void dtgvCommande_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dtgvCommande.Rows.Count - 1)
            {
                DataGridViewRow row = dtgvCommande.Rows[e.RowIndex];
                row.Selected = true;
                cmdeSelected = (Commande)row.DataBoundItem;
                loadTableViewDetails(cmdeSelected.Id);
                lblDispo.Text = "0";
                btnStandBy.Enabled = true;
                btnMakeLivraison.Enabled = true;
                if (FormUtils.commandeValide(service.showDetailsCommandeByIdCommande(cmdeSelected.Id)))
                {
                    lblValidity.Visible = true;
                }
                else
                {
                    lblValidity.Text = "Commande invalide";
                    lblValidity.Visible = true;
                }
            }
        }

        private void dtgvDetail_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dtgvDetail.Rows.Count - 1)
            {
                DataGridViewRow row = dtgvDetail.Rows[e.RowIndex];
                row.Selected = true;
                Produit prod = (Produit)row.Cells[0].Value;
                lblDispo.Text = prod.Stock.ToString();
            }
        }

        private void btnMakeLivraison_Click(object sender, EventArgs e)
        {
            if (cmdeSelected != null)
            {
                PlanifierLivraison plan = new PlanifierLivraison(cmdeSelected);
                plan.Show();
                service.updateCommandeStatus(cmdeSelected.Id, "EXPEDIE");
            }
        }

        private void btnStandBy_Click(object sender, EventArgs e)
        {
            if (cmdeSelected != null)
            {
                if (FormUtils.commandeValide(service.showDetailsCommandeByIdCommande(cmdeSelected.Id)))
                {
                    //Notification d'erreur et renitialisation
                    MessageBox.Show("Cette commande est valide", "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    reboot();
                }
                else
                {
                    service.updateCommandeStatus(cmdeSelected.Id, "STANDBY");
                    MessageBox.Show("Commande mise en attente avec Success", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reboot();
                }
            }
        }

        private void reboot()
        {
            loadTableViewCommandes();
            btnMakeLivraison.Enabled = false;
            btnStandBy.Enabled = false;
            lblDispo.Text = "0";
            lblValidity.Text = "Commande valide";
            lblValidity.Visible = false;
            loadTableViewDetails(0);
            cmdeSelected = null;
        }

        private void btnBoot_Click(object sender, EventArgs e)
        {
            reboot();
        }

        private void cboFiltre_TextChanged(object sender, EventArgs e)
        {
            btnMakeLivraison.Enabled = false;
            btnStandBy.Enabled = false;
            lblDispo.Text = "0";
            lblValidity.Text = "Commande valide";
            lblValidity.Visible = false;
            loadTableViewDetails(0);
            cmdeSelected = null;
            loadTableViewCommandes(cboFiltre.Text);
           
        }

       
    }
        
}
