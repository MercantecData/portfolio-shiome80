using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_orienteret_prog
{
    class Container
    {
        public string type;
        public string bagType;
        public string shape;
        public string look;
        public string feature;

        public string Description()
        {
            return $"This is a {type}. It can hold a {bagType} bag. It is {shape}. It have details like {look}. It have {feature} as a feature";
        }

        public string FirstUse()
        {
            return "Use it as a gross hat";
        }

        public string SecondUse()
        {
            return "You can store stuff you don't want";
        }

        public string ThirdUse()
        {
            return "Use for basketball";
        }

        public string ForthUse()
        {
            return "Not very good at being an aquarium";
        }

        public string LastUse()
        {
            return "Can contain garbage";
        }
    }
}
