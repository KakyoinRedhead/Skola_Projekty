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
    public partial class Nastaveni : Form
    {
       public static List<string> seznamHracu = new List<string>();

        public Nastaveni()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(seznamHracu.Count > 32)
            {
                MessageBox.Show("Moc hracu");
                return;
            }
            TextBox textBox = new TextBox();
            textBox.PlaceholderText = "Jméno hráče.....";
            flowLayoutPanel1.Controls.Add(textBox);
                seznamHracu.Add(textBox.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        public List<string> GetJmena()
        {
            return seznamHracu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }
    }
}
