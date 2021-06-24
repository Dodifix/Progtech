using System;
using System.Collections.Generic;
using System.Text;

namespace Progtech_Character_Manager.EquippingAnItem
{
    class ChoosingTheThirdItem : CharacterDecorator
    {
        public override int getLuck()
        {
            return base.getLuck() + random.Next(0, 3);
        }

        public override int getSpeed()
        {
            return base.getSpeed() + random.Next(1, 2);
        }

        public override int getStrength()
        {
            return base.getStrength() + random.Next(1, 3);
        }

        public override int getVitality()
        {
            return base.getVitality() + random.Next(0, 3);
        }

        public override int getPrice()
        {
            return base.getPrice() + 100;
        }
        public ChoosingTheThirdItem(CharacterBase characterBase) : base(characterBase)
        {

        }
    }
}
