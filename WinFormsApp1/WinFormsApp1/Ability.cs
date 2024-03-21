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
    public class HumanAbilities:Ability
    {
        Spell spell_1;
        Spell spell_2;
        Spell spell_3;
        public HumanAbilities()
        {
            AbilityType = "HumanAbility";
            spell_1 = new Spell("Decisive Strike", 150, 0, 8);
            spell_2 = new Spell("Courage", 0, 0, 15);
            spell_3 = new Spell("Justice", 450, 0, 80);
            Spells = new List<Spell>();
            Spells.Add(spell_1);
            Spells.Add(spell_2);
            Spells.Add(spell_3);
        }
    }
    class DwarvenAbilities : Ability
    {
        Spell spell_1;
        Spell spell_2;
        Spell spell_3;
        public DwarvenAbilities()
        {
            AbilityType = "DwarvenAbilities";
            spell_1 = new Spell("Decisive Strike", 150, 0, 8);
            spell_2 = new Spell("Courage", 0, 0, 15);
            spell_3 = new Spell("Justice", 450, 0, 80);
            Spells = new List<Spell>();
            Spells.Add(spell_1);
            Spells.Add(spell_2);
            Spells.Add(spell_3);
        }

    }
    class ElvenAbilities : Ability
    {
        Spell spell_1;
        Spell spell_2;
        Spell spell_3;
        public ElvenAbilities()
        {
            AbilityType = "ElvenAbilities";
            spell_1 = new Spell("Brushmaker", 0, 0, 20);
            spell_2 = new Spell("Daisy the rock!", 120, 0, 120);
            spell_3 = new Spell("Incinerate", 250, 0, 8);
            Spells = new List<Spell>();
            Spells.Add(spell_1);
            Spells.Add(spell_2);
            Spells.Add(spell_3);
        }

    }
    class OrcishAbilities : Ability
    {
        Spell spell_1;
        Spell spell_2;
        Spell spell_3;
        public OrcishAbilities()
        {
            AbilityType = "OrcishAbilities";
            spell_1 = new Spell("Decisive Strike", 150, 0, 8);
            spell_2 = new Spell("Courage", 0, 0, 15);
            spell_3 = new Spell("Justice", 450, 0, 80);
            Spells = new List<Spell>();
            Spells.Add(spell_1);
            Spells.Add(spell_2);
            Spells.Add(spell_3);
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
