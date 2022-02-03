
namespace gescom22
{
    partial class CtrlProduct
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
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxProduct = new System.Windows.Forms.PictureBox();
            this.btnRDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLibelle
            // 
            this.lblLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelle.Location = new System.Drawing.Point(204, 20);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(343, 23);
            this.lblLibelle.TabIndex = 1;
            this.lblLibelle.Text = "Libelle";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(235, 55);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(28, 15);
            this.lblPrix.TabIndex = 2;
            this.lblPrix.Text = "Prix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "CFA";
            // 
            // picBoxProduct
            // 
            this.picBoxProduct.Image = global::gescom22.Properties.Resources.téléchargement;
            this.picBoxProduct.Location = new System.Drawing.Point(30, 20);
            this.picBoxProduct.Name = "picBoxProduct";
            this.picBoxProduct.Size = new System.Drawing.Size(121, 108);
            this.picBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProduct.TabIndex = 0;
            this.picBoxProduct.TabStop = false;
            // 
            // btnRDetails
            // 
            this.btnRDetails.Location = new System.Drawing.Point(460, 88);
            this.btnRDetails.Name = "btnRDetails";
            this.btnRDetails.Size = new System.Drawing.Size(75, 23);
            this.btnRDetails.TabIndex = 18;
            this.btnRDetails.Text = "Details";
            this.btnRDetails.UseVisualStyleBackColor = true;
            this.btnRDetails.Click += new System.EventHandler(this.btnRDetails_Click);
            // 
            // CtrlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.picBoxProduct);
            this.Name = "CtrlProduct";
            this.Size = new System.Drawing.Size(577, 136);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxProduct;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRDetails;
    }
}
