namespace Clicker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneTrackBar1 = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.siticoneTrackBar2 = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left click CPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(250)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(331, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "10";
            // 
            // siticoneTrackBar1
            // 
            this.siticoneTrackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.siticoneTrackBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.siticoneTrackBar1.Location = new System.Drawing.Point(12, 41);
            this.siticoneTrackBar1.Maximum = 20;
            this.siticoneTrackBar1.Minimum = 6;
            this.siticoneTrackBar1.Name = "siticoneTrackBar1";
            this.siticoneTrackBar1.Size = new System.Drawing.Size(300, 23);
            this.siticoneTrackBar1.TabIndex = 2;
            this.siticoneTrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.siticoneTrackBar1.Value = 20;
            this.siticoneTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneTrackBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.LawnGreen;
            this.siticoneButton1.Location = new System.Drawing.Point(231, 3);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(81, 32);
            this.siticoneButton1.TabIndex = 3;
            this.siticoneButton1.Text = "Enable";
            this.siticoneButton1.TextChanged += new System.EventHandler(this.siticoneButton1_TextChanged);
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Interval = 150;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // siticoneTrackBar2
            // 
            this.siticoneTrackBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.siticoneTrackBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.siticoneTrackBar2.Location = new System.Drawing.Point(92, 226);
            this.siticoneTrackBar2.Maximum = 30;
            this.siticoneTrackBar2.Name = "siticoneTrackBar2";
            this.siticoneTrackBar2.Size = new System.Drawing.Size(300, 23);
            this.siticoneTrackBar2.TabIndex = 4;
            this.siticoneTrackBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.siticoneTrackBar2.Value = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.siticoneTrackBar2);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.siticoneTrackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar siticoneTrackBar1;
        private System.Windows.Forms.Timer timer1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Timer Random;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar siticoneTrackBar2;
    }
}

