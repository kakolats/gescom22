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
using Action = gescom22.utils.Action;

namespace gescom22
{
    public partial class FrmGestionProduits : Form
    {
        private readonly string IMG_DEFAULT = @"C:\Users\HP\Documents\TROISIEME ANNEE\C#\Gescom\gescom22\Resources\téléchargement.png";
        private Service service = new Service();
        private string fileName;
        private Produit prodSelected;
        public FrmGestionProduits()
        {
            InitializeComponent();
        }

        private void loadDataGridProduits()
        {
            dtgvProduits.AutoGenerateColumns = false;
            dtgvProduits.DataSource=service.showAllProduit();
        }

        
        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.jpeg Files (*.jpeg)|*.jpeg|.jpg Files (*.jpg)|*.jpg|.png Files (*.png)|*.png";

            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picBoxProduit.Image = Image.FromFile(dialog.FileName);

                fileName = dialog.FileName;

            }
        }

        private void FrmGestionProduits_Load(object sender, EventArgs e)
        {
            loadComboBoxCategorie();
            loadDataGridProduits();
            FormUtils.desactiveFields(btnAdd, btnUp, btnDel, Action.ADD);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbLibelle.Text)
                || string.IsNullOrEmpty(txtbPrix.Text)
                || string.IsNullOrEmpty(txtbStock.Text)
                || string.IsNullOrEmpty(txtbDescription.Text))
            {
                MessageBox.Show("Champs Obligatoires", "Erreur", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(fileName)) fileName = IMG_DEFAULT;
                byte[] image = MyImage.convertImageToByte(fileName);
                string libelle = txtbLibelle.Text.Trim();
                double prix = Convert.ToDouble(txtbPrix.Text);
                int stock = Convert.ToInt32(txtbStock.Text);
                string description = txtbDescription.Text;
                Produit produit = new Produit()
                {
                    Libelle = libelle,
                    Prix = prix,
                    Stock = stock,
                    Description = description,
                    Image = image
                };
                Categorie cat = (Categorie)cboCategorie.SelectedItem;
                Console.WriteLine(cat.Libelle);
                produit.Categorie = cat;
                service.addProduit(produit);
                MessageBox.Show("Produit  Ajouté avec Success", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGridProduits();
                clearFields();

            }
            
        }


        private void loadComboBoxCategorie()
        {
            cboCategorie.DataSource = service.showAllCategories();
            cboCategorie.DisplayMember = "Libelle";
            cboCategorie.ValueMember = "Id";
        }
        private void clearFields()
        {
            txtbLibelle.Clear();
            txtbDescription.Clear();
            txtbLibelle.Clear();
            txtbPrix.Clear();
            txtbStock.Clear();
            loadComboBoxCategorie();
            prodSelected = null;
            btnAddFieldsState();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clearFields();
            FormUtils.desactiveFields(btnAdd, btnUp, btnDel, Action.ADD);
        }

        

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (prodSelected != null)
            {
                if (txtbStock.Text != "")
                {
                    service.updateProduit(prodSelected.Id, int.Parse(txtbStock.Text));
                    loadDataGridProduits();
                    btnAddFieldsState();
                    clearFields();
                }
                
            }
        }

        private void btnUpFieldsState()
        {
            FormUtils.activeTextBoxes(gBoxProductData,false);
            txtbStock.Enabled = true;
            btnUploadPic.Enabled = false;
        }

        private void btnAddFieldsState()
        {
            FormUtils.activeTextBoxes(gBoxProductData, true);
            btnUploadPic.Enabled = true;
        }

        private void dtgvProduits_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dtgvProduits.Rows.Count - 1)
            {
                FormUtils.desactiveFields(btnAdd, btnUp, btnDel, Action.UPDEL);
                DataGridViewRow row = dtgvProduits.Rows[e.RowIndex];
                row.Selected = true;
                prodSelected = (Produit)row.DataBoundItem;
                txtbLibelle.Text = row.Cells[1].Value.ToString();
                txtbPrix.Text = row.Cells[2].Value.ToString();
                txtbStock.Text = row.Cells[3].Value.ToString();
                btnUpFieldsState();
            }
        }
    }
}
