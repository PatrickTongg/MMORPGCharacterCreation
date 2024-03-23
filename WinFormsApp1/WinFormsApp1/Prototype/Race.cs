using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation.Prototype
{
    [Serializable()]
    public class Race : IPrototype<Race>
    {
        public string Name { get; set; }
        public double HP { get; set; }
        public double Armor { get; set; }
        public double MagicResist { get; set; }
        public double MovementSpeed { get; set; }
        public Race(string Race, double HP, double Armor, double MagicResist, double MovementSpeed)
        {
            Name = Race;
            this.HP = HP;
            this.Armor = Armor;
            this.MagicResist = MagicResist;
            this.MovementSpeed = MovementSpeed;
        }

        public override string ToString()
        {
            return $"Name:{Name}\nHP:{HP}\nArmor{Armor}\nMagic resist:{MagicResist}\nMovement Speed:{MovementSpeed}";
        }

    }
    [Serializable()]
    public class RaceManager : IPrototype<Race>
    {
        public Dictionary<string, Race> race = new Dictionary<string, Race>
        {
            {"HUM",new Race("Human",100,100,100,100)},
            {"DWA",new Race("Dwarf", 200,200,50,50) },
            {"ELV",new Race("Elf", 50,100,150,100) },
            {"ORC",new Race("Orcish", 200,150,50,50)}
        };

    }
}
