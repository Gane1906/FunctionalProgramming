using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class GreatestOfThree
    {
        public void checkMax(int a,int b,int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is greater than" + b + " and " + c);
            }
            if (b > a && b > c)
            {
                Console.WriteLine(b + " is greater than" + a + " and " + c);
            }
            else
            {
                Console.WriteLine(c + " is greater than " + a + " and " + b);
            }
        }
    }
}
