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
    public partial class SouborButtonProEditor : UserControl {
        string fileName = "";
        string path = "";
        Form form;

        public SouborButtonProEditor(string fileName, Form form) {
            InitializeComponent();

            //path = @"C:\Users\baton\source\repos\Spojovacka\Spojovacka\" + fileName;

            path = fileName;

            fileName = fileName.Remove(fileName.Length - 4);

            label1.Text = fileName;

            this.form = form;

            this.fileName = fileName;
        }

        private void label1_Click(object sender, EventArgs e) {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left) {
                Editor editor = new Editor(path);

                form.Hide();

                editor.ShowDialog();

                form.Show();
            } else if (me.Button == MouseButtons.Right) {
                label1.Visible = false;

                button1.Visible = true;
                textBox1.Visible = true;

                textBox1.Text = fileName;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            label1.Visible = true;

            button1.Visible = false;
            textBox1.Visible = false;

            File.Move(fileName + ".txt", textBox1.Text + ".txt");

            fileName = textBox1.Text;

            label1.Text = fileName;

            path = fileName + ".txt";
        }
    }
}
