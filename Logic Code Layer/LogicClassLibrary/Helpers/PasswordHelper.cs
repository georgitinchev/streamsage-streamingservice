﻿using LogicClassLibrary.Interface.Helpers;
using System.Security.Cryptography;
using System.Text;

namespace LogicClassLibrary.Helpers
{
    public class PasswordHelper : IPasswordHelper
    {
        public  string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        public string HashPassword(string password, string salt)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string saltedPassword = password + salt;
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public  bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            string hash = HashPassword(password, storedSalt);
            return hash == storedHash;
        }
    }
}
