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
        GlobalVariables globalVariables;
        EncounterProperties encounter;
        Form5 form5;
        Characters character;
        bool check = false;

        public characterNotesPage()
        {
            InitializeComponent();
            
        }

        private void saveNotes_Click(object sender, EventArgs e)
        {
            if (check)
            {
                GlobalVariables.notes = textBox1.Text;
            }
            else
            {
                character.setNotes(textBox1.Text);
                saveToDataTable(textBox1.Text);
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
        
        public void getEncounterProperties(EncounterProperties encounter)
        {
            this.encounter = encounter;
        }

        public void getForm(Form5 form)
        {
            this.form5 = form;
        }

        public void getCharacter(Characters character)
        {
            this.character = character;
        }

        private void saveToDataTable(string notes)
        {
         
            form5.characterTable.PrimaryKey = new DataColumn[] { form5.characterTable.Columns["Name"] };

            DataRow foundRow = form5.characterTable.Rows.Find(character.getName());

            if (foundRow != null)
            {
                foundRow[4] = notes;
                form5.characterTable.WriteXml("characters.xml");
            }
        }
    }
}
