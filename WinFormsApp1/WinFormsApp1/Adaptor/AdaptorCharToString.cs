using RpgCharaterCreation.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation.Adaptor
{
    public class AdaptorCharactorToString:CharacterToString
    {
        CharacterToString adaptor;
        public AdaptorCharactorToString()
        {

            adaptor = new CharacterToString();
        }

        public string ConvertCharacterToString(Character ch)
        {
            return adaptor.InputCharater(ch).RaceRevert().ClazzRevert().AbilityRevert().ApperancesRevert().buildString();
        }
    }
}
