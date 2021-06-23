using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progtech_Boltkezelo.CharacterCreation;
namespace Progtech_Boltkezelo.EquippingAnItem
{
    class Characters : CharacterBase
    {
        private int price;

        private List<CharacterCreate>list;
        public Characters(List<CharacterCreate> list)
        {
            this.list = list;
            this.price = 500 * this.list.Count();
        }
        public override int getPrice()
        {
            return price;
        }
        public override int getStrength()
        {
            return 10;
        }

        public override int getVitality()
        {
            return 10;
        }

        public override int getLuck()
        {
            return 10;
        }

        public override int getSpeed()
        {
            return 1;
        }

       
    }
}
