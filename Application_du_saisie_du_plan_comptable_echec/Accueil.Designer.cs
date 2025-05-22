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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.lblCompte = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblOperation = new System.Windows.Forms.Label();
            this.txtOperation = new System.Windows.Forms.TextBox();
            this.lblCategorieDepenses = new System.Windows.Forms.Label();
            this.cbCategorieDepense = new System.Windows.Forms.ComboBox();
            this.lblCategorieRecettes = new System.Windows.Forms.Label();
            this.cbCategorieRecettes = new System.Windows.Forms.ComboBox();
            this.dgvOperation = new System.Windows.Forms.DataGridView();
            this.btnNewOperation = new System.Windows.Forms.Button();
            this.tsMenuApplication = new System.Windows.Forms.ToolStrip();
            this.tsParametre = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsDepenseParametre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRecetteParametre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCompte = new System.Windows.Forms.ToolStripButton();
            this.tsOperation = new System.Windows.Forms.ToolStripButton();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.btnClearFiltre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).BeginInit();
            this.tsMenuApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompte
            // 
            this.lblCompte.AutoSize = true;
            this.lblCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompte.Location = new System.Drawing.Point(15, 57);
            this.lblCompte.Name = "lblCompte";
            this.lblCompte.Size = new System.Drawing.Size(160, 18);
            this.lblCompte.TabIndex = 0;
            this.lblCompte.Text = "Numéro de document :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(15, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.Location = new System.Drawing.Point(72, 92);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowCheckBox = true;
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(15, 124);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(81, 18);
            this.lblOperation.TabIndex = 4;
            this.lblOperation.Text = "Opération :";
            // 
            // txtOperation
            // 
            this.txtOperation.Location = new System.Drawing.Point(109, 124);
            this.txtOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(100, 22);
            this.txtOperation.TabIndex = 5;
            // 
            // lblCategorieDepenses
            // 
            this.lblCategorieDepenses.AutoSize = true;
            this.lblCategorieDepenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorieDepenses.Location = new System.Drawing.Point(441, 63);
            this.lblCategorieDepenses.Name = "lblCategorieDepenses";
            this.lblCategorieDepenses.Size = new System.Drawing.Size(148, 18);
            this.lblCategorieDepenses.TabIndex = 6;
            this.lblCategorieDepenses.Text = "Catégorie dépenses :";
            // 
            // cbCategorieDepense
            // 
            this.cbCategorieDepense.FormattingEnabled = true;
            this.cbCategorieDepense.Location = new System.Drawing.Point(604, 63);
            this.cbCategorieDepense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategorieDepense.Name = "cbCategorieDepense";
            this.cbCategorieDepense.Size = new System.Drawing.Size(121, 24);
            this.cbCategorieDepense.TabIndex = 7;
            // 
            // lblCategorieRecettes
            // 
            this.lblCategorieRecettes.AutoSize = true;
            this.lblCategorieRecettes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorieRecettes.Location = new System.Drawing.Point(441, 118);
            this.lblCategorieRecettes.Name = "lblCategorieRecettes";
            this.lblCategorieRecettes.Size = new System.Drawing.Size(137, 18);
            this.lblCategorieRecettes.TabIndex = 8;
            this.lblCategorieRecettes.Text = "Catégorie recettes :";
            // 
            // cbCategorieRecettes
            // 
            this.cbCategorieRecettes.FormattingEnabled = true;
            this.cbCategorieRecettes.Location = new System.Drawing.Point(604, 118);
            this.cbCategorieRecettes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategorieRecettes.Name = "cbCategorieRecettes";
            this.cbCategorieRecettes.Size = new System.Drawing.Size(121, 24);
            this.cbCategorieRecettes.TabIndex = 9;
            // 
            // dgvOperation
            // 
            this.dgvOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperation.Location = new System.Drawing.Point(18, 190);
            this.dgvOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOperation.Name = "dgvOperation";
            this.dgvOperation.RowHeadersWidth = 51;
            this.dgvOperation.RowTemplate.Height = 24;
            this.dgvOperation.Size = new System.Drawing.Size(741, 266);
            this.dgvOperation.TabIndex = 10;
            // 
            // btnNewOperation
            // 
            this.btnNewOperation.Location = new System.Drawing.Point(266, 475);
            this.btnNewOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewOperation.Name = "btnNewOperation";
            this.btnNewOperation.Size = new System.Drawing.Size(167, 25);
            this.btnNewOperation.TabIndex = 11;
            this.btnNewOperation.Text = "Nouvel Opération";
            this.btnNewOperation.UseVisualStyleBackColor = true;
            this.btnNewOperation.Click += new System.EventHandler(this.btnNewOperation_Click);
            // 
            // tsMenuApplication
            // 
            this.tsMenuApplication.BackColor = System.Drawing.Color.Silver;
            this.tsMenuApplication.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenuApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsParametre,
            this.tsCompte,
            this.tsOperation});
            this.tsMenuApplication.Location = new System.Drawing.Point(0, 0);
            this.tsMenuApplication.Name = "tsMenuApplication";
            this.tsMenuApplication.Size = new System.Drawing.Size(771, 27);
            this.tsMenuApplication.TabIndex = 12;
            this.tsMenuApplication.Text = "toolStrip1";
            // 
            // tsParametre
            // 
            this.tsParametre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsParametre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDepenseParametre,
            this.tsRecetteParametre});
            this.tsParametre.Image = ((System.Drawing.Image)(resources.GetObject("tsParametre.Image")));
            this.tsParametre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsParametre.Name = "tsParametre";
            this.tsParametre.Size = new System.Drawing.Size(96, 24);
            this.tsParametre.Text = "Paramètres";
            // 
            // tsDepenseParametre
            // 
            this.tsDepenseParametre.Name = "tsDepenseParametre";
            this.tsDepenseParametre.Size = new System.Drawing.Size(150, 26);
            this.tsDepenseParametre.Text = "Dépense";
            this.tsDepenseParametre.Click += new System.EventHandler(this.tsDepenseParametre_Click);
            // 
            // tsRecetteParametre
            // 
            this.tsRecetteParametre.Name = "tsRecetteParametre";
            this.tsRecetteParametre.Size = new System.Drawing.Size(150, 26);
            this.tsRecetteParametre.Text = "Recette";
            this.tsRecetteParametre.Click += new System.EventHandler(this.tsRecetteParametre_Click);
            // 
            // tsCompte
            // 
            this.tsCompte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsCompte.Image = ((System.Drawing.Image)(resources.GetObject("tsCompte.Image")));
            this.tsCompte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCompte.Name = "tsCompte";
            this.tsCompte.Size = new System.Drawing.Size(66, 24);
            this.tsCompte.Text = "Compte";
            this.tsCompte.Click += new System.EventHandler(this.tsCompte_Click);
            // 
            // tsOperation
            // 
            this.tsOperation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsOperation.Image = ((System.Drawing.Image)(resources.GetObject("tsOperation.Image")));
            this.tsOperation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOperation.Name = "tsOperation";
            this.tsOperation.Size = new System.Drawing.Size(80, 24);
            this.tsOperation.Text = "Operation";
            this.tsOperation.Click += new System.EventHandler(this.tsOperation_Click);
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Location = new System.Drawing.Point(266, 156);
            this.btnFiltrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrer.TabIndex = 13;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            this.btnFiltrer.Click += new System.EventHandler(this.btnFiltrer_Click);
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(181, 56);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(44, 22);
            this.txtNumDoc.TabIndex = 14;
            // 
            // btnClearFiltre
            // 
            this.btnClearFiltre.Location = new System.Drawing.Point(421, 159);
            this.btnClearFiltre.Name = "btnClearFiltre";
            this.btnClearFiltre.Size = new System.Drawing.Size(130, 26);
            this.btnClearFiltre.TabIndex = 15;
            this.btnClearFiltre.Text = "Enlever les filtres";
            this.btnClearFiltre.UseVisualStyleBackColor = true;
            this.btnClearFiltre.Click += new System.EventHandler(this.btnClearFiltre_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 511);
            this.Controls.Add(this.btnClearFiltre);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.tsMenuApplication);
            this.Controls.Add(this.btnNewOperation);
            this.Controls.Add(this.dgvOperation);
            this.Controls.Add(this.cbCategorieRecettes);
            this.Controls.Add(this.lblCategorieRecettes);
            this.Controls.Add(this.cbCategorieDepense);
            this.Controls.Add(this.lblCategorieDepenses);
            this.Controls.Add(this.txtOperation);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCompte);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).EndInit();
            this.tsMenuApplication.ResumeLayout(false);
            this.tsMenuApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompte;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.TextBox txtOperation;
        private System.Windows.Forms.Label lblCategorieDepenses;
        private System.Windows.Forms.ComboBox cbCategorieDepense;
        private System.Windows.Forms.Label lblCategorieRecettes;
        private System.Windows.Forms.ComboBox cbCategorieRecettes;
        private System.Windows.Forms.DataGridView dgvOperation;
        private System.Windows.Forms.Button btnNewOperation;
        private System.Windows.Forms.ToolStrip tsMenuApplication;
        private System.Windows.Forms.ToolStripDropDownButton tsParametre;
        private System.Windows.Forms.ToolStripMenuItem tsDepenseParametre;
        private System.Windows.Forms.ToolStripMenuItem tsRecetteParametre;
        private System.Windows.Forms.ToolStripButton tsCompte;
        private System.Windows.Forms.ToolStripButton tsOperation;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Button btnClearFiltre;
    }
}

