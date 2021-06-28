using System;
using System.Security.Cryptography;
using System.Text;
using CustomerManagement.Interfaces;

namespace CustomerManagement.Logic
{
    public class UserLogin : IUserLogin
    {
        public string GenerateSalt(int length)
        {
            var encryption = new SHA256Managed();
            return Convert.ToBase64String(encryption.ComputeHash(new byte[length]));
        }

        /// <summary>
        /// Erzeugt SHA256-Hashcode aus Eingabe
        /// </summary>
        /// <param name="plainText">Die zu verhashende Zeichenkette</param>
        /// <param name="salt">Hashwert zur komplexeren verhashung</param>
        /// <returns>SHA256-Hashcode</returns>
        public string GenerateHash(string plainText, string salt)
        {
            var encryption = new SHA256Managed();
            return Convert.ToBase64String(encryption.ComputeHash(Encoding.ASCII.GetBytes(plainText + salt)));
        }

        public bool VerifyPasswordHash(string plainText, string storedHash, string salt)
        {
            if (string.IsNullOrWhiteSpace(plainText) 
                || string.IsNullOrWhiteSpace(storedHash)
                || string.IsNullOrWhiteSpace(salt))
            {
                return false;
            }
            return GenerateHash(plainText, salt) == storedHash;
        }
    }
}