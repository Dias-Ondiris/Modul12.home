using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.home
{
    public class Bus : Car
    {
        public Bus(string name) : base(name) { }
        public override void Drive()
        {
            int speed = RandomSpeed.Next(10, 110); 
            Position += speed;
            Console.WriteLine($"{Name} находится на позиции {Position}.");

            if (Position >= 2000)
            {
                OnFinished();
            }
        }
    }
}
