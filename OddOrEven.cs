using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class OddOrEven
    {
        public static void CheckOddEvenNumber()
        {
            int num;
            Console.WriteLine("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The Entered Number is Even");
            }
            else
            {
                Console.WriteLine("The Entered Number is Odd");
            }
        }
    }
}
