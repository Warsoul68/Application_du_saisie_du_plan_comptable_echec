using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Depense
    {
        private int idDepense;
        private string libelleD;

        public Depense(int idDepense, string libelleD)
        {
            this.idDepense = idDepense;
            this.libelleD = libelleD;
        }

        public int getIdDepense()
        {
            return idDepense;
        }

        public void setIdDepense(int idDepense)
        {
            this.idDepense = idDepense;
        }

        public string getLibelleD()
        {
            return libelleD;
        }

        public void setLibelleD(string libelleD)
        {
            this.libelleD = libelleD;
        }

        public int IdDepenseAffiche => getIdDepense();
        public string LibelleDAffiche => getLibelleD();
    }
}
