using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class FlipCoin
    {
        public static double Calculateflips(int flipcoin)
        {
            Console.WriteLine("enter the number of flips");
            int Head = 0;
            int Tail = 0;
            int Headcount = 0;
            int Tailcount = 0;
            double Headpercentage = 0;
            double Tailpercentage = 0;


            if (flipcoin > 0)
            {
                for (int i = 0; i < flipcoin; i++)
                {
                    Random random = new Random();
                    int num = random.Next(2);
                    Console.WriteLine("generated random number is: " + num);
                    if (num == 0)
                    {
                        Tailcount++;
                    }
                    else
                    {
                        Headcount++;
                    }
                }
                Console.WriteLine("The count of Head is: " + Headcount);
                Console.WriteLine("The count of Tail is: " + Tailcount);
                Headpercentage = Headcount * 100 / flipcoin;
                Tailpercentage = Tailcount * 100 / flipcoin;
                Console.WriteLine("The percentage of Head is: " + Headpercentage + "%");
                Console.WriteLine("The percentage of Tail is: " + Tailpercentage + "%");
            }
            else
            {
                Console.WriteLine("Please enter valid number of flips");
            }
            return Headpercentage;
        }
    }
}
