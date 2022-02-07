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
    public partial class FrmCommandeValidation : Form
    {
        private Service service = new Service();
        private Commande cmdeSelected;
        public FrmCommandeValidation()
        {
            InitializeComponent();
        }

        private void FrmCommandeValidation_Load(object sender, EventArgs e)
        {
            loadTableViewCommandes();
        }

        private void loadTableViewCommandes(string etat="EN ATTENTE")
        {
            dtgvCommandes.AutoGenerateColumns = false;
            dtgvCommandes.DataSource = service.findAllCommandesByEtat(etat);
            
        }

        private void loadTableViewDetails(int idCommande)
        {
            dtgvDetails.AutoGenerateColumns = false;
            dtgvDetails.DataSource = service.showDetailsCommandeByIdCommande(idCommande);
        }

        private void dtgvCommandes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dtgvCommandes.Rows.Count - 1)
            {
                DataGridViewRow row = dtgvCommandes.Rows[e.RowIndex];
                row.Selected = true;
                cmdeSelected = (Commande)row.DataBoundItem;
                loadTableViewDetails(cmdeSelected.Id);
                lblDsipo.Text = "0";
                btnValidation.Enabled = true;
                btnAttente.Enabled = true;
                if (FormUtils.commandeValide(service.showDetailsCommandeByIdCommande(cmdeSelected.Id)))
                {
                    lblValide.Visible = true;
                }
                else
                {
                    lblValide.Text = "Commande invalide";
                    lblValide.Visible = true;
                }
            }
        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            if (cmdeSelected != null)
            {
                if (FormUtils.commandeValide(service.showDetailsCommandeByIdCommande(cmdeSelected.Id)))
                {
                    //Valider la commande
                    service.updateCommandeStatus(cmdeSelected.Id,"VALIDE");
                    MessageBox.Show("Commande validee avec Success", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reboot();
                }
                else
                {
                    //Notification d'erreur et renitialisation
                    MessageBox.Show("Champs Obligatoires", "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    reboot();
                }
            }
            else
            {

            }
        }

        private void dtgvDetails_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dtgvDetails.Rows.Count - 1)
            {
                DataGridViewRow row = dtgvDetails.Rows[e.RowIndex];
                row.Selected = true;
                Produit prod = (Produit)row.Cells[0].Value;
                lblDsipo.Text = prod.Stock.ToString();
            }
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            reboot();
        }

        private void reboot()
        {
            loadTableViewCommandes();
            btnValidation.Enabled = false;
            btnAttente.Enabled = false;
            lblDsipo.Text = "0";
            lblValide.Text = "Commande valide";
            lblValide.Visible = false;
            loadTableViewDetails(0);
            cmdeSelected = null;
        }

        private void btnAttente_Click(object sender, EventArgs e)
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
                    service.updateCommandeStatus(cmdeSelected.Id, "EN ATTENTE");
                    MessageBox.Show("Commande mise en attente avec Success", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reboot();
                }
            }
        }

        private void cboFiltre_TextChanged(object sender, EventArgs e)
        {
            btnValidation.Enabled = false;
            btnAttente.Enabled = false;
            lblDsipo.Text = "0";
            lblValide.Text = "Commande valide";
            lblValide.Visible = false;
            loadTableViewDetails(0);
            cmdeSelected = null;
            loadTableViewCommandes("EN ATTENTE");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmConnexion frm = new FrmConnexion();
            frm.Show();
            this.Hide();
        }
    }
}
