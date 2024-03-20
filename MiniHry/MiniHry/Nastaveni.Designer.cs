namespace MiniHry
{
    partial class Nastaveni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            trackBar1 = new TrackBar();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Jméno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 110);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Příjmení ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Životy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 250);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Minihry";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 288);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Kolečka";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(122, 288);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(71, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Písmena";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(228, 288);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(89, 19);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "Porovnávíní";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 37);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 10;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.SmallChange = 10;
            trackBar1.TabIndex = 11;
            trackBar1.Value = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 37);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 12;
            label5.Text = "životy: ";
            // 
            // Nastaveni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 450);
            Controls.Add(label5);
            Controls.Add(trackBar1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Nastaveni";
            Text = "Nastaveni";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private TrackBar trackBar1;
        private Label label5;
    }
}