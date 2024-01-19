namespace Encounters
{
    partial class Form5
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.turnBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.eventBox = new System.Windows.Forms.TextBox();
            this.characterDataTable = new System.Windows.Forms.DataGridView();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dexBox = new System.Windows.Forms.NumericUpDown();
            this.ACBox = new System.Windows.Forms.NumericUpDown();
            this.currentHealthBox = new System.Windows.Forms.NumericUpDown();
            this.maxHealthBox = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.initiativeBox = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.encounterName = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.tempHealthButton = new System.Windows.Forms.Button();
            this.characterNotesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentHealthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHealthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiativeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 564);
            this.listBox1.TabIndex = 0;
            // 
            // turnBox
            // 
            this.turnBox.BackColor = System.Drawing.SystemColors.Window;
            this.turnBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.turnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.turnBox.Location = new System.Drawing.Point(12, 16);
            this.turnBox.Multiline = true;
            this.turnBox.Name = "turnBox";
            this.turnBox.ReadOnly = true;
            this.turnBox.Size = new System.Drawing.Size(914, 54);
            this.turnBox.TabIndex = 1;
            this.turnBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "End Turn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Attack";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(566, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Heal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(374, 82);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(552, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // eventBox
            // 
            this.eventBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.eventBox.Location = new System.Drawing.Point(374, 166);
            this.eventBox.Multiline = true;
            this.eventBox.Name = "eventBox";
            this.eventBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eventBox.Size = new System.Drawing.Size(552, 480);
            this.eventBox.TabIndex = 6;
            // 
            // characterDataTable
            // 
            this.characterDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.characterDataTable.Location = new System.Drawing.Point(961, 12);
            this.characterDataTable.Name = "characterDataTable";
            this.characterDataTable.Size = new System.Drawing.Size(472, 189);
            this.characterDataTable.TabIndex = 7;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(1026, 290);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(218, 20);
            this.nameBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(984, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(958, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Max Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(944, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Current Health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(998, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "AC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(993, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dex";
            // 
            // dexBox
            // 
            this.dexBox.Location = new System.Drawing.Point(1026, 538);
            this.dexBox.Name = "dexBox";
            this.dexBox.Size = new System.Drawing.Size(120, 20);
            this.dexBox.TabIndex = 14;
            // 
            // ACBox
            // 
            this.ACBox.Location = new System.Drawing.Point(1026, 472);
            this.ACBox.Name = "ACBox";
            this.ACBox.Size = new System.Drawing.Size(120, 20);
            this.ACBox.TabIndex = 15;
            // 
            // currentHealthBox
            // 
            this.currentHealthBox.Location = new System.Drawing.Point(1026, 409);
            this.currentHealthBox.Name = "currentHealthBox";
            this.currentHealthBox.Size = new System.Drawing.Size(120, 20);
            this.currentHealthBox.TabIndex = 16;
            // 
            // maxHealthBox
            // 
            this.maxHealthBox.Location = new System.Drawing.Point(1026, 347);
            this.maxHealthBox.Name = "maxHealthBox";
            this.maxHealthBox.Size = new System.Drawing.Size(120, 20);
            this.maxHealthBox.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(961, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(472, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Input Character Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(973, 604);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Initiative";
            // 
            // initiativeBox
            // 
            this.initiativeBox.Location = new System.Drawing.Point(1026, 602);
            this.initiativeBox.Name = "initiativeBox";
            this.initiativeBox.Size = new System.Drawing.Size(120, 20);
            this.initiativeBox.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1210, 535);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(223, 82);
            this.button5.TabIndex = 21;
            this.button5.Text = "Add to encounter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(503, 716);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Save Encounter";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 680);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Encounter Name";
            // 
            // encounterName
            // 
            this.encounterName.Location = new System.Drawing.Point(503, 677);
            this.encounterName.Name = "encounterName";
            this.encounterName.Size = new System.Drawing.Size(223, 20);
            this.encounterName.TabIndex = 24;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(374, 137);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(284, 23);
            this.button7.TabIndex = 25;
            this.button7.Text = "Go Back";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tempHealthButton
            // 
            this.tempHealthButton.Location = new System.Drawing.Point(758, 108);
            this.tempHealthButton.Name = "tempHealthButton";
            this.tempHealthButton.Size = new System.Drawing.Size(168, 23);
            this.tempHealthButton.TabIndex = 26;
            this.tempHealthButton.Text = "Add Temp Health";
            this.tempHealthButton.UseVisualStyleBackColor = true;
            this.tempHealthButton.Click += new System.EventHandler(this.tempHealthButton_Click);
            // 
            // characterNotesButton
            // 
            this.characterNotesButton.Location = new System.Drawing.Point(12, 652);
            this.characterNotesButton.Name = "characterNotesButton";
            this.characterNotesButton.Size = new System.Drawing.Size(356, 22);
            this.characterNotesButton.TabIndex = 27;
            this.characterNotesButton.Text = "Check Character Notes";
            this.characterNotesButton.UseVisualStyleBackColor = true;
            this.characterNotesButton.Click += new System.EventHandler(this.characterNotesButton_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 751);
            this.Controls.Add(this.characterNotesButton);
            this.Controls.Add(this.tempHealthButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.encounterName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.initiativeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.maxHealthBox);
            this.Controls.Add(this.currentHealthBox);
            this.Controls.Add(this.ACBox);
            this.Controls.Add(this.dexBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.characterDataTable);
            this.Controls.Add(this.eventBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.turnBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form5";
            this.Text = "Encounter Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentHealthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHealthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiativeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox turnBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox eventBox;
        private System.Windows.Forms.DataGridView characterDataTable;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown dexBox;
        private System.Windows.Forms.NumericUpDown ACBox;
        private System.Windows.Forms.NumericUpDown currentHealthBox;
        private System.Windows.Forms.NumericUpDown maxHealthBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown initiativeBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox encounterName;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button tempHealthButton;
        private System.Windows.Forms.Button characterNotesButton;
    }
}