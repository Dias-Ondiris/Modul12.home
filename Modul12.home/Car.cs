using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.home
{
    public abstract class Car
    {
        public string Name { get; protected set; }
        public int Position { get; protected set; }
        protected Random RandomSpeed = new Random();

        public event EventHandler Finished;

        protected Car(string name)
        {
            Name = name;
        }

        public virtual void Drive()
        {
            int speed = RandomSpeed.Next(1, 100);  
            Position += speed;
            Console.WriteLine($"{Name} находится на позиции {Position}.");

            if (Position >= 2000) 
            {
                OnFinished();
            }
        }

        protected virtual void OnFinished()
        {
            Finished?.Invoke(this, EventArgs.Empty);
        }
    }


}
