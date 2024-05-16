using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spojovacka {
    public partial class Editor : Form {
        private List<Circle> points = new List<Circle>();
        private int pointCounter = 1;

        string path = "";

        public Editor() {
            InitializeComponent();

            if (path == "") {
                btnLoad.Visible = false;
            }
        }

        public Editor(string path) : this() {
            this.path = path;

            btnLoad.Visible = true;
        }

        private void DrawPoint(int i, int x, int y) {
            var size = new Size(12, 12);
            var location = new Point(x, y);

            points.Add(new Circle(i, Brushes.Black, size, location));
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                AddPoint(e.Location);
            }
            else if (e.Button == MouseButtons.Right) {
                RemoveNearestPoint(e.Location);
            }
        }

        private void AddPoint(Point location) {
            DrawPoint(pointCounter++, location.X, location.Y);
            //points.Add(new Circle(pointCounter++, location));
            pictureBox1.Invalidate();
        }

        private void RemoveNearestPoint(Point location) {
            if (points.Count == 0) return;

            var nearestPoint = points.OrderBy(p => Distance(p.Location, location)).First();
            points.Remove(nearestPoint);
            pointCounter--;

            // Recalculate point numbers
            for (int i = 0; i < points.Count; i++) {
                points[i].ID = i + 1;
            }

            pictureBox1.Invalidate();
        }

        private double Distance(Point p1, Point p2) {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            var g = e.Graphics;

            foreach (var point in points) {
                point.Draw(g);
                
                //e.Graphics.FillEllipse(Brushes.Black, point.Location.X - (point.Size.Width / 2), point.Location.Y - (point.Size.Height / 2), 12, 12);
                //e.Graphics.DrawString(point.ID.ToString(), new Font("Arial", 11), Brushes.Black, point.Location.X, point.Location.Y - (point.Size.Height * 2));
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (path == "") {
                SavePointsToNewFile();
            } else {
                SavePointsToFile(path);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            LoadPointsFromFile(path);
        }

        private void SavePointsToNewFile() {
            string fileName = Path.GetRandomFileName();

            fileName = fileName.Remove(fileName.Length - 4);

            fileName = fileName + ".txt";

            //string dir = Path.Combine(@"C:\Users\baton\source\repos\Spojovacka\Spojovacka\", fileName);

            string dir = fileName;

            path = dir;

            btnLoad.Visible = true;

            using (StreamWriter sw = File.CreateText(dir)) ;

            SavePointsToFile(dir);
        }

        private void SavePointsToFile(string filePath) {
            using (StreamWriter writer = new StreamWriter(filePath)) {
                foreach (var point in points) {
                    writer.WriteLine($"{point.Location.X},{point.Location.Y}");
                }
            }
        }

        private void LoadPointsFromFile(string filePath) {
            points.Clear();
            pointCounter = 1;
            using (StreamReader reader = new StreamReader(filePath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int x) && int.TryParse(parts[1], out int y)) {
                        DrawPoint(pointCounter++, x, y);
                        //points.Add(new Circle(pointCounter++, new Point(x, y)));
                    }
                }
            }
            pictureBox1.Invalidate();
        }
    }
}
