using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    [Serializable()]
    public class Ability : IPrototype<Ability>
    {
        public List <Spell> Spells { get; set; }
        public string AbilityType { get; set; }

        public override string ToString()
        {
            return $"AbilityType: {AbilityType}";
        }
    }
    [Serializable()]
    class AbilityManager : IPrototype<Ability>
    {
        public Dictionary<string, Ability> ability = new Dictionary<string, Ability>
        {
            {"Human",new HumanAbilities()},
            {"Dwarven",new DwarvenAbilities()},
            {"Elve",new ElvenAbilities() },
            {"Orcish",new OrcishAbilities() }
        };

    }
}
