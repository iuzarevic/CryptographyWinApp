using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOS2
{
    static class Dizajner
    {
        public static void FormaBezOkna(Form forma)
        {
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.MaximizeBox = false;
            forma.MinimizeBox = false;
            forma.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area.
            forma.ControlBox = false;
            forma.BackColor = System.Drawing.Color.SkyBlue;
            forma.AutoScroll = true;
        }

        public static void prilagodiFormuPanelu(Form forma, Panel panel)
        {
            forma.TopLevel = false;
            forma.Width = panel.Width;
            forma.Height = panel.Height;
            panel.Controls.Add(forma);
            forma.Show();
        }

        public static void prilagodiVelicinu(Form forma, Panel panel)
        {
            forma.Height = panel.Height;
            forma.Width = panel.Width;
        }
    }
}
