using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOS2
{
    static class FileManager
    {
        public static void SpremiPrivatniKljuc(string privatniKljuc)
        {
            using (StreamWriter w = new StreamWriter("privatni_kljuc.txt", false))
            {
                w.WriteLine(privatniKljuc);
            }
        }

        public static void SpremiJavniKljuc(string javniKljuc)
        {
            using (StreamWriter w = new StreamWriter("javni_kljuc.txt", false))
            {
                w.WriteLine(javniKljuc);
            }
        }

        public static void SpremiTajniKljuc(string tajniKljuc)
        {
            using (StreamWriter w = new StreamWriter("tajni_kljuc.txt", false))
            {
                w.WriteLine(tajniKljuc);
            }
        }

        public static void SpremiIV(string iv)
        {
            using (StreamWriter w = new StreamWriter("iv.txt", false))
            {
                w.WriteLine(iv);
            }
        }

        public static bool SpremiEnkriptiranuDatoteku(string fileName, byte[] byteArray, string tip)
        {
            string name = "";
            if (tip == "AES")
            {
                name = Path.GetFileNameWithoutExtension(fileName) + "_" + "aes" + Path.GetExtension(fileName);
            }
            else if (tip == "RSA")
            {
                name = Path.GetFileNameWithoutExtension(fileName) + "_" + "rsa" + Path.GetExtension(fileName);
            }
            try
            {
                using (var fs = new FileStream(name, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }
        }

        public static bool SpremiDekriptiranuDatoteku(string fileName, byte[] byteArray)
        {
            try
            {
                using (var fs = new FileStream(Path.GetFileNameWithoutExtension(fileName) + "_" + "dekriptirano" + Path.GetExtension(fileName), FileMode.Create, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }
        }

        public static void SpremiSazetak(string hash, string path)
        {
            using (StreamWriter w = new StreamWriter(Path.GetFileNameWithoutExtension(path)+"_sazetak.txt", false))
            {
                w.WriteLine(hash);
            }
        }

        public static bool SpremiPotpis(byte[] potpis, string path)
        {
            byte[] byteArray = potpis;
            try
            {
                using (var fs = new FileStream(Path.GetFileNameWithoutExtension(path) + "_" + "potpis" + Path.GetExtension(path), FileMode.Create, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }
        }
    }
}
