using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Hasharp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hasharp());
        }
        static string CreateMD5(string x)
        {
            var convertTmp = Encoding.Default.GetBytes(x);
            MD5 md5 = MD5.Create();
            var hashBytes = md5.ComputeHash(convertTmp);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }
        static string CreateSHA1(string x)
        {
            var convertTmp = Encoding.Default.GetBytes(x);
            SHA1 sha1 = SHA1.Create();
            var hashBytes = sha1.ComputeHash(convertTmp);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }
        static string CreateSHA256(string x)
        {
            var convertTmp = Encoding.Default.GetBytes(x);
            SHA256 sha256 = SHA256.Create();
            var hashBytes = sha256.ComputeHash(convertTmp);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }
    }
}
