﻿namespace Application_du_saisie_du_plan_comptable_echec
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
            this.lblLibelleRecette = new System.Windows.Forms.Label();
            this.dgvRecette = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtLibelleRecette = new System.Windows.Forms.TextBox();
            this.txtIdRecette = new System.Windows.Forms.TextBox();
            this.BtnRechercherId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecette)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdRecette
            // 
            this.lblIdRecette.AutoSize = true;
            this.lblIdRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRecette.Location = new System.Drawing.Point(37, 30);
            this.lblIdRecette.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdRecette.Name = "lblIdRecette";
            this.lblIdRecette.Size = new System.Drawing.Size(110, 18);
            this.lblIdRecette.TabIndex = 0;
            this.lblIdRecette.Text = "Id Recette        :";
            // 
            // lblLibelleRecette
            // 
            this.lblLibelleRecette.AutoSize = true;
            this.lblLibelleRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelleRecette.Location = new System.Drawing.Point(37, 58);
            this.lblLibelleRecette.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibelleRecette.Name = "lblLibelleRecette";
            this.lblLibelleRecette.Size = new System.Drawing.Size(112, 18);
            this.lblLibelleRecette.TabIndex = 2;
            this.lblLibelleRecette.Text = "Libelle Recette :";
            // 
            // dgvRecette
            // 
            this.dgvRecette.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecette.Location = new System.Drawing.Point(41, 106);
            this.dgvRecette.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecette.Name = "dgvRecette";
            this.dgvRecette.RowHeadersWidth = 51;
            this.dgvRecette.Size = new System.Drawing.Size(452, 185);
            this.dgvRecette.TabIndex = 5;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(41, 298);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(393, 298);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 28);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(149, 298);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Mettre a jour";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(285, 298);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // txtLibelleRecette
            // 
            this.txtLibelleRecette.Location = new System.Drawing.Point(172, 57);
            this.txtLibelleRecette.Name = "txtLibelleRecette";
            this.txtLibelleRecette.Size = new System.Drawing.Size(168, 22);
            this.txtLibelleRecette.TabIndex = 10;
            // 
            // txtIdRecette
            // 
            this.txtIdRecette.Location = new System.Drawing.Point(172, 29);
            this.txtIdRecette.Name = "txtIdRecette";
            this.txtIdRecette.Size = new System.Drawing.Size(100, 22);
            this.txtIdRecette.TabIndex = 11;
            // 
            // BtnRechercherId
            // 
            this.BtnRechercherId.Location = new System.Drawing.Point(393, 58);
            this.BtnRechercherId.Name = "BtnRechercherId";
            this.BtnRechercherId.Size = new System.Drawing.Size(145, 23);
            this.BtnRechercherId.TabIndex = 12;
            this.BtnRechercherId.Text = "Rechercher par id";
            this.BtnRechercherId.UseVisualStyleBackColor = true;
            this.BtnRechercherId.Click += new System.EventHandler(this.BtnRechercherId_Click);
            // 
            // ParametreRecette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 353);
            this.Controls.Add(this.BtnRechercherId);
            this.Controls.Add(this.txtIdRecette);
            this.Controls.Add(this.txtLibelleRecette);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dgvRecette);
            this.Controls.Add(this.lblLibelleRecette);
            this.Controls.Add(this.lblIdRecette);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParametreRecette";
            this.Text = "Parametre pour les Recette";
            this.Load += new System.EventHandler(this.ParametreRecette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdRecette;
        private System.Windows.Forms.Label lblLibelleRecette;
        private System.Windows.Forms.DataGridView dgvRecette;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtLibelleRecette;
        private System.Windows.Forms.TextBox txtIdRecette;
        private System.Windows.Forms.Button BtnRechercherId;
    }
}