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
    }
}
