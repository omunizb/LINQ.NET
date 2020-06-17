using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5_PHASE2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            IEnumerable<int> numQuery =
                from num in numbers
                select num;

            Console.WriteLine($"The average grade was {numQuery.Average()}, with"
                              + $" {numQuery.Max()} as maximum and a minimum of {numQuery.Min()}");
        }
    }
}
