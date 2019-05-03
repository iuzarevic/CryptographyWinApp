using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOS2
{
    class RSA : Enkripcija
    {
        public override byte[] EnkriptirajFile(byte[] podaci)
        {
            byte[] cipherbytes;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(javniKljuc);
                cipherbytes = rsa.Encrypt(podaci, false);
            }

            return cipherbytes;
        }

        public override byte[] DekriptirajFile(byte[] podaci)
        {
            byte[] plain;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(privatniKljuc);
                plain = rsa.Decrypt(podaci, false);
            }

            return plain;
        }
    }
}
