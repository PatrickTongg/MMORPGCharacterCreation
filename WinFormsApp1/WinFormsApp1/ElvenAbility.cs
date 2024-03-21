using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    class ElvenAbilities : Ability
    {
        public ElvenAbilities()
        {
            AbilityType = "ElvenAbilities";
            Spells = new List<Spell>();
            Spells.Add(new Spell("Brushmaker", 0, 0, 20));
            Spells.Add(new Spell("Daisy the rock!", 120, 0, 120));
            Spells.Add(new Spell("Incinerate", 250, 0, 8));
        }

    }
}
