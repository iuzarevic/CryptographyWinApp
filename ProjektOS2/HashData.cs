using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOS2
{
    class HashData
    {
        public static string ComputeHashSHA256(byte[] data)
        {
            using (var sha256 = SHA256.Create())
            {
                return Convert.ToBase64String(sha256.ComputeHash(data));
            }
        }
    }
}
