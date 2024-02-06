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
    public partial class Hra : Form
    {
        Nastaveni nastaveni = new Nastaveni();
        List<Label> seznaamLabelu = new List<Label>();
        public Hra()
        {
            InitializeComponent();
        }

        public void pridejHrace()
        {
            List<string> hraci = nastaveni.GetJmena();
            foreach (string jmeno in hraci)
            {
                Label label1 = new Label();
                label1.Text = jmeno;
                label1.Height = flowLayoutPanel1.Height;
                label1.Width = 50;
                flowLayoutPanel1.Controls.Add(label1);
                hraci.Add(label1);
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void StartHry()
        {
            
          
        }
    }
}
