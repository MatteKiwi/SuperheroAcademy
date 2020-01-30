using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Hello and welcome to superhero academy");
            Console.WriteLine("What kind of hero would you like to be?");
            Console.WriteLine("1: A SuperHuman, 2: A SuperNerd, 3: A Mutant");
            string input = Console.ReadLine();

            if (input == "1")
            {
                SuperHuman sh1 = new SuperHuman();
                sh1.present();
            }
            else if (input == "2")
            {
                SuperNerd sn1 = new SuperNerd();
                sn1.present();
            }
            else if (input == "3")
            {
                Mutant m1 = new Mutant();
                m1.present();
            }



            Console.ReadLine();
        }
    }
}
