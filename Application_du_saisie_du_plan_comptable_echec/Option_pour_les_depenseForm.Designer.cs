namespace Application_du_saisie_du_plan_comptable_echec
{
    partial class ParametreDepense
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
            this.lblIdDepense = new System.Windows.Forms.Label();
            this.cboDepense = new System.Windows.Forms.ComboBox();
            this.lblLibelleDepense = new System.Windows.Forms.Label();
            this.cboLibelleDepense = new System.Windows.Forms.ComboBox();
            this.dgvDepense = new System.Windows.Forms.DataGridView();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepense)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdDepense
            // 
            this.lblIdDepense.AutoSize = true;
            this.lblIdDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDepense.Location = new System.Drawing.Point(16, 23);
            this.lblIdDepense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdDepense.Name = "lblIdDepense";
            this.lblIdDepense.Size = new System.Drawing.Size(123, 18);
            this.lblIdDepense.TabIndex = 0;
            this.lblIdDepense.Text = "Id dépense          :";
            // 
            // cboDepense
            // 
            this.cboDepense.FormattingEnabled = true;
            this.cboDepense.Location = new System.Drawing.Point(159, 23);
            this.cboDepense.Margin = new System.Windows.Forms.Padding(4);
            this.cboDepense.Name = "cboDepense";
            this.cboDepense.Size = new System.Drawing.Size(72, 24);
            this.cboDepense.TabIndex = 1;
            // 
            // lblLibelleDepense
            // 
            this.lblLibelleDepense.AutoSize = true;
            this.lblLibelleDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelleDepense.Location = new System.Drawing.Point(16, 59);
            this.lblLibelleDepense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibelleDepense.Name = "lblLibelleDepense";
            this.lblLibelleDepense.Size = new System.Drawing.Size(120, 18);
            this.lblLibelleDepense.TabIndex = 2;
            this.lblLibelleDepense.Text = "Libelle Depense :";
            // 
            // cboLibelleDepense
            // 
            this.cboLibelleDepense.FormattingEnabled = true;
            this.cboLibelleDepense.Location = new System.Drawing.Point(159, 59);
            this.cboLibelleDepense.Margin = new System.Windows.Forms.Padding(4);
            this.cboLibelleDepense.Name = "cboLibelleDepense";
            this.cboLibelleDepense.Size = new System.Drawing.Size(160, 24);
            this.cboLibelleDepense.TabIndex = 3;
            // 
            // dgvDepense
            // 
            this.dgvDepense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepense.Location = new System.Drawing.Point(20, 117);
            this.dgvDepense.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDepense.Name = "dgvDepense";
            this.dgvDepense.RowHeadersWidth = 51;
            this.dgvDepense.Size = new System.Drawing.Size(445, 258);
            this.dgvDepense.TabIndex = 4;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(365, 55);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(100, 28);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(20, 383);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 383);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Mettre a jour";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(257, 383);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(365, 383);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 28);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // ParametreDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 439);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dgvDepense);
            this.Controls.Add(this.cboLibelleDepense);
            this.Controls.Add(this.lblLibelleDepense);
            this.Controls.Add(this.cboDepense);
            this.Controls.Add(this.lblIdDepense);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParametreDepense";
            this.Text = "Parametre pour les Depense";
            this.Load += new System.EventHandler(this.ParametreDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdDepense;
        private System.Windows.Forms.ComboBox cboDepense;
        private System.Windows.Forms.Label lblLibelleDepense;
        private System.Windows.Forms.ComboBox cboLibelleDepense;
        private System.Windows.Forms.DataGridView dgvDepense;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
    }
}