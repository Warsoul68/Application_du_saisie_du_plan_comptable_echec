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
    public partial class ParametreRecette : Form
    {
        public ParametreRecette()
        {
            InitializeComponent();

        }

        private void ParametreRecette_Load(object sender, EventArgs e)
        {
            dgvRecette.AutoGenerateColumns = true;
            dgvRecette.DataSource = RecetteDAO.getTouteLesRecette();
            dgvRecette.Columns["IdRecetteAffiche"].HeaderText = "id";
            dgvRecette.Columns["LibelleRAffiche"].HeaderText = "Libellé";
        }

        private void BtnRechercherId_Click(object sender, EventArgs e)
        {
            int recetteId;

            if (int.TryParse(txtIdRecette.Text, out recetteId))
            {
                Recette r = RecetteDAO.rechercher(recetteId);
                txtLibelleRecette.Text = r.getLibelleR();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Recette uneRecette = new Recette(Convert.ToInt32(txtIdRecette.Text), txtLibelleRecette.Text);
            int res = RecetteDAO.creer(uneRecette);
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
            Recette uneRecette = new Recette(Convert.ToInt32(txtIdRecette.Text), txtLibelleRecette.Text);
            int res = RecetteDAO.supprimer(uneRecette);
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
            Recette uneRecette = new Recette(Convert.ToInt32(txtIdRecette.Text), txtLibelleRecette.Text);
            int res = RecetteDAO.modifier(uneRecette);
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
