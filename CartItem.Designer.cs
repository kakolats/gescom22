
namespace gescom22
{
    partial class CartItem
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuantite = new System.Windows.Forms.Label();
            this.picMinus = new System.Windows.Forms.PictureBox();
            this.picPlus = new System.Windows.Forms.PictureBox();
            this.picBoxProduct = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(435, 121);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(35, 13);
            this.lblQuantite.TabIndex = 10;
            this.lblQuantite.Text = "label1";
            // 
            // picMinus
            // 
            this.picMinus.Image = global::gescom22.Properties.Resources.minus;
            this.picMinus.Location = new System.Drawing.Point(482, 104);
            this.picMinus.Name = "picMinus";
            this.picMinus.Size = new System.Drawing.Size(33, 30);
            this.picMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinus.TabIndex = 9;
            this.picMinus.TabStop = false;
            this.picMinus.Click += new System.EventHandler(this.picMinus_Click);
            // 
            // picPlus
            // 
            this.picPlus.Image = global::gescom22.Properties.Resources._1200px_OOjs_UI_icon_add_svg;
            this.picPlus.Location = new System.Drawing.Point(396, 104);
            this.picPlus.Name = "picPlus";
            this.picPlus.Size = new System.Drawing.Size(33, 30);
            this.picPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlus.TabIndex = 8;
            this.picPlus.TabStop = false;
            this.picPlus.Click += new System.EventHandler(this.picPlus_Click);
            // 
            // picBoxProduct
            // 
            this.picBoxProduct.Image = global::gescom22.Properties.Resources.téléchargement;
            this.picBoxProduct.Location = new System.Drawing.Point(20, 26);
            this.picBoxProduct.Name = "picBoxProduct";
            this.picBoxProduct.Size = new System.Drawing.Size(121, 108);
            this.picBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProduct.TabIndex = 11;
            this.picBoxProduct.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "CFA";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(194, 61);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(28, 15);
            this.lblPrix.TabIndex = 13;
            this.lblPrix.Text = "Prix";
            // 
            // lblLibelle
            // 
            this.lblLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelle.Location = new System.Drawing.Point(163, 26);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(343, 23);
            this.lblLibelle.TabIndex = 12;
            this.lblLibelle.Text = "Libelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(219, 121);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 15);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total";
            // 
            // btnRetirer
            // 
            this.btnRetirer.Location = new System.Drawing.Point(457, 26);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(75, 23);
            this.btnRetirer.TabIndex = 17;
            this.btnRetirer.Text = "Retirer";
            this.btnRetirer.UseVisualStyleBackColor = true;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(336, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "label3";
            this.lblId.Visible = false;
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnRetirer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.picBoxProduct);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.picMinus);
            this.Controls.Add(this.picPlus);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(549, 150);
            this.Load += new System.EventHandler(this.CartItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMinus;
        private System.Windows.Forms.PictureBox picPlus;
        private System.Windows.Forms.PictureBox picBoxProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetirer;
        public System.Windows.Forms.Label lblPrix;
        public System.Windows.Forms.Label lblLibelle;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Label lblQuantite;
    }
}
