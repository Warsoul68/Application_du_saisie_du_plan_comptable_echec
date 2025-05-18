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

        public static Recette rechercher(int vidR)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "select * from Recette where id = " + vidR;
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
    }
    }
