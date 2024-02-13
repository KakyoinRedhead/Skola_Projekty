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
    public partial class Karta : UserControl
    {
        public int Hodnota {  get; set; }
        public Image Image { get => _image; set { this.BackgroundImage = value; _image = value; } }
        private Image _image;
        public string CardType { get; set; }
        public Karta()
        {
            InitializeComponent();
        }

        public Dictionary<string, int> cardHodnota = new Dictionary<string, int>()
        {
            {"spodek", 4},
            {"svrsek", 5},
            {"kral", 6},
            {"7", 7},
            {"8", 8},
            {"9", 9},
            {"10", 10},
            {"eso", 11}
        };

        public void PridejHodnotu(string cardName)
        {
            string hodnota = cardName.Replace(".png", "").Split("_")[1];
            CardType = cardName.Replace(".png", "").Split("_")[0].Replace("./cards\\", "");
            Hodnota = cardHodnota[hodnota];
            label1.Text = $"{CardType} [{hodnota}]";
        }


    }
}
