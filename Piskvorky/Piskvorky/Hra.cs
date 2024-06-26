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
          foreach(Policko policko in herniPole)
            {
                if (policko.Barva == false)
                {
                    return;
                }
            }
            MessageBox.Show("Pole je plne");    

        }


        public void HerniPoleKliknuto(Policko policko)
        {
            if(!policko.Barva)
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
            }
         
            ZjistiVyhru();
            JePolePlne();

            return;
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
                    herniPole[j, i] = policko;  
                    policko.OnPolickoKliknuto += HerniPoleKliknuto;
                }
            }
          
            
        }
    }
}
