using LIB_BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIB_DAL
{
    public class CompteDAO
    {
        public static List<Compte> getTousLesComptes()
        {
            List<Compte> res = new List<Compte>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "SELECT * FROM Compte";
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Compte c = new Compte(dr.GetInt32(0), dr.GetString(1), (float)dr.GetDecimal(2));
                    res.Add(c);
                }
                dr.Close();
                return res;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lors de la lecture des comptes : " + ex.Message);
                return null;
            }
        }
    }
}
