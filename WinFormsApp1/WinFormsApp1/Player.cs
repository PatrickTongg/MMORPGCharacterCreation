using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    public class Player
    {
        private Clazz clazz { get; set; }
        private Race race { get; set; }
        private Ability ability { get; set; }
        
        private Appearance appearance { get; set; }

        public Player(string clazz_key,string race_key,string appearance_key, string ability_key){
            
            ClassFactory classFactory = new ClassFactory();
            clazz = classFactory.CreateClass(clazz_key);

            RaceFactory raceFactory = new RaceFactory();
            race = raceFactory.CreateRace(race_key);

            AppearanceFactory factory = new AppearanceFactory();
            appearance = factory.CreateAppearance(appearance_key);

            AbilityFactory abilityFactory = new AbilityFactory();
            ability = abilityFactory.CreateAbility(ability_key); 

        }
    }
}
