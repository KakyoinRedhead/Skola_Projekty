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
    public partial class Kostka : UserControl
    {
        private int hodnota;

        private bool jeOdlozena = true;

        private bool jeVybrana;

        public bool JeVybrana1 
        {
            get => jeVybrana;
            set
            {
                jeVybrana = value;
                panel1.BackColor = jeVybrana ? Color.FromArgb(128,128,0,128) : Color .Transparent;
            }
        }
        public bool JeOlozena
        {
            get => jeOdlozena;
            set
            {
                jeOdlozena = value;
                panel1.BackColor = jeOdlozena ? Color.FromArgb(128, 28, 0, 28) : Color.Transparent;
            }
        }

        public int Hodnota
        {
            get => hodnota;
            set
            {
                hodnota = value;
                BackgroundImage = Image.FromFile($"{hodnota}.png");
            }
        } 

        public event Action<Kostka> OnkostkaLinknuto;

        public Kostka()
        {
            InitializeComponent();
            panel1.BackColor = Color.Transparent;
        }

        private void Kostka_MouseClick(object sender, MouseEventArgs e)
        {
            if (jeOdlozena)
                return;

            OnkostkaLinknuto?.Invoke(this);

            jeVybrana = !jeVybrana;
            
        }

        public void Vylosuj()
        {
            Hodnota = Random.Shared.Next(1, 7);
        }
    }
}
