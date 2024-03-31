using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation;

namespace RpgCharaterCreation.Builder
{
    public class AdaptorStringToChar: Character
    {
        Builder adaptor;
        string[] attr;
        public AdaptorStringToChar(string []attr)
        { 
            this.attr = attr;
            this.adaptor = new Builder();
            StringToCharacter();
        }

        public void StringToCharacter()
        {
            Character ch =  adaptor.SetRace(attr[0]).SetClazz(attr[1]).SetAbility(attr[2]).SetAppearance(attr[3]).Build();
            race = ch.race;
            clazz = ch.clazz;
            ability = ch.ability;
            appearances = ch.appearances;

        }
    }
}
