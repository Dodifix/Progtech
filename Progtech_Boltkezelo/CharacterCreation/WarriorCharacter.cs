using System;
using System.Collections.Generic;
using System.Text;

namespace Progtech_Boltkezelo.CharacterCreation
{
    class WarriorCharacter : CharacterCreate
    {
        protected override void Choose()
        {
            Console.WriteLine("I choose the warrior character.");
        }
        protected override void Create()
        {
            Console.WriteLine("I create the warrior character.");
        }
    }
}
