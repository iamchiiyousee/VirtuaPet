using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class VirtuaPet
    {
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public bool Waste { get; set; }
        public int Boredom { get; set; }

        /*public VirtuaPet()
        {
            Hunger = 0;
        }*/
        
        public void DisplayStats()
        {
            Console.WriteLine("{0}:", Name);
            Console.WriteLine("Hunger is at {0}", Hunger);
            Console.WriteLine("Thirst is at {0}", Thirst);
            if (Waste == true)
            {
                Console.WriteLine("{0} needs to poop/pee.", Name);
            }
            else if (Waste == false)
            {
                Console.WriteLine("{0} does not need to eliminate.", Name);
            }
            Console.WriteLine("Boredom is at {0}.", Boredom);
            ActionMenu();
        }

        public void ActionMenu()
        {
            Console.WriteLine("\nWhat would you like to do with {0}?\n Please type the number:\n", Name);
            Console.WriteLine("1: Feed");
            Console.WriteLine("2: Hydrate");
            Console.WriteLine("3: Let it poop/pee");
            Console.WriteLine("4: Play");
            Console.WriteLine("5: Check again");

            int actionChoice = Convert.ToInt32(Console.ReadLine());
            if (actionChoice == 5)
            {
                DisplayStats();
            }

        }

        public void Tick()
        {
            while(Hunger < 10)
            {
                Hunger = Hunger + 1;
                Task.Delay(TimeSpan.FromSeconds(2)).Wait();

            }
        }

    }
}
