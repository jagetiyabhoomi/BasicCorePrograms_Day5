using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class LeapYear
    {
        public static void FindLeapYear()
        {
            Console.WriteLine("enter any year: ");
            int year = int.Parse(Console.ReadLine());
            if (year.ToString().Length == 4)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("Entered year is Leap Year");
                }
                else
                {
                    Console.WriteLine("Your entered year is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid Year!");
            }

        }
    }
}
