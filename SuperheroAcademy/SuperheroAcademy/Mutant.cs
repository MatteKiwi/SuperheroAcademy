using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class Mutant: Human
    {
        private string name = "ET";
        private int age = 149;
        private string ability = "Super Strong";
        private int speed = 6;
        private int IQ = 80;
        private int power = 150;

        public void SuperPower()
        {
            for (int i = 0; i < 3; i++)
            {
                power *= 2;
                i++;
            }
        }

        public void present()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Ability: " + ability);
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("Power: " + power);
            Console.WriteLine("IQ: " + IQ);
        }
    }
}
