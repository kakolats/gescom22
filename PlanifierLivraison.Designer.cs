
namespace gescom22
{
    partial class PlanifierLivraison
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
            this.datePic = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLivreur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlanifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePic
            // 
            this.datePic.Location = new System.Drawing.Point(93, 36);
            this.datePic.Name = "datePic";
            this.datePic.Size = new System.Drawing.Size(216, 20);
            this.datePic.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // cboLivreur
            // 
            this.cboLivreur.FormattingEnabled = true;
            this.cboLivreur.Location = new System.Drawing.Point(93, 114);
            this.cboLivreur.Name = "cboLivreur";
            this.cboLivreur.Size = new System.Drawing.Size(216, 21);
            this.cboLivreur.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Livreur";
            // 
            // btnPlanifier
            // 
            this.btnPlanifier.Location = new System.Drawing.Point(321, 223);
            this.btnPlanifier.Name = "btnPlanifier";
            this.btnPlanifier.Size = new System.Drawing.Size(75, 23);
            this.btnPlanifier.TabIndex = 6;
            this.btnPlanifier.Text = "Planifier";
            this.btnPlanifier.UseVisualStyleBackColor = true;
            this.btnPlanifier.Click += new System.EventHandler(this.btnPlanifier_Click);
            // 
            // PlanifierLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 270);
            this.Controls.Add(this.btnPlanifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLivreur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePic);
            this.Name = "PlanifierLivraison";
            this.Text = "PlanifierLivraison";
            this.Load += new System.EventHandler(this.PlanifierLivraison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLivreur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlanifier;
    }
}