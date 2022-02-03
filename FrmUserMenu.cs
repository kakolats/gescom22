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
    public partial class FrmUserMenu : Form
    {

        private static List<Produit> panier;
        private static User user;

        public static List<Produit> Panier { get => panier; set => panier = value; }
        public static User User { get => user; set => user = value; }

        public FrmUserMenu(User user)
        {
            FrmUserMenu.user = user;
            FrmUserMenu.Panier=new List<Produit>();
            InitializeComponent();
        }

        public void clearChildren()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void FrmUserMenu_Load(object sender, EventArgs e)
        {
            lblUserName.Text = user.NomComplet;
            loadFrmCatalogue();
        }

        public void loadFrmCatalogue()
        {
            clearChildren();
            FrmCatalogue frm = new FrmCatalogue();
            frm.MdiParent = this;
            frm.Show();
        }

        public void loadFrmDetails(Produit prod)
        {
            clearChildren();
            FrmDetailsProduit frm = new FrmDetailsProduit(prod);
            frm.MdiParent = this;
            frm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            loadFrmCatalogue();
        }

        private void lblPanier_Click(object sender, EventArgs e)
        {
            clearChildren();
            FrmCart frm = new FrmCart(FrmUserMenu.Panier);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
