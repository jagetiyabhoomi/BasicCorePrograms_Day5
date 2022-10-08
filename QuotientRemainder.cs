using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public static class QuotientRemainder
    {
        public static void CheckQuotientRemainder()
        {
            int dividend = 50, divisor = 8;
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Divident: {0} Divisor: {1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);

        }
    }
}
