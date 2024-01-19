namespace Encounters
{
    partial class characterNotesPage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveNotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(905, 455);
            this.textBox1.TabIndex = 0;
            // 
            // saveNotes
            // 
            this.saveNotes.Location = new System.Drawing.Point(394, 488);
            this.saveNotes.Name = "saveNotes";
            this.saveNotes.Size = new System.Drawing.Size(115, 23);
            this.saveNotes.TabIndex = 1;
            this.saveNotes.Text = "Save Notes";
            this.saveNotes.UseVisualStyleBackColor = true;
            this.saveNotes.Click += new System.EventHandler(this.saveNotes_Click);
            // 
            // characterNotesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 532);
            this.Controls.Add(this.saveNotes);
            this.Controls.Add(this.textBox1);
            this.Name = "characterNotesPage";
            this.Text = "Note Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button saveNotes;
    }
}