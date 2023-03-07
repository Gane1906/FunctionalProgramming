using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class VowelCheck
    {
        public void checkVowel()
        {
            Console.WriteLine("Enter the  Alphabet");
            char ch;
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("The alphabet " + ch + " is vowel");
            }
            else
                Console.WriteLine("The alphabet " + ch + " is Consonant");
        }
    }
}
