using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation.Prototype;

namespace RpgCharaterCreation
{
    public class Character:CharacterToString
    {
        public Clazz clazz { get; set; }
        public Race race { get; set; }
        public Ability ability { get; set; }
        public Appearances appearances { get; set; }

        public string DisplayInfo()
        {
            return $"Race: {race.Name}  Class:{clazz.ClazzName}";
        }
        public override string ToString()
        {
            return ConvertCharacterToString(this);
        }


    }
}
