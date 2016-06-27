using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtuaPet myPet = new VirtuaPet();

            Console.WriteLine("Welcome to VirtuaPet.\nPlease enter the name of your pet.");
            

            myPet.Name = Console.ReadLine();

            Console.WriteLine("Great! Please enter the type of pet:");

            string petDisplay = Console.ReadLine();

            Console.WriteLine("\nCongratulations, welcome {0} into the world!", myPet.Name);

            while (myPet.IsAlive())
            {

                displayPet();
                myPet.DisplayStats();
               // myPet.ActionMenu();

           
               
            }

            if (myPet.hunger > 10)
            {
                Console.WriteLine("\n!!!{0} has died of hunger!!!", myPet.Name);
            }
            else if (myPet.thirst > 10)
            {
                Console.WriteLine("\n!!!{0} has died of thirst!!!", myPet.Name);
            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadKey();
         }



        private static void displayPet()
        {
            
        }
    }
}
