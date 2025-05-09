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
        private int idUtilisateur;
        private string login;
        private string pass;

        public Utilisateur(int idUtilisateur, string login, string pass)
        {
            this.idUtilisateur = idUtilisateur;
            this.login = login;
            this.pass = pass;
        }

        public int getIdUtilisateur()
        {
            return idUtilisateur;
        }

        public void setIdUtilisateur(int idUtilisateur)
        {
            this.idUtilisateur = idUtilisateur;
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
