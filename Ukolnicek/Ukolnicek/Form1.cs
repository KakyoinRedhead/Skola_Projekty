namespace Ukolnicek
{
    public partial class Form1 : Form
    {
        List<Ukol> seznamUkolu = new List<Ukol>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vytvořit ukol
            Ukol ukol = new Ukol();
            flowLayoutPanel1.Controls.Add(ukol);
            seznamUkolu.Add(ukol);
            string textUkol = textBox1.Text;
            ukol.pridejTextUkolu(textUkol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveCompletedTasks();
        }

        private void RemoveCompletedTasks()
        {
            List<Ukol> completedTasks = new List<Ukol>(seznamUkolu);

            foreach (Ukol task in completedTasks)
            {
                if (task.hotovo)
                {
                    flowLayoutPanel1.Controls.Remove(task);
                    seznamUkolu.Remove(task);
                }
            }
        }
    }
}
