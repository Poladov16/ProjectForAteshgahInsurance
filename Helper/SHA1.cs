using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Ateshgah_Insurance_Project.Helper
{
    public class SHA1
    {
        public static async Task<string> SHA(string data)
        {
            var byteData = Encoding.ASCII.GetBytes(data);
            var sh = new SHA1CryptoServiceProvider();
            var byteHash = sh.ComputeHash(byteData);
            var result = "";
            foreach (var t in byteHash)
            {
                result += t.ToString("x2");
            }
            return result;
        }
    }
}