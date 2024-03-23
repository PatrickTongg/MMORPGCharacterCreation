using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation.Prototype;

namespace RpgCharaterCreation.Factories
{
    public class ClassFactory
    {
        public Clazz CreateClass(string key)
        {
            ClazzManager manager = new ClazzManager();
            return manager.clazz[key].Clone();
        }
    }
}
