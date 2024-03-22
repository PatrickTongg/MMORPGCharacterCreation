using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation.Prototype;

namespace RpgCharaterCreation.Factories
{
    public class RaceFactory
    {
        public Race CreateRace(string key)
        {
            RaceManager manager = new RaceManager();
            return manager.race[key].Clone();
        }
    }
}
