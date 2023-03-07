using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class PowerOfTwo
    {
        public void power(int num)
        {
            for(int i=0;i<num;i++)
            {
                Console.Write(Math.Pow(2, i)+" ");
            }
            Console.WriteLine();
        }
    }
}
