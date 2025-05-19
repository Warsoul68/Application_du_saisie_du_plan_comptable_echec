namespace Application_du_saisie_du_plan_comptable_echec
{
    partial class OperationFr
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
            this.lblNomOperation = new System.Windows.Forms.Label();
            this.cboNomOperation = new System.Windows.Forms.ComboBox();
            this.lblAnneeResultat = new System.Windows.Forms.Label();
            this.dtpAnneeResultat = new System.Windows.Forms.DateTimePicker();
            this.lblDateTransaction = new System.Windows.Forms.Label();
            this.dtpDateTransaction = new System.Windows.Forms.DateTimePicker();
            this.lblMontant = new System.Windows.Forms.Label();
            this.numMontant = new System.Windows.Forms.NumericUpDown();
            this.lblTypeRecette = new System.Windows.Forms.Label();
            this.cboTypeRecette = new System.Windows.Forms.ComboBox();
            this.lblTypeDepense = new System.Windows.Forms.Label();
            this.cboTypeDepense = new System.Windows.Forms.ComboBox();
            this.dgvVueOpération = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRechercherParNomOperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVueOpération)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomOperation
            // 
            this.lblNomOperation.AutoSize = true;
            this.lblNomOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomOperation.Location = new System.Drawing.Point(16, 23);
            this.lblNomOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomOperation.Name = "lblNomOperation";
            this.lblNomOperation.Size = new System.Drawing.Size(141, 18);
            this.lblNomOperation.TabIndex = 0;
            this.lblNomOperation.Text = "Nom de l\'opération :";
            // 
            // cboNomOperation
            // 
            this.cboNomOperation.FormattingEnabled = true;
            this.cboNomOperation.Location = new System.Drawing.Point(181, 22);
            this.cboNomOperation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNomOperation.Name = "cboNomOperation";
            this.cboNomOperation.Size = new System.Drawing.Size(187, 24);
            this.cboNomOperation.TabIndex = 1;
            // 
            // lblAnneeResultat
            // 
            this.lblAnneeResultat.AutoSize = true;
            this.lblAnneeResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnneeResultat.Location = new System.Drawing.Point(16, 57);
            this.lblAnneeResultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnneeResultat.Name = "lblAnneeResultat";
            this.lblAnneeResultat.Size = new System.Drawing.Size(129, 18);
            this.lblAnneeResultat.TabIndex = 2;
            this.lblAnneeResultat.Text = "Année de resultat :";
            // 
            // dtpAnneeResultat
            // 
            this.dtpAnneeResultat.Location = new System.Drawing.Point(181, 57);
            this.dtpAnneeResultat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpAnneeResultat.Name = "dtpAnneeResultat";
            this.dtpAnneeResultat.Size = new System.Drawing.Size(224, 22);
            this.dtpAnneeResultat.TabIndex = 3;
            // 
            // lblDateTransaction
            // 
            this.lblDateTransaction.AutoSize = true;
            this.lblDateTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTransaction.Location = new System.Drawing.Point(16, 102);
            this.lblDateTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTransaction.Name = "lblDateTransaction";
            this.lblDateTransaction.Size = new System.Drawing.Size(144, 18);
            this.lblDateTransaction.TabIndex = 4;
            this.lblDateTransaction.Text = "Date de transaction :";
            // 
            // dtpDateTransaction
            // 
            this.dtpDateTransaction.Location = new System.Drawing.Point(181, 102);
            this.dtpDateTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateTransaction.Name = "dtpDateTransaction";
            this.dtpDateTransaction.Size = new System.Drawing.Size(224, 22);
            this.dtpDateTransaction.TabIndex = 5;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(16, 139);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(70, 18);
            this.lblMontant.TabIndex = 6;
            this.lblMontant.Text = "Montant :";
            // 
            // numMontant
            // 
            this.numMontant.Location = new System.Drawing.Point(181, 139);
            this.numMontant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numMontant.Name = "numMontant";
            this.numMontant.Size = new System.Drawing.Size(140, 22);
            this.numMontant.TabIndex = 7;
            // 
            // lblTypeRecette
            // 
            this.lblTypeRecette.AutoSize = true;
            this.lblTypeRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeRecette.Location = new System.Drawing.Point(16, 180);
            this.lblTypeRecette.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeRecette.Name = "lblTypeRecette";
            this.lblTypeRecette.Size = new System.Drawing.Size(117, 18);
            this.lblTypeRecette.TabIndex = 8;
            this.lblTypeRecette.Text = "Type de recette :";
            // 
            // cboTypeRecette
            // 
            this.cboTypeRecette.FormattingEnabled = true;
            this.cboTypeRecette.Location = new System.Drawing.Point(181, 178);
            this.cboTypeRecette.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTypeRecette.Name = "cboTypeRecette";
            this.cboTypeRecette.Size = new System.Drawing.Size(160, 24);
            this.cboTypeRecette.TabIndex = 9;
            // 
            // lblTypeDepense
            // 
            this.lblTypeDepense.AutoSize = true;
            this.lblTypeDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeDepense.Location = new System.Drawing.Point(16, 225);
            this.lblTypeDepense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeDepense.Name = "lblTypeDepense";
            this.lblTypeDepense.Size = new System.Drawing.Size(128, 18);
            this.lblTypeDepense.TabIndex = 10;
            this.lblTypeDepense.Text = "Type de dépense :";
            // 
            // cboTypeDepense
            // 
            this.cboTypeDepense.FormattingEnabled = true;
            this.cboTypeDepense.Location = new System.Drawing.Point(181, 222);
            this.cboTypeDepense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTypeDepense.Name = "cboTypeDepense";
            this.cboTypeDepense.Size = new System.Drawing.Size(160, 24);
            this.cboTypeDepense.TabIndex = 11;
            // 
            // dgvVueOpération
            // 
            this.dgvVueOpération.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVueOpération.Location = new System.Drawing.Point(20, 268);
            this.dgvVueOpération.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVueOpération.Name = "dgvVueOpération";
            this.dgvVueOpération.RowHeadersWidth = 51;
            this.dgvVueOpération.Size = new System.Drawing.Size(507, 185);
            this.dgvVueOpération.TabIndex = 12;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(20, 460);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(427, 460);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Mettre a jour";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(221, 460);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnRechercherParNomOperation
            // 
            this.btnRechercherParNomOperation.Location = new System.Drawing.Point(373, 219);
            this.btnRechercherParNomOperation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRechercherParNomOperation.Name = "btnRechercherParNomOperation";
            this.btnRechercherParNomOperation.Size = new System.Drawing.Size(210, 28);
            this.btnRechercherParNomOperation.TabIndex = 16;
            this.btnRechercherParNomOperation.Text = "Rechercher par nom d\'opération";
            this.btnRechercherParNomOperation.UseVisualStyleBackColor = true;
            // 
            // OperationFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 503);
            this.Controls.Add(this.btnRechercherParNomOperation);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dgvVueOpération);
            this.Controls.Add(this.cboTypeDepense);
            this.Controls.Add(this.lblTypeDepense);
            this.Controls.Add(this.cboTypeRecette);
            this.Controls.Add(this.lblTypeRecette);
            this.Controls.Add(this.numMontant);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.dtpDateTransaction);
            this.Controls.Add(this.lblDateTransaction);
            this.Controls.Add(this.dtpAnneeResultat);
            this.Controls.Add(this.lblAnneeResultat);
            this.Controls.Add(this.cboNomOperation);
            this.Controls.Add(this.lblNomOperation);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OperationFr";
            this.Text = "Action sur les operation ";
            ((System.ComponentModel.ISupportInitialize)(this.numMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVueOpération)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomOperation;
        private System.Windows.Forms.ComboBox cboNomOperation;
        private System.Windows.Forms.Label lblAnneeResultat;
        private System.Windows.Forms.DateTimePicker dtpAnneeResultat;
        private System.Windows.Forms.Label lblDateTransaction;
        private System.Windows.Forms.DateTimePicker dtpDateTransaction;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.NumericUpDown numMontant;
        private System.Windows.Forms.Label lblTypeRecette;
        private System.Windows.Forms.ComboBox cboTypeRecette;
        private System.Windows.Forms.Label lblTypeDepense;
        private System.Windows.Forms.ComboBox cboTypeDepense;
        private System.Windows.Forms.DataGridView dgvVueOpération;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRechercherParNomOperation;
    }
}