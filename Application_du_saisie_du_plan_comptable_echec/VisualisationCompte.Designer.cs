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
            this.lblLibelleCompte = new System.Windows.Forms.Label();
            this.txtLibelleCompte = new System.Windows.Forms.TextBox();
            this.lblSoldeCompte = new System.Windows.Forms.Label();
            this.numSoldeCompte = new System.Windows.Forms.NumericUpDown();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.dgvCompte = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnUpdateSolde = new System.Windows.Forms.Button();
            this.txtNumCompte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSoldeCompte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumCompte
            // 
            this.lblNumCompte.AutoSize = true;
            this.lblNumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCompte.Location = new System.Drawing.Point(16, 23);
            this.lblNumCompte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumCompte.Name = "lblNumCompte";
            this.lblNumCompte.Size = new System.Drawing.Size(144, 18);
            this.lblNumCompte.TabIndex = 0;
            this.lblNumCompte.Text = "Numéro de compte :";
            // 
            // lblLibelleCompte
            // 
            this.lblLibelleCompte.AutoSize = true;
            this.lblLibelleCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelleCompte.Location = new System.Drawing.Point(16, 66);
            this.lblLibelleCompte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibelleCompte.Name = "lblLibelleCompte";
            this.lblLibelleCompte.Size = new System.Drawing.Size(131, 18);
            this.lblLibelleCompte.TabIndex = 2;
            this.lblLibelleCompte.Text = "Libelle du compte :";
            // 
            // txtLibelleCompte
            // 
            this.txtLibelleCompte.Location = new System.Drawing.Point(183, 65);
            this.txtLibelleCompte.Margin = new System.Windows.Forms.Padding(4);
            this.txtLibelleCompte.Name = "txtLibelleCompte";
            this.txtLibelleCompte.Size = new System.Drawing.Size(132, 22);
            this.txtLibelleCompte.TabIndex = 3;
            // 
            // lblSoldeCompte
            // 
            this.lblSoldeCompte.AutoSize = true;
            this.lblSoldeCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldeCompte.Location = new System.Drawing.Point(16, 108);
            this.lblSoldeCompte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoldeCompte.Name = "lblSoldeCompte";
            this.lblSoldeCompte.Size = new System.Drawing.Size(128, 18);
            this.lblSoldeCompte.TabIndex = 4;
            this.lblSoldeCompte.Text = "Solde du compte :";
            // 
            // numSoldeCompte
            // 
            this.numSoldeCompte.Location = new System.Drawing.Point(183, 108);
            this.numSoldeCompte.Margin = new System.Windows.Forms.Padding(4);
            this.numSoldeCompte.Name = "numSoldeCompte";
            this.numSoldeCompte.Size = new System.Drawing.Size(133, 22);
            this.numSoldeCompte.TabIndex = 5;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(367, 108);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(100, 28);
            this.btnRechercher.TabIndex = 6;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // dgvCompte
            // 
            this.dgvCompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompte.Location = new System.Drawing.Point(20, 150);
            this.dgvCompte.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCompte.Name = "dgvCompte";
            this.dgvCompte.RowHeadersWidth = 51;
            this.dgvCompte.Size = new System.Drawing.Size(447, 212);
            this.dgvCompte.TabIndex = 7;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(16, 369);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSolde
            // 
            this.btnUpdateSolde.Location = new System.Drawing.Point(308, 369);
            this.btnUpdateSolde.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateSolde.Name = "btnUpdateSolde";
            this.btnUpdateSolde.Size = new System.Drawing.Size(159, 28);
            this.btnUpdateSolde.TabIndex = 9;
            this.btnUpdateSolde.Text = "Mettre a jour le solde";
            this.btnUpdateSolde.UseVisualStyleBackColor = true;
            // 
            // txtNumCompte
            // 
            this.txtNumCompte.Location = new System.Drawing.Point(183, 22);
            this.txtNumCompte.Name = "txtNumCompte";
            this.txtNumCompte.Size = new System.Drawing.Size(28, 22);
            this.txtNumCompte.TabIndex = 10;
            // 
            // VisualisationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 427);
            this.Controls.Add(this.txtNumCompte);
            this.Controls.Add(this.btnUpdateSolde);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dgvCompte);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.numSoldeCompte);
            this.Controls.Add(this.lblSoldeCompte);
            this.Controls.Add(this.txtLibelleCompte);
            this.Controls.Add(this.lblLibelleCompte);
            this.Controls.Add(this.lblNumCompte);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisualisationCompte";
            this.Text = "Compte";
            this.Load += new System.EventHandler(this.VisualisationCompte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoldeCompte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumCompte;
        private System.Windows.Forms.Label lblLibelleCompte;
        private System.Windows.Forms.TextBox txtLibelleCompte;
        private System.Windows.Forms.Label lblSoldeCompte;
        private System.Windows.Forms.NumericUpDown numSoldeCompte;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dgvCompte;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnUpdateSolde;
        private System.Windows.Forms.TextBox txtNumCompte;
    }
}