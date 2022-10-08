using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class LargestNumber
    {
        public static void CheckLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Fint the Largest of Three Numbers : ");
            Console.WriteLine("Input the 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st number is the greatest among three");
                }
                else
                {
                    Console.WriteLine("The 3rd number is the greatest among three");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd number is the greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd number is the greatest among three");
            }
        }
    }
}
