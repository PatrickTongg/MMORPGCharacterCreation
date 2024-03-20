using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgCharaterCreation
{
    class Appearance : IPrototype<Appearance>
    {
        public String Description {  get; set; }
    }
    class HairStyle : Appearance
    {
        bool Tided;
        public HairStyle()
        {
            Tided = false;
        }
    }
    class Attire : Appearance
    {
        string color;
        public Attire()
        {
           color = "red";
        }
    }
    class Facialfeature : Appearance
    {
        bool Mushstach;
        bool scar;
        public Facialfeature()
        {
            Mushstach = false;
            scar = true;
        }
    }
    [Serializable()]
    class AppearanceManager : IPrototype<Appearance>
    {
        public Dictionary<string, Appearance> appearance = new Dictionary<string, Appearance>
        {
            {"Hairstyle",new HairStyle()},
            {"Facialfeature",new Facialfeature() },
            {"Attire",new Attire() }
        };

    }
}
