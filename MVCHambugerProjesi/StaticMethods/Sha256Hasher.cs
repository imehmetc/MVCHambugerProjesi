﻿using System.Security.Cryptography;
using System.Text;

namespace MVCHambugerProjesi.StaticMethods
{
    public static class Sha256Hasher
    {
        public static string ComputeSha256Hash(string pass)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pass));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
