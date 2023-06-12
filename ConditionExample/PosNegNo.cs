using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to accept a number from the user & check number is +ve or -ve or zero.
namespace ConditionExample
{
    internal class PosNegNo
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Enter number:");
            a = Convert.ToInt32(Console.ReadLine());

            if(a > 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else if(a < 0)
            {
                Console.WriteLine("Number is Negative");
            }
            else if(a == 0)
            {
                Console.WriteLine("Number is Zero");
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
    }
}
