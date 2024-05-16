namespace Piskvorky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            Hra hra = new Hra();
            hra.ShowDialog();

            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            Nastaveni nastaveni = new Nastaveni();
            nastaveni.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toto je hra piškvorky. Hraje se na ploše XxY. Hrá?i st?ídav? p?idávají kole?ka a k?ížky. Vyhrává ten, kdo první spojí 5 svých symbol? v ?ad?, sloupci nebo diagonále.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
