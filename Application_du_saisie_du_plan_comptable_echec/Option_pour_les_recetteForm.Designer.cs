namespace Application_du_saisie_du_plan_comptable_echec
{
    partial class ParametreRecette
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
            this.lblIdRecette = new System.Windows.Forms.Label();
            this.cboIdRecette = new System.Windows.Forms.ComboBox();
            this.lblLibelleRecette = new System.Windows.Forms.Label();
            this.cboLibelleRecette = new System.Windows.Forms.ComboBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.dgvRecette = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecette)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdRecette
            // 
            this.lblIdRecette.AutoSize = true;
            this.lblIdRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRecette.Location = new System.Drawing.Point(28, 24);
            this.lblIdRecette.Name = "lblIdRecette";
            this.lblIdRecette.Size = new System.Drawing.Size(95, 15);
            this.lblIdRecette.TabIndex = 0;
            this.lblIdRecette.Text = "Id Recette          :";
            // 
            // cboIdRecette
            // 
            this.cboIdRecette.FormattingEnabled = true;
            this.cboIdRecette.Location = new System.Drawing.Point(129, 23);
            this.cboIdRecette.Name = "cboIdRecette";
            this.cboIdRecette.Size = new System.Drawing.Size(56, 21);
            this.cboIdRecette.TabIndex = 1;
            // 
            // lblLibelleRecette
            // 
            this.lblLibelleRecette.AutoSize = true;
            this.lblLibelleRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelleRecette.Location = new System.Drawing.Point(28, 47);
            this.lblLibelleRecette.Name = "lblLibelleRecette";
            this.lblLibelleRecette.Size = new System.Drawing.Size(95, 15);
            this.lblLibelleRecette.TabIndex = 2;
            this.lblLibelleRecette.Text = "Libelle Recette :";
            // 
            // cboLibelleRecette
            // 
            this.cboLibelleRecette.FormattingEnabled = true;
            this.cboLibelleRecette.Location = new System.Drawing.Point(129, 47);
            this.cboLibelleRecette.Name = "cboLibelleRecette";
            this.cboLibelleRecette.Size = new System.Drawing.Size(124, 21);
            this.cboLibelleRecette.TabIndex = 3;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(295, 47);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher :";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // dgvRecette
            // 
            this.dgvRecette.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecette.Location = new System.Drawing.Point(31, 86);
            this.dgvRecette.Name = "dgvRecette";
            this.dgvRecette.Size = new System.Drawing.Size(339, 150);
            this.dgvRecette.TabIndex = 5;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(31, 242);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(295, 242);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(112, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Mettre a jour";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(214, 242);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // ParametreRecette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 287);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dgvRecette);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.cboLibelleRecette);
            this.Controls.Add(this.lblLibelleRecette);
            this.Controls.Add(this.cboIdRecette);
            this.Controls.Add(this.lblIdRecette);
            this.Name = "ParametreRecette";
            this.Text = "Parametre pour les Recette";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdRecette;
        private System.Windows.Forms.ComboBox cboIdRecette;
        private System.Windows.Forms.Label lblLibelleRecette;
        private System.Windows.Forms.ComboBox cboLibelleRecette;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dgvRecette;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSupprimer;
    }
}