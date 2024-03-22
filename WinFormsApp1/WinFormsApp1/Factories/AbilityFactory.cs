using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation.Prototype;

namespace RpgCharaterCreation.Factories
{
    public class AbilityFactory
    {
        public Ability CreateAbility(string key)
        {
            AbilityManager manager = new AbilityManager();
            return manager.ability[key].Clone();
        }
    }
}
