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
    public partial class FrmDetailsProduit : Form
    {
        private Produit produit;
        public FrmDetailsProduit(Produit produit)
        {
            this.produit = produit;
            InitializeComponent();
        }


        private void FrmDetailsProduit_Load(object sender, EventArgs e)
        {
            lblNomProduit.Text = this.produit.Libelle;
            txtbPrix.Enabled = false;
            txtbPrix.Text = this.produit.Prix.ToString();
            txtbDescription.Enabled = false;
            txtbDescription.Text = this.produit.Description;
            picBoxProduct.Image = MyImage.convertByteToImage(this.produit.Image);
        }

        private void btnCatalogue_Click(object sender, EventArgs e)
        {
            FrmUserMenu frm = (FrmUserMenu)this.ParentForm;
            frm.loadFrmCatalogue();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (FrmUserMenu.Panier.Count > 0)
            {

                if (identicalId(FrmUserMenu.Panier,produit.Id))
                {
                    MessageBox.Show("Produit deja dans le panier",
                        "Avertissement",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }else
                {
                    FrmUserMenu.Panier.Add(produit);
                    MessageBox.Show("Produit ajouté au panier Case 1 avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                FrmUserMenu.Panier.Add(produit);
                MessageBox.Show("Produit ajouté au panier Case 2 avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            
        }

        private Boolean identicalId(List<Produit> prod,int id)
        {
            foreach(Produit pr in prod)
            {
                if (pr.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
