using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Affecte
    {
        private int numCompteA;
        private DateTime anneeResultatA;
        private int idTransaction;
        private float debit;
        private float credit;

        public Affecte(int numCompteA, DateTime anneeResultatA, int idTransaction, float debit, float credit)
        {
            this.numCompteA = numCompteA;
            this.anneeResultatA = anneeResultatA;
            this.idTransaction = idTransaction;
            this.debit = debit;
            this.credit = credit;
        }

        public int getNumCompteA()
        {
            return numCompteA;
        }

        public void setNumCompteA(int numCompteA)
        {
            this.numCompteA = numCompteA;
        }

        public DateTime getAnneeResultatA()
        {
            return anneeResultatA;
        }

        public void setAnneeResultatA(DateTime anneeResultatA)
        {
            this.anneeResultatA = anneeResultatA;
        }

        public int getIdTransaction()
        {
            return idTransaction;
        }

        public void setIdTransaction(int idTransaction)
        {
            this.idTransaction = idTransaction;
        }

        public float getDebit()
        {
            return debit;
        }

        public void setDebit(float debit)
        {
            this.debit = debit;
        }

        public float getCredit()
        {
            return credit;
        }

        public void setCredit(float credit)
        {
            this.credit = credit;
        }
    }
}
