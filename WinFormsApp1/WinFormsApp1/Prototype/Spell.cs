using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation.Prototype
{
    public class Spell
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Healing { get; set; }
        public double Cooldown { get; set; }

        public Spell(string Name, double Damage, double Healing, double Cooldown)
        {
            this.Name = Name;
            this.Damage = Damage;
            this.Healing = Healing;
            this.Cooldown = Cooldown;
        }

        public override string ToString()
        {
            return $"Name:{Name}  Damage:{Damage} Healing:{Healing} Cooldown:{Cooldown}";
        }
    }
}
