using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetsiBere
{
    public partial class Nastaveni : Form
    {
        List<string> seznamHracu = new List<string>();

        public Nastaveni()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.PlaceholderText = "Jméno hráče.....";
            flowLayoutPanel1.Controls.Add(textBox);
            foreach (Control prvek in flowLayoutPanel1.Controls)
            {
                seznamHracu.Add(prvek.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        public List<string> GetJmena()
        {
            return seznamHracu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
