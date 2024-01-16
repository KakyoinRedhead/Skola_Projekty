using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukolnicek
{
    public partial class Ukol : UserControl
    {
        public event EventHandler Ukolzmenen;
        public bool hotovo;
        public Ukol()
        {
            InitializeComponent();
        }

        private void Ukol_Click(object sender, EventArgs e)
        {

        }

        public void pridejTextUkolu(string text)
        {
            label1.Text = text;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Font = new Font(label1.Font, FontStyle.Strikeout);
                hotovo = true;
            }
            else
            {
                label1.Font = new Font(label1.Font, FontStyle.Regular);
                hotovo = false;
            }
        }
    }
}

