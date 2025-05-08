using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Recette
    {
        private int idRecette;
        private string libelleR;

        public Recette(int idRecette, string libelleR)
        {
            this.idRecette = idRecette;
            this.libelleR = libelleR;
        }

        public int getIdRecette()
        {
            return idRecette;
        }

        public void setIdRecette(int idRecette)
        {
            this.idRecette = idRecette;
        }

        public string getLibelleR()
        {
            return libelleR;
        }

        public void setLibelleR(string libelleR)
        {
            this.libelleR = libelleR;
        }
    }
}
