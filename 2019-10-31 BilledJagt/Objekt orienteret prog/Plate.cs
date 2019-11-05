using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_orienteret_prog
{
    class Plate
    {
        public string what;
        public string material;
        public string detail;
        public string color;
        public string shape;

        public string Description()
        {
            return $"This is a {what}. It is made of {material}. It has {detail} and is {color} and is {shape}shaped";
        }

        public string FirstUse()
        {
            return "Chineese hat";
        }

        public string SecondUse()
        {
            return "Pirate hat";
        }

        public string ThirdUse()
        {
            return "Cap hat";
        }

        public string ForthUse()
        {
            return "Eat cake of it";
        }

        public string LastUse()
        {
            return "I have already eaten cake of it";
        }
    }
}
