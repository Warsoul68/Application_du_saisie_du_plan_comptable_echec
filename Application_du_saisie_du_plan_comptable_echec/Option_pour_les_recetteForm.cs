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
    }
}
