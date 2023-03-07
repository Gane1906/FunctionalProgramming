using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class EvenOdd
    {
        public void checkNumber(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is a even number");
            }
            else
                Console.WriteLine(num + " is a odd number");
        }
    }
}
