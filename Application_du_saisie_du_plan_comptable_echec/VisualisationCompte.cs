using LIB_BLL;
using LIB_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_du_saisie_du_plan_comptable_echec
{
    public partial class VisualisationCompte : Form
    {
        public VisualisationCompte()
        {
            InitializeComponent();
        }

        private void VisualisationCompte_Load(object sender, EventArgs e)
        {
            dgvCompte.AutoGenerateColumns = true;
            dgvCompte.DataSource = CompteDAO.getTousLesComptes();
            dgvCompte.Columns["NumCompteAffiche"].HeaderText = "num";
            dgvCompte.Columns["LibelleCompteAffiche"].HeaderText = "libelle";
            dgvCompte.Columns["SoldeCompteAffiche"].HeaderText = "solde";

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            int numCompte;
            if (int.TryParse(txtNumCompte.Text, out numCompte))
            {
                Compte c = CompteDAO.rechercher(numCompte);
                txtLibelleCompte.Text = c.getLibelleCompte();
                numSoldeCompte.Value = Convert.ToDecimal(c.getSoldeCompte());
                
            }
        }

        private void btnUpdateSolde_Click(object sender, EventArgs e)
        {
            float numCompte = (float)numSoldeCompte.Value;

            Compte unCompte = new Compte(Convert.ToInt32(txtNumCompte.Text), txtLibelleCompte.Text, numCompte);
            int res = CompteDAO.modifier(unCompte);
            if (res == 1)
            {
                MessageBox.Show("Modification effectuée");
            }
            else
            {
                MessageBox.Show("Problème sur la modification");
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
