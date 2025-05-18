using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Transaction
    {
        private DateTime anneeResultatT;
        private int idTransaction;
        private DateTime dateTransaction;
        private float montant;
        private int idDepense;
        private int idRecette;

        public Transaction(DateTime anneeResultatT, int idTransaction, DateTime dateTransaction, float montant, int idDepense, int idRecette)
        {
            this.anneeResultatT = anneeResultatT;
            this.idTransaction = idTransaction;
            this.dateTransaction = dateTransaction;
            this.montant = montant;
            this.idDepense = idDepense;
            this.idRecette = idRecette;
        }

        public DateTime getAnneeResultatT()
        {
            return anneeResultatT;
        }

        public void setAnneeResultatT(DateTime anneeResultatT)
        {
            this.anneeResultatT = anneeResultatT;
        }

        public int getIdTransaction()
        {
            return idTransaction;
        }

        public void setIdTransaction(int idTransaction)
        {
            this.idTransaction = idTransaction;
        }

        public DateTime getDateTransaction()
        {
            return dateTransaction;
        }

        public void setDateTransaction(DateTime dateTransaction)
        {
            this.dateTransaction = dateTransaction;
        }

        public float getMontant()
        {
            return montant;
        }

        public void setMontant(float montant)
        {
            this.montant = montant;
        }

        public int getIdDepense()
        {
            return idDepense;
        }

        public void setIdDepense(int idDepense)
        {
            this.idDepense = idDepense;
        }

        public int getIdRecette()
        {
            return idRecette;
        }

        public void setIdRecette(int idRecette)
        {
            this.idRecette = idRecette;
        }
    }
}
