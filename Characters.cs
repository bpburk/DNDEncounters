using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Encounters
{
     public class Characters
    {
        private static readonly Random random = new Random();
        public String name { get; set; }
        public int AC { get; set; }
        public int initiative { get; set; }
        public int dex { get; set; }
        public int currentHealth { get; set; }
        public int maxHealth { get; set; }
        public int tempHealth { get; set; }
        private string characterNotes { get; set; }
        public int damageDone { get; set; } = 0;
        private string ID { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{name} - Initiative: {initiative} - Health: {currentHealth} + {tempHealth} - AC: {AC}";
        }
            public Characters(string name, int aC, int initiative,  int dex, int maxHealth, int currentHealth)
        {
            this.name = name;
            this.AC = aC;
            this.dex = dex;
            this.initiative = setInitiative(initiative);
            if (currentHealth == 0)
                this.currentHealth = maxHealth;
            else
                this.currentHealth = currentHealth;
            this.maxHealth = maxHealth;
            tempHealth = 0;
        }

        public int setInitiative(int original)
        {
            
            if(original == 0)
                return random.Next(1, 21) + dex;
            else
                return original + dex;
            
        }

        public void takeDamage(int damage)
        {
            // Subtract damage from temp health first, if any
            int effectiveDamage = damage - tempHealth;
            tempHealth -= damage;
            if (tempHealth < 0) tempHealth = 0;

            // Apply remaining damage to current health
            if (effectiveDamage > 0)
            {
                currentHealth -= effectiveDamage;
                if (currentHealth < 0) currentHealth = 0;
            }
        }

        public void setTempHealth(int amount)
        {
            tempHealth = amount;
        }

        public void Heal(int amount)
        {
            currentHealth += amount;
            if (currentHealth > maxHealth) currentHealth = maxHealth + tempHealth;
        }

        public String getName()
        {
            return name;
        }

        public void setNotes(string notes)
        {
            characterNotes = notes;
        }

        public string getNotes()
        {
            return characterNotes;
        }

        public void encounterDamage(int damage)
        {
            damageDone += damage;
        }
        public void setID(string ID)
        {
            this.ID = ID;
        }

        public string getID()
        {
            return ID;
        }
}
}
