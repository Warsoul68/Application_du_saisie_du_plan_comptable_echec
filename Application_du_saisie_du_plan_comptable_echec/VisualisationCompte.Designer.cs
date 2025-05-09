namespace Application_du_saisie_du_plan_comptable_echec
{
    partial class VisualisationCompte
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
            this.lblNumCompte = new System.Windows.Forms.Label();
            this.cboNumCompte = new System.Windows.Forms.ComboBox();
            this.lblLibelleCompte = new System.Windows.Forms.Label();
            this.txtLibelleCompte = new System.Windows.Forms.TextBox();
            this.lblSoldeCompte = new System.Windows.Forms.Label();
            this.numSoldeCompte = new System.Windows.Forms.NumericUpDown();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnUpdateSolde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoldeCompte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumCompte
            // 
            this.lblNumCompte.AutoSize = true;
            this.lblNumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCompte.Location = new System.Drawing.Point(12, 19);
            this.lblNumCompte.Name = "lblNumCompte";
            this.lblNumCompte.Size = new System.Drawing.Size(119, 15);
            this.lblNumCompte.TabIndex = 0;
            this.lblNumCompte.Text = "Numéro de compte :";
            // 
            // cboNumCompte
            // 
            this.cboNumCompte.FormattingEnabled = true;
            this.cboNumCompte.Location = new System.Drawing.Point(137, 19);
            this.cboNumCompte.Name = "cboNumCompte";
            this.cboNumCompte.Size = new System.Drawing.Size(54, 21);
            this.cboNumCompte.TabIndex = 1;
            // 
            // lblLibelleCompte
            // 
            this.lblLibelleCompte.AutoSize = true;
            this.lblLibelleCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelleCompte.Location = new System.Drawing.Point(12, 54);
            this.lblLibelleCompte.Name = "lblLibelleCompte";
            this.lblLibelleCompte.Size = new System.Drawing.Size(111, 15);
            this.lblLibelleCompte.TabIndex = 2;
            this.lblLibelleCompte.Text = "Libelle du compte :";
            // 
            // txtLibelleCompte
            // 
            this.txtLibelleCompte.Location = new System.Drawing.Point(137, 53);
            this.txtLibelleCompte.Name = "txtLibelleCompte";
            this.txtLibelleCompte.Size = new System.Drawing.Size(100, 20);
            this.txtLibelleCompte.TabIndex = 3;
            // 
            // lblSoldeCompte
            // 
            this.lblSoldeCompte.AutoSize = true;
            this.lblSoldeCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldeCompte.Location = new System.Drawing.Point(12, 88);
            this.lblSoldeCompte.Name = "lblSoldeCompte";
            this.lblSoldeCompte.Size = new System.Drawing.Size(106, 15);
            this.lblSoldeCompte.TabIndex = 4;
            this.lblSoldeCompte.Text = "Solde du compte :";
            // 
            // numSoldeCompte
            // 
            this.numSoldeCompte.Location = new System.Drawing.Point(137, 88);
            this.numSoldeCompte.Name = "numSoldeCompte";
            this.numSoldeCompte.Size = new System.Drawing.Size(100, 20);
            this.numSoldeCompte.TabIndex = 5;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(275, 88);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 6;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 172);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(12, 300);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSolde
            // 
            this.btnUpdateSolde.Location = new System.Drawing.Point(231, 300);
            this.btnUpdateSolde.Name = "btnUpdateSolde";
            this.btnUpdateSolde.Size = new System.Drawing.Size(119, 23);
            this.btnUpdateSolde.TabIndex = 9;
            this.btnUpdateSolde.Text = "Mettre a jour le solde";
            this.btnUpdateSolde.UseVisualStyleBackColor = true;
            // 
            // VisualisationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 347);
            this.Controls.Add(this.btnUpdateSolde);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.numSoldeCompte);
            this.Controls.Add(this.lblSoldeCompte);
            this.Controls.Add(this.txtLibelleCompte);
            this.Controls.Add(this.lblLibelleCompte);
            this.Controls.Add(this.cboNumCompte);
            this.Controls.Add(this.lblNumCompte);
            this.Name = "VisualisationCompte";
            this.Text = "Compte";
            ((System.ComponentModel.ISupportInitialize)(this.numSoldeCompte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumCompte;
        private System.Windows.Forms.ComboBox cboNumCompte;
        private System.Windows.Forms.Label lblLibelleCompte;
        private System.Windows.Forms.TextBox txtLibelleCompte;
        private System.Windows.Forms.Label lblSoldeCompte;
        private System.Windows.Forms.NumericUpDown numSoldeCompte;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnUpdateSolde;
    }
}