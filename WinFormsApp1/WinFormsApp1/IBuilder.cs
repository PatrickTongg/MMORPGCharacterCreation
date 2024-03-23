using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    public interface IBuilder
    {
        void setAbility(string key);
        void setClazz(string key);
        void setRace(string key);
        void setAppearance(string key);
        Character build();
    }
}
