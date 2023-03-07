using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class PrimeFactors
    {
        public void factors(int num)
        {
            Console.Write("The prime factors are " + num + " are: ");
            while (num % 2 == 0)
            {
                Console.Write("2 ");
                num /= 2;
            }
            for(int i = 3; i * i <=num; i+=2)
            {
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
            }
            if (num > 2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

    }
}
