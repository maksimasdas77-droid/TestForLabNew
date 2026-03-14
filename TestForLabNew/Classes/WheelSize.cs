using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForLabNew
{
    internal class WheelSize
    {
        private int wight;  //265
        private int profile; //65
        private int radius; //16

        public int Wight
        {
            get => wight;
            set
            {
                if (value > 0)
                wight = value;
            }
        }
        public int Profile
        {
            get => profile;
            set
            {
                if (value > 0)
                profile = value;
            }
        }
        public int Radius
        {
            get => radius;
            set
            {
                if (value > 0)
                radius = value;
            }
        }

        public override string ToString()
        {
            return $"{Wight}/{Profile}R{Radius}";
        }
    }
}
