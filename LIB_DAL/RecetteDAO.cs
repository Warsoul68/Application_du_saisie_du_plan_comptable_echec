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
    public class RecetteDAO
    {
        public static List<Recette> getTouteLesRecette()
        {
                List<Recette> res = new List<Recette>();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Bdd.getConnexion();
                cmd.CommandText = "SELECT * FROM Recette";
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Recette r = new Recette(dr.GetInt32(0), dr.GetString(1));
                        res.Add(r);
                    }
                    dr.Close();
                    return res;
                }
                catch
                {
                    return null;
                }
            }

        public static Recette rechercher(int vIdR)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "select * from Recette where id = " + vIdR;
            try
            {
                dr = cmd.ExecuteReader();
                dr.Read();

                Recette r = new Recette(dr.GetInt32(0), dr.GetString(1));

                dr.Close();
                return r;
            }
            catch
            {
                return null;


            }
        }

        public static int creer(Recette r)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "insert into Recette values (" + r.getIdRecette() + ", '" + r.getLibelleR() + "')";
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
        public static int supprimer(Recette r)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "delete from Recette where id = " + r.getIdRecette();
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

        public static int modifier(Recette r)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "update Recette set libelle = '" + r.getLibelleR() + "' where id = " + r.getIdRecette();
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
