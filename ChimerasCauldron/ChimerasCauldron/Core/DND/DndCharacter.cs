using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChimerasCauldron.Core.DND
{

    internal class DndCharacter
    {

        /*--CLASS LEVEL VARIABLES-----------------------------------------CLASS LEVEL VARIABLES--*/
        private string characterName;
        private int characterLevel;
        private int characterXpAmount;

        private DndClass characterClass;
        private DndBackgroud characterBackground;
        private DndSpecies characterSpecies;

        /*--GETTERS AND SETTERS---------------------------------------------GETTERS AND SETTERS--*/
        public string GetCharacterName()
        {
            if (characterName != null && characterName != string.Empty)
            {
                return this.characterName;
            }
            else
            {
                return "Unnamed Character";
            }
        }

        public void SetCharacterName(string name)
        {
            this.characterName = name;
        }

        public int GetCharacterLevel()
        {
            if (characterLevel != null && characterLevel > 0)
            {
                return this.characterLevel;
            }
            else
            {
                return -1;
            }
        }

        public void SetCharacterLevel(int level)
        {
            this.characterLevel = level;
        }

        public int GetCharacterXpAmount()
        {
            return this.characterXpAmount;
        }

        public void SetCharacterXpAmount(int xpAmount)
        {
            this.characterXpAmount = xpAmount;
        }

    }
}
