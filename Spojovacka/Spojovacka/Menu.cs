using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spojovacka {
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();
        }

        private void btnGame_Click(object sender, EventArgs e) {
            FormVyberu formVyberu = new FormVyberu("hra");

            Hide();

            formVyberu.ShowDialog();
            
            Show();
        }

        private void btnEditor_Click(object sender, EventArgs e) {
            EditorPrompt editorPrompt = new EditorPrompt();

            Hide();

            editorPrompt.ShowDialog();

            Show();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
