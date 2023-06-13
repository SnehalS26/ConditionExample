using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
                int sub = 0;
                if(n1>n2)
                   sub = n1 - n2;
         else
                    sub = n2 - n1;
                Console.WriteLine($"Substraction is {sub}");
            }
            else if(option == 3)
            {
                int mult = n1 * n2;
                Console.WriteLine($"Multiplication is {mult}");
            }
            else if( option == 4)
            {
                float div = 0;
                if ((float) n1 > (float) n2)
                     div = (float)n1 / (float)n2;
                else
                    div = (float)n2 / (float)n1;

                Console.WriteLine($"Division is {div}");
            }
            else
            {
                Console.WriteLine("Enter Valid Option.");
            }
        }
    }
}
