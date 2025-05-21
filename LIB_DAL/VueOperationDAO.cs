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

        public static List<VueOperation> getVueOperationFiltre(int vNumDocument)
        {
            List<VueOperation> res = new List<VueOperation>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = Bdd.getConnexion();

            cmd.CommandText = "SELECT * FROM Vue_Selection_Article WHERE 1=1 ";

            if (vLibelleVA != "") cmd.CommandText += " AND Libellé LIKE '%" + vLibelleVA + "%'";

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())

                {
                    VueArticle va = new VueArticle(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5));
                    res.Add(va);

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
