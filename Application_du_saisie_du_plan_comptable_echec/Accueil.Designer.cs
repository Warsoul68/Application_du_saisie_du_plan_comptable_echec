namespace Application_du_saisie_du_plan_comptable_echec
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCompte = new System.Windows.Forms.Label();
            this.cbCompte = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblOperation = new System.Windows.Forms.Label();
            this.txtOperation = new System.Windows.Forms.TextBox();
            this.lblCategorieDepense = new System.Windows.Forms.Label();
            this.cbCategorieDepense = new System.Windows.Forms.ComboBox();
            this.lblCategorieRecettes = new System.Windows.Forms.Label();
            this.cbCategorieRecettes = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewOperation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompte
            // 
            this.lblCompte.AutoSize = true;
            this.lblCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompte.Location = new System.Drawing.Point(24, 32);
            this.lblCompte.Name = "lblCompte";
            this.lblCompte.Size = new System.Drawing.Size(69, 18);
            this.lblCompte.TabIndex = 0;
            this.lblCompte.Text = "Compte :";
            // 
            // cbCompte
            // 
            this.cbCompte.FormattingEnabled = true;
            this.cbCompte.Location = new System.Drawing.Point(99, 31);
            this.cbCompte.Name = "cbCompte";
            this.cbCompte.Size = new System.Drawing.Size(121, 24);
            this.cbCompte.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(24, 61);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(77, 61);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(24, 97);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(81, 18);
            this.lblOperation.TabIndex = 4;
            this.lblOperation.Text = "Opération :";
            // 
            // txtOperation
            // 
            this.txtOperation.Location = new System.Drawing.Point(111, 97);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(100, 22);
            this.txtOperation.TabIndex = 5;
            // 
            // lblCategorieDepense
            // 
            this.lblCategorieDepense.AutoSize = true;
            this.lblCategorieDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorieDepense.Location = new System.Drawing.Point(313, 31);
            this.lblCategorieDepense.Name = "lblCategorieDepense";
            this.lblCategorieDepense.Size = new System.Drawing.Size(140, 18);
            this.lblCategorieDepense.TabIndex = 6;
            this.lblCategorieDepense.Text = "Catégorie dépense :";
            // 
            // cbCategorieDepense
            // 
            this.cbCategorieDepense.FormattingEnabled = true;
            this.cbCategorieDepense.Location = new System.Drawing.Point(459, 30);
            this.cbCategorieDepense.Name = "cbCategorieDepense";
            this.cbCategorieDepense.Size = new System.Drawing.Size(121, 24);
            this.cbCategorieDepense.TabIndex = 7;
            // 
            // lblCategorieRecettes
            // 
            this.lblCategorieRecettes.AutoSize = true;
            this.lblCategorieRecettes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorieRecettes.Location = new System.Drawing.Point(313, 97);
            this.lblCategorieRecettes.Name = "lblCategorieRecettes";
            this.lblCategorieRecettes.Size = new System.Drawing.Size(137, 18);
            this.lblCategorieRecettes.TabIndex = 8;
            this.lblCategorieRecettes.Text = "Catégorie recettes :";
            // 
            // cbCategorieRecettes
            // 
            this.cbCategorieRecettes.FormattingEnabled = true;
            this.cbCategorieRecettes.Location = new System.Drawing.Point(459, 91);
            this.cbCategorieRecettes.Name = "cbCategorieRecettes";
            this.cbCategorieRecettes.Size = new System.Drawing.Size(121, 24);
            this.cbCategorieRecettes.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(521, 244);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnNewOperation
            // 
            this.btnNewOperation.Location = new System.Drawing.Point(219, 397);
            this.btnNewOperation.Name = "btnNewOperation";
            this.btnNewOperation.Size = new System.Drawing.Size(167, 25);
            this.btnNewOperation.TabIndex = 11;
            this.btnNewOperation.Text = "Nouvel Opération";
            this.btnNewOperation.UseVisualStyleBackColor = true;
            this.btnNewOperation.Click += new System.EventHandler(this.btnNewOperation_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 457);
            this.Controls.Add(this.btnNewOperation);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbCategorieRecettes);
            this.Controls.Add(this.lblCategorieRecettes);
            this.Controls.Add(this.cbCategorieDepense);
            this.Controls.Add(this.lblCategorieDepense);
            this.Controls.Add(this.txtOperation);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbCompte);
            this.Controls.Add(this.lblCompte);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompte;
        private System.Windows.Forms.ComboBox cbCompte;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.TextBox txtOperation;
        private System.Windows.Forms.Label lblCategorieDepense;
        private System.Windows.Forms.ComboBox cbCategorieDepense;
        private System.Windows.Forms.Label lblCategorieRecettes;
        private System.Windows.Forms.ComboBox cbCategorieRecettes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewOperation;
    }
}

