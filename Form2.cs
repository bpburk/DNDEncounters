using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Encounters
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        private static readonly Random random = new Random();
        public DataTable characterTable;
        EncounterProperties encounterProperties = new EncounterProperties();
        Form2 f2;
        private string ID = string.Empty;
        public string notes = string.Empty;

        public Form2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_Load);
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
        }

        private string createUniqueID()
        {
            int a, b, c, d, total, result;
            char letter;
            for(int i = 0; i < 10; i++)
            {
                a = random.Next(20, 100);
                b = random.Next(200, 350);
                c = random.Next(1, 5000);
                d = random.Next(1, 5);

                total = a * b + c;
                
                switch(d)
                {
                    case 1:
                        result = total % 23;
                        letter = (char)('#' + result);
                        ID += letter;
                        break;

                    case 2:
                        result = total % 36;
                        letter = (char)(':' + result);
                        ID += letter;
                        break;
                    case 3:
                        result = total % 30;
                        letter = (char)('a' + result);
                        ID += letter;
                        break;
                    case 4:
                        result = total % 94;
                        letter = (char)('!' + result);
                        ID += letter;
                        break;
                }
            }
            return ID;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            encounterList.DataSource = encounterProperties.getList();
            encounterList.DisplayMember = "Name";

            characterTable = new DataTable("Characters");
            characterTable.Columns.Add("Name", typeof(string));
            characterTable.Columns.Add("Dex", typeof(int));
            characterTable.Columns.Add("AC", typeof(int));
            characterTable.Columns.Add("Max Health", typeof(int));
            characterTable.Columns.Add("Notes", typeof(string));
            characterTable.Columns.Add("ID", typeof(string));
            

            var dataSet = new DataSet();
            dataSet.Tables.Add(characterTable);
            dataSet.ReadXml("characters.xml");
           
            characterDataTable.DataSource = characterTable;

            characterDataTable.Columns[0].Width = 205;
            characterDataTable.Columns["Dex"].Visible = false;
            characterDataTable.Columns["AC"].Visible = false;
            characterDataTable.Columns["Max Health"].Visible = false;
            characterDataTable.Columns["Notes"].Visible = false;
            characterDataTable.Columns["ID"].Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nameBox.Text == "")
            {
                MessageBox.Show("Character must have a name");
            }
            else
            {
                Characters character = new Characters(nameBox.Text, Convert.ToInt32(ACBox.Value), Convert.ToInt32(initiativeBox.Value), Convert.ToInt32(dexBox.Value), Convert.ToInt32(maxHealthBox.Value), Convert.ToInt32(currentHealthBox.Value));
                character.setNotes(notes);
                if(ID != string.Empty)
                {
                    character.setID(ID);
                }
                encounterProperties.AddCharacter(character);
                updateList();
            }
        }

        public void updateList()
        {
            encounterList.DataSource = null;
            encounterList.DataSource = encounterProperties.getList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = characterDataTable.CurrentCell.RowIndex;

            if (index > -1)
            {
                nameBox.Text = characterTable.Rows[index].ItemArray[0].ToString();
                dexBox.Value = Convert.ToDecimal(characterTable.Rows[index].ItemArray[1]);
                initiativeBox.Value = 0;
                ACBox.Value = Convert.ToDecimal(characterTable.Rows[index].ItemArray[2]);
                maxHealthBox.Value = Convert.ToDecimal(characterTable.Rows[index].ItemArray[3]);
                currentHealthBox.Value = Convert.ToDecimal(characterTable.Rows[index].ItemArray[3]);
                notes = characterTable.Rows[index].ItemArray[4].ToString();
                ID = characterTable.Rows[index].ItemArray[5].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
            {
                MessageBox.Show("Character must have a name");
            }
            else
            {

                characterTable.PrimaryKey = new DataColumn[] { characterTable.Columns["ID"] };

                DataRow foundRow = characterTable.Rows.Find(ID);

                if (foundRow != null)
                {
                    foundRow[0] = nameBox.Text;
                    foundRow[1] = dexBox.Value;
                    foundRow[2] = ACBox.Value;
                    foundRow[3] = maxHealthBox.Value;
                    foundRow[4] = notes;
                    characterTable.WriteXml("characters.xml");
                }
                else
                {
                    ID = createUniqueID();
                    characterTable.Rows.Add(nameBox.Text, dexBox.Value, ACBox.Value, maxHealthBox.Value, notes, ID);
                    characterTable.WriteXml("characters.xml");
                } 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            ACBox.Value = 0;
            maxHealthBox.Value = 0;
            currentHealthBox.Value = 0;
            initiativeBox.Value = 0;
            dexBox.Value = 0;
            notes = string.Empty;
            ID = string.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(encounterList.SelectedItems.Count > 0)
            {
                Characters selectedCharacter = (Characters)encounterList.SelectedItem;
                encounterProperties.RemoveCharacter(selectedCharacter);
                updateList();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(encounterProperties.getNumber() < 2)
            {
                MessageBox.Show("Must have 2 characters added to encounter");
            }
            else
            {
                encounterProperties.orderList();
                this.Hide();
                Form5 f5 = new Form5();
                f5.getEncounter(encounterProperties);
                f5.getForm5(f5);
                f5.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index = characterDataTable.CurrentCell.RowIndex;
            characterTable.Rows[index].Delete();
            characterTable.WriteXml("characters.xml");
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void characterNotes_Click(object sender, EventArgs e)
        {
            characterNotesPage notePage = new characterNotesPage();
            notePage.getNotes(notes);
            notePage.getForm2(f2);
            notePage.getCheck(true);
            notePage.Show();
        }

        public void getNotes(string textbox)
        {
            notes = textbox;
        }

        public string getNameBox()
        {
            return nameBox.Text;
        }

        public void getF2(Form2 f2)
        {
            this.f2 = f2;
        }

        public string getID()
        {
            return ID;
        }
    }
}
