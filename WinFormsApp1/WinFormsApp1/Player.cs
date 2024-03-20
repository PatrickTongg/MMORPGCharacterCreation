using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    public class Player
    {
        private Clazz clazz { get; set; }
        private Race race { get; set; }
        private Ability ability { get; set; }
        
        private Appearance appearance { get; set; }

        public Player (ICharacterFactory factory){
        }
    }
}
