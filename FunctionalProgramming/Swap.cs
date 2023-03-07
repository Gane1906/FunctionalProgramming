using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Swap
    { 
        public void swapNumbers(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("The value of first number after swapping is: " + num1 + "\nThe value of seond number after swappinfg is: " + num2);
        }
    }
}
