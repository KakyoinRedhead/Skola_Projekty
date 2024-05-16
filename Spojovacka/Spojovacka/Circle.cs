using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spojovacka {
    internal class Circle {
        public Brush Brush { get; set; }
        public Size Size { get; set; }
        public Point Location { get; set; }
        public Rectangle Rectangle { 
            get {
                return new Rectangle(Location, Size);
            }
        }
        public int ID { get; set; }

        public Circle(int id, Brush brush, Size size, Point location) {
            ID = id;
            Brush = brush;
            Size = size;
            Location = location;
        }

        public void Draw(Graphics g) {
            g.DrawString(ID.ToString(), new Font("Arial", 11), Brushes.Black, new Point(Location.X, Location.Y - (Size.Height * 2)));
            g.FillEllipse(Brush, Rectangle);
        }
    }
}
