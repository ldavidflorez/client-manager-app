using System.Security.Cryptography;
using System.Text;

namespace MyWebApi.Utils
{
    public class EncryptionHelper
    {
        public static string EncryptString(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2")); // Convert byte to hexadecimal string
                }

                return builder.ToString();
            }
        }
    }
}
