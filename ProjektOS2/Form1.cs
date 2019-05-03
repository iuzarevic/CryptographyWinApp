using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOS2
{
    public partial class Form1 : Form
    {
        Form forma;
        Button trenutni;

        public Form1()
        {
            InitializeComponent();
            trenutni = btn_enkripcija;

            EnkripcijaForma formaEnkripcija = new EnkripcijaForma();
            Dizajner.prilagodiFormuPanelu(formaEnkripcija, glavniPanel);
            forma = formaEnkripcija;
        }

        private void DealocirajGlavniPanel()
        {
            foreach (Control control in glavniPanel.Controls)
            {
                control.Dispose();
            }
            glavniPanel.Controls.Clear();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Dizajner.prilagodiVelicinu(forma, glavniPanel);
        }

        private void btn_dekripcija_Click(object sender, EventArgs e)
        {
            DealocirajGlavniPanel();
            DekriptiranjeForma formaDekriptiranje = new DekriptiranjeForma();
            Dizajner.prilagodiFormuPanelu(formaDekriptiranje, glavniPanel);
            forma = formaDekriptiranje;
        }

        private void btn_enkripcija_Click(object sender, EventArgs e)
        {
            DealocirajGlavniPanel();
            EnkripcijaForma formaEnkripcija = new EnkripcijaForma();
            Dizajner.prilagodiFormuPanelu(formaEnkripcija, glavniPanel);
            forma = formaEnkripcija;
        }

        private void btn_sazetak_Click(object sender, EventArgs e)
        {
            DealocirajGlavniPanel();
            SazetakForma sazetakForma = new SazetakForma();
            Dizajner.prilagodiFormuPanelu(sazetakForma, glavniPanel);
            forma = sazetakForma;
        }

        private void btn_potpis_Click(object sender, EventArgs e)
        {
            DealocirajGlavniPanel();
            PotpisForma potpisForma = new PotpisForma();
            Dizajner.prilagodiFormuPanelu(potpisForma, glavniPanel);
            forma = potpisForma;
        }
    }
}
