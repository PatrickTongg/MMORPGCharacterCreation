using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation.Builder
{
    public interface IBuilder
    {
        IBuilder SetAbility(string key);
        IBuilder SetClazz(string key);
        IBuilder SetRace(string key);
        IBuilder SetAppearance(string key);
        Character Build();
    }
}
