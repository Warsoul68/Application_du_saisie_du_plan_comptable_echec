using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIB_BLL;
using LIB_DAL;

namespace Application_du_saisie_du_plan_comptable_echec
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            Connexion C = new Connexion();
            C.ShowDialog();

            bool ouvert = Bdd.ouvrirConnexion();

            if (ouvert)
            {
                MessageBox.Show("la connexion avec la base de donnée est réussie");
                MessageBox.Show(Bdd.afficherConnexion());

                dgvOperation.AutoGenerateColumns = true;
                dgvOperation.DataSource = VueOperationDAO.getTouteLesOperationsVo();
                dgvOperation.Columns["NumDocumentAffiche"].HeaderText = "Numéro document";
                dgvOperation.Columns["DateVOAffiche"].HeaderText = "Date";
                dgvOperation.Columns["OperationVOAffiche"].HeaderText = "Opération";
                dgvOperation.Columns["DebitEuroVOAffiche"].HeaderText = "Débit EUROS";
                dgvOperation.Columns["CreditEuroVOAffiche"].HeaderText = "Crédit EUROS";
                dgvOperation.Columns["CategorieDepensesAffiche"].HeaderText = "Catégorie dépenses";
                dgvOperation.Columns["CategorieRecettesAffiche"].HeaderText = "Catégorie recettes";

            }

            else
            {
                MessageBox.Show("la connexion avec la base de donnée n'a pas été effectuer");


            }

        }

        private void btnNewOperation_Click(object sender, EventArgs e)
        {
            NouvelleOperationForm NOF = new NouvelleOperationForm();
            NOF.Show();

        }

        private void tsRecetteParametre_Click(object sender, EventArgs e)
        {
            ParametreRecette PA = new ParametreRecette();
            PA.Show();
        }

        private void tsDepenseParametre_Click(object sender, EventArgs e)
        {
            ParametreDepense PDE = new ParametreDepense();
            PDE.Show();

        }

        private void tsCompte_Click(object sender, EventArgs e)
        {
            VisualisationCompte VC = new VisualisationCompte();
            VC.Show();

        }

        private void tsOperation_Click(object sender, EventArgs e)
        {
            OperationFr OFR = new OperationFr();
            OFR.Show();

        }

        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            int numDoc = 0;
            if (!string.IsNullOrWhiteSpace(txtNumDoc.Text))
                int.TryParse(txtNumDoc.Text, out numDoc);

            DateTime vDateSaisie = dtpDate.Value.Date;

            dgvOperation.AutoGenerateColumns = true;
            dgvOperation.DataSource = VueOperationDAO.getVueOperationFiltre(numDoc, vDateSaisie);
            dgvOperation.Columns["NumDocumentAffiche"].HeaderText = "Numéro document";
            dgvOperation.Columns["DateVOAffiche"].HeaderText = "Date";
            dgvOperation.Columns["OperationVOAffiche"].HeaderText = "Opération";
            dgvOperation.Columns["DebitEuroVOAffiche"].HeaderText = "Débit EUROS";
            dgvOperation.Columns["CreditEuroVOAffiche"].HeaderText = "Crédit EUROS";
            dgvOperation.Columns["CategorieDepensesAffiche"].HeaderText = "Catégorie dépenses";
            dgvOperation.Columns["CategorieRecettesAffiche"].HeaderText = "Catégorie recettes";

        }
    }
}
