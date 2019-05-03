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
    public partial class PotpisForma : Form
    {
        bool ucitaj = false;
        bool ucitajPotpis = false;
        byte[] loadedPotpis;
        byte[] loadedHash;
        public PotpisForma()
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
        }

        private void btn_ucitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog traziDatoteku = new OpenFileDialog();
            if (traziDatoteku.ShowDialog() == DialogResult.OK)
            {
                byte[] result;
                string path = traziDatoteku.FileName;
                byte[] data = File.ReadAllBytes(path);
                byte[] hash = Convert.FromBase64String(HashData.ComputeHashSHA256(data));

                DigitalSignature signature = new DigitalSignature();
                signature.ProdruzivanjeKljuceva(File.ReadAllText("javni_kljuc.txt"), File.ReadAllText("privatni_kljuc.txt"));
                result = signature.SignData(hash);
                box_potpis.Text = Convert.ToBase64String(result);

                FileManager.SpremiPotpis(result, path);
            }
        }

        private void btn_ucitaj2_Click(object sender, EventArgs e)
        {
            OpenFileDialog traziDatoteku = new OpenFileDialog();
            if (traziDatoteku.ShowDialog() == DialogResult.OK)
            {
                string path = traziDatoteku.FileName;
                byte[] data = File.ReadAllBytes(path);
                loadedHash = Convert.FromBase64String(HashData.ComputeHashSHA256(data));
                box_path.Text = path;
                ucitaj = true;
                if (ucitajPotpis == true)
                {
                    btn_provjeriPotpis.Enabled = true;
                }
            }
        }

        private void btn_ucitajPotpis_Click(object sender, EventArgs e)
        {
            OpenFileDialog traziDatoteku = new OpenFileDialog();
            if (traziDatoteku.ShowDialog() == DialogResult.OK)
            {
                string path = traziDatoteku.FileName;
                try
                {
                    loadedPotpis = File.ReadAllBytes(path);
                    box_potpis2.Text = Convert.ToBase64String(loadedPotpis);
                    ucitajPotpis = true;
                    if (ucitaj == true)
                    {
                        btn_provjeriPotpis.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("U ovoj datoteci se ne nalazi digitalni potpis!");
                }
            }
        }

        private void btn_provjeriPotpis_Click(object sender, EventArgs e)
        {
            DigitalSignature signature = new DigitalSignature();
            signature.ProdruzivanjeKljuceva(File.ReadAllText("javni_kljuc.txt"), File.ReadAllText("privatni_kljuc.txt"));
            bool provjera = signature.VerifySignature(loadedHash, loadedPotpis);
            if (provjera == true)
            {
                box_result.Text = "Potpis je ispravan";
            }
            else
            {
                box_result.Text = "Potpis nije ispravan";
            }
        }
    }
}
