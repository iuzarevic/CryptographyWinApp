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
    public partial class SazetakForma : Form
    {
        public SazetakForma()
        {
            InitializeComponent();
            Dizajner.FormaBezOkna(this);
        }

        private void btn_ucitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog traziDatoteku = new OpenFileDialog();
            if (traziDatoteku.ShowDialog() == DialogResult.OK)
            {
                string path = traziDatoteku.FileName;
                byte[] data = File.ReadAllBytes(path);
                string hash = HashData.ComputeHashSHA256(data);
                box_sazetak.Text = hash;
                FileManager.SpremiSazetak(hash, path);
            }
        }
    }
}
