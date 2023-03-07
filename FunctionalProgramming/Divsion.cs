using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Divsion
    {
        public void operation(int num1,int num2)
        {
            int quotient = num1 / num2;
            int remainder = num1 % num2;
            Console.WriteLine("The quotient is " + quotient + "\n the remainder is " + remainder);
        }
    }
}
