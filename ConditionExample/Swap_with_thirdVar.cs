using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Swap values of two integer variables using third variable
namespace ConditionExample
{
    internal class Swap_with_thirdVar
    {
        static void Main(string[] args)
        {
            int a , b , c ;

            Console.WriteLine("After Swapping:");
            Console.WriteLine("Enter Value of A");
            a = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter Value of B");
            b = Convert.ToInt32(Console.ReadLine());
            

            c = a;
            a = b;
            b = c;
            

            Console.WriteLine("Before Swapping:");
            Console.WriteLine("a : "  +a);
            Console.WriteLine("b : "  +b);
        }
    }
}
