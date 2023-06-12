using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Accept marks of 3 subjects physics ,chemistry , maths out of 100. Calculate percentage.
Display grade as below.
Percentage > 80% - Grade A
Percentage > 70% - Grade B
Percentage > 60% - Grade C
Percentage < 60% - Grade D
*/
namespace ConditionExample
{
    internal class Cal_perc
    {
        static void Main(string[] args)
        {
            int marathi, hindi, english;
            double total, perc;

            Console.WriteLine("Enter Marathi Marks:");
            marathi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hindi Marks:");
            hindi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter English Marks:");
            english = Convert.ToInt32(Console.ReadLine());

            total = marathi + hindi + english;
            Console.WriteLine("Total is:" + total);

            perc = total / 3;
            Console.WriteLine("Percentage is :" +perc);

            if(perc > 80) 
            {
                Console.WriteLine("Grade A.");
            }
            else if(perc > 70)
            {
                Console.WriteLine("Grade B.");
            }
            else if(perc > 60)
            {
                Console.WriteLine("Grade C.");
            }
            else if(perc < 60)
            {
                Console.WriteLine("Grade D.");
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
