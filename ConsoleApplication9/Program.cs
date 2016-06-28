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
            displaypet freakingdisplay = new displaypet();


            Console.WriteLine("Welcome to VirtuaPet.\nPlease enter the name of your pet.");
            myPet.Name = Console.ReadLine();


            Console.WriteLine("\nGreat! Please enter the type of pet:");
            Console.WriteLine("1: Cat");
            Console.WriteLine("2: Dog");
            Console.WriteLine("3: Snake");
            Console.WriteLine("4: Other");

            freakingdisplay.petDisplay = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nCongratulations, welcome {0} into the world!", myPet.Name);

            while (myPet.IsAlive())
            {

                freakingdisplay.displayChoice();
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

 


    }
}
