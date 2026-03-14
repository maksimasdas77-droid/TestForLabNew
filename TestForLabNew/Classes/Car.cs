using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestForLabNew
{
    internal class Car
    {
        public string name;
        public string? model;
        public int year;
        public string owner;

        public string? appointment;
        public int? tankscount;
        public int? tankvol;
        public int? wheelcount;
        public int? batterycount;
        public battory? battory;

        public WheelSize? wheelsize;

        public DateTime CreatedAt;
        public DateTime LastUpdatedAt;
    }
}
