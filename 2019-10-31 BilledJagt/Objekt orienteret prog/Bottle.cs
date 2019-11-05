using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_orienteret_prog
{
    class Bottle
    {
        public string type;
        public string liquid;
        public bool GotPant;
        public bool GotBarcodeline;
        public bool GotCap;

        public string Description()
        {
            return $"{type} {liquid} {GotPant} {GotCap} {GotBarcodeline}";
        }

        public string FirstUse()
        {
            return "Cold hat";
        }

        public string SecondUse()
        {
            return $"You can drink the {liquid}";
        }

        public string ThirdUse()
        {
            return "You can carry it";
        }

        public string ForthUse()
        {
            return $"You can shower in the {liquid}";
        }

        public string LastUse()
        {
            return $"Donate 1 kr to poor children";
        }
    }
}
