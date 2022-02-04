
namespace gescom22
{
    partial class FrmGestionProduits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionProduits));
            this.gBoxProductData = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.txtbPrix = new System.Windows.Forms.TextBox();
            this.txtbStock = new System.Windows.Forms.TextBox();
            this.txtbLibelle = new System.Windows.Forms.TextBox();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.picBoxProduit = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvProduits = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduit)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxProductData
            // 
            this.gBoxProductData.Controls.Add(this.btnAnnuler);
            this.gBoxProductData.Controls.Add(this.btnDel);
            this.gBoxProductData.Controls.Add(this.btnUp);
            this.gBoxProductData.Controls.Add(this.btnAdd);
            this.gBoxProductData.Controls.Add(this.cboCategorie);
            this.gBoxProductData.Controls.Add(this.label6);
            this.gBoxProductData.Controls.Add(this.label5);
            this.gBoxProductData.Controls.Add(this.label3);
            this.gBoxProductData.Controls.Add(this.label2);
            this.gBoxProductData.Controls.Add(this.label1);
            this.gBoxProductData.Controls.Add(this.txtbDescription);
            this.gBoxProductData.Controls.Add(this.txtbPrix);
            this.gBoxProductData.Controls.Add(this.txtbStock);
            this.gBoxProductData.Controls.Add(this.txtbLibelle);
            this.gBoxProductData.Controls.Add(this.btnUploadPic);
            this.gBoxProductData.Controls.Add(this.picBoxProduit);
            this.gBoxProductData.Location = new System.Drawing.Point(26, 29);
            this.gBoxProductData.Name = "gBoxProductData";
            this.gBoxProductData.Size = new System.Drawing.Size(317, 510);
            this.gBoxProductData.TabIndex = 0;
            this.gBoxProductData.TabStop = false;
            this.gBoxProductData.Text = "Produit";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(16, 468);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(55, 23);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(227, 468);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(55, 23);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(155, 468);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(55, 23);
            this.btnUp.TabIndex = 15;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(85, 468);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboCategorie
            // 
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(98, 422);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(196, 21);
            this.cboCategorie.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Categorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Libelle";
            // 
            // txtbDescription
            // 
            this.txtbDescription.Location = new System.Drawing.Point(100, 305);
            this.txtbDescription.Multiline = true;
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(194, 92);
            this.txtbDescription.TabIndex = 6;
            // 
            // txtbPrix
            // 
            this.txtbPrix.Location = new System.Drawing.Point(100, 206);
            this.txtbPrix.Name = "txtbPrix";
            this.txtbPrix.Size = new System.Drawing.Size(194, 20);
            this.txtbPrix.TabIndex = 4;
            // 
            // txtbStock
            // 
            this.txtbStock.Location = new System.Drawing.Point(100, 252);
            this.txtbStock.Name = "txtbStock";
            this.txtbStock.Size = new System.Drawing.Size(194, 20);
            this.txtbStock.TabIndex = 3;
            // 
            // txtbLibelle
            // 
            this.txtbLibelle.Location = new System.Drawing.Point(100, 163);
            this.txtbLibelle.Name = "txtbLibelle";
            this.txtbLibelle.Size = new System.Drawing.Size(194, 20);
            this.txtbLibelle.TabIndex = 2;
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.Location = new System.Drawing.Point(126, 117);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(75, 23);
            this.btnUploadPic.TabIndex = 1;
            this.btnUploadPic.Text = "Upload";
            this.btnUploadPic.UseVisualStyleBackColor = true;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
            // 
            // picBoxProduit
            // 
            this.picBoxProduit.Image = ((System.Drawing.Image)(resources.GetObject("picBoxProduit.Image")));
            this.picBoxProduit.Location = new System.Drawing.Point(100, 44);
            this.picBoxProduit.Name = "picBoxProduit";
            this.picBoxProduit.Size = new System.Drawing.Size(119, 67);
            this.picBoxProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProduit.TabIndex = 0;
            this.picBoxProduit.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvProduits);
            this.groupBox2.Location = new System.Drawing.Point(392, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 510);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des produits";
            // 
            // dtgvProduits
            // 
            this.dtgvProduits.AllowUserToAddRows = false;
            this.dtgvProduits.AllowUserToDeleteRows = false;
            this.dtgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Libelle,
            this.Prix,
            this.Stock,
            this.Categorie});
            this.dtgvProduits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProduits.Location = new System.Drawing.Point(3, 16);
            this.dtgvProduits.Name = "dtgvProduits";
            this.dtgvProduits.ReadOnly = true;
            this.dtgvProduits.Size = new System.Drawing.Size(510, 491);
            this.dtgvProduits.TabIndex = 0;
            this.dtgvProduits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProduits_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 25;
            // 
            // Libelle
            // 
            this.Libelle.DataPropertyName = "Libelle";
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            this.Libelle.Width = 150;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "Prix";
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 75;
            // 
            // Categorie
            // 
            this.Categorie.DataPropertyName = "Categorie";
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.Name = "Categorie";
            this.Categorie.ReadOnly = true;
            this.Categorie.Width = 125;
            // 
            // FrmGestionProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBoxProductData);
            this.Name = "FrmGestionProduits";
            this.Text = "FrmGestionProduits";
            this.Load += new System.EventHandler(this.FrmGestionProduits_Load);
            this.gBoxProductData.ResumeLayout(false);
            this.gBoxProductData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxProductData;
        private System.Windows.Forms.PictureBox picBoxProduit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.TextBox txtbPrix;
        private System.Windows.Forms.TextBox txtbStock;
        private System.Windows.Forms.TextBox txtbLibelle;
        private System.Windows.Forms.Button btnUploadPic;
        private System.Windows.Forms.DataGridView dtgvProduits;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
        private System.Windows.Forms.Button btnAnnuler;
    }
}