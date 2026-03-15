using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForLabNew
{
    internal class PetrolTool //дописать этот класс потом, когда доведу до ума автомобили и оборудвоание
    {
        public string? Name { get; set; } 
        public string? Model {  get; set; }
        public string? Owner { get; set;}
        public string? Storageloc {  get; set; }

        public string? Petroltype {  get; set; }
        public string? Appointment {  get; set; }
        public int Year
        {
            get => year;
            set
            {
                if(value>0)
                year = value;
            }
        }

        private int year;



    }
}
