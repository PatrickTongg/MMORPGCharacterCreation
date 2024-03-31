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
            Character ch =  adaptor.setRace(attr[0]).setClazz(attr[1]).setAbility(attr[2]).setAppearance(attr[3]).build();
            race = ch.race;
            clazz = ch.clazz;
            ability = ch.ability;
            appearances = ch.appearances;

        }
    }
}
