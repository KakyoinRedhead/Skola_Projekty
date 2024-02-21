using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Had_Maturita
{
    internal class Jablko
    {
        private Point pozice;

        public Point Pozice => pozice;

        public Jablko(Point pozice)
        {
            this.pozice = pozice;
        }

        public void Vykresli(Graphics g)
        {
            g.FillEllipse(Brushes.Red,
                pozice.X * Hra.VELIKOST_POLICKA,
                pozice.Y * Hra.VELIKOST_POLICKA,
                Hra.VELIKOST_POLICKA,
                Hra.VELIKOST_POLICKA);
        }
    }
}
