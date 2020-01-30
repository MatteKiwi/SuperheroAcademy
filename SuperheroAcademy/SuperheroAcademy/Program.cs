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
         //välkommns /info meddelande till användaren
            Console.WriteLine("Hello and welcome to superhero academy");
            Console.WriteLine("What kind of hero would you like to be?");
            Console.WriteLine("1: A SuperHuman, 2: A SuperNerd, 3: A Mutant");
 
            int n = 0;
            while (n <= 1) //en enekel while loop som kollar ifall användaren har skrivit ett nummer och inte en bokstav, ifall användaren har skrivit ett nummer så går den vidare
            {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("Icke sa micke! försök igen!!"); //felmeddelande
            }
            //enekel ifsats ifall deras input är mellan 1-3 och därav skapar en instansans av den samt kör metoden present av den användaren valde
            if (n == 1)
            {
                SuperHuman sh1 = new SuperHuman();
                sh1.present();
            }
            else if (n == 2)
            {
                SuperNerd sn1 = new SuperNerd();
                sn1.present();
            }
            else if (n == 3)
            {
                Mutant m1 = new Mutant();
                m1.present();
            }



            Console.ReadLine();
        }
    }
}
