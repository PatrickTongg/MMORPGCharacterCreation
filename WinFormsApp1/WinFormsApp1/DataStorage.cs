using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCharaterCreation
{
    public class DataStorage
    {
        public List<Character> CharacterList;
        public static DataStorage instance { get; private set; }

        private DataStorage()
        { 
            CharacterList = new List<Character>();
        }

        public static DataStorage Instance { 
            get { 
                if (instance == null)
                {
                    instance = new DataStorage();
                }
                return instance;
            } 
        }
    }
}
