using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForLabNew
{
    internal class battory
    {
        private int volts;
        private int batterycapacity;
        private int startingcurrent;
        public string? Batterydescription { get; set; }
        public int Volts { get => volts; set => volts = value; }
        public int Batterycapacity { get => batterycapacity; set => batterycapacity = value; }
        public int Startingcurrent { get => startingcurrent; set => startingcurrent = value; }
    }
}
    