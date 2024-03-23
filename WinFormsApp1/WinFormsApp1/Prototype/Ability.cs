using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RpgCharaterCreation.Prototype
{
    [Serializable()]
    public class Ability : IPrototype<Ability>
    {
        public List<Spell> Spells { get; set; }
        public string AbilityType { get; set; }

        public override string ToString()
        {
            return $"AbilityType: {AbilityType}";
        }
    }
    public class HumanAbilities : Ability
    {

        public HumanAbilities()
        {
            AbilityType = "HumanAbility";
            Spells = new List<Spell>();
            Spells.Add (new Spell("Decisive Strike", 150, 0, 8));
            Spells.Add(new Spell("Courage", 0, 0, 15));
            Spells.Add(new Spell("Justice", 450, 0, 80));
        }
    }
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

    [Serializable()]
    class AbilityManager : IPrototype<Ability>
    {
        public Dictionary<string, Ability> ability = new Dictionary<string, Ability>
        {
            {"HUMA",new HumanAbilities()},
            {"DWAA",new DwarvenAbilities()},
            {"ELVA",new ElvenAbilities() },
            {"ORCA",new OrcishAbilities() }
        };

    }
}
