using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    public class ClassFactory:ICharacterFactory
    {
         public Clazz CreateClass(string key) 
        {
            ClazzManager manager = new ClazzManager();
            return manager.clazz[key].Clone();
        }
    }
}
