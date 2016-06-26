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
        private double thirst { get; set; }
        private bool waste { get; set; }
        private int boredom { get; set; }
        private double hungertick { get; set; }


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

         

       /* public double Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
            }
        }*/

        public VirtuaPet()
        {
            hunger = 0;
            thirst = 0;
            boredom = 0;
            waste = false;
        }
        /*public VirtuaPet()
        {
            Hunger = 0;
        }*/
        
        public void DisplayStats()
        {
            
            Console.WriteLine("\n{0}:", name);
            Console.WriteLine("Hunger is at {0}", hunger);
            Console.WriteLine("Thirst is at {0}", thirst);
            if (waste == true)
            {
                Console.WriteLine("{0} needs to poop/pee.", name);
            }
            else if (waste == false)
            {
                Console.WriteLine("{0} does not need to poop/pee.", name);
            }
            Console.WriteLine("Boredom is at {0}.", boredom);
            Tick();
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
            else if (actionChoice == 1)
            {
                FeedMethod();
            }
           else if (actionChoice == 2)
            {
                HydrateMethod();
            }
            else if (actionChoice == 3)
            {
                PoopMethod();
            }
           else if (actionChoice == 4)
            {
                PlayMethod();
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
                ActionMenu();
            }

        }

        private void PlayMethod()
        {
            hunger++;
            thirst++;
            boredom = Convert.ToInt32( boredom * .5);
            Console.WriteLine("\nYou played with {0}!\n", Name);
            Console.WriteLine("Hunger went up by 1!\nThirst went up by 1!\nBoredom went down by half!");
        }

        private void PoopMethod()
        {
            throw new NotImplementedException();
        }

        private void HydrateMethod()
        {
            throw new NotImplementedException();
        }

        private void FeedMethod()
        {
            throw new NotImplementedException();
        }

        public void Tick()
        {
            hungertick = hungertick + .4;
            double hungertemp = hungertick;
            Math.Round(hungertemp);
            hunger = Convert.ToInt32(hungertemp);

            boredom++;

            /*while(hunger < 10)
             {
                 hunger = hunger + 1;
                 Task.Delay(TimeSpan.FromSeconds(2)).Wait();

             }
             */
        }

    }
}
