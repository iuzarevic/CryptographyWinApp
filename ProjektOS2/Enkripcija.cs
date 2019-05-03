using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace ProjektOS2
{
    public abstract class Enkripcija
    {
        protected string javniKljuc;
        protected string privatniKljuc;
        protected byte[] tajniKljuc;
        protected byte[] IV;

        public virtual byte[] GenerirajRandomBroj(int length)
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[length];
                randomNumberGenerator.GetBytes(randomNumber);
                return randomNumber;
            }
        }

        public virtual void AssignRSAKljuceva()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                javniKljuc = rsa.ToXmlString(false);
                privatniKljuc = rsa.ToXmlString(true);
            }
        }

        public virtual string DohvatiJavniKljuc()
        {
            return javniKljuc;
        }

        public virtual string DohvatiPrivatniKljuc()
        {
            return privatniKljuc;
        }

        public virtual byte[] DohvatiAESKljuc()
        {
            return tajniKljuc;
        }

        public virtual byte[] DohvatiIV()
        {
            return IV;
        }

        public virtual void PridruziJavniKljuc(string javni)
        {
            javniKljuc = javni;
        }

        public virtual void PridruziPrivatniKljuc(string privatni)
        {
            privatniKljuc = privatni;
        }

        public virtual void PridruziKljucIV(byte[] kljuc, byte[] iv)
        {
            tajniKljuc = kljuc;
            IV = iv;
        }

        public virtual string PrikazEnkriptiranihPodataka(byte[] podaci)
        {
            string result = Convert.ToBase64String(podaci);
            return result;
        }

        public virtual void GenerirajKljucIV()
        {
            tajniKljuc = GenerirajRandomBroj(32);
            IV = GenerirajRandomBroj(16);
        }

        public abstract byte[] EnkriptirajFile(byte[] podaci);
        public abstract byte[] DekriptirajFile(byte[] podaci);
    }
}
