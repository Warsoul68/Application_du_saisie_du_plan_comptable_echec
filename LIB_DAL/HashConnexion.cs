using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LIB_DAL
{
    public class HashConnexion
    {
        public static class HashUtil
        {
            private static string DeriveSalt(string identifiant)
            {
                using (var sha256 = SHA256.Create())
                {
                    byte[] saltBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(identifiant));
                    return Convert.ToBase64String(saltBytes);
                }
            }

            public static string HashPassword(string password, string identifiant)
            {
                string salt = DeriveSalt(identifiant);
                string saltedPassword = salt + password;

                using (var sha256 = SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                    return Convert.ToBase64String(hashBytes);
                }
            }
        }
    }
}
}
