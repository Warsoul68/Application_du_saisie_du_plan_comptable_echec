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
            this.txtDebitEuro = new System.Windows.Forms.TextBox();
            this.lblCategorieDepenses = new System.Windows.Forms.Label();
            this.cbCategorieDepense = new System.Windows.Forms.ComboBox();
            this.btnCree = new System.Windows.Forms.Button();
            this.lblChoixCategories = new System.Windows.Forms.Label();
            this.rdbDepense = new System.Windows.Forms.RadioButton();
            this.rdbRecette = new System.Windows.Forms.RadioButton();
            this.lblCategorieRecette = new System.Windows.Forms.Label();
            this.cbCategorieRecette = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomOperation
            // 
            this.lblNomOperation.AutoSize = true;
            this.lblNomOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomOperation.Location = new System.Drawing.Point(9, 38);
            this.lblNomOperation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomOperation.Name = "lblNomOperation";
            this.lblNomOperation.Size = new System.Drawing.Size(118, 15);
            this.lblNomOperation.TabIndex = 0;
            this.lblNomOperation.Text = "Nom de l\'opération :";
            // 
            // txtNomOperation
            // 
            this.txtNomOperation.Location = new System.Drawing.Point(131, 38);
            this.txtNomOperation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomOperation.Name = "txtNomOperation";
            this.txtNomOperation.Size = new System.Drawing.Size(131, 20);
            this.txtNomOperation.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(9, 15);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 11);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(9, 68);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(58, 15);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant :";
            // 
            // txtDebitEuro
            // 
            this.txtDebitEuro.Location = new System.Drawing.Point(66, 68);
            this.txtDebitEuro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDebitEuro.Name = "txtDebitEuro";
            this.txtDebitEuro.Size = new System.Drawing.Size(76, 20);
            this.txtDebitEuro.TabIndex = 5;
            // 
            // lblCategorieDepenses
            // 
            this.lblCategorieDepenses.AutoSize = true;
            this.lblCategorieDepenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorieDepenses.Location = new System.Drawing.Point(287, 81);
            this.lblCategorieDepenses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorieDepenses.Name = "lblCategorieDepenses";
            this.lblCategorieDepenses.Size = new System.Drawing.Size(119, 15);
            this.lblCategorieDepenses.TabIndex = 6;
            this.lblCategorieDepenses.Text = "Catégorie Dépense :";
            // 
            // cbCategorieDepense
            // 
            this.cbCategorieDepense.FormattingEnabled = true;
            this.cbCategorieDepense.Location = new System.Drawing.Point(399, 80);
            this.cbCategorieDepense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategorieDepense.Name = "cbCategorieDepense";
            this.cbCategorieDepense.Size = new System.Drawing.Size(124, 21);
            this.cbCategorieDepense.TabIndex = 7;
            // 
            // btnCree
            // 
            this.btnCree.Location = new System.Drawing.Point(250, 152);
            this.btnCree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCree.Name = "btnCree";
            this.btnCree.Size = new System.Drawing.Size(56, 19);
            this.btnCree.TabIndex = 8;
            this.btnCree.Text = "Crée";
            this.btnCree.UseVisualStyleBackColor = true;
            // 
            // lblChoixCategories
            // 
            this.lblChoixCategories.AutoSize = true;
            this.lblChoixCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixCategories.Location = new System.Drawing.Point(9, 98);
            this.lblChoixCategories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoixCategories.Name = "lblChoixCategories";
            this.lblChoixCategories.Size = new System.Drawing.Size(115, 15);
            this.lblChoixCategories.TabIndex = 9;
            this.lblChoixCategories.Text = "Choix de catégorie :";
            // 
            // rdbDepense
            // 
            this.rdbDepense.AutoSize = true;
            this.rdbDepense.Location = new System.Drawing.Point(135, 98);
            this.rdbDepense.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDepense.Name = "rdbDepense";
            this.rdbDepense.Size = new System.Drawing.Size(68, 17);
            this.rdbDepense.TabIndex = 10;
            this.rdbDepense.TabStop = true;
            this.rdbDepense.Text = "Dépense";
            this.rdbDepense.UseVisualStyleBackColor = true;
            // 
            // rdbRecette
            // 
            this.rdbRecette.AutoSize = true;
            this.rdbRecette.Location = new System.Drawing.Point(202, 98);
            this.rdbRecette.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbRecette.Name = "rdbRecette";
            this.rdbRecette.Size = new System.Drawing.Size(63, 17);
            this.rdbRecette.TabIndex = 11;
            this.rdbRecette.TabStop = true;
            this.rdbRecette.Text = "Recette";
            this.rdbRecette.UseVisualStyleBackColor = true;
            // 
            // lblCategorieRecette
            // 
            this.lblCategorieRecette.AutoSize = true;
            this.lblCategorieRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorieRecette.Location = new System.Drawing.Point(287, 110);
            this.lblCategorieRecette.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorieRecette.Name = "lblCategorieRecette";
            this.lblCategorieRecette.Size = new System.Drawing.Size(111, 15);
            this.lblCategorieRecette.TabIndex = 12;
            this.lblCategorieRecette.Text = "Catégorie Recette :";
            // 
            // cbCategorieRecette
            // 
            this.cbCategorieRecette.FormattingEnabled = true;
            this.cbCategorieRecette.Location = new System.Drawing.Point(399, 109);
            this.cbCategorieRecette.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategorieRecette.Name = "cbCategorieRecette";
            this.cbCategorieRecette.Size = new System.Drawing.Size(124, 21);
            this.cbCategorieRecette.TabIndex = 13;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(169, 152);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 19);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // NouvelleOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 180);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.cbCategorieRecette);
            this.Controls.Add(this.lblCategorieRecette);
            this.Controls.Add(this.rdbRecette);
            this.Controls.Add(this.rdbDepense);
            this.Controls.Add(this.lblChoixCategories);
            this.Controls.Add(this.btnCree);
            this.Controls.Add(this.cbCategorieDepense);
            this.Controls.Add(this.lblCategorieDepenses);
            this.Controls.Add(this.txtDebitEuro);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtNomOperation);
            this.Controls.Add(this.lblNomOperation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NouvelleOperationForm";
            this.Text = "Crée une nouvelle opération";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomOperation;
        private System.Windows.Forms.TextBox txtNomOperation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.TextBox txtDebitEuro;
        private System.Windows.Forms.Label lblCategorieDepenses;
        private System.Windows.Forms.ComboBox cbCategorieDepense;
        private System.Windows.Forms.Button btnCree;
        private System.Windows.Forms.Label lblChoixCategories;
        private System.Windows.Forms.RadioButton rdbDepense;
        private System.Windows.Forms.RadioButton rdbRecette;
        private System.Windows.Forms.Label lblCategorieRecette;
        private System.Windows.Forms.ComboBox cbCategorieRecette;
        private System.Windows.Forms.Button btnAnnuler;
    }
}