using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_orienteret_prog
{
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
}
