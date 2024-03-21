using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    public class HumanAbilities : Ability
    {
        public HumanAbilities()
        {
            AbilityType = "HumanAbility";
            Spells = new List<Spell>();
            Spells.Add(new Spell("Decisive Strike", 150, 0, 8));
            Spells.Add(new Spell("Courage", 0, 0, 15));
            Spells.Add(new Spell("Justice", 450, 0, 80));
        }
    }
}
