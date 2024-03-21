using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    public class RaceFactory:ICharacterFactory
    {
        public Race CreateRace(String key)
        {
            RaceManager manager = new RaceManager();
            return manager.race[key]; 
        }
    }
}
