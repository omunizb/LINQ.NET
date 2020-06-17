using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Ex5_PHASE3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            IEnumerable<int> aboveFive =
                (from num in numbers
                where num > 5
                select num).ToArray();

            Console.WriteLine("[ {0} ]", string.Join(", ", aboveFive));

            IEnumerable<int> belowFive =
                (from num in numbers
                 where num < 5
                 select num).ToArray();

            Console.WriteLine("[ {0} ]", string.Join(", ", belowFive));
        }
    }
}
