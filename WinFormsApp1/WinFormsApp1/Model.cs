using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation.Factories;
using RpgCharaterCreation.Prototype;

namespace RpgCharaterCreation
{
    internal class Model:IModel
    {
        public override Race createRace(string Key)
        {
            RaceFactory factory = new RaceFactory();
            return factory.CreateRace(Key).Clone();
        }

        public override Clazz createClazz(string Key)
        {
            ClassFactory factory = new ClassFactory();
            return factory.CreateClass(Key).Clone();
        }

        public override Appearances createAppearance(string Key)
        {
            AppearanceFactory factory = new AppearanceFactory();
            return factory.CreateAppearance(Key).Clone();
        }
        public override Ability createAbility(string Key)
        {
            AbilityFactory factory = new AbilityFactory();
            return factory.CreateAbility(Key).Clone();
        }

    }
}
