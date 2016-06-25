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

            Console.WriteLine("\nCongratulations, welcome {0} into the world!\n", myPet.Name);

            while (true)
            {
                myPet.DisplayStats();
               // myPet.Tick();
                myPet.ActionMenu();
               
            }

            //Console.ReadKey();
         }


    }
}
