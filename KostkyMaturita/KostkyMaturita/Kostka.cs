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

        private bool jeOdlozena;

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
        }

        private void Kostka_MouseClick(object sender, MouseEventArgs e)
        {
            OnkostkaLinknuto?.Invoke(this);
        }

        public void Vylosuj()
        {
            Hodnota = Random.Shared.Next(1, 7);
        }
    }
}
