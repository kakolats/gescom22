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
    public partial class FrmRpMenu : Form
    {
        private User user;
        public FrmRpMenu(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void loadGestionProduits()
        {
            clearChildren();
            FrmGestionProduits frm = new FrmGestionProduits();
            frm.MdiParent = this;
            frm.Show();
        }

        public void clearChildren()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void FrmRpMenu_Load(object sender, EventArgs e)
        {
            loadGestionProduits();
        }

        private void lblGererProduit_Click(object sender, EventArgs e)
        {
            loadGestionProduits();
        }

        private void lblGererCommande_Click(object sender, EventArgs e)
        {
            clearChildren();
            FrmGestionCommandes frm = new FrmGestionCommandes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lblDeconnexion_Click(object sender, EventArgs e)
        {
            FrmConnexion frm = new FrmConnexion();
            frm.Show();
            this.Hide();
        }
    }
}
