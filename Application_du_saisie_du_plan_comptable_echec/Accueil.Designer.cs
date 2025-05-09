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
            this.tsMenuApplication = new System.Windows.Forms.ToolStrip();
            this.tsParametre = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsDepenseParametre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRecetteParametre = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tsMenuApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompte
            // 
            this.lblCompte.AutoSize = true;
            this.lblCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompte.Location = new System.Drawing.Point(11, 46);
            this.lblCompte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompte.Name = "lblCompte";
            this.lblCompte.Size = new System.Drawing.Size(56, 15);
            this.lblCompte.TabIndex = 0;
            this.lblCompte.Text = "Compte :";
            // 
            // cbCompte
            // 
            this.cbCompte.FormattingEnabled = true;
            this.cbCompte.Location = new System.Drawing.Point(71, 45);
            this.cbCompte.Margin = new System.Windows.Forms.Padding(2);
            this.cbCompte.Name = "cbCompte";
            this.cbCompte.Size = new System.Drawing.Size(92, 21);
            this.cbCompte.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(11, 74);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(54, 75);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(151, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(11, 101);
            this.lblOperation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(67, 15);
            this.lblOperation.TabIndex = 4;
            this.lblOperation.Text = "Opération :";
            // 
            // txtOperation
            // 
            this.txtOperation.Location = new System.Drawing.Point(82, 101);
            this.txtOperation.Margin = new System.Windows.Forms.Padding(2);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(76, 20);
            this.txtOperation.TabIndex = 5;
            // 
            // lblCategorieDepense
            // 
            this.lblCategorieDepense.AutoSize = true;
            this.lblCategorieDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorieDepense.Location = new System.Drawing.Point(235, 51);
            this.lblCategorieDepense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorieDepense.Name = "lblCategorieDepense";
            this.lblCategorieDepense.Size = new System.Drawing.Size(117, 15);
            this.lblCategorieDepense.TabIndex = 6;
            this.lblCategorieDepense.Text = "Catégorie dépense :";
            // 
            // cbCategorieDepense
            // 
            this.cbCategorieDepense.FormattingEnabled = true;
            this.cbCategorieDepense.Location = new System.Drawing.Point(356, 50);
            this.cbCategorieDepense.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategorieDepense.Name = "cbCategorieDepense";
            this.cbCategorieDepense.Size = new System.Drawing.Size(92, 21);
            this.cbCategorieDepense.TabIndex = 7;
            // 
            // lblCategorieRecettes
            // 
            this.lblCategorieRecettes.AutoSize = true;
            this.lblCategorieRecettes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorieRecettes.Location = new System.Drawing.Point(235, 101);
            this.lblCategorieRecettes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorieRecettes.Name = "lblCategorieRecettes";
            this.lblCategorieRecettes.Size = new System.Drawing.Size(112, 15);
            this.lblCategorieRecettes.TabIndex = 8;
            this.lblCategorieRecettes.Text = "Catégorie recettes :";
            // 
            // cbCategorieRecettes
            // 
            this.cbCategorieRecettes.FormattingEnabled = true;
            this.cbCategorieRecettes.Location = new System.Drawing.Point(351, 100);
            this.cbCategorieRecettes.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategorieRecettes.Name = "cbCategorieRecettes";
            this.cbCategorieRecettes.Size = new System.Drawing.Size(92, 21);
            this.cbCategorieRecettes.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(391, 198);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnNewOperation
            // 
            this.btnNewOperation.Location = new System.Drawing.Point(162, 340);
            this.btnNewOperation.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewOperation.Name = "btnNewOperation";
            this.btnNewOperation.Size = new System.Drawing.Size(125, 20);
            this.btnNewOperation.TabIndex = 11;
            this.btnNewOperation.Text = "Nouvel Opération";
            this.btnNewOperation.UseVisualStyleBackColor = true;
            this.btnNewOperation.Click += new System.EventHandler(this.btnNewOperation_Click);
            // 
            // tsMenuApplication
            // 
            this.tsMenuApplication.BackColor = System.Drawing.Color.Silver;
            this.tsMenuApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsParametre});
            this.tsMenuApplication.Location = new System.Drawing.Point(0, 0);
            this.tsMenuApplication.Name = "tsMenuApplication";
            this.tsMenuApplication.Size = new System.Drawing.Size(458, 25);
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
            this.tsParametre.Size = new System.Drawing.Size(79, 22);
            this.tsParametre.Text = "Paramètres";
            // 
            // tsDepenseParametre
            // 
            this.tsDepenseParametre.Name = "tsDepenseParametre";
            this.tsDepenseParametre.Size = new System.Drawing.Size(180, 22);
            this.tsDepenseParametre.Text = "Dépense";
            // 
            // tsRecetteParametre
            // 
            this.tsRecetteParametre.Name = "tsRecetteParametre";
            this.tsRecetteParametre.Size = new System.Drawing.Size(180, 22);
            this.tsRecetteParametre.Text = "Recette";
            this.tsRecetteParametre.Click += new System.EventHandler(this.tsRecetteParametre_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 371);
            this.Controls.Add(this.tsMenuApplication);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tsMenuApplication.ResumeLayout(false);
            this.tsMenuApplication.PerformLayout();
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
        private System.Windows.Forms.ToolStrip tsMenuApplication;
        private System.Windows.Forms.ToolStripDropDownButton tsParametre;
        private System.Windows.Forms.ToolStripMenuItem tsDepenseParametre;
        private System.Windows.Forms.ToolStripMenuItem tsRecetteParametre;
    }
}

