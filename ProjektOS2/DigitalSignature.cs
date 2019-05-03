using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
namespace ProjektOS2
{
    class DigitalSignature
    {
        private string publicKey;
        private string privateKey;

        public void ProdruzivanjeKljuceva(string javni, string privatni)
        {
            publicKey = javni;
            privateKey = privatni;
        }

        public byte[] SignData(byte[] hash)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(privateKey);

                var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                rsaFormatter.SetHashAlgorithm("SHA256");

                return rsaFormatter.CreateSignature(hash);
            }
        }

        public bool VerifySignature(byte[] hash, byte[] signature)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(publicKey);

                var rsaFormatter = new RSAPKCS1SignatureDeformatter(rsa);
                rsaFormatter.SetHashAlgorithm("SHA256");

                return rsaFormatter.VerifySignature(hash, signature);
            }
        }
    }
}
