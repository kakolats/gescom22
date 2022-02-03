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
    public partial class CartItem : UserControl
    {
        public CartItem()
        {
            InitializeComponent();
        }

        #region Properties
        private int id;
        private int total;
        private string libelle;
        private string prix;
        private Image pic;
        private int number;

        [Category("Custom Props")]
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; lblLibelle.Text = value; }
        }

        [Category("Custom Props")]
        public int Number
        {
            get { return number; }
            set { number = value; lblQuantite.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public string Prix
        {
            get { return prix; }
            set { prix = value; lblPrix.Text = value; }
        }

        [Category("Custom Props")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Category("Custom Props")]
        public Image Pic
        {
            get { return pic; }
            set { pic = value; picBoxProduct.Image = value; }
        }

        #endregion

        private void picPlus_Click(object sender, EventArgs e)
        {
            this.number++;
            lblQuantite.Text = number.ToString();
            makeTotal();
        }

        private void picMinus_Click(object sender, EventArgs e)
        {
            this.number--;
            lblQuantite.Text = number.ToString();
            makeTotal();
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {

        }

        private void CartItem_Load(object sender, EventArgs e)
        {
            number = 1;
            lblQuantite.Text = number.ToString();
            makeTotal();
        }

        private void makeTotal()
        {
            total = (int.Parse(prix)*number);
            lblTotal.Text = total.ToString();
        }
    }
}
