using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
   public class Loops
   {
        //While Loop

        public void UseWhileLoops(int num)
        {
            int baseCount = 1;
            while(baseCount <= num)
            {
                Console.WriteLine("Don't Stop till you get to" + num);
                Console.WriteLine(baseCount+ ":" + num);
                baseCount++;
            }
        }
   }
}
