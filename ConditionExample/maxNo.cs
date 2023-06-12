using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a C# program to find maximum between three numbers (using logical operator)
namespace ConditionExample
{
    internal class maxNo
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Enter 1st Number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd Number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("num1 is Maximum." +num1);
            }
            else if (num2  > num3)
            {
                Console.WriteLine("num2 is maximum" + num2);
            }
            else
            {
                Console.WriteLine("num3 is maximum" + num3);
            }
           
        }
    }
}
