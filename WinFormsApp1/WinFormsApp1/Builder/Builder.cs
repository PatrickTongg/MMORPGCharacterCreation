using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation.Factories;

namespace RpgCharaterCreation.Builder
{
    public class Builder : IBuilder
    {
        private Character ch;
        private IModel model;
        public Builder()
        {
            ch = new Character();
            model = new Model();
        }
        public IBuilder SetAbility(string Key)
        {
            ch.ability = model.CreateAbility(Key);
            return this;
        }
        public IBuilder SetClazz(string Key)
        {
            ch.clazz = model.CreateClazz(Key);
            return this;
        }
        public IBuilder SetAppearance(string Key)
        {
            ch.appearances = model.CreateAppearance(Key);
            return this;
        }
        public IBuilder SetRace(string Key)
        {
            ch.race = model.CreateRace(Key);
            return this;
        }

        public Character Build()
        {
            return ch;
        }
    }
}
