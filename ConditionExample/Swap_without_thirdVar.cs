using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Swap values of two integer variables without using a third variable.

namespace ConditionExample
{
    internal class Swap_without_thirdVar
    {
        static void Main(string[] args)
        {
            int x ,y ;

            Console.WriteLine("Enter Two Numbers:");
            Console.WriteLine("Before Swapping:");
            x= Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            x = x + y;
            y = x-y;
            x = x - y;

            Console.WriteLine("After Swapping");
            Console.WriteLine("x:" +x);
            Console.WriteLine("y :" +y);
        }
    }
}
