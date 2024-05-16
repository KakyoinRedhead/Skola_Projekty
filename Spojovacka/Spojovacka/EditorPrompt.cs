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
    public partial class EditorPrompt : Form {
        public EditorPrompt() {
            InitializeComponent();
        }

        private void btnNewEditor_Click(object sender, EventArgs e) {
            Editor editor = new Editor();

            this.Hide();

            editor.ShowDialog();

            this.Show();
        }

        private void btnVybratEditor_Click(object sender, EventArgs e) {
            FormVyberu formVyberu = new FormVyberu("editor");

            this.Hide();

            formVyberu.ShowDialog();

            this.Show();
        }
    }
}
