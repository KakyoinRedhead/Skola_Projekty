﻿using System;
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
        int skoreOdlozenychKostek = 0;
        
        bool prvniHod = true;
        public Hra()
        {
            InitializeComponent();
        }

        public Hra(List<string> seznamJmen) : this()
        {
            foreach (string jmeno in seznamJmen)
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
            for (int i = 0; i < 6; i++)
            {
                Kostka kostka = new Kostka();
                flowLayoutPanel1.Controls.Add(kostka);
                seznamKostek.Add(kostka);
                kostka.OnkostkaLinknuto += Kostka_OnKostkaKliknuto;
            }
        }

        private void Kostka_OnKostkaKliknuto(Kostka kostka)
        {
            // Kostku vyberu

            int skore = ZjistiKombinace(seznamKostek.FindAll(kostka => kostka.JeVybrana));
            label1.Text = $"Skóre: {skore + skoreOdlozenychKostek}";
        }

        private int ZjistiKombinace(List<Kostka> vybraneKostky)
        {
            int skore = 0;
            //použij seznam
            bool postupka = true;
            for(int i = 1; i < 7 ; i++)
            {
               if(seznamKostek.Exists(kostka => kostka.Hodnota == i))
                {
                    postupka = false;
                }
            }
            if(postupka)
            {
                skore = 3000;
                return skore;
            }

            if(vybraneKostky.FindAll(kostka => kostka.Hodnota == 1).Count() == 1)
            {
                skore += 100;
            }
            if (vybraneKostky.FindAll(kostka => kostka.Hodnota == 5).Count() == 1)
            {
                skore += 50;
            }
            if (vybraneKostky.FindAll(kostka => kostka.Hodnota == 1).Count() == 3)
            {
                skore += 1000;
            }
            for (int i = 2; i < 7; i++)
            {
                if (vybraneKostky.FindAll(kostka => kostka.Hodnota == i).Count() == 3)
                {
                    skore += i * 100;
                    
                }
            }

            int pocetDvojic = 0;
            for(int i = 1 ; i < 7; i++)
            {
                if (vybraneKostky.FindAll(kostka => kostka.Hodnota == i).Count() == 2)
                {
                    pocetDvojic++;
                }
            }

            if(pocetDvojic == 3)
            {
                //skore je 1500
                skore += 1500;
            }

            return skore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Kostka> vybraneKostky = seznamKostek.FindAll(kostka => kostka.JeVybrana);
            if(vybraneKostky.Count > 0)
            {
                int skore = ZjistiKombinace(vybraneKostky);
                skoreOdlozenychKostek = skore;
                label1.Text = $"Skore: {skore + skoreOdlozenychKostek}";
                foreach(Kostka kostka in vybraneKostky)
                {
                    kostka.Odloz();
                }
            }
           

            //Vylosuj kostky mimo pouzite

            //Podminka prohry => resetuj kostky

            // odemikat/zamikat tlačitka


            for (int i = 0; i < seznamKostek.Count; i++)
            {
                if (prvniHod)
                {
                    seznamKostek[i].JeOlozena = false;
                }
                if (!seznamKostek[i].JeOlozena)
                seznamKostek[i].Vylosuj();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // pri nejakych vybranych kombinacich zapis a prepnout na dalsiho hrace 
        }
    }
}
