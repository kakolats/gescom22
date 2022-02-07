
namespace gescom22
{
    partial class FrmGestionCommandes
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
            this.dtgvDetail = new System.Windows.Forms.DataGridView();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvCommande = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStandBy = new System.Windows.Forms.Button();
            this.lblValidity = new System.Windows.Forms.Label();
            this.btnBoot = new System.Windows.Forms.Button();
            this.lblDispo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMakeLivraison = new System.Windows.Forms.Button();
            this.cboFiltre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDetail
            // 
            this.dtgvDetail.AllowUserToDeleteRows = false;
            this.dtgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Libelle,
            this.Quantite,
            this.Stock});
            this.dtgvDetail.Location = new System.Drawing.Point(538, 58);
            this.dtgvDetail.Name = "dtgvDetail";
            this.dtgvDetail.ReadOnly = true;
            this.dtgvDetail.Size = new System.Drawing.Size(367, 300);
            this.dtgvDetail.TabIndex = 3;
            this.dtgvDetail.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvDetail_CellMouseClick);
            // 
            // Libelle
            // 
            this.Libelle.DataPropertyName = "Produit";
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            this.Libelle.Width = 125;
            // 
            // Quantite
            // 
            this.Quantite.DataPropertyName = "Quantite";
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Produit";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // dtgvCommande
            // 
            this.dtgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Statut,
            this.User});
            this.dtgvCommande.Location = new System.Drawing.Point(26, 57);
            this.dtgvCommande.Name = "dtgvCommande";
            this.dtgvCommande.Size = new System.Drawing.Size(492, 300);
            this.dtgvCommande.TabIndex = 2;
            this.dtgvCommande.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvCommande_CellMouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 200;
            // 
            // Statut
            // 
            this.Statut.DataPropertyName = "Etat";
            this.Statut.HeaderText = "Statut";
            this.Statut.Name = "Statut";
            this.Statut.ReadOnly = true;
            this.Statut.Width = 200;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Visible = false;
            // 
            // btnStandBy
            // 
            this.btnStandBy.Enabled = false;
            this.btnStandBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandBy.Location = new System.Drawing.Point(570, 478);
            this.btnStandBy.Name = "btnStandBy";
            this.btnStandBy.Size = new System.Drawing.Size(149, 40);
            this.btnStandBy.TabIndex = 15;
            this.btnStandBy.Text = "Mettre en attente";
            this.btnStandBy.UseVisualStyleBackColor = true;
            this.btnStandBy.Click += new System.EventHandler(this.btnStandBy_Click);
            // 
            // lblValidity
            // 
            this.lblValidity.AutoSize = true;
            this.lblValidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidity.Location = new System.Drawing.Point(599, 414);
            this.lblValidity.Name = "lblValidity";
            this.lblValidity.Size = new System.Drawing.Size(120, 17);
            this.lblValidity.TabIndex = 14;
            this.lblValidity.Text = "Commande valide";
            this.lblValidity.Visible = false;
            // 
            // btnBoot
            // 
            this.btnBoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoot.Location = new System.Drawing.Point(198, 484);
            this.btnBoot.Name = "btnBoot";
            this.btnBoot.Size = new System.Drawing.Size(96, 29);
            this.btnBoot.TabIndex = 13;
            this.btnBoot.Text = "Renitialiser";
            this.btnBoot.UseVisualStyleBackColor = true;
            this.btnBoot.Click += new System.EventHandler(this.btnBoot_Click);
            // 
            // lblDispo
            // 
            this.lblDispo.AutoSize = true;
            this.lblDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispo.Location = new System.Drawing.Point(722, 382);
            this.lblDispo.Name = "lblDispo";
            this.lblDispo.Size = new System.Drawing.Size(16, 17);
            this.lblDispo.TabIndex = 12;
            this.lblDispo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(599, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stock Disponible:";
            // 
            // btnMakeLivraison
            // 
            this.btnMakeLivraison.Enabled = false;
            this.btnMakeLivraison.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeLivraison.Location = new System.Drawing.Point(749, 478);
            this.btnMakeLivraison.Name = "btnMakeLivraison";
            this.btnMakeLivraison.Size = new System.Drawing.Size(156, 40);
            this.btnMakeLivraison.TabIndex = 10;
            this.btnMakeLivraison.Text = "Planifier la livraison";
            this.btnMakeLivraison.UseVisualStyleBackColor = true;
            this.btnMakeLivraison.Click += new System.EventHandler(this.btnMakeLivraison_Click);
            // 
            // cboFiltre
            // 
            this.cboFiltre.FormattingEnabled = true;
            this.cboFiltre.Location = new System.Drawing.Point(318, 30);
            this.cboFiltre.Name = "cboFiltre";
            this.cboFiltre.Size = new System.Drawing.Size(200, 21);
            this.cboFiltre.TabIndex = 16;
            this.cboFiltre.TextChanged += new System.EventHandler(this.cboFiltre_TextChanged);
            // 
            // FrmGestionCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 554);
            this.Controls.Add(this.cboFiltre);
            this.Controls.Add(this.btnStandBy);
            this.Controls.Add(this.lblValidity);
            this.Controls.Add(this.btnBoot);
            this.Controls.Add(this.lblDispo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMakeLivraison);
            this.Controls.Add(this.dtgvDetail);
            this.Controls.Add(this.dtgvCommande);
            this.Name = "FrmGestionCommandes";
            this.Text = "FrmGestionCommandes";
            this.Load += new System.EventHandler(this.FrmGestionCommandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridView dtgvCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.Button btnStandBy;
        private System.Windows.Forms.Label lblValidity;
        private System.Windows.Forms.Button btnBoot;
        private System.Windows.Forms.Label lblDispo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMakeLivraison;
        private System.Windows.Forms.ComboBox cboFiltre;
    }
}