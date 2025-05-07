using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Annee
    {
        private DateTime anneeResultat;

        public Annee(DateTime anneeResultat)
        {
            this.anneeResultat = anneeResultat;
        }

        public DateTime getAnneeResultat()
        {
            return anneeResultat;
        }

        public void setAnneeResultat(DateTime anneeResultat)
        {
            this.anneeResultat = anneeResultat;
        }
    }
}
