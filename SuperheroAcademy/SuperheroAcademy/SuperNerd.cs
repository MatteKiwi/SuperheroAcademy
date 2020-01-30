using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class SuperNerd : Human
    {
        //varibaler ifrån human
        private string name = "Larry";
        private int age = 19;
        private string ability = "Super Smart";
        private int speed = 2;
        private int IQ = 200;
        private int power = 45;
        //dess superkraft
        public void SuperPower()
        {
            for (int i = 0; i < 3; i++)
            {
                IQ *= 2;
                i++;
            }
        }
        //all dess info
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
