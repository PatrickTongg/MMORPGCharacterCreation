using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    [Serializable()]
    public abstract class IPrototype<T>
    {
        public T Clone()
        {
            return (T) this.MemberwiseClone();
        }

    }
}
