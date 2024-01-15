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
        public int initiativeBonus { get; set; }
        public int dex { get; set; }
        public int currentHealth { get; set; }
        public int maxHealth { get; set; }
        public int tempHealth { get; set; }

        public override string ToString()
        {
            return $"{name} - Initiative: {initiative} - Health: {currentHealth} - AC: {AC}";
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
            if (dex < 10)
                initiativeBonus = -1;
            else if (dex < 12)
                initiativeBonus = 0;
            else if (dex < 14)
                initiativeBonus = 1;
            else if (dex < 16)
                initiativeBonus = 2;
            else if (dex < 18)
                initiativeBonus = 3;
            else if (dex < 20)
                initiativeBonus = 4;
            else
                initiativeBonus = 5;
            if(original == 0)
                return random.Next(1, 21) + initiativeBonus;
            else
                return original + initiativeBonus;
            
        }

        public void TakeDamage(int damage)
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

        public void Heal(int amount)
        {
            currentHealth += amount;
            if (currentHealth > maxHealth) currentHealth = maxHealth;
        }

        public String getName()
        {
            return name;
        }
    }
}
