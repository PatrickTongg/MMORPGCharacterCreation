using RpgCharaterCreation.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    public class CharacterToString
    {
        private string output;
        private Character ch =null;
        private  Dictionary<string, string> RaceDict = new Dictionary<String, string>
        {
            {"Human","HUM"},
            {"Dwarf","DWA"},
            {"Elf","ELV"},
            {"Orcish","ORC"}
        };

        private Dictionary<String, string> ClazzDict = new Dictionary<String, string>
        {
            {"Warrior","WAR"},
            {"Mages" , "MAG" },
            {"Rogue" , "ROG" },
            {"Cleric" , "CLE"}
        };
        private Dictionary<String, string> AbilityDict = new Dictionary<String, string>
        {
            {"HumanAbilities","HUMA"},
            {"DwarvenAbilities","DWAA"},
            {"ElvenAbilities" , "ELVA"},
            {"OrcishAbilities" , "ORCA"}
        };
        private Dictionary<string, string> AppearanceDict = new Dictionary<String, string>
        {
            {new HairStyle().ToString(),"HAIR"},
            {new Facialfeature().ToString() , "FACE"},
            {new Attire().ToString(), "ATTIRE" }
        };
        public CharacterToString()
        {
            
            this.output =string.Empty;
        }
        public CharacterToString InputCharater(Character ch)
        {
            this.ch = ch ;
            return this;
        }


        public CharacterToString RaceRevert()
        {
            output += $"{RaceDict[ch.race.Name]},";
            return this;
        }
        public CharacterToString ClazzRevert()
        {
            output += $"{ClazzDict[ch.clazz.ClazzName]},";
            return this;
        }

        public CharacterToString AbilityRevert()
        {
            output += $"{AbilityDict[ch.ability.AbilityType]},";
            return this;
        }
        public CharacterToString ApperancesRevert()
        {
            output += $"{AppearanceDict[ch.appearances.ToString()]},";
            return this;
        }
        public string buildString()
        {
            return output;
        }

        public string ConvertCharacterToString(Character ch)
        {
            return InputCharater(ch).RaceRevert().ClazzRevert().AbilityRevert().ApperancesRevert().buildString();
        }

    }
}
