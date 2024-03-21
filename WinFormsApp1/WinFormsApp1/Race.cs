using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    [Serializable()]
    public class Race : IPrototype<Race>
    {
        public string Name { get; set; }
        public double HP { get; set; }
        public double Armor { get; set; }
        public double MagicResist { get; set; }
        public double MovementSpeed {  get; set; }
        public Race(string Race,double HP,double Armor,double MagicResist,double MovementSpeed)
        {
            this.Name = Race;
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
            {"Human",new Race("Humans",100,100,100,100)},
            {"Dwarven",new Race("Dwarves", 200,200,50,50) },
            {"Elve",new Race("Elves", 50,100,150,100) },
            {"Orcish",new Race("Orcish", 200,150,50,50)}
        };

    }
}
