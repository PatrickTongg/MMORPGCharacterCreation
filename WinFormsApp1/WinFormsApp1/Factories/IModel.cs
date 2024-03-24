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
        public abstract Race createRace(string Key);

        public abstract Clazz createClazz(string Key);

        public abstract Appearances createAppearance(string Key);
        public abstract Ability createAbility(string Key);


    }
}

