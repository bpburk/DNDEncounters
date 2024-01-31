using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encounters
{
    public partial class characterNotesPage : System.Windows.Forms.Form
    {
        Form5 form5 = null;
        Form2 form2 = null;
        Characters character;
        bool check = false;

        public characterNotesPage()
        {
            InitializeComponent();
            textBox1.Enter += new EventHandler(textBox1_Enter);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void saveNotes_Click(object sender, EventArgs e)
        {
            if (check)
            {
                saveToForm2DataTable(textBox1.Text);
                form2.notes = textBox1.Text;
            }
            else
            {
                character.setNotes(textBox1.Text);
                saveToForm5DataTable(textBox1.Text);
                form5.updateList();
            }
        }

        public void getNotes(string notes)
        {
            textBox1.Text = notes;
        }

        public void getCheck(bool check)
        {
            this.check = check;
        }
        
        public void getForm5(Form5 form)
        {
            this.form5 = form;
        }

        public void getForm2(Form2 form)
        {
            this.form2 = form;
        }

        public void getCharacter(Characters character)
        {
            this.character = character;
        }

        private void saveToForm5DataTable(string notes)
        {
         
            form5.characterTable.PrimaryKey = new DataColumn[] { form5.characterTable.Columns["ID"] };

            DataRow foundRow = form5.characterTable.Rows.Find(character.getID());

            if (foundRow != null)
            {
                foundRow[4] = notes;
                form5.characterTable.WriteXml("characters.xml");
            }
        }

        private void saveToForm2DataTable(string notes)
        {

            form2.characterTable.PrimaryKey = new DataColumn[] { form2.characterTable.Columns["ID"] };

            DataRow foundRow = form2.characterTable.Rows.Find(form2.getID());

            if (foundRow != null)
            {
                foundRow[4] = notes;
                form2.characterTable.WriteXml("characters.xml");
            }            
        }
    }
}
