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
    public partial class FormVyberu : Form {
        string jeProEditor = "";

        public FormVyberu(string value) {
            InitializeComponent();

            jeProEditor = value;

            GetFilesFromDirectory();
        }

        private void GetFilesFromDirectory() {
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Users\fnaf9\OneDrive\Dokumenty\GitHub\Skola_Projekty\Spojovacka\Spojovacka\bin\Debug\net6.0-windows");

            FileInfo[] Files = dinfo.GetFiles("*.txt");

            foreach(FileInfo file in Files) {
                if (jeProEditor == "editor") {
                    flowLayoutPanel1.Controls.Add(new SouborButtonProEditor(file.Name, this));
                } else if (jeProEditor == "hra") {
                    flowLayoutPanel1.Controls.Add(new SouborButton(file.Name, this));
                }
            }
        }
    }
}
