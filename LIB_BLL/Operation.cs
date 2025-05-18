using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Operation
    {
        private int numOperation;
        private string nomOperation;
        private DateTime anneeResultatO;
        private int idTransaction;

        public Operation(int numOperation, string nomOperation, DateTime anneeResultatO, int idTransaction)
        {
            this.numOperation = numOperation;
            this.nomOperation = nomOperation;
            this.anneeResultatO = anneeResultatO;
            this.idTransaction = idTransaction;
        }

        public int getNumOperation()
        {
            return numOperation;
        }

        public void setNumOperation(int numOperation)
        {
            this.numOperation = numOperation;
        }

        public string getNomOperation()
        {
            return nomOperation;
        }

        public void setNomOperation(string nomOperation)
        {
            this.nomOperation = nomOperation;
        }

        public DateTime getAnneeResultatO()
        {
            return anneeResultatO;
        }

        public void setAnneeResultatO(DateTime anneeResultatO)
        {
            this.anneeResultatO = anneeResultatO;
        }

        public int getIdTransaction()
        {
            return idTransaction;
        }

        public void setIdTransaction(int idTransaction)
        {
            this.idTransaction = idTransaction;
        }
    }
}
