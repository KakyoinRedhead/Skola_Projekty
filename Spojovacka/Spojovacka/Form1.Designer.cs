﻿namespace Spojovacka {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pCanvas
            // 
            this.pCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCanvas.Location = new System.Drawing.Point(12, 12);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(776, 426);
            this.pCanvas.TabIndex = 0;
            this.pCanvas.TabStop = false;
            this.pCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas_Paint);
            this.pCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pCanvas_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pCanvas;
    }
}