using LIB_BLL;
using LIB_DAL;
using System;
using System.Text;
using System.Windows.Forms;

namespace Application_du_saisie_du_plan_comptable_echec
{
    public partial class ParametreDepense : Form
    {
        public ParametreDepense()
        {
            InitializeComponent();
        }

        private void ParametreDepense_Load(object sender, EventArgs e)
        {
            dgvDepense.AutoGenerateColumns = true;
            dgvDepense.DataSource = DepenseDAO.getTouteLesDepenses();
            dgvDepense.Columns["IdDepenseAffiche"].HeaderText = "id";
            dgvDepense.Columns["LibelleDAffiche"].HeaderText = "libellé"; 

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            int depenseId;

            if (int.TryParse(txtIdDepense.Text, out depenseId))
            {
                Depense d = DepenseDAO.rechercher(depenseId);
                txtLibelleDepense.Text = d.getLibelleD();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Depense uneDepense = new Depense(Convert.ToInt32(txtIdDepense.Text), txtLibelleDepense.Text);
            int res = DepenseDAO.creer(uneDepense);
            if (res != 1)
            {
                MessageBox.Show("Ajout effectuée");
            }
            else
            {
                MessageBox.Show("Problème sur l'ajout");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Depense uneDepense = new Depense(Convert.ToInt32(txtIdDepense.Text), txtLibelleDepense.Text);
            int res = DepenseDAO.supprimer(uneDepense);
            if (res != 1)
            {
                MessageBox.Show("Suppression effectuée");
            }
            else
            {
                MessageBox.Show("Problème sur  la suppression");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Depense uneDepense = new Depense(Convert.ToInt32(txtIdDepense.Text), txtLibelleDepense.Text);
            int res = DepenseDAO.modifier(uneDepense);
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
