using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment11_AndreiKazakov
{
    internal class Car
    {
        public int year;
        public string make;
        public int speed;

        public Car(int year, string  make)
        {
            this.year = year;
            this.make = make;
            this.speed = 0;
        }

        public void Accelerate()
        {
            this.speed += 5;
        }

        public void Brake()
        {
            if (this.speed >= 5)
            {
                this.speed -= 5;
            }
        }
    }
}
