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
            this.lblLibelleDepense = new System.Windows.Forms.Label();
            this.dgvDepense = new System.Windows.Forms.DataGridView();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtIdDepense = new System.Windows.Forms.TextBox();
            this.txtLibelleDepense = new System.Windows.Forms.TextBox();
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
            this.btnRechercher.Size = new System.Drawing.Size(129, 28);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher par id";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
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
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
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
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
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
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtIdDepense
            // 
            this.txtIdDepense.Location = new System.Drawing.Point(165, 23);
            this.txtIdDepense.Name = "txtIdDepense";
            this.txtIdDepense.Size = new System.Drawing.Size(54, 22);
            this.txtIdDepense.TabIndex = 10;
            // 
            // txtLibelleDepense
            // 
            this.txtLibelleDepense.Location = new System.Drawing.Point(165, 58);
            this.txtLibelleDepense.Name = "txtLibelleDepense";
            this.txtLibelleDepense.Size = new System.Drawing.Size(148, 22);
            this.txtLibelleDepense.TabIndex = 11;
            // 
            // ParametreDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 439);
            this.Controls.Add(this.txtLibelleDepense);
            this.Controls.Add(this.txtIdDepense);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dgvDepense);
            this.Controls.Add(this.lblLibelleDepense);
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
        private System.Windows.Forms.Label lblLibelleDepense;
        private System.Windows.Forms.DataGridView dgvDepense;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtIdDepense;
        private System.Windows.Forms.TextBox txtLibelleDepense;
    }
}