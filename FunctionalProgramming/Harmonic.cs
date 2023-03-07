using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Harmonic
    {
        public void nthHarmonic(int num)
        {
            int output = 0;
            for(int i = 1; i <= num; i++)
            {
                output++;
                Console.Write("1/" + i + "+");
            }
            Console.WriteLine();
            Console.WriteLine("The nth harmonic number is 1/"+output);
        }
    }
}
