using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForLabNew
{
    internal class battery
    {
        private int volts;
        private int batterycapacity;
        private int startingcurrent;
        public string? Batterydescription { get; set; }

        public battery() : this(12, 60, 300, "Стандартный аккумулятор")
        {
        }

        public battery(int volts, int capacity, int startingCurrent, string? description = null)
        {
            Volts = volts;
            Batterycapacity = capacity;
            Startingcurrent = startingCurrent;
            Batterydescription = description;
        }

        public int Volts
        {
            get => volts;
            set
            {
                if(value > 0)
                volts = value;
            }
        }
        public int Batterycapacity
        {
            get => batterycapacity;
            set
            {
                if (value > 0)
                batterycapacity = value;
            }
        }
        public int Startingcurrent
        {
            get => startingcurrent;
            set
            {
                if (value > 0)
                startingcurrent = value;
            }
        }
    }
}
    