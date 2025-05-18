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
            dgvCompte.Columns["NumCompteAffiche"].HeaderText = "numCompte";
            dgvCompte.Columns["LibelleCompteAffiche"].HeaderText = "libelleCompte";
            dgvCompte.Columns["SoldeCompteAffiche"].HeaderText = "soldeCompte";

        }
    }
}
