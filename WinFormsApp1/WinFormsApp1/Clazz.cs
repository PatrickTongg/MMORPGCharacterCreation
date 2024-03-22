using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation.Prototype;

namespace RpgCharaterCreation
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
            this.ClazzName = clazz;
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
            {"Warrior",new  Clazz("Warrior",Clazz.AttackType.Melee)},
            {"Mages",new Clazz("Mages", Clazz.AttackType.Range) },
            {"Rougue",new  Clazz("Rougue", Clazz.AttackType.Melee) },
            {"Cleric",new  Clazz("Cleric", Clazz.AttackType.Range)}
        };

    }
}