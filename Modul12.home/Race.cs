using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.home
{
    public delegate void RaceDelegate();

    public class Race
    {
        public event RaceDelegate StartRace;
        public event EventHandler<Car> RaceFinished;

        private List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
            car.Finished += Car_Finished;
        }

        private void Car_Finished(object sender, EventArgs e)
        {
            var car = sender as Car;
            RaceFinished?.Invoke(this, car);
        }

        public void Start()
        {
            StartRace?.Invoke();

            bool raceFinished = false;
            while (!raceFinished)
            {
                foreach (var car in cars)
                {
                    car.Drive();
                    if (car.Position >= 2000)
                    {
                        raceFinished = true;
                        break;
                    }
                }
            }
        }
    }
}
