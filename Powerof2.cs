using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class Powerof2
    {
        public static void calculatepower()
        {
            int n = 0;
            int poweroftwo = 1;
            Console.WriteLine("enter any Number");
            n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n < 31)
            {
                for (int i = 0; i <= n; i++)
                {
                    if (i <= n)
                    {
                        Console.WriteLine(i + " " + poweroftwo);
                        poweroftwo = 2 * poweroftwo;
                    }
                }
            }
        }

    }
}
