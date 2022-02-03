using gescom22.dto;
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
    public partial class FrmCart : Form
    {
        Service service = new Service();
        List<Produit> produits;
        int i=0;
        double montant = 0;
        public FrmCart(List<Produit> produit)
        {
            this.produits = produit;
            InitializeComponent();
        }

        private void FrmCart_Load(object sender, EventArgs e)
        {
            populateCart();
            settingTotal();
        }

        private void populateCart()
        {
            CartItem[] items = new CartItem[produits.Count];
            if (produits.Count > 0)
            {
                foreach (Produit prod in produits)
                {
                    items[i] = new CartItem();
                    items[i].Libelle = prod.Libelle;
                    items[i].Prix = prod.Prix.ToString();
                    items[i].Pic = MyImage.convertByteToImage(prod.Image);
                    items[i].Id = prod.Id;
                    /* (flowLayoutPanel1.Controls.Count > 0)
                    {
                        flowLayoutPanel1.Controls.Clear();  
                     }
                     else*/
                     flowLayoutPanel1.Controls.Add(items[i]);

                     this.i += 1;
                }
            }
            
        }

        public void settingTotal()
        {
            foreach(CartItem con in flowLayoutPanel1.Controls)
            {
                montant += int.Parse(con.lblTotal.Text);
                lblTotal.Text = montant.ToString();
            }
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            settingTotal();
            Commande com = new Commande()
            {
                Date = DateTime.Today,
                Montant = Double.Parse(lblTotal.Text),
                AdresseLivraison=((Client)FrmUserMenu.User).Adresse,
                Etat="EN ATTENTE",
                Client=service.findClientById(FrmUserMenu.User.Id)
                
            };
            List<DetailsCommandeDTO> details=new List<DetailsCommandeDTO>();
            foreach (CartItem con in flowLayoutPanel1.Controls)
            {
                DetailsCommandeDTO detail = new DetailsCommandeDTO()
                {
                    Quantite=int.Parse(con.lblQuantite.Text),
                    Produit=service.findProduitById(con.Id)
                };
                details.Add(detail);
            }
            service.addCommande(com, details);
            MessageBox.Show("Commande effectuee avec Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmUserMenu.Panier = new List<Produit>();
            FrmUserMenu frm = (FrmUserMenu)this.ParentForm;
            frm.loadFrmCatalogue();

        }
    }
}
