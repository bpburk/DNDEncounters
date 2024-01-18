namespace Encounters
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.dexBox = new System.Windows.Forms.NumericUpDown();
            this.ACBox = new System.Windows.Forms.NumericUpDown();
            this.currentHealthBox = new System.Windows.Forms.NumericUpDown();
            this.maxHealthBox = new System.Windows.Forms.NumericUpDown();
            this.initiativeBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.characterDataTable = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.encounterList = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dexBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentHealthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHealthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiativeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DEX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Initiative";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max Health";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Current Health";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(85, 42);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(196, 20);
            this.nameBox.TabIndex = 6;
            // 
            // dexBox
            // 
            this.dexBox.Location = new System.Drawing.Point(112, 282);
            this.dexBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.dexBox.Name = "dexBox";
            this.dexBox.Size = new System.Drawing.Size(120, 20);
            this.dexBox.TabIndex = 7;
            // 
            // ACBox
            // 
            this.ACBox.Location = new System.Drawing.Point(112, 342);
            this.ACBox.Name = "ACBox";
            this.ACBox.Size = new System.Drawing.Size(120, 20);
            this.ACBox.TabIndex = 8;
            // 
            // currentHealthBox
            // 
            this.currentHealthBox.Location = new System.Drawing.Point(112, 162);
            this.currentHealthBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.currentHealthBox.Name = "currentHealthBox";
            this.currentHealthBox.Size = new System.Drawing.Size(120, 20);
            this.currentHealthBox.TabIndex = 9;
            // 
            // maxHealthBox
            // 
            this.maxHealthBox.Location = new System.Drawing.Point(112, 102);
            this.maxHealthBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.maxHealthBox.Name = "maxHealthBox";
            this.maxHealthBox.Size = new System.Drawing.Size(120, 20);
            this.maxHealthBox.TabIndex = 10;
            // 
            // initiativeBox
            // 
            this.initiativeBox.Location = new System.Drawing.Point(112, 222);
            this.initiativeBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.initiativeBox.Name = "initiativeBox";
            this.initiativeBox.Size = new System.Drawing.Size(120, 20);
            this.initiativeBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Character to Encounter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // characterDataTable
            // 
            this.characterDataTable.AllowUserToResizeColumns = false;
            this.characterDataTable.AllowUserToResizeRows = false;
            this.characterDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.characterDataTable.Location = new System.Drawing.Point(303, 42);
            this.characterDataTable.Name = "characterDataTable";
            this.characterDataTable.Size = new System.Drawing.Size(248, 366);
            this.characterDataTable.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Input Character Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Save Character Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // encounterList
            // 
            this.encounterList.DataSource = this.encounterList.CustomTabOffsets;
            this.encounterList.FormattingEnabled = true;
            this.encounterList.Location = new System.Drawing.Point(593, 40);
            this.encounterList.Name = "encounterList";
            this.encounterList.Size = new System.Drawing.Size(240, 368);
            this.encounterList.TabIndex = 17;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(593, 414);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(240, 35);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete Character from Encounter";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button5.Location = new System.Drawing.Point(303, 496);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(530, 82);
            this.button5.TabIndex = 19;
            this.button5.Text = "Start Encounter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(303, 455);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(248, 35);
            this.button6.TabIndex = 20;
            this.button6.Text = "Delete Character Data";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 592);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.encounterList);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.characterDataTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.initiativeBox);
            this.Controls.Add(this.maxHealthBox);
            this.Controls.Add(this.currentHealthBox);
            this.Controls.Add(this.ACBox);
            this.Controls.Add(this.dexBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "New Encounter";
            ((System.ComponentModel.ISupportInitialize)(this.dexBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentHealthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHealthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initiativeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.NumericUpDown dexBox;
        private System.Windows.Forms.NumericUpDown ACBox;
        private System.Windows.Forms.NumericUpDown currentHealthBox;
        private System.Windows.Forms.NumericUpDown maxHealthBox;
        private System.Windows.Forms.NumericUpDown initiativeBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView characterDataTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox encounterList;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}