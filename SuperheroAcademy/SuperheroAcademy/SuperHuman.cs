using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class SuperHuman : Human
    {
        //variabler med data ifrån human
        private string name = "Kent";
        private int age = 34;
        private string ability = "Super Fast";
        private int speed = 8;
        private int IQ = 110;
        private int power = 90;

        //dum metod för dess superkraft
        public void SuperPower()
        {
            for (int i = 0; i < 3; i++)
            {
                speed *= 2;
                i++;
            }
        }
        //presentera alla dess info
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
