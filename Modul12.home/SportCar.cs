using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.home
{
    public class SportCar : Car
    {
        public SportCar(string name) : base(name) { }

        public override void Drive()
        {
            int speed = RandomSpeed.Next(50, 150);  
            Position += speed;
            Console.WriteLine($"{Name} находится на позиции {Position}.");

            if (Position >= 2000)
            {
                OnFinished();
            }
        }
    }


}
