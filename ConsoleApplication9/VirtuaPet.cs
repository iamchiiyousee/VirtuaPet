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
        public int hunger { get; set; }
        public int thirst { get; set; }
        private bool poop { get; set; }
        private bool pee { get; set; }
        private int boredom { get; set; }
        private double hungerTick { get; set; }
        decimal thirstTick { get; set; }
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
        
        public void DisplayStats()
        {
            poopedItself();
            peedItself();

            Console.WriteLine("\n{0}:", Name);
            Console.WriteLine("Hunger is at {0}", hunger);
            Console.WriteLine("Thirst is at {0}", thirst);
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

        private void PeeMethod()
        {
            pee = false;
            Console.WriteLine("{0} went pee!", Name);
        }

        private void PlayMethod()
        {
            hungerTick++;
            thirstTick++;
            boredom = Convert.ToInt32( boredom * .4);
            Console.WriteLine("\nYou played with {0}!\n", Name);
            Console.WriteLine("Hunger went up!\nThirst went up!\nBoredom went down!");
        }
        /// <summary>
        /// Pet clears its bowels and the counter is reset.
        /// </summary>
        private void PoopMethod()
        {
            poop = false;
            Console.WriteLine("{0} went poop!");
        }
        /// <summary>
        /// Removes thirst points and clears the counter. Adds pee points.
        /// </summary>
        private void HydrateMethod()
        {
            peeTick++;
            thirst = 0;
            thirstTick = 0;

        }
        /// <summary>
        /// Removes hunger points and clears the counter. Adds poop points.
        /// </summary>
        private void FeedMethod()
        {
            poopTick++;
            hunger = 0;
            hungerTick = 0;

        }
        /// <summary>
        /// Adds 1 hunger and thirst point every 2 times Tick is called. Adds 1 boredom point every time Tick is called.
        /// </summary>
        public void Tick()
        {
            //Math.Round has a tendency to cause hunger to stay at the same number 3 times in a row and leads to inconsistent counting for the hunger counter.
            hungerTick = hungerTick + .5;
            double hungertemp = hungerTick;
            Math.Round(hungertemp);
            hunger = Convert.ToInt32(hungertemp);

            //I tried another way but it's still the same.
            thirstTick = thirstTick + Convert.ToDecimal(.5);
            decimal thirstTemp = thirstTick;
            Math.Round(thirstTemp, MidpointRounding.AwayFromZero);
            thirst = Convert.ToInt32(thirstTemp);

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
