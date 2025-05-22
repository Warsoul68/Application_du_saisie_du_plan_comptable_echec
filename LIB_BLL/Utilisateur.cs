using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LIB_BLL
{
    public class Utilisateur
    {
        private int idU;
        private string login;
        private string pass;

        public Utilisateur(int idU, string login, string pass)
        {
            this.idU = idU;
            this.login = login;
            this.pass = pass;
        }

        public int getIdU()
        {
            return idU;
        }

        public void setIdU(int idU)
        {
            this.idU = idU;
        }

        public string getLogin()
        {
            return login;
        }

        public void setLogin(string login)
        {
            this.login = login;
        }

        public string getPass()
        {
            return pass;
        }

        public void setPass(string pass)
        {
            this.pass = pass;
        }

    }
}
