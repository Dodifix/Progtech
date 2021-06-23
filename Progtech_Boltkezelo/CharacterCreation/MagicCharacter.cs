using System;
using System.Collections.Generic;
using System.Text;

namespace Progtech_Boltkezelo.CharacterCreation
{
    class MagicCharacter : CharacterCreate
    {
        protected override void Choose()
        {
            Console.WriteLine("I choose the magician character.");
        }
        protected override void Create()
        {
            Console.WriteLine("I create the magician character.");
        }
    }
}
