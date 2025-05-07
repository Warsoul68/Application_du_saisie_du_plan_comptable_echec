using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Compte
    {
        private int numCompte;
        private string libelleCompte;
        private float soldeCompte;

        public Compte(int numCompte, string libelleCompte, float soldeCompte)
        {
            this.numCompte = numCompte;
            this.libelleCompte = libelleCompte;
            this.soldeCompte = soldeCompte;
        }

        public int getNumCompte()
        {
            return numCompte;
        }

        public void setNumCompte(int numCompte)
        {
            this.numCompte = numCompte;
        }

        public string getLibelleCompte()
        {
            return libelleCompte;
        }

        public void setLibelleCompte(string libelleCompte)
        {
            this.libelleCompte = libelleCompte;
        }

        public float getSoldeCompte()
        {
            return soldeCompte;
        }

        public void setSoldeCompte(float soldeCompte)
        {
            this.soldeCompte = soldeCompte;
        }
    }
}
