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
    }
}
