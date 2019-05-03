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
    public partial class EnkripcijaForma : Form
    {
        string path;
        byte[] data;
        byte[] encryptedData;
        Enkripcija trenutna;
        public EnkripcijaForma()
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);

            odabirAlgoritam.DataSource = new List<string> { "AES", "RSA"};
        }

        private void Ocisti()
        {
            odabirPrvo.Clear();
            odabirDrugo.Clear();
            prikazEnkriptirano.Clear();
            prikazOriginal.Clear();
            gumbEnkriptiraj.Enabled = false;
        }

        private void gumbGeneriraj_Click(object sender, EventArgs e)
        {
            if (odabirAlgoritam.SelectedValue == (object)"AES")
            {
                Enkripcija aesEnkripcija = new AES();
                aesEnkripcija.GenerirajKljucIV();
                odabirPrvo.Text = Convert.ToBase64String(aesEnkripcija.DohvatiAESKljuc());
                odabirDrugo.Text = Convert.ToBase64String(aesEnkripcija.DohvatiIV());
                trenutna = aesEnkripcija;
                FileManager.SpremiTajniKljuc(odabirPrvo.Text);
                FileManager.SpremiIV(odabirDrugo.Text);
            }

            if (odabirAlgoritam.SelectedValue == (object)"RSA")
            {
                Enkripcija rsaEnkripcija = new RSA();
                rsaEnkripcija.AssignRSAKljuceva();
                odabirPrvo.Text = rsaEnkripcija.DohvatiJavniKljuc();
                odabirDrugo.Text = rsaEnkripcija.DohvatiPrivatniKljuc();
                trenutna = rsaEnkripcija;
                FileManager.SpremiJavniKljuc(odabirPrvo.Text);
                FileManager.SpremiPrivatniKljuc(odabirDrugo.Text);
            }

        }

        private void odabirAlgoritam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (odabirAlgoritam.SelectedValue == (object)"RSA")
            {
                labelaPrvo.Text = "Javni:";
                labelaDrugo.Text = "Privatni:";
                Ocisti();
            }
            if (odabirAlgoritam.SelectedValue == (object)"AES")
            {
                labelaPrvo.Text = "Tajni:";
                labelaDrugo.Text = "IV:";
                Ocisti();
            }
        }

        private void btn_ucitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog traziDatoteku = new OpenFileDialog();
            if (traziDatoteku.ShowDialog() == DialogResult.OK)
            {
                path = traziDatoteku.FileName;
                data = File.ReadAllBytes(path);
                prikazOriginal.Text = Encoding.UTF8.GetString(data);
                gumbEnkriptiraj.Enabled = true;
            }
            else
            {
                gumbEnkriptiraj.Enabled = false;
            }
        }

        private void gumbEnkriptiraj_Click(object sender, EventArgs e)
        {
            try
            {
                if (odabirAlgoritam.SelectedValue == (object)"AES")
                {
                    encryptedData = trenutna.EnkriptirajFile(data);
                }
                if (odabirAlgoritam.SelectedValue == (object)"RSA")
                {
                    encryptedData = trenutna.EnkriptirajFile(data);
                }
                FileManager.SpremiEnkriptiranuDatoteku(path, encryptedData, odabirAlgoritam.SelectedValue.ToString());
                prikazEnkriptirano.Text = trenutna.PrikazEnkriptiranihPodataka(encryptedData);
            }
            catch
            {
                MessageBox.Show("Neispravna datoteka! Najvjerovatnije je datoteka prevelika");
            }

        }
    }
}
