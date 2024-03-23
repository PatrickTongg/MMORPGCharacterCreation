using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation.Factories;

namespace RpgCharaterCreation
{
    public class Builder : IBuilder
    {
        private Character ch;

        public Builder()
        {
            ch = new Character();
        }
        public void setAbility(string Key)
        {
            AbilityFactory factory = new AbilityFactory();
            ch.ability = factory.CreateAbility(Key);
        }
        public void setClazz(string Key)
        {
            ClassFactory factory = new ClassFactory();
            ch.clazz = factory.CreateClass(Key);
        }
        public void setAppearance(string Key)
        {
            AppearanceFactory factory = new AppearanceFactory();
            ch.appearances = factory.CreateAppearance(Key);
        }
        public void setRace(string Key)
        {
            RaceFactory factory = new RaceFactory();
            ch.race = factory.CreateRace(Key);
        }

        public Character build()
        {
            return ch;
        }
    }
}
