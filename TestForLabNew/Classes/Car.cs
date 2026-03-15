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


        //public battery? battery { get; set; } //задел на будущее, пока разберусь с конструктором и всем остальным
        //public WheelSize? wheelsize { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }

        public Car() : this("Не задано", "Не задано", 2000, "РОСН", "Специльная", null, null, null, null)
        { 
        }

        public Car(string? name, string? model, int year, string owner, string? appointment, int? tankscount, int? tankvol, int? wheelcount, int? batterycount)
        {
            Name = name;
            Model = model;
            this.year = year;
            Owner = owner;
            Appointment = appointment;
            this.tankscount = tankscount;
            this.tankvol = tankvol;
            this.wheelcount = wheelcount;
            this.batterycount = batterycount;
            CreatedAt = DateTime.Now;
            LastUpdatedAt = DateTime.Now;
        }
        public Car(string name, string owner, int year)
    : this(name, null, year, owner, null, null, null, null, null)
        {
        }

        public Car(string name, string model, int year, string owner)
    : this(name, model, year, owner, null, null, null, null, null)
        {
        }

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

        public override string? ToString()
        {
            //return $"{Name} {Model} ({Year}) — владелец: {Owner}";
           return $"=== Информация об автомобиле ===\n" +
       $"Название:             {Name}\n" +
       $"Модель:               {Model}\n" +
       $"Год выпуска:          {Year}\n" +
       $"Владелец:             {Owner}\n" +
       $"Назначение:           {Appointment}\n" +
       $"Количество баков:     {Tankscount}\n" +
       $"Объём бака:           {Tankvol}\n" +
       $"Количество колёс:     {Wheelcount}\n" +
       $"Количество АКБ:       {Batterycount}\n" +
       $"Создано:              {CreatedAt}\n" +
       $"Последнее обновление: {LastUpdatedAt}\n" +
       $"===============================";
        }
    }
}
