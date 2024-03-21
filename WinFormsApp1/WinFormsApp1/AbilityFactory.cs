using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    public class AbilityFactory:ICharacterFactory
    {
        public Ability CreateAbility(string key)
        {
            AbilityManager manager= new AbilityManager();
            return manager.ability[key].Clone();
        }
    }
}
