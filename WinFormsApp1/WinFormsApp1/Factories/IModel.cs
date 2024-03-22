using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation.Prototype;

namespace RpgCharaterCreation.Factories
{
    public abstract class IModel
    {
        public Race createRace(string Key)
        {
            RaceFactory factory = new RaceFactory();
            return factory.CreateRace(Key).Clone();
        }

        public Clazz createClazz(string Key)
        {
            ClassFactory factory = new ClassFactory();
            return factory.CreateClass(Key).Clone();
        }

        public Appearance createAppearance(string Key)
        {
            AppearanceFactory factory = new AppearanceFactory();
            return factory.CreateAppearance(Key).Clone();
        }
        public Ability createAbility(string Key)
        {
            AbilityFactory factory = new AbilityFactory();
            return factory.CreateAbility(Key).Clone();
        }


    }
}

