using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class displaypet
    {
        public int petdisplay;
        public int petDisplay
        {
            get
            {
                return petdisplay;
            }
            set
            {
                petdisplay = value;
            }
        }

        public void displayChoice()
        {

            if (petdisplay == 1)
            {
                Console.WriteLine(@"	

              a          a
             aaa        aaa
            aaaaaaaaaaaaaaaa
           aaaaaaaaaaaaaaaaaa
          aaaaafaaaaaaafaaaaaa
          aaaaaaaaaaaaaaaaaaaa
           aaaaaaaaaaaaaaaaaa
            aaaaaaa  aaaaaaa
             aaaaaaaaaaaaaa
  a         aaaaaaaaaaaaaaaa
 aaa       aaaaaaaaaaaaaaaaaa
 aaa      aaaaaaaaaaaaaaaaaaaa
 aaa     aaaaaaaaaaaaaaaaaaaaaa
 aaa    aaaaaaaaaaaaaaaaaaaaaaaa
  aaa   aaaaaaaaaaaaaaaaaaaaaaaa
  aaa   aaaaaaaaaaaaaaaaaaaaaaaa
  aaa    aaaaaaaaaaaaaaaaaaaaaa
   aaa    aaaaaaaaaaaaaaaaaaaa
    aaaaaaaaaaaaaaaaaaaaaaaaaa
     aaaaaaaaaaaaaaaaaaaaaaaaa
");
            }
            else if (petdisplay == 2)
            {
                Console.WriteLine(@"░░░░██░░████████░░██░░░░░░░░░░░░░░░░░░░░░░░░░░ 
░░██░░██░░░░░░░░██░░██░░░░░░░░░░░░░░░░░░░░░░░░ 
░░██░░░░░░░░░░░░░░░░██░░░░░░░░░░░░░░░░░░░░░░░░ 
░░██░░░░░░░░░░░░░░░░░░██░░░░░░░░░░░░░░░░░░░░░░ 
██░░░░██░░░░██░░░░░░░░░░██░░░░░░░░░░░░░░░░░░░░ 
██░░░░░░░░░░░░░░░░░░░░░░░░████░░░░░░░░░░░░░░░░ 
██░░░░░░████░░░░░░░░░░░░░░░░░░██████████████░░ 
██░░██░░██░░░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░██ 
██░░░░████████░░░░░░░░░░░░░░░░░░░░░░░░██████░░ 
██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░ 
██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░
██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░ 
██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░ 
██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░░░ 
░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░░░ 
░░██░░░░████░░░░████████░░░░████░░░░██░░░░░░░░ 
░░██░░░░████░░██░░░░░░██░░██░░██░░░░██░░░░░░░░ 
░░██░░██░░░░██░░░░░░░░░░██░░░░██░░██░░░░░░░░░░ 
░░░░██░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░░░░░░░");
            }
            else if (petdisplay == 3)
            {
                Console.WriteLine(@"
░░░░░░░░░░░░░░░░██
░░░░░░░░░░░░░░░░███
░░██░░░░░░░░░░░████
░░███░░░░░░░░░██████
░░████░░░░░░░███████
░░░█████░░░█████●███
░░░░█████▓▓█████████
░░░░░████▓▓████████
░░░░░░███▓▓███████
░░░░░░██▓▓██████
░░░░░██▓▓█████
░░░░██▓▓████
░░░██▓▓███
░░██▓▓██
░██▓▓██
░██▓▓██
░░██▓▓██
░░░██▓▓██
░░░░██▓▓██
░░░░░██▓▓██
░░░░██▓▓██
░░░░██▓▓██
░░░██▓▓██
░░██▓▓██
░██▓▓██
░░█▓▓█
░░░▓▓
░░░░▓");
            }
            else
            {
               
            }


        }
    }
}
