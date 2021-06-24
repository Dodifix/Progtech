using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progtech_Character_Manager.EquippingAnItem
{
    class ChoosingTheFirstItem : CharacterDecorator
    {
        public override int getLuck()
        {
            return base.getLuck() + random.Next(1,3);
        }

        public override int getSpeed()
        {
            return base.getSpeed() + random.Next(0,1);
        }

        public override int getStrength()
        {
            return base.getStrength() + random.Next(0,5);
        }

        public override int getVitality()
        {
            return base.getVitality() + random.Next(2,4);
        }
        public override int getPrice()
        {
            return base.getPrice() + 300;
        }

        public ChoosingTheFirstItem(CharacterBase characterBase) : base(characterBase)
        {
            
        }
    }
}
