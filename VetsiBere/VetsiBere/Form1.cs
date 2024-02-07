namespace VetsiBere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hra hra = new Hra();
            hra.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vetši bere lmao nebud nula a vyhraj");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nastaveni nastaveni = new Nastaveni();
            nastaveni.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
