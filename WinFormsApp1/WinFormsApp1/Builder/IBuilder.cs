using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation.Builder
{
    public interface IBuilder
    {
        IBuilder setAbility(string key);
        IBuilder setClazz(string key);
        IBuilder setRace(string key);
        IBuilder setAppearance(string key);
        Character build();
    }
}
