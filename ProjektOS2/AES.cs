using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOS2
{
    public class AES : Enkripcija
    {

        public override byte[] EnkriptirajFile(byte[] podaci)
        {
            var data = podaci;
            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = tajniKljuc;
                aes.IV = IV;
                using (var memoryStream = new MemoryStream())
                {
                    var cryptoStream = new CryptoStream(memoryStream,
                    aes.CreateEncryptor(), CryptoStreamMode.Write);
                    cryptoStream.Write(data, 0, data.Length);
                    cryptoStream.FlushFinalBlock();
                    return memoryStream.ToArray();
                }
            }
        }

        public override byte[] DekriptirajFile(byte[] podaci)
        {
            byte[] dataToDecrypt = podaci;
            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = tajniKljuc;
                aes.IV = IV;
                using (var memoryStream = new MemoryStream())
                {
                    var cryptoStream = new CryptoStream(memoryStream,
                    aes.CreateDecryptor(), CryptoStreamMode.Write);
                    cryptoStream.Write(dataToDecrypt, 0, dataToDecrypt.Length);
                    cryptoStream.FlushFinalBlock();
                    var decryptBytes = memoryStream.ToArray();
                    return decryptBytes;
                }
            }
        }

    }
}
