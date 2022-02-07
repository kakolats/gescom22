
namespace gescom22
{
    partial class FrmCommandeValidation
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
            this.dtgvCommandes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvDetails = new System.Windows.Forms.DataGridView();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDsipo = new System.Windows.Forms.Label();
            this.btnReboot = new System.Windows.Forms.Button();
            this.lblValide = new System.Windows.Forms.Label();
            this.btnAttente = new System.Windows.Forms.Button();
            this.cboFiltre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCommandes
            // 
            this.dtgvCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Statut,
            this.User});
            this.dtgvCommandes.Location = new System.Drawing.Point(12, 57);
            this.dtgvCommandes.Name = "dtgvCommandes";
            this.dtgvCommandes.Size = new System.Drawing.Size(492, 300);
            this.dtgvCommandes.TabIndex = 0;
            this.dtgvCommandes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvCommandes_CellMouseClick);
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
            // dtgvDetails
            // 
            this.dtgvDetails.AllowUserToDeleteRows = false;
            this.dtgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Libelle,
            this.Quantite,
            this.Stock});
            this.dtgvDetails.Location = new System.Drawing.Point(524, 58);
            this.dtgvDetails.Name = "dtgvDetails";
            this.dtgvDetails.ReadOnly = true;
            this.dtgvDetails.Size = new System.Drawing.Size(367, 300);
            this.dtgvDetails.TabIndex = 1;
            this.dtgvDetails.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvDetails_CellMouseClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Commandes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Details";
            // 
            // btnValidation
            // 
            this.btnValidation.Enabled = false;
            this.btnValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidation.Location = new System.Drawing.Point(710, 479);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(80, 40);
            this.btnValidation.TabIndex = 4;
            this.btnValidation.Text = "Valider";
            this.btnValidation.UseVisualStyleBackColor = true;
            this.btnValidation.Click += new System.EventHandler(this.btnValidation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock Disponible:";
            // 
            // lblDsipo
            // 
            this.lblDsipo.AutoSize = true;
            this.lblDsipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDsipo.Location = new System.Drawing.Point(660, 383);
            this.lblDsipo.Name = "lblDsipo";
            this.lblDsipo.Size = new System.Drawing.Size(16, 17);
            this.lblDsipo.TabIndex = 6;
            this.lblDsipo.Text = "0";
            // 
            // btnReboot
            // 
            this.btnReboot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReboot.Location = new System.Drawing.Point(35, 485);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(96, 29);
            this.btnReboot.TabIndex = 7;
            this.btnReboot.Text = "Renitialiser";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // lblValide
            // 
            this.lblValide.AutoSize = true;
            this.lblValide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValide.Location = new System.Drawing.Point(537, 415);
            this.lblValide.Name = "lblValide";
            this.lblValide.Size = new System.Drawing.Size(120, 17);
            this.lblValide.TabIndex = 8;
            this.lblValide.Text = "Commande valide";
            this.lblValide.Visible = false;
            // 
            // btnAttente
            // 
            this.btnAttente.Enabled = false;
            this.btnAttente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttente.Location = new System.Drawing.Point(540, 479);
            this.btnAttente.Name = "btnAttente";
            this.btnAttente.Size = new System.Drawing.Size(149, 40);
            this.btnAttente.TabIndex = 9;
            this.btnAttente.Text = "Mettre en attente";
            this.btnAttente.UseVisualStyleBackColor = true;
            this.btnAttente.Click += new System.EventHandler(this.btnAttente_Click);
            // 
            // cboFiltre
            // 
            this.cboFiltre.FormattingEnabled = true;
            this.cboFiltre.Location = new System.Drawing.Point(304, 30);
            this.cboFiltre.Name = "cboFiltre";
            this.cboFiltre.Size = new System.Drawing.Size(200, 21);
            this.cboFiltre.TabIndex = 17;
            this.cboFiltre.TextChanged += new System.EventHandler(this.cboFiltre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Deconnexion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmCommandeValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 623);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboFiltre);
            this.Controls.Add(this.btnAttente);
            this.Controls.Add(this.lblValide);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.lblDsipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValidation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDetails);
            this.Controls.Add(this.dtgvCommandes);
            this.Name = "FrmCommandeValidation";
            this.Text = "FrmCommandeValidation";
            this.Load += new System.EventHandler(this.btnAttente_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCommandes;
        private System.Windows.Forms.DataGridView dtgvDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValidation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDsipo;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Label lblValide;
        private System.Windows.Forms.Button btnAttente;
        private System.Windows.Forms.ComboBox cboFiltre;
        private System.Windows.Forms.Label label4;
    }
}