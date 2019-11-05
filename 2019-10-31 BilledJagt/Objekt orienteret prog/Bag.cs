using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_orienteret_prog
{
    class Bag
    {
        public string type;
        public string color;
        public int numberOfHandles;
        public int numberOfZippers;
        public string extra;

        public string MyBagDescription()
        {
            return $"My new {type} is {color}, it has {numberOfHandles} and {numberOfZippers} and as an extra feature {extra}";
        }

        public string FirstUse()
        {
            return $"With the {numberOfZippers} you have a good posibility of hanging yourself";
        }

        public string SecondUse()
        {
            return $"You can hide a small dog in the {type} and bring it to school";
        }

        public string ThirdUse()
        {
            return $"You can hide a rather healthy amount of cocaine in the {type}";
        }

        public string ForthUse()
        {
            return $"You can stash your {extra} in your {type}";
        }

        public string LastUse()
        {
            return "Hat";
        }
    }


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


    class MsgBoard
    {
        public string what;
        public int legs;
        public string msg;
        public string feature;
        public string material;

        public string Description()
        {
            return $"This is a {what}. It have {legs} legs. It says: {msg}. It has {feature} as a feature and is made of {material}";
        }

        public string FirstUse()
        {
            return $"{msg} tells people what to do";
        }

        public string SecondUse()
        {
            return "Blocks my path and forces me to go outside";
        }

        public string ThirdUse()
        {
            return "Got a theme-song with Snoop-dogg and Wiz Khalifa";
        }

        public string ForthUse()
        {
            return $"{what} is life";
        }

        public string LastUse()
        {
            return "Hat";
        }
    }


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
