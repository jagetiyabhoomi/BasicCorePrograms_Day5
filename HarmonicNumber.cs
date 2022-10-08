using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class HarmonicNumber
    {
        public static void FindHarmonicNumber()
        {
            int num;
            double result = 0.0;
            Console.WriteLine("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                result += 1 / (float)i;
            }
            Console.WriteLine("Harmonic Number is: " + result);
        }
    }
}
