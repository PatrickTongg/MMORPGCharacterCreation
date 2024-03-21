using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    class OrcishAbilities : Ability
    {

        public OrcishAbilities()
        {
            AbilityType = "OrcishAbilities";
            Spells = new List<Spell>();
            Spells.Add(new Spell("Destructure Strike", 150, 0, 8));
            Spells.Add(new Spell("Spin of Death", 200, 0, 20));
            Spells.Add(new Spell("Undying will", 0, 0, 80));
        }

    }
}
