namespace Application_du_saisie_du_plan_comptable_echec
{
    partial class NouvelleOperationForm
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
            this.txtNomOperation = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblCategorieDepenses = new System.Windows.Forms.Label();
            this.cbCategorieDepense = new System.Windows.Forms.ComboBox();
            this.btnCree = new System.Windows.Forms.Button();
            this.lblChoixCategories = new System.Windows.Forms.Label();
            this.rdbDepense = new System.Windows.Forms.RadioButton();
            this.rdbRecette = new System.Windows.Forms.RadioButton();
            this.lblCategorieRecette = new System.Windows.Forms.Label();
            this.cbCategorieRecette = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblAnneeResultat = new System.Windows.Forms.Label();
            this.cboAnneeResultat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumTransaction = new System.Windows.Forms.NumericUpDown();
            this.numMontant = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontant)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomOperation
            // 
            this.lblNomOperation.AutoSize = true;
            this.lblNomOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomOperation.Location = new System.Drawing.Point(12, 47);
            this.lblNomOperation.Name = "lblNomOperation";
            this.lblNomOperation.Size = new System.Drawing.Size(141, 18);
            this.lblNomOperation.TabIndex = 0;
            this.lblNomOperation.Text = "Nom de l\'opération :";
            // 
            // txtNomOperation
            // 
            this.txtNomOperation.Location = new System.Drawing.Point(175, 47);
            this.txtNomOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomOperation.Name = "txtNomOperation";
            this.txtNomOperation.Size = new System.Drawing.Size(173, 22);
            this.txtNomOperation.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 14);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(12, 84);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(70, 18);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant :";
            // 
            // lblCategorieDepenses
            // 
            this.lblCategorieDepenses.AutoSize = true;
            this.lblCategorieDepenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorieDepenses.Location = new System.Drawing.Point(383, 100);
            this.lblCategorieDepenses.Name = "lblCategorieDepenses";
            this.lblCategorieDepenses.Size = new System.Drawing.Size(143, 18);
            this.lblCategorieDepenses.TabIndex = 6;
            this.lblCategorieDepenses.Text = "Catégorie Dépense :";
            this.lblCategorieDepenses.Visible = false;
            // 
            // cbCategorieDepense
            // 
            this.cbCategorieDepense.FormattingEnabled = true;
            this.cbCategorieDepense.Location = new System.Drawing.Point(553, 100);
            this.cbCategorieDepense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategorieDepense.Name = "cbCategorieDepense";
            this.cbCategorieDepense.Size = new System.Drawing.Size(164, 24);
            this.cbCategorieDepense.TabIndex = 7;
            this.cbCategorieDepense.Visible = false;
            // 
            // btnCree
            // 
            this.btnCree.Location = new System.Drawing.Point(333, 187);
            this.btnCree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCree.Name = "btnCree";
            this.btnCree.Size = new System.Drawing.Size(75, 23);
            this.btnCree.TabIndex = 8;
            this.btnCree.Text = "Crée";
            this.btnCree.UseVisualStyleBackColor = true;
            // 
            // lblChoixCategories
            // 
            this.lblChoixCategories.AutoSize = true;
            this.lblChoixCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixCategories.Location = new System.Drawing.Point(12, 121);
            this.lblChoixCategories.Name = "lblChoixCategories";
            this.lblChoixCategories.Size = new System.Drawing.Size(139, 18);
            this.lblChoixCategories.TabIndex = 9;
            this.lblChoixCategories.Text = "Choix de catégorie :";
            // 
            // rdbDepense
            // 
            this.rdbDepense.AutoSize = true;
            this.rdbDepense.Location = new System.Drawing.Point(180, 121);
            this.rdbDepense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDepense.Name = "rdbDepense";
            this.rdbDepense.Size = new System.Drawing.Size(84, 20);
            this.rdbDepense.TabIndex = 10;
            this.rdbDepense.TabStop = true;
            this.rdbDepense.Text = "Dépense";
            this.rdbDepense.UseVisualStyleBackColor = true;
            this.rdbDepense.CheckedChanged += new System.EventHandler(this.rdbDepense_CheckedChanged);
            // 
            // rdbRecette
            // 
            this.rdbRecette.AutoSize = true;
            this.rdbRecette.Location = new System.Drawing.Point(269, 121);
            this.rdbRecette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbRecette.Name = "rdbRecette";
            this.rdbRecette.Size = new System.Drawing.Size(75, 20);
            this.rdbRecette.TabIndex = 11;
            this.rdbRecette.TabStop = true;
            this.rdbRecette.Text = "Recette";
            this.rdbRecette.UseVisualStyleBackColor = true;
            this.rdbRecette.CheckedChanged += new System.EventHandler(this.rdbRecette_CheckedChanged);
            // 
            // lblCategorieRecette
            // 
            this.lblCategorieRecette.AutoSize = true;
            this.lblCategorieRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorieRecette.Location = new System.Drawing.Point(383, 135);
            this.lblCategorieRecette.Name = "lblCategorieRecette";
            this.lblCategorieRecette.Size = new System.Drawing.Size(135, 18);
            this.lblCategorieRecette.TabIndex = 12;
            this.lblCategorieRecette.Text = "Catégorie Recette :";
            this.lblCategorieRecette.Visible = false;
            // 
            // cbCategorieRecette
            // 
            this.cbCategorieRecette.FormattingEnabled = true;
            this.cbCategorieRecette.Location = new System.Drawing.Point(553, 134);
            this.cbCategorieRecette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategorieRecette.Name = "cbCategorieRecette";
            this.cbCategorieRecette.Size = new System.Drawing.Size(164, 24);
            this.cbCategorieRecette.TabIndex = 13;
            this.cbCategorieRecette.Visible = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(225, 187);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lblAnneeResultat
            // 
            this.lblAnneeResultat.AutoSize = true;
            this.lblAnneeResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAnneeResultat.Location = new System.Drawing.Point(437, 18);
            this.lblAnneeResultat.Name = "lblAnneeResultat";
            this.lblAnneeResultat.Size = new System.Drawing.Size(129, 18);
            this.lblAnneeResultat.TabIndex = 15;
            this.lblAnneeResultat.Text = "Année de résultat :";
            // 
            // cboAnneeResultat
            // 
            this.cboAnneeResultat.FormattingEnabled = true;
            this.cboAnneeResultat.Location = new System.Drawing.Point(572, 16);
            this.cboAnneeResultat.Name = "cboAnneeResultat";
            this.cboAnneeResultat.Size = new System.Drawing.Size(133, 24);
            this.cboAnneeResultat.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(437, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id de la transaction :";
            // 
            // NumTransaction
            // 
            this.NumTransaction.Location = new System.Drawing.Point(582, 46);
            this.NumTransaction.Name = "NumTransaction";
            this.NumTransaction.Size = new System.Drawing.Size(120, 22);
            this.NumTransaction.TabIndex = 18;
            // 
            // numMontant
            // 
            this.numMontant.Location = new System.Drawing.Point(88, 84);
            this.numMontant.Name = "numMontant";
            this.numMontant.Size = new System.Drawing.Size(120, 22);
            this.numMontant.TabIndex = 19;
            // 
            // NouvelleOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 222);
            this.Controls.Add(this.numMontant);
            this.Controls.Add(this.NumTransaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAnneeResultat);
            this.Controls.Add(this.lblAnneeResultat);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.cbCategorieRecette);
            this.Controls.Add(this.lblCategorieRecette);
            this.Controls.Add(this.rdbRecette);
            this.Controls.Add(this.rdbDepense);
            this.Controls.Add(this.lblChoixCategories);
            this.Controls.Add(this.btnCree);
            this.Controls.Add(this.cbCategorieDepense);
            this.Controls.Add(this.lblCategorieDepenses);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtNomOperation);
            this.Controls.Add(this.lblNomOperation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NouvelleOperationForm";
            this.Text = "Crée une nouvelle opération";
            ((System.ComponentModel.ISupportInitialize)(this.NumTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMontant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomOperation;
        private System.Windows.Forms.TextBox txtNomOperation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblCategorieDepenses;
        private System.Windows.Forms.ComboBox cbCategorieDepense;
        private System.Windows.Forms.Button btnCree;
        private System.Windows.Forms.Label lblChoixCategories;
        private System.Windows.Forms.RadioButton rdbDepense;
        private System.Windows.Forms.RadioButton rdbRecette;
        private System.Windows.Forms.Label lblCategorieRecette;
        private System.Windows.Forms.ComboBox cbCategorieRecette;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblAnneeResultat;
        private System.Windows.Forms.ComboBox cboAnneeResultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumTransaction;
        private System.Windows.Forms.NumericUpDown numMontant;
    }
}