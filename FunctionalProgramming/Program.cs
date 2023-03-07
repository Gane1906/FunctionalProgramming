using System;
using System.ComponentModel;

namespace FunctionalProgramming
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to functional programming");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Coin Flip\n2.leap year\n3.Exit\nEnter your option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin coin = new FlipCoin();
                        Console.WriteLine("Enter num of flips of coin");
                        int num= Convert.ToInt32(Console.ReadLine());
                        coin.flip(num);
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        Console.WriteLine("Enter year");
                        int year = Convert.ToInt32(Console.ReadLine());
                        leap.leapChcek(year);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
                
            }
        }
        
    }

}