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
    public partial class NouvelleOperationForm : Form
    {
        public NouvelleOperationForm()
        {
            InitializeComponent();
        }

        private void rdbDepense_CheckedChanged(object sender, EventArgs e)
        {
            lblCategorieDepenses.Visible = true;
            cbCategorieDepense.Visible = true;
            lblCategorieRecette.Visible = false;
            cbCategorieRecette.Visible = false;
        }

        private void rdbRecette_CheckedChanged(object sender, EventArgs e)
        {
            lblCategorieRecette.Visible = true;
            cbCategorieRecette.Visible = true;
            lblCategorieDepenses.Visible = false;
            cbCategorieDepense.Visible = false;
        }
    }
}
