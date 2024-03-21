using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    class DwarvenAbilities : Ability
    {

        public DwarvenAbilities()
        {
            AbilityType = "DwarvenAbilities";
            Spells = new List<Spell>();
            Spells.Add(new Spell("Health Generator", 0, 100, 15));
            Spells.Add(new Spell("Lava shoot", 200, 0, 0));
            Spells.Add(new Spell("Core Overdrive", 0, 350, 80));
        }

    }
}
