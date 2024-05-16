namespace MiniHry
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
            hra.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nastaveni nastaveni = new Nastaveni();
            nastaveni.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
