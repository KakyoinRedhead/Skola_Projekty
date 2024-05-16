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
    public partial class Nastaveni : Form
    {
        public int Vyska;
        public int Sirka;
        
        
        public Nastaveni()
        {
            InitializeComponent();
        }


        public Nastaveni(int vyska, int sirka) : this()
        {
            this.Vyska = vyska;
            this.Sirka = sirka;
            getSirka();
            getVyska();
        }



        public int getVyska()
        {
            return Vyska = Convert.ToInt32(numericUpDown1.Value);
        }

        public int getSirka()
        {
            return Sirka = Convert.ToInt32(numericUpDown2.Value);
        }

        public static int V_Uloz, S_Uloz;
    
        private void button1_Click(object sender, EventArgs e)
        {
            V_Uloz = getVyska();
            S_Uloz = getSirka();
            this.Close();
        }
    }
}
