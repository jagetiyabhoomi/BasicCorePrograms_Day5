using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class PrimeFactor
    {
        public static void FindPrimeFactor()
        {
            int num;
            Console.WriteLine("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i + " is a prime factor of " + num);
                }
            }
        }
    }
}
