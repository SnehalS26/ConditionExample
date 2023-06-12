using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to accept a character from user & check whether it is vowel or not

namespace ConditionExample
{
    internal class vowel
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("Enter a Alphabets:");
            c = Convert.ToChar(Console.ReadLine());

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'U' || c == 'O')
            {
                Console.WriteLine($"{c} is a Vowel.");
            }
            else
            {
                Console.WriteLine($"{c} Not a Vowel ");
            }
        }
    }
}
