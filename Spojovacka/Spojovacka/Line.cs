using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spojovacka {
    internal class Line {
        public Pen Pen { get; set; }
        public Point StartingLocation { get; set; }
        public Point EndingLocation { get; set; }

        public Line(Pen pen, Point startingLocation, Point endingLocation) {
            Pen = pen;
            StartingLocation = startingLocation;
            EndingLocation = endingLocation;
        }

        public void Draw(Graphics g) {
            g.DrawLine(Pen, StartingLocation, EndingLocation);
        }
    }
}
