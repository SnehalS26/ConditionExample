using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionExample
{
    internal class if_else_condition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Select any one number to perform the operation.");
            int option = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                int sum = n1 + n2;
                Console.WriteLine($"Addition is {sum}");
            }
            else if(option == 2)
            {
                int sub = n1 - n2;
                Console.WriteLine($"Substraction is {sub}");
            }
            else if(option == 3)
            {
                int mult = n1 * n2;
                Console.WriteLine($"Multiplication is {mult}");
            }
            else if( option == 4)
            {
                double div = (double)n1/ (double)n2;
                Console.WriteLine($"Division is {div}");
            }
            else
            {
                Console.WriteLine("Enter Valid Option.");
            }
        }
    }
}
