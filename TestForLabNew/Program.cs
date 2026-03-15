namespace TestForLabNew
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Name = "Гонка";
            car1.Model = "Рахич";
            car1.Year = 2022;
            car1.Owner = "РОСН";
            car1.Appointment = "Специальая";
            car1.Tankscount = 2;
            car1.Tankvol = 40;

            Console.WriteLine(car1.ToString());
            Car car2 = new Car("Фольксваген", "Крафтер", 2008, "ОМТОиС", "Специальная", 2, 40, 5, 2);
            Console.WriteLine(car2);

            Console.Write("Введите название автомобиля: ");
            string? carname = Console.ReadLine();
            Console.Write("Введите модель автомобиля: ");
            string? carmodel = Console.ReadLine();
            int caryear = ReadClass.ReadValue<int>("Введите год автомобиля: ", int.TryParse);
            Console.Write("Введите владельца автомобиля: ");
            string? carowner = Console.ReadLine();

            Car car3 = new Car(carname, carmodel, caryear, carowner);
            
            Console.WriteLine(car3.ToString());



            Console.ReadLine();
        }
    }
}