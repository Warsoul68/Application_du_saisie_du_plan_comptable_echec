using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class VueOperation
    {
        private int numDocument;
        private DateTime dateVO;
        private string operationVO;
        private float debitEuroVO;
        private float creditEuroVO;
        private string categorieDepenses;
        private string categorieRecettes;

        public VueOperation(int numDocument, DateTime dateVO, string operationVO, float debitEuroVO, float creditEuroVO, string categorieDepenses, string categorieRecettes)
        {
            this.numDocument = numDocument;
            this.dateVO = dateVO;
            this.operationVO = operationVO;
            this.debitEuroVO = debitEuroVO;
            this.creditEuroVO = creditEuroVO;
            this.categorieDepenses = categorieDepenses;
            this.categorieRecettes = categorieRecettes;
        }

        public int getNumDocument()
        {
            return numDocument;
        }

        public void setNumDocument(int numDocument)
        {
            this.numDocument = numDocument;
        }

        public DateTime getDateVO()
        {
            return dateVO;
        }

        public void setDateVO(DateTime dateVO)
        {
            this.dateVO = dateVO;
        }

        public string getOperationVO()
        {
            return operationVO;
        }

        public void setOperationVO(string operationVO)
        {
            this.operationVO = operationVO;
        }

        public float getDebitEuroVO()
        {
            return debitEuroVO;
        }

        public void setDebitEuroVO(float debitEuroVO)
        {
            this.debitEuroVO = debitEuroVO;
        }

        public float getCreditEuroVO()
        {
            return creditEuroVO;
        }

        public void setCreditEuroVO(float creditEuroVO)
        {
            this.creditEuroVO = creditEuroVO;
        }

        public string getCategorieDepenses()
        {
            return categorieDepenses;
        }

        public void setCategorieDepenses(string categorieDepenses)
        {
            this.categorieDepenses = categorieDepenses;
        }

        public string getCategorieRecettes()
        {
            return categorieRecettes;
        }

        public void setCategorieRecettes(string categorieRecettes)
        {
            this.categorieRecettes = categorieRecettes;
        }
    }
}
