using System;
using System.Collections.Generic;
using System.Text;

namespace Progtech_Character_Manager.CharacterCreation
{
    class CharacterFactory
    {
        public CharacterCreate creatCharacter (String character)
        {
            switch (character)
            {
                case "Magician": return new MagicCharacter();
                case "Warrior": return new WarriorCharacter();
                default: return null;
            }
        }
    }
}
