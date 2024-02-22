using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Had_Maturita
{
    public partial class Hra : Form
    {
        public const int VELIKOST_POLICKA = 25;
        public const int VELIKOST_POLE = 20;
        Had had;
        Jablko jablko;
        public Hra()
        {
            InitializeComponent();
            VytvorHada();
            VytvorJablko();
        }

        private void VytvorHada()
        {
            had = new Had();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (had != null)
            {
                had.Vykresli(e.Graphics);
                jablko.Vykresli(e.Graphics);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    had.Hlava.ZmenSmer(0);
                    break;

                case Keys.D:
                case Keys.Right:
                    had.Hlava.ZmenSmer(1);
                    break;

                case Keys.S:
                case Keys.Down:
                    had.Hlava.ZmenSmer(2);
                    break;

                case Keys.A:
                case Keys.Left:
                    had.Hlava.ZmenSmer(3);
                    break;
            }

        }
        public void VytvorJablko()
        {
            Point pozice = new Point(
                Random.Shared.Next(0, VELIKOST_POLE),
                Random.Shared.Next(0, VELIKOST_POLE)
                );
            //Vyřešit jablko na hadovi
            jablko = new Jablko(pozice);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            had.Pohni();
            // Had udela ham ham => je tam jablicko?
            
            //Zkusit  bum bum => je tam stena?

            Refresh();
        }
    }
}
