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
    
    public partial class FrmMenuLivreur : Form
    {
        private User user;
        public FrmMenuLivreur(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            loadLivraisons();
        }

        private void loadLivraisons()
        {
            clearChildren();
            FrmLivreurLivraisons frm = new FrmLivreurLivraisons(user.Id);
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

        private void FrmMenuLivreur_Load(object sender, EventArgs e)
        {
            loadLivraisons();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmConnexion frm = new FrmConnexion();
            frm.Show();
            this.Hide();
        }
    }
}
