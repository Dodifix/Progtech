using System;
using System.Collections.Generic;
using System.Text;

namespace Progtech_Boltkezelo.Map
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
