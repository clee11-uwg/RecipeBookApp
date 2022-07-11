using System;
using System.Security.Cryptography;
using System.Text;

namespace RecipeBookApp.Utility
{
    /// <summary>
    /// Utility class for any needed cryptography
    /// </summary>
    public class Crypt
    {
        /// <summary>
        /// Compute SHA-256 hash of a given string.
        /// 
        /// Implementation from Dmitry Bychenko, 12/1/21, at https://stackoverflow.com/questions/16999361/obtain-sha-256-string-of-a-string
        /// </summary>
        /// <param name="value">String to hash</param>
        /// <returns>Hash of the string</returns>
        public static String SHA256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
