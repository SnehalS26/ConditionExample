using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# program to input electricity consumption unit and calculate total electricity bill according to the given condition:
//For first 50 units Rs. 0.50/unit
//For next 100 units Rs. 0.75/unit
//For next 100 units Rs. 1.20/unit
//For unit above 250 Rs. 1.50/unit An additional surcharge of 20% is added to the bill
namespace ConditionExample
{
    internal class Elect_bill
    {
        static void Main(string[] args)
        {
            int unit=160;
            double amount, total, charge;

            //Console.WriteLine("Enter Total Unit Consumption:");
            //unit = Convert.ToInt32(Console.ReadLine());

            if(unit <= 50)
            {
                amount = unit * 0.50;
            }
            else if(unit <= 150)
            {
                amount = 25 + (unit - 50) * 0.75;
            }
            else if(unit <= 250)
            {
                amount = 100 + (unit - 150) * 1.20;
            }
            else
            {
                amount = 220 + (unit - 250) * 1.50;
            }

            charge = amount * 0.20;
            total = amount + charge;

            Console.WriteLine("Electricity Bill is:" + total);

        }
    }
}
