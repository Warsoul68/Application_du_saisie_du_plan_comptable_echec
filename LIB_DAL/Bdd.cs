using MySql.Data.MySqlClient;
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
        private static MySqlConnection c;
        public Bdd() { }

        public static bool ouvrirConnexion()
        {
            string chaineDeConnexion = "SERVER=localhost;" + "DATABASE=bdd_saisie_comptable_echec;" + "UID=root;" + "PASSWORD= ;";
            c = new MySqlConnection();
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

        public static MySqlConnection getConnexion()
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
