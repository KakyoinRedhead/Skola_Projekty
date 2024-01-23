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
                BackgroundImage = Image.FromFile($"{hodnota}.jpg");
            }
        } 

        public Kostka()
        {
            InitializeComponent();
        }

        private void Kostka_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
