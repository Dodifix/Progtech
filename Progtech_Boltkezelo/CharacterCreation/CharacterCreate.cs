using System;
using System.Collections.Generic;
using System.Text;

namespace Progtech_Character_Manager.CharacterCreation
{
     abstract class CharacterCreate
    {
        public void create()
        {
            Choose();
            Create();
        }
        protected abstract void Choose();
        protected abstract void Create();
    }
}
