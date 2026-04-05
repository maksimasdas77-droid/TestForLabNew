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
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year
        {
            get => year;
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException("Некорректный год выпуска");
                year = value;
                Touch();
            }
        }
        private int year;

        public string Owner { get; set; }
        public string Appointment { get; set; }

        public int? TanksCount { get; set; }
        public int? TankVolume { get; set; }
        public int? WheelCount { get; set; }

        public List<Battery> Batteries { get; set; } = new();
        public WheelSize WheelSize { get; set; }

        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; private set; } = DateTime.Now;

        private void Touch() => LastUpdatedAt = DateTime.Now;

        public Car()
    : this("Не задано", "Не задано", 2000, "РОСН", "Специальная", null, null, null, null)
        {
        }

        public Car(string? name, string? model, int year, string owner,
                   string? appointment, int? tanksCount, int? tankVolume,
                   int? wheelCount, int? batteryCount)
        {
            Name = name ?? "Не задано";
            Model = model;
            Year = year;
            Owner = owner;
            Appointment = appointment;
            TanksCount = tanksCount;
            TankVolume = tankVolume;
            WheelCount = wheelCount;

            // создаём аккумуляторы, если указано количество
            if (batteryCount.HasValue)
            {
                for (int i = 0; i < batteryCount.Value; i++)
                    Batteries.Add(new Battery());
            }

            CreatedAt = DateTime.Now;
            LastUpdatedAt = DateTime.Now;
        }

        public Car(string name, string owner, int year)
            : this(name, null, year, owner, null, null, null, null, null)
        {
        }

        public Car(string name, string? model, int year, string owner)
            : this(name, model, year, owner, null, null, null, null, null)
        {
        }
        public override string ToString()
        {
            return $"""
        === Информация об автомобиле ===
        Название:             {Name}
        Модель:               {Model}
        Год выпуска:          {Year}
        Владелец:             {Owner}
        Назначение:           {Appointment}
        Количество баков:     {TanksCount}
        Объём бака:           {TankVolume}
        Количество колёс:     {WheelCount}
        Размер колёс:         {WheelSize}
        Количество АКБ:       {Batteries.Count}
        Создано:              {CreatedAt}
        Последнее обновление: {LastUpdatedAt}
        ===============================
        """;
        }
    }

}
