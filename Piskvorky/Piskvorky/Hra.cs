using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piskvorky
{   
    public partial class Hra : Form
    {
        public bool ZacinaPrvni = true;
        Policko[,] herniPole;
        public Hra()
        {
            InitializeComponent();
            VytvorHerniPole();

           
        }

        public void ZjistiVyhru()
        {

        }


        public void JePolePlne()
        {
            if (herniPole != null)
            {
                bool plny = herniPole.Cast<Policko>().All(policko => policko.Barva != null && policko.Barva);
                if (!plny)
                {
                    MessageBox.Show("Remiza");

                }
                else
                {
                    MessageBox.Show("Vyhral jsi");
                }

            }

        }


        public void HerniPoleKliknuto(Policko policko)
        {
            if (ZacinaPrvni)
            {
                policko.CervenaBarva();
                ZacinaPrvni = false;
            }
            else
            {
                policko.ModraBarva();
                ZacinaPrvni = true;
            }
            ZjistiVyhru();
            JePolePlne();


        }

        public void VytvorHerniPole()
        {
             
            Nastaveni nastaveni = new Nastaveni();
            if(Nastaveni.V_Uloz != 0 && Nastaveni.S_Uloz != 0){
            herniPole = new Policko[Nastaveni.V_Uloz, Nastaveni.S_Uloz];
            } else{herniPole = new Policko[5,5];}
            Policko policko;

            for (int i = 0; i < herniPole.GetLength(0); i++)
            {
                for (int j = 0; j < herniPole.GetLength(1); j++)
                {
                    policko = new Policko(j, i);
                    policko.Location = new Point(j * policko.Height, i * policko.Width);
                    panel1.Controls.Add(policko);
                    policko.OnPolickoKliknuto += HerniPoleKliknuto;
                }
            }
          
            
        }
    }
}
