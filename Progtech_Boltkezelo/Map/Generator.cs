using System;
using System.Collections.Generic;
using System.Text;

namespace Progtech_Character_Manager.Map
{
    class Generator
    {
        private MapStrategy mapStrategy;

        public void Choose (MapStrategy strategy)
        {
            mapStrategy = strategy;
        }

        public void MapGen()
        {
            mapStrategy.MapGen();
        }
    }
}
