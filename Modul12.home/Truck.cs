using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.home
{
    public class Truck : Car
    {
        public Truck(string name) : base(name) { }

        public override void Drive()
        {
            int speed = RandomSpeed.Next(1, 70);  
            Position += speed;
            Console.WriteLine($"{Name} находится на позиции {Position}.");

            if (Position >= 2000)
            {
                OnFinished();
            }
        }
    }
}
