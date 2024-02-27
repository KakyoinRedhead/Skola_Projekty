namespace Kalkulacka
{
    public partial class Form1 : Form
    {
        decimal? ANS = null;
        public string Priklad
        {
            get => textBox1.Text;
            set
            {
                textBox1.Text = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            PridejOperator('+');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Priklad += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Priklad += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Priklad += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Priklad += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Priklad += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Priklad += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Priklad += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Priklad += "9";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Priklad += "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            PridejOperator('-');
        }

        private void button22_Click(object sender, EventArgs e)
        {
            PridejOperator('*');
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Priklad += "(";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Priklad += ")";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PridejOperator('/');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Priklad.EndsWith(".") || !char.IsDigit(Priklad.Last()))
                return;


            Priklad += ".";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Rovnase button
        }

        public void PridejOperator(char operace)
        {
            char posledniPismeno = Priklad.Last();
            char[] posledniOperator = new char[] { '+', '-', '*', '/' };

            if (posledniOperator.Contains(posledniPismeno))
            {
                Priklad = Priklad.Remove(Priklad.Length - 1);
            }
            Priklad += operace;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //znamenkovac
            char pismeno;
            for(int i = Priklad.Length -1; i >= 0; i--)
            {
                pismeno = Priklad[i];
                if (!char.IsDigit(pismeno) && pismeno != ')')
                {
                    if(pismeno == '-')
                    {
                        Priklad = Priklad.Substring(i);
                    }
                    else
                    {
                        Priklad = Priklad.Insert(i + 1, "(-") + ")";
                    }
                    
                    break;
                }
            }
        }
    }
}
