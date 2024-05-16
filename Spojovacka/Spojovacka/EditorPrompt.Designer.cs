namespace Spojovacka {
    partial class EditorPrompt {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnNewEditor = new System.Windows.Forms.Button();
            this.btnVybratEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewEditor
            // 
            this.btnNewEditor.Location = new System.Drawing.Point(12, 12);
            this.btnNewEditor.Name = "btnNewEditor";
            this.btnNewEditor.Size = new System.Drawing.Size(140, 60);
            this.btnNewEditor.TabIndex = 0;
            this.btnNewEditor.Text = "Nový Editor";
            this.btnNewEditor.UseVisualStyleBackColor = true;
            this.btnNewEditor.Click += new System.EventHandler(this.btnNewEditor_Click);
            // 
            // btnVybratEditor
            // 
            this.btnVybratEditor.Location = new System.Drawing.Point(12, 81);
            this.btnVybratEditor.Name = "btnVybratEditor";
            this.btnVybratEditor.Size = new System.Drawing.Size(140, 60);
            this.btnVybratEditor.TabIndex = 1;
            this.btnVybratEditor.Text = "Vybrat Editor";
            this.btnVybratEditor.UseVisualStyleBackColor = true;
            this.btnVybratEditor.Click += new System.EventHandler(this.btnVybratEditor_Click);
            // 
            // EditorPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 153);
            this.Controls.Add(this.btnVybratEditor);
            this.Controls.Add(this.btnNewEditor);
            this.Name = "EditorPrompt";
            this.Text = "EditorPrompt";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNewEditor;
        private Button btnVybratEditor;
    }
}