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
    public partial class FrmCatalogue : Form
    {
        private int i = 0;
        Service service = new Service();
        public FrmCatalogue()
        {
            InitializeComponent();
        }

        private void FrmCatalogue_Load(object sender, EventArgs e)
        {
            //loadDataGridView();
            populateCatalogue();
        }
        /*
        private void loadDataGridView()
        {
            dtgvProduits.AutoGenerateColumns = false;
            dtgvProduits.DataSource = service.showAllProduit();
        }*/

        private void populateCatalogue()
        {
            List<Produit> produits = service.showAllProduit();
            CtrlProduct[] ctrlproduits = new CtrlProduct[produits.Count];
            
            foreach (Produit prod in produits)
            {
                ctrlproduits[i] = new CtrlProduct();
                ctrlproduits[i].Libelle = prod.Libelle;
                ctrlproduits[i].Prix = prod.Prix.ToString();
                ctrlproduits[i].Pic = MyImage.convertByteToImage(prod.Image);
                ctrlproduits[i].Id = prod.Id;
                /* (flowLayoutPanel1.Controls.Count > 0)
                {
                     flowLayoutPanel1.Controls.Clear();  
                }
                else*/
                flowLayoutPanel1.Controls.Add(ctrlproduits[i]);

                this.i += 1;
            }
        }

        
    }
}
