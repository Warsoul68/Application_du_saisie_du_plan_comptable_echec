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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void btnNewOperation_Click(object sender, EventArgs e)
        {
            NouvelleOperationForm NOF = new NouvelleOperationForm();
            NOF.Show();

        }
    }
}
