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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdDepense
            // 
            this.lblIdDepense.AutoSize = true;
            this.lblIdDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDepense.Location = new System.Drawing.Point(12, 19);
            this.lblIdDepense.Name = "lblIdDepense";
            this.lblIdDepense.Size = new System.Drawing.Size(101, 15);
            this.lblIdDepense.TabIndex = 0;
            this.lblIdDepense.Text = "Id dépense          :";
            // 
            // cboDepense
            // 
            this.cboDepense.FormattingEnabled = true;
            this.cboDepense.Location = new System.Drawing.Point(119, 19);
            this.cboDepense.Name = "cboDepense";
            this.cboDepense.Size = new System.Drawing.Size(55, 21);
            this.cboDepense.TabIndex = 1;
            // 
            // lblLibelleDepense
            // 
            this.lblLibelleDepense.AutoSize = true;
            this.lblLibelleDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelleDepense.Location = new System.Drawing.Point(12, 48);
            this.lblLibelleDepense.Name = "lblLibelleDepense";
            this.lblLibelleDepense.Size = new System.Drawing.Size(103, 15);
            this.lblLibelleDepense.TabIndex = 2;
            this.lblLibelleDepense.Text = "Libelle Depense :";
            // 
            // cboLibelleDepense
            // 
            this.cboLibelleDepense.FormattingEnabled = true;
            this.cboLibelleDepense.Location = new System.Drawing.Point(119, 48);
            this.cboLibelleDepense.Name = "cboLibelleDepense";
            this.cboLibelleDepense.Size = new System.Drawing.Size(121, 21);
            this.cboLibelleDepense.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 210);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(274, 45);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(15, 311);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(96, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Mettre a jour";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(193, 311);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(274, 311);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // ParametreDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 357);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboLibelleDepense);
            this.Controls.Add(this.lblLibelleDepense);
            this.Controls.Add(this.cboDepense);
            this.Controls.Add(this.lblIdDepense);
            this.Name = "ParametreDepense";
            this.Text = "Parametre pour les recette";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdDepense;
        private System.Windows.Forms.ComboBox cboDepense;
        private System.Windows.Forms.Label lblLibelleDepense;
        private System.Windows.Forms.ComboBox cboLibelleDepense;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
    }
}