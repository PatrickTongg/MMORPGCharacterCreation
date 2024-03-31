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
        public abstract Race CreateRace(string Key);
        public abstract Clazz CreateClazz(string Key);
        public abstract Appearances CreateAppearance(string Key);
        public abstract Ability CreateAbility(string Key);


    }
}

