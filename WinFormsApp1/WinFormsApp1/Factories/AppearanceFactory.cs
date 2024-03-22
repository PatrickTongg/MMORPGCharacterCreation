using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RpgCharaterCreation.Prototype;

namespace RpgCharaterCreation.Factories
{
    public class AppearanceFactory
    {
        public Appearances CreateAppearance(string key)
        {
            AppearanceManager appearanceManager = new AppearanceManager();
            return appearanceManager.appearance[key].Clone();
        }
    }
}
