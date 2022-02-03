
namespace gescom22
{
    partial class FrmDetailsProduit
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
            this.picBoxProduct = new System.Windows.Forms.PictureBox();
            this.lblNomProduit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbPrix = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnCatalogue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxProduct
            // 
            this.picBoxProduct.Location = new System.Drawing.Point(278, 38);
            this.picBoxProduct.Name = "picBoxProduct";
            this.picBoxProduct.Size = new System.Drawing.Size(196, 143);
            this.picBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProduct.TabIndex = 0;
            this.picBoxProduct.TabStop = false;
            // 
            // lblNomProduit
            // 
            this.lblNomProduit.AutoSize = true;
            this.lblNomProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProduit.Location = new System.Drawing.Point(308, 199);
            this.lblNomProduit.Name = "lblNomProduit";
            this.lblNomProduit.Size = new System.Drawing.Size(117, 20);
            this.lblNomProduit.TabIndex = 1;
            this.lblNomProduit.Text = "Nom du produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtbDescription
            // 
            this.txtbDescription.Location = new System.Drawing.Point(200, 303);
            this.txtbDescription.Multiline = true;
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(274, 124);
            this.txtbDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prix";
            // 
            // txtbPrix
            // 
            this.txtbPrix.Location = new System.Drawing.Point(200, 250);
            this.txtbPrix.Name = "txtbPrix";
            this.txtbPrix.Size = new System.Drawing.Size(274, 20);
            this.txtbPrix.TabIndex = 5;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(373, 468);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(101, 28);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Ajouter au panier";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnCatalogue
            // 
            this.btnCatalogue.Location = new System.Drawing.Point(230, 468);
            this.btnCatalogue.Name = "btnCatalogue";
            this.btnCatalogue.Size = new System.Drawing.Size(117, 28);
            this.btnCatalogue.TabIndex = 7;
            this.btnCatalogue.Text = "Retour au catalogue";
            this.btnCatalogue.UseVisualStyleBackColor = true;
            this.btnCatalogue.Click += new System.EventHandler(this.btnCatalogue_Click);
            // 
            // FrmDetailsProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(799, 546);
            this.Controls.Add(this.btnCatalogue);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txtbPrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomProduit);
            this.Controls.Add(this.picBoxProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetailsProduit";
            this.Text = "FrmDetailsProduit";
            this.Load += new System.EventHandler(this.FrmDetailsProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxProduct;
        private System.Windows.Forms.Label lblNomProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbPrix;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnCatalogue;
    }
}