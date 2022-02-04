
namespace gescom22
{
    partial class FrmLivreurLivraisons
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
            this.dtgvLivraisons = new System.Windows.Forms.DataGridView();
            this.gpoDonnees = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbAdresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLivraisons)).BeginInit();
            this.gpoDonnees.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvLivraisons
            // 
            this.dtgvLivraisons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLivraisons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Statut});
            this.dtgvLivraisons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvLivraisons.Location = new System.Drawing.Point(3, 16);
            this.dtgvLivraisons.Name = "dtgvLivraisons";
            this.dtgvLivraisons.ReadOnly = true;
            this.dtgvLivraisons.Size = new System.Drawing.Size(393, 378);
            this.dtgvLivraisons.TabIndex = 0;
            // 
            // gpoDonnees
            // 
            this.gpoDonnees.Controls.Add(this.btnDone);
            this.gpoDonnees.Controls.Add(this.txtbNumero);
            this.gpoDonnees.Controls.Add(this.label2);
            this.gpoDonnees.Controls.Add(this.txtbAdresse);
            this.gpoDonnees.Controls.Add(this.label1);
            this.gpoDonnees.Location = new System.Drawing.Point(476, 42);
            this.gpoDonnees.Name = "gpoDonnees";
            this.gpoDonnees.Size = new System.Drawing.Size(419, 414);
            this.gpoDonnees.TabIndex = 1;
            this.gpoDonnees.TabStop = false;
            this.gpoDonnees.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvLivraisons);
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 397);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.Name = "Statut";
            this.Statut.ReadOnly = true;
            this.Statut.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresse";
            // 
            // txtbAdresse
            // 
            this.txtbAdresse.Location = new System.Drawing.Point(142, 57);
            this.txtbAdresse.Name = "txtbAdresse";
            this.txtbAdresse.Size = new System.Drawing.Size(223, 20);
            this.txtbAdresse.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero";
            // 
            // txtbNumero
            // 
            this.txtbNumero.Location = new System.Drawing.Point(142, 128);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(223, 20);
            this.txtbNumero.TabIndex = 3;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(258, 336);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(90, 30);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Livraison Faite";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EN COURS",
            "FAIT"});
            this.comboBox1.Location = new System.Drawing.Point(231, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // FrmLivreurLivraisons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 493);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpoDonnees);
            this.Name = "FrmLivreurLivraisons";
            this.Text = "FrmLivreurLivraisons";
            this.Load += new System.EventHandler(this.FrmLivreurLivraisons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLivraisons)).EndInit();
            this.gpoDonnees.ResumeLayout(false);
            this.gpoDonnees.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLivraisons;
        private System.Windows.Forms.GroupBox gpoDonnees;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtbNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbAdresse;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}