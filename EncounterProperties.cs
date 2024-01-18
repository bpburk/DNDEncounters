using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encounters
{
    public class EncounterProperties
    {
        public List<Characters> CharactersList { get; private set; }
        public int Round { get; private set; }

        public EncounterProperties()
        {
            CharactersList = new List<Characters>();
            Round = 1;

        }

        public void AddCharacter(Characters character)
        {
            CharactersList.Add(character);
        }

        public void RemoveCharacter(Characters character)
        {
            CharactersList.Remove(character);
        }
        public List<Characters> getList()
        {
            return CharactersList;
        }

        public void orderList()
        {
            List<Characters> orderByInitiative = CharactersList.OrderByDescending(p => p.initiative).ToList();
            CharactersList = orderByInitiative;
        }

        public string currentTurn(int count)
        {
            return CharactersList[count].getName();
        }

        public void increaseRound()
        {
            Round++;
        }

        public void decreaseRound()
        {
            Round--;
        }

        public int getRound()
        {
            return Round;
        }
    }
}
