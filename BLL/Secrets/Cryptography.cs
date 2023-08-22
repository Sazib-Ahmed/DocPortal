using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Secrets
{
    internal class Cryptography
    {
        public static string EncryptPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password.Trim()));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static string EncryptToken(string data)
        {
            using (var hmac = new HMACSHA256())
            {
                var key = Encoding.UTF8.GetBytes("(It's a Wonderful Life 1946) and (North by Northwest 1959)");
                hmac.Key = key;

                byte[] dataBytes = Encoding.UTF8.GetBytes(data);
                byte[] hashBytes = hmac.ComputeHash(dataBytes);

                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
