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
                Console.WriteLine("1.Coin Flip\n2.leap year\n3.Power of 2\n4.Harmoic progression\n5.Prime factors\n6. Quotient and remainder\n7.Swap\n8.Even or odd\n9.Vowel or consonant\n10.Exit\nEnter your option to execute");
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
                        PowerOfTwo pow=new PowerOfTwo();
                        Console.WriteLine("Enter the number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        pow.power(number);
                        break;
                    case 4:
                        Harmonic harmonic = new Harmonic();
                        Console.WriteLine("Enter n value");
                        int nth=Convert.ToInt32(Console.ReadLine());
                        harmonic.nthHarmonic(nth);
                        break;
                    case 5:
                        PrimeFactors pf = new PrimeFactors();
                        Console.WriteLine("Enter the number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        pf.factors(n);
                        break;
                    case 6:                                                            
                        Divsion divsion = new Divsion();
                        Console.WriteLine("Enter the first number");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        divsion.operation(num1, num2);
                        break;
                    case 7:
                        Swap swap = new Swap();
                        Console.WriteLine("Enter first number");
                        int firstNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second number");
                        int secondNum = Convert.ToInt32(Console.ReadLine());
                        swap.swapNumbers(firstNum, secondNum);
                        break;
                    case 8:
                        EvenOdd eo = new EvenOdd();
                        Console.WriteLine("Enter any number");
                        int number1=Convert.ToInt32(Console.ReadLine());
                        eo.checkNumber(number1);
                        break;
                    case 9:
                        VowelCheck vowelCheck = new VowelCheck();
                        vowelCheck.checkVowel();
                        break;
                    case 10:
                        flag = false;
                        break;
                }
                
            }
        }
        
    }

}