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
    }
}
