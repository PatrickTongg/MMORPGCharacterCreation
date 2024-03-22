using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgCharaterCreation.Prototype
{
    public class Appearances : IPrototype<Appearances>
    {
        public string Description { get; set; }
    }
    public class HairStyle : Appearances
    {
        bool Tided;
        public HairStyle()
        {
            Tided = false;
        }
    }
    public class Attire : Appearances
    {
        string color;
        public Attire()
        {
            color = "red";
        }
    }
    public class Facialfeature : Appearances
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
    public class AppearanceManager : IPrototype<Appearances>
    {
        public Dictionary<string, Appearances> appearance = new Dictionary<string, Appearances>
        {
            {"Hairstyle",new HairStyle()},
            {"Facialfeature",new Facialfeature() },
            {"Attire",new Attire() }
        };

    }
}
