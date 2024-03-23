using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation.Prototype
{
    [Serializable()]
    public class Clazz : IPrototype<Clazz>
    {
        public string ClazzName { get; set; }
        public AttackType attackType { get; set; }
        public enum AttackType
        {
            Melee,
            Range
        }

        public Clazz(string clazz, AttackType attackType)
        {
            ClazzName = clazz;
            this.attackType = attackType;
        }
        public override string ToString()
        {
            return $"Class: {ClazzName} \nAttack Type: {attackType}";
        }
    }
    [Serializable()]
    public class ClazzManager : IPrototype<Clazz>
    {
        public Dictionary<string, Clazz> clazz = new Dictionary<string, Clazz>
        {
            {"WAR",new  Clazz("Warrior",Clazz.AttackType.Melee)},
            {"MAG",new Clazz("Mages", Clazz.AttackType.Range) },
            {"ROG",new  Clazz("Rogue", Clazz.AttackType.Melee) },
            {"CLE",new  Clazz("Cleric", Clazz.AttackType.Range)}
        };

    }
}