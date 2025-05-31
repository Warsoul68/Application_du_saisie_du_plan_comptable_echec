using LIB_BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class OperationDAO
    {
        public static Operation rechercher(int vNumO)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "select * from Operation where numOperation = " + vNumO;
            try
            {
                dr = cmd.ExecuteReader();
                dr.Read();

                Operation o = new Operation(dr.GetInt32(0), dr.GetString(1), dr.GetDateTime(2), dr.GetInt32(3));

                dr.Close();
                return o;
            }
            catch
            {
                return null;
            }
        }

        public static int creer(Operation o)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "insert into Operation values (" + o.getNumOperation() + ", '" + o.getNomOperation() + "', '" + o.getAnneeResultatO() + "', " + o.getIdTransaction() + ")";
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

        public static int supprimer(Operation o)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "delete from Operation where idTransaction = " + o.getIdTransaction();
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

        public static int modifier(Operation o)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "update Operation set nomOperation = '" + o.getNomOperation()  + "', '" + o.getAnneeResultatO() + "' where idTransaction = " + o.getIdTransaction();
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
