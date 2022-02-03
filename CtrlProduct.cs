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
    public partial class CtrlProduct : UserControl
    {
        private Service service=new Service();
        public CtrlProduct()
        {
            InitializeComponent();
        }

        #region Properties
        private int id;
        private string libelle;
        private string prix;
        private Image pic;

        [Category("Custom Props")]
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; lblLibelle.Text = value; }
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

        

        private void btnRDetails_Click(object sender, EventArgs e)
        {
            FrmUserMenu frm= (FrmUserMenu)this.ParentForm.ParentForm;
            frm.loadFrmDetails(service.findProduitById(this.Id));
        }
    }
}
