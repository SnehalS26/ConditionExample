using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# program to input any character and check whether it is alphabet, digit or special character
namespace ConditionExample
{
    internal class check_alpha_digit
    {
        static void Main(string[] args)
        {
            
            char c;

            
            Console.WriteLine("Enter any character.");
            c = Convert.ToChar(Console.ReadLine());
            
           

            if (c >= '0' && c <= '9')
            {
                Console.WriteLine("Digit");
            }
            else if(c >= 'a' && c <= 'z') 
            {
                Console.WriteLine("Alphabet");
            }
            else
            {
                Console.WriteLine("Special Character");
            }
           
        }
    }
}
