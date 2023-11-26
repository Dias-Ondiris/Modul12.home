using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.home
{
    
    internal class Program
    {

        public static void Main(string[] args)
        {
            var race = new Race();

            race.AddCar(new SportCar("Спортивный автомобиль"));
            race.AddCar(new Truck("Грузовик"));
            race.AddCar(new Bus("Автобус"));
            // Добавление других автомобилей

            race.StartRace += () => Console.WriteLine("Гонка началась!");
            race.RaceFinished += (sender, car) => Console.WriteLine($"{car.Name} финишировал!");

            race.Start();
            Console.ReadKey();
        }
    }
}
