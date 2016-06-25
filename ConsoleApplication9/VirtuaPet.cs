using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class VirtuaPet
    {
        private string name;
        private int hunger { get; set; }
        private int thirst { get; set; }
        private bool waste { get; set; }
        private int boredom { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }



        /*public VirtuaPet()
        {
            Hunger = 0;
        }*/
        
        public void DisplayStats()
        {
            Console.WriteLine("{0}:", name);
            Console.WriteLine("Hunger is at {0}", hunger);
            Console.WriteLine("Thirst is at {0}", thirst);
            if (waste == true)
            {
                Console.WriteLine("{0} needs to poop/pee.", name);
            }
            else if (waste == false)
            {
                Console.WriteLine("{0} does not need to eliminate.", name);
            }
            Console.WriteLine("Boredom is at {0}.", boredom);
            ActionMenu();
        }

        public void ActionMenu()
        {
            Console.WriteLine("\nWhat would you like to do with {0}?\n Please type the number:\n", name);
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
            while(hunger < 10)
            {
                hunger = hunger + 1;
                Task.Delay(TimeSpan.FromSeconds(2)).Wait();

            }
        }

    }
}
