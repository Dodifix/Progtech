using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progtech_Boltkezelo.EquippingAnItem
{
    
    class CharacterDecorator : CharacterBase
    {
        private CharacterBase characterBase;
        public override int getLuck()
        {
            return characterBase.getLuck();
        }

        public override int getSpeed()
        {
            return characterBase.getSpeed();
        }

        public override int getStrength()
        {
            return characterBase.getStrength();
        }

        public override int getVitality()
        {
            return characterBase.getVitality();
        }

        public override int getPrice()
        {
            return characterBase.getPrice();
        }

        public CharacterDecorator(CharacterBase characterBase)
        {
            this.characterBase = characterBase;
        }
    }
}
