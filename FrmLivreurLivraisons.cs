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
    public partial class FrmLivreurLivraisons : Form
    {
        private int idUser;
        private Service service = new Service();
        private Livraison livraisonSelected;
        public FrmLivreurLivraisons(int idUser)
        {
            this.idUser = idUser;
            InitializeComponent();
        }

        private void FrmLivreurLivraisons_Load(object sender, EventArgs e)
        {
            loadTableView();
            loadComboBox();
        }
        private void loadTableView(string etat="EN COURS")
        {
            dtgvLivraisons.DataSource = service.findLivraisonsByLivreurAndEtat(idUser, etat);
        }

        private void loadComboBox()
        {
            List<string> strings = new List<string>();
            strings.Add("EN COURS");
            strings.Add("FAIT");
            cboFiltre.DataSource = strings;
        }

        private void cboFiltre_TextChanged(object sender, EventArgs e)
        {
            loadTableView(cboFiltre.Text);
        }

        private void dtgvLivraisons_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dtgvLivraisons.Rows.Count - 1)
            {
                DataGridViewRow row = dtgvLivraisons.Rows[e.RowIndex];
                row.Selected = true;
                livraisonSelected = (Livraison)row.DataBoundItem;
                if (livraisonSelected.Etat.Equals("FAIT"))
                {
                    btnDone.Enabled = false;
                }
                else
                {

                    btnDone.Enabled = true;
                    txtbAdresse.Text = livraisonSelected.Commande.AdresseLivraison;
                    txtbNumero.Text = livraisonSelected.Commande.Client.Telephone;
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (livraisonSelected != null)
            {
                service.updateLivraisonStatus(livraisonSelected.Id, "FAIT");
                service.updateCommandeStatus(livraisonSelected.Commande.Id, "LIVRE");
            }
        }
    }
}
