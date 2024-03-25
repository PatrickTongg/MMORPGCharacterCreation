using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation;

namespace RpgCharaterCreation.Builder
{
    public class Adaptor:Builder
    {
        Builder adaptor;
        public Adaptor()
        { 
            adaptor = new Builder();
        }

        public Character StringToCharater(string race, string clazz, string ability, string appearance)
        {
            return adaptor.setRace(race).setClazz(clazz).setAbility(ability).setAppearance(appearance).build();
        } 
    }
}
