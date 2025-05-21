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
    public class VueOperationDAO
    {
        public static List<VueOperation> getTouteLesOperationsVo()
        {
            List<VueOperation> res = new List<VueOperation>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "SELECT * FROM Vue_Operation";
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    VueOperation vo = new VueOperation(dr.GetInt32(0), dr.GetDateTime(1), dr.GetString(2), (float)dr.GetDecimal(3), (float)dr.GetDecimal(4), dr.GetString(5), dr.GetString(6));
                    res.Add(vo);
                }
                dr.Close();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la lecture des Opération de la vue : " + ex.Message);
                return null;
            }
        }

        public static List<VueOperation> getVueOperationFiltre(int vNumDocument = 0, DateTime vDateVo = default(DateTime))
        {
            List<VueOperation> res = new List<VueOperation>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();

            cmd.CommandText = "SELECT * FROM Vue_Operation WHERE 1=1 ";

            if (vNumDocument != 0) cmd.CommandText += " AND Numéro_document = " + vNumDocument;
            if (vDateVo != default(DateTime)) cmd.CommandText += " AND Date = '" + vDateVo.ToString("yyyy-MM-dd") + "'";

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    VueOperation vo = new VueOperation(dr.GetInt32(0), dr.GetDateTime(1), dr.GetString(2), (float)dr.GetDecimal(3), (float)dr.GetDecimal(4), dr.GetString(5), dr.GetString(6));
                    res.Add(vo);

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
