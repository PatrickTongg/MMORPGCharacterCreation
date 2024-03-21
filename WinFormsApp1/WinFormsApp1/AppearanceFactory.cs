using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    public class AppearanceFactory:ICharacterFactory
    {
        public Appearance CreateAppearance(string key)
        {
            AppearanceManager appearanceManager = new AppearanceManager();
            return appearanceManager.appearance[key].Clone();
        }
    }
}
