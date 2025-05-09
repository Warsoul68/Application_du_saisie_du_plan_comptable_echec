using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class Bdd
    {
        private static SqlConnection c;
        public Bdd() { }

        public static bool ouvrirConnexion()
        {
            string chaineDeConnexion = "Data Source=PC-MATHIAS\\SQLEXPRESS;" + "Initial Catalog=bdd_saisie_comptable_echec;" + "Integrated Security = SSPI;";
            c = new SqlConnection();
            c.ConnectionString = chaineDeConnexion;
            try
            {
                c.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static SqlConnection getConnexion()
        {
            return c;
        }

        public static string afficherConnexion()
        {
            return "Connecté sur " + c.DataSource + "--> " + c.Database + " Etat = " + c.State;
        }

        public void fermerConnexion()
        {
            c.Close();

        }
    }
}
