using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOS2
{
    public partial class DekriptiranjeForma : Form
    {
        Enkripcija trenutna;
        string path;
        byte[] data;
        byte[] decryptedData;

        public DekriptiranjeForma()
        {
            InitializeComponent();

            Dizajner.FormaBezOkna(this);
            odabirAlgoritam.DataSource = new List<string> { "AES", "RSA" };
        }

        private void Ocisti()
        {
            prikazEnkriptirano.Clear();
            prikazOriginal.Clear();
            gumbDekriptiraj.Enabled = false;
        }

        private void btn_ucitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog traziDatoteku = new OpenFileDialog();
            if (traziDatoteku.ShowDialog() == DialogResult.OK)
            {
                path = traziDatoteku.FileName;
                data = File.ReadAllBytes(path);
                prikazEnkriptirano.Text = Convert.ToBase64String(data);
                gumbDekriptiraj.Enabled = true;
            }
            else
            {
                gumbDekriptiraj.Enabled = false;
            }
        }

        private void odabirAlgoritam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ocisti();
        }

        private void gumbDekriptiraj_Click(object sender, EventArgs e)
        {
            try
            {
                if (odabirAlgoritam.SelectedValue == (object)"AES")
                {
                    Enkripcija aes = new AES();
                    byte[] tajni = Convert.FromBase64String(File.ReadAllText("tajni_kljuc.txt"));
                    byte[] iv = Convert.FromBase64String(File.ReadAllText("iv.txt"));
                    aes.PridruziKljucIV(tajni, iv);
                    decryptedData = aes.DekriptirajFile(data);
                }
                if (odabirAlgoritam.SelectedValue == (object)"RSA")
                {
                    Enkripcija rsa = new RSA();
                    string privatni = File.ReadAllText("privatni_kljuc.txt");
                    string javni = File.ReadAllText("javni_kljuc.txt");
                    rsa.PridruziPrivatniKljuc(privatni);
                    rsa.PridruziJavniKljuc(javni);
                    decryptedData = rsa.DekriptirajFile(data);
                }
                FileManager.SpremiDekriptiranuDatoteku(path, decryptedData);
                prikazOriginal.Text = Encoding.UTF8.GetString(decryptedData);
            }
            catch
            {
                MessageBox.Show("Učitana je neispravna datoteka!");
            }
        }
    }
}
