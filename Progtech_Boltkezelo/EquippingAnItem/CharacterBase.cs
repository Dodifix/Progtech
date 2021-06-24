using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progtech_Character_Manager.EquippingAnItem
{
    abstract class CharacterBase //Alap karakter
    {
        public Random random = new Random();
        public abstract int getStrength();
        public abstract int getVitality();
        public abstract int getLuck();
        public abstract int getSpeed();

        public abstract int getPrice();

    }
}
