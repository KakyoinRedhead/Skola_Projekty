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
            MessageBox.Show("Toto je hra pi�kvorky. Hraje se na plo�e XxY. Hr�?i st?�dav? p?id�vaj� kole?ka a k?�ky. Vyhr�v� ten, kdo prvn� spoj� 5 sv�ch symbol? v ?ad?, sloupci nebo diagon�le.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
