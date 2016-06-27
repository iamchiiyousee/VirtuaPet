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
            if (myPet.hunger == myPet.thirst)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("{0} has died of either hunger, or thirst, or both. Either way it's\n dead and you're a terrible owner. I'm calling the ASPCA.", myPet.Name);
                Console.WriteLine("-----------------------------");
            }
            else if (myPet.hunger > myPet.thirst)
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine("!!!{0} has died of hunger!!!", myPet.Name);
                Console.WriteLine("-----------------------------------");
            }
            else if (myPet.thirst > myPet.hunger)
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine("!!!{0} has died of thirst!!!", myPet.Name);
                Console.WriteLine("-----------------------------------");
            }
            

            Console.WriteLine("\nPress enter to exit.");
            Console.ReadKey();
         }



        private static void displayPet()
        {
            
        }
    }
}
