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
    public partial class Form5 : System.Windows.Forms.Form
    {
        public DataTable characterTable;
        DataTable encounterTable;
        EncounterProperties encounterProperties;
        int count = 0;
        Form5 f5;
        string notes = string.Empty;
        private string ID = string.Empty;

        public Form5()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form5_Load);
            this.FormClosing += new FormClosingEventHandler(Form5_FormClosing);
        }

        public void getEncounter(EncounterProperties encounter)
        {
            encounterProperties = encounter;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            characterTable = new DataTable("Characters");
            characterTable.Columns.Add("Name", typeof(string));
            characterTable.Columns.Add("Dex", typeof(int));
            characterTable.Columns.Add("AC", typeof(int));
            characterTable.Columns.Add("Max Health", typeof(int));
            characterTable.Columns.Add("Notes", typeof(string));
            characterTable.Columns.Add("ID", typeof(string));

            encounterTable = new DataTable("Encounters");
            encounterTable.Columns.Add("Date", typeof(string));
            encounterTable.Columns.Add("Encounter History", typeof(string));

            var dataSet = new DataSet();
            dataSet.Tables.Add(characterTable);
            dataSet.ReadXml("characters.xml");

            var encounterSet = new DataSet();
            encounterSet.Tables.Add(encounterTable);
            encounterSet.ReadXml("encounterHistory.xml");
            

            characterDataTable.DataSource = characterTable;

            characterDataTable.Columns["Dex"].Visible = false;
            characterDataTable.Columns["AC"].Visible = false;
            characterDataTable.Columns["Max Health"].Visible = false;
            characterDataTable.Columns["Notes"].Visible = false;
            characterDataTable.Columns["ID"].Visible = false;
            listBox1.DataSource = encounterProperties.getList();
            textChange();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (++count == encounterProperties.CharactersList.Count())
            {
                count = 0;
                encounterProperties.increaseRound();
            }
                
            textChange();
        }

        private void textChange()
        {
            turnBox.Text = $"It is {encounterProperties.currentTurn(count)}'s turn";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                Characters selectedCharacter = (Characters)listBox1.SelectedItem;
                if(Convert.ToInt32(numericUpDown1.Value) == 0)
                    eventBox.Text += $"Round: {encounterProperties.getRound()}: {encounterProperties.CharactersList[count].getName()} missed their attack on {selectedCharacter.getName()}.";
                else
                {
                    encounterProperties.CharactersList[count].encounterDamage(Convert.ToInt32(numericUpDown1.Value));
                    selectedCharacter.takeDamage(Convert.ToInt32(numericUpDown1.Value));
                    eventBox.Text += $"Round: {encounterProperties.getRound()}: {encounterProperties.CharactersList[count].getName()} attacked {selectedCharacter.getName()} for " +
                        $"{Convert.ToInt32(numericUpDown1.Value)} points. Their HP is now {selectedCharacter.currentHealth}.";
                }
                eventBox.AppendText(Environment.NewLine);
                updateList();
                textChange();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                Characters selectedCharacter = (Characters)listBox1.SelectedItem;
                if (selectedCharacter == encounterProperties.CharactersList[count])
                {
                    selectedCharacter.Heal(Convert.ToInt32(numericUpDown1.Value));
                    eventBox.Text += $"Round: {encounterProperties.getRound()}: {encounterProperties.CharactersList[count].getName()} healed themselves for " +
                        $"{Convert.ToInt32(numericUpDown1.Value)} points. Their HP is now {selectedCharacter.currentHealth}.";
                }
                else
                {
                    selectedCharacter.Heal(Convert.ToInt32(numericUpDown1.Value));
                    eventBox.Text += $"Round: {encounterProperties.getRound()}: {encounterProperties.CharactersList[count].getName()} healed {selectedCharacter.getName()} for " +
                        $"{Convert.ToInt32(numericUpDown1.Value)} points. Their HP is now {selectedCharacter.currentHealth}.";
                }
                eventBox.AppendText(Environment.NewLine);
                updateList();
                textChange();
            }
        }

        public void getForm5(Form5 f5)
        {
            this.f5 = f5;
        }

        public void updateList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = encounterProperties.getList();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Characters character = new Characters(nameBox.Text, Convert.ToInt32(ACBox.Value), Convert.ToInt32(initiativeBox.Value), Convert.ToInt32(dexBox.Value), Convert.ToInt32(maxHealthBox.Value), Convert.ToInt32(currentHealthBox.Value));
            character.setNotes(notes);
            notes = string.Empty;
            if (character.initiative > encounterProperties.CharactersList[count].initiative)
                count++;
            eventBox.Text += $"Round {encounterProperties.getRound()}: {character.getName()} has been added to the encounter. Initiative: {character.initiative}";
            eventBox.AppendText(Environment.NewLine);
            encounterProperties.AddCharacter(character);
            encounterProperties.orderList();
            updateList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!(encounterName.Text == ""))
            {
                encounterTable.Rows.Add($"{encounterName.Text} " + DateTime.Now.ToString(), eventBox.Text + encounterProperties.getDamageList());
                encounterTable.WriteXml("encounterHistory.xml");
                MessageBox.Show("Encounter has been saved successfully");
            }
            else
            {
                MessageBox.Show("Encounter must have a name.");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (--count < 0)
            {
                count = encounterProperties.CharactersList.Count() - 1;
                encounterProperties.decreaseRound();
            }

            textChange();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tempHealthButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0 && Convert.ToInt32(numericUpDown1.Value) > 0)
            {
                Characters selectedCharacter = (Characters)listBox1.SelectedItem;
                selectedCharacter.setTempHealth(Convert.ToInt32(numericUpDown1.Value));
                eventBox.Text += $"Round: {encounterProperties.getRound()}: {encounterProperties.CharactersList[count].getName()} gave {selectedCharacter.getName()} " +
                       $"{Convert.ToInt32(numericUpDown1.Value)} temporary hit points. Their HP is now {selectedCharacter.currentHealth + selectedCharacter.tempHealth}.";
                eventBox.AppendText(Environment.NewLine);
                updateList();
            }    
        }

        private void characterNotesButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                Characters selectedCharacter = (Characters)listBox1.SelectedItem;
                characterNotesPage characterNotes = new characterNotesPage();
                characterNotes.getNotes(selectedCharacter.getNotes());
                characterNotes.getCharacter(selectedCharacter);
                characterNotes.getForm5(f5);
                characterNotes.Show();
            }
        }

        public string getID()
        {
            return ID;
        }

        private void button8_Click(object sender, EventArgs e)
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
    }
}
