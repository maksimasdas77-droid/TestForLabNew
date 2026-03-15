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
        public string? Name { get; set; }
        public string? Model { get; set; }
        private int year;
        public string Owner { get; set; }

        public string? Appointment { get; set; }
        private int? tankscount;
        private int? tankvol;
        private int? wheelcount;
        private int? batterycount;


        public battory? battory { get; set; }
        public WheelSize? wheelsize { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }

        public int Year
        {
            get => year;
            set
            {
                year = value;
            }
        }

        public int? Tankscount
        {
            get => tankscount;
            set
            {
                tankscount = value;
            }
        }
        public int? Tankvol
        {
            get => tankvol;
            set
            {
                tankvol = value;
            }
        }
        public int? Wheelcount
        {
            get => wheelcount;
            set
            {
                wheelcount = value;
            }
        }
        public int? Batterycount
        {
            get => batterycount;
            set
            {
                batterycount = value;
            }
        }
    }
}
