using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class FlipCoin
    {
        public void flip(int numOfFlips)
        {
            int head = 0, tail = 0, count = 0;
            while(count< numOfFlips)
            {
                Random random = new Random();
                double coin=random.NextDouble();
                if (coin < 0.5)
                    tail++;
                else
                    head++;
                count++;
            }
            double headPercentage = (head * 100) / numOfFlips;
            double tailPercentage = (tail * 100) / numOfFlips;
            Console.WriteLine("Head percentage----> " + headPercentage + "\nTail percentage----> " + tailPercentage);
        }
    }
}
