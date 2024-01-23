using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KostkyMaturita
{
    public partial class Hra : Form
    {
        List<Label> seznamLabelu = new List<Label>();
        List<Kostka> seznamKostek = new List<Kostka>();
        public Hra()
        {
            InitializeComponent();
        }

        public Hra(List<string> seznamJmen) : this()
        {
            foreach(string jmeno in seznamJmen)
            {
                Label label1 = new Label();
                label1.Text = jmeno;
                label1.Height = flowLayoutPanel2.Height;
                label1.Width = 50;
                flowLayoutPanel2.Controls.Add(label1);
                seznamLabelu.Add(label1);
            }

            VytvorKostky();
        }

        private void VytvorKostky()
        {
            for (int i = 0; i < 6 ; i++)
            {
                Kostka kostka = new Kostka();
                flowLayoutPanel1.Controls.Add(kostka);
                seznamKostek.Add(kostka);
                kostka.Vylosuj();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < seznamKostek.Count; i++)
            {
                seznamKostek[i].Vylosuj();
            }
        }
    }
}
