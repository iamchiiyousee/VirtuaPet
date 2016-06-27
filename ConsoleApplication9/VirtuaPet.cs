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
        public double hunger { get; set; }
        public double thirst { get; set; }
        private bool poop { get; set; }
        private bool pee { get; set; }
        private int boredom { get; set; }
       // private double hungerTick { get; set; }
       // private double thirstTick { get; set; }
        private int peeTick { get; set; }
        private int poopTick { get; set; }


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
            poop = false;
            pee = false;
        }
        /*public VirtuaPet()
        {
            Hunger = 0;
        }*/
        /// <summary>
        /// Determines whether the pet is alive using the hunger and thirst counters.
        /// </summary>
        /// <returns>Whether pet is alive or dead.</returns>
        public bool IsAlive()
        {
            if (hunger <= 10 & thirst <=10)
            {

                return true;
            }
           /* if (thirst <= 10)
            {
                return true;
            }*/
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Displays pet stats, checks the poop and pee counters, runs the hunger and thirst ticks, continues onto the menu.
        /// </summary>
        public void DisplayStats()
        {
            poopedItself();
            peedItself();

            Console.WriteLine("\n{0}:", Name);
            Console.WriteLine("Hunger is at {0}", Math.Round(hunger, MidpointRounding.AwayFromZero));
            Console.WriteLine("Thirst is at {0}", Math.Round(thirst, MidpointRounding.AwayFromZero));
            if (poop == true)
            {
                Console.WriteLine("!!!{0} needs to poop!!!", Name);
            }
            else if (poop == false)
            {
                Console.WriteLine("{0} does not need to poop.", Name);
            }
            if (pee == true)
            {
                Console.WriteLine("!!!{0} needs to pee!!!", Name);
            }
            else if (pee == false)
            {
                Console.WriteLine("{0} does not need to pee.", Name);
            }
            Console.WriteLine("Boredom is at {0}.", boredom);
            Tick();
            ActionMenu();
        }
        /// <summary>
        /// Reads the pee counter and determines whether or not the pet needs to pee. If the pee counter reaches a certain point,
        /// the counter is cleared and a message displays that the pet has peed itself.
        /// </summary>
        private void peedItself()
        {
            if (peeTick == 8)
            {
                peeTick = 0;
                Console.WriteLine("!!!\n{0} peed on your carpet! \n!!!", Name);
            }
            if (peeTick > 5)
            {
                pee = true;
            }
            else
            {
                pee = false;
            }

        }
        /// <summary>
        /// Reads the poop counter and determines whether or not the pet needs to poop. If the poop counter reaches a certain point,
        /// the counter is cleared and a message displays that the pet has pooped itself.
        /// </summary>
        private void poopedItself()
        {
           
            if (poopTick == 8)
            {
                poopTick = 0;
                Console.WriteLine("!!!\n{0} pooped on your carpet!\n!!!", Name);
            }

            if (poopTick > 5)
            {
                poop = true;
            }
            else
            {
                poop = false;
            }
        }
        /// <summary>
        /// Displays list of options and uses input to call the specified method.
        /// </summary>
        public void ActionMenu()
        {
            Console.WriteLine("\nWhat would you like to do with {0}?\n Please type the number:\n", Name);
            Console.WriteLine("1: Feed");
            Console.WriteLine("2: Hydrate");
            Console.WriteLine("3: Let it poop");
            Console.WriteLine("4: Let it pee");
            Console.WriteLine("5: Play");
            Console.WriteLine("6: Check again");

            int actionChoice = Convert.ToInt32(Console.ReadLine());

            if (actionChoice == 6)
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
                PeeMethod();
            }
           else if (actionChoice == 5)
            {
                PlayMethod();
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
                ActionMenu();
            }

        }
        /// <summary>
        /// Clears the pee counter and displays that the pet has peed.
        /// </summary>
        private void PeeMethod()
        {
            peeTick = 0;
            Console.WriteLine("{0} went pee!", Name);
        }
        /// <summary>
        /// Reduces the boredom counter by .6 and adds 1 to hunger and thirst.
        /// </summary>
        private void PlayMethod()
        {
            hunger++;
            thirst++;
            boredom = Convert.ToInt32( boredom * .4);
            Console.WriteLine("\nYou played with {0}!\n", Name);
            Console.WriteLine("Hunger went up!\nThirst went up!\nBoredom went down!");
        }
        /// <summary>
        /// Pet clears its bowels and the counter is reset.
        /// </summary>
        private void PoopMethod()
        {
            poopTick = 0;
            Console.WriteLine("{0} went poop!", Name);
        }
        /// <summary>
        /// Removes thirst points and clears the counter. Adds pee points.
        /// </summary>
        private void HydrateMethod()
        {
            peeTick++;
            thirst = 0;
            //thirstTick = 0;

        }
        /// <summary>
        /// Removes hunger points and clears the counter. Adds poop points.
        /// </summary>
        private void FeedMethod()
        {
            poopTick++;
            hunger = 0;
            //hungerTick = 0;

        }
        /// <summary>
        /// Adds 1 hunger and thirst point every 2 times Tick is called. Adds 1 boredom point every time Tick is called.
        /// </summary>
        public void Tick()
        {
            //Convert has a tendency to cause hunger to stay at the same number 3 times in a row and leads to inconsistent counting for the hunger counter.
            hunger = hunger + .5;
            //double hungertemp = hungerTick;
           // Math.Round(hungertemp);
           // hunger = hungerTick;

            //I tried another way but it's still the same.
            thirst = thirst + .5;
            //double thirstTemp = thirstTick;
           // Math.Round(thirstTemp, MidpointRounding.AwayFromZero);
            //thirst = thirstTick;

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
