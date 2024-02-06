namespace VetsiBere
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
            button1 = new Button();
            button3 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.None;
            button1.BackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 12);
            button1.Name = "button1";
            button1.Size = new Size(108, 35);
            button1.TabIndex = 0;
            button1.Text = "Přidat Hráče";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(127, 12);
            button3.Name = "button3";
            button3.Size = new Size(125, 35);
            button3.TabIndex = 2;
            button3.Text = "Smazat Hráče";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(230, 212);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 288);
            button2.Name = "button2";
            button2.Size = new Size(230, 46);
            button2.TabIndex = 4;
            button2.Text = "Zpět";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Nastaveni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 346);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Nastaveni";
            Text = "Nastaveni";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
    }
}