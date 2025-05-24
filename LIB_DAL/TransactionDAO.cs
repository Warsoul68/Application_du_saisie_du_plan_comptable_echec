using LIB_BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class TransactionDAO
    {
        public static int creer(Transaction t)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "insert into TransactionO values (" + t.getAnneeResultatT() + ", " + t.getDateTransaction() + ", " + t.getMontant() + ", " + t.getIdDepense() + ", " + t.getIdRecette() + ")";
            try
            {
                dr = cmd.ExecuteReader();
                dr.Read();


                dr.Close();
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;


            }
        }
    }
}
