namespace KostkyMaturita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> seznamJmen = new List<string>();
            foreach (Control prvek in flowLayoutPanel1.Controls)
            {
                seznamJmen.Add(prvek.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.PlaceholderText = "Jmeno hra?e....";
            flowLayoutPanel1.Controls.Add(textBox);
        }
    }
}
