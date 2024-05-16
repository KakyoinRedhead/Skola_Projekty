namespace Spojovacka {
    public partial class Form1 : Form {
        List<Circle> points = new List<Circle>();
        List<int> pointIDs = new List<int>();
        List<int> remainingPointIDs = new List<int>();
        List<Line> lines = new List<Line>();

        Point firstLinePoint = Point.Empty;
        Point lastLinePoint = Point.Empty;

        public Form1(string path) {
            InitializeComponent();

            string[] linesFromFile = File.ReadAllLines(path);
            // string[] linesFromFile = File.ReadAllLines(@"C:\Users\baton\source\repos\Spojovacka\Spojovacka\Points.txt");

            for (int i = 0; i < linesFromFile.Length; i++) {
                string[] coordinates = linesFromFile[i].Split(",");
                if (coordinates.Length != 2) {
                    continue;
                }

                int x, y;
                if (!int.TryParse(coordinates[0], out x) || !int.TryParse(coordinates[1], out y)) {
                    continue;
                }

                DrawCircle(i + 1, x, y);
                pointIDs.Add(i + 1);
                remainingPointIDs.Add(i + 1);
            }
        }

        private void DrawCircle(int i, int x, int y) {
            var size = new Size(12, 12);
            var location = new Point(x, y);

            points.Add(new Circle(i, Brushes.Black, size, location));
        }

        private void pCanvas_Paint(object sender, PaintEventArgs e) {
            var g = e.Graphics;

            foreach(var p in points) {
                p.Draw(g);
            }

            foreach(var l in lines) {
                l.Draw(g);
            }
        }

        private void pCanvas_MouseClick(object sender, MouseEventArgs e) {
            CheckBodyLocation(e);
        }

        private void CheckBodyLocation(MouseEventArgs e) {
            foreach (var p in points) {
                if (p.Rectangle.Contains(e.Location)) {
                    if (firstLinePoint == Point.Empty && remainingPointIDs.First() == p.ID) {
                        remainingPointIDs.Remove(p.ID);
                        firstLinePoint = p.Location + (p.Size / 2);
                    }
                    else if (pointIDs.First() == p.ID) {
                        lastLinePoint = p.Location + (p.Size / 2);

                        lines.Add(new Line(new Pen(Brushes.Black, 4), firstLinePoint, lastLinePoint));

                        firstLinePoint = lastLinePoint;
                    }
                    else if (remainingPointIDs.Count > 0 && remainingPointIDs.First() == p.ID) {
                        remainingPointIDs.Remove(p.ID);
                        lastLinePoint = p.Location + (p.Size / 2);

                        lines.Add(new Line(new Pen(Brushes.Black, 4), firstLinePoint, lastLinePoint));

                        firstLinePoint = lastLinePoint;
                    }
                    break;
                }
            }

            pCanvas.Refresh();
        }
    }
}