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
        private IModel model;
        public Builder()
        {
            ch = new Character();
            model  = new Model();
        }
        public IBuilder setAbility(string Key)
        {
            ch.ability = model.createAbility(Key);
            return this;
        }
        public IBuilder setClazz(string Key)
        {
            ch.clazz = model.createClazz(Key);
            return this;
        }
        public IBuilder setAppearance(string Key)
        {
            ch.appearances = model.createAppearance(Key);
            return this;
        }
        public IBuilder setRace(string Key)
        {
            ch.race = model.createRace(Key);
            return this;
        }

        public Character build()
        {
            return ch;
        }
    }
}
