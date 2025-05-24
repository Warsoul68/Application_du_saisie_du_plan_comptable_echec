using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB_BLL;

namespace LIB_DAL
{
    public class DepenseDAO
    {
        public static List<Depense> getTouteLesDepenses()
        {
            List<Depense> res = new List<Depense>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "SELECT * FROM Depense";
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Depense d = new Depense(dr.GetInt32(0), dr.GetString(1));
                    res.Add(d);
                }
                dr.Close();
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static Depense rechercher(int vIdD)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "select * from Depense where id = " + vIdD;
            try
            {
                dr = cmd.ExecuteReader();
                dr.Read();

                Depense d = new Depense(dr.GetInt32(0), dr.GetString(1));

                dr.Close();
                return d;
            }
            catch
            {
                return null;


            }
        }
        public static int creer(Depense d)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "insert into Depense values (" + d.getIdDepense() + ", '" + d.getLibelleD() + "')";
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

        public static int supprimer(Depense d)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "delete from Depense where id = " + d.getIdDepense();
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

        public static int modifier(Depense d)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "update Depense set libelle = '" + d.getLibelleD() + "' where id = " + d.getIdDepense();
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
