using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5_PHASE1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            IEnumerable<int> numQuery =
                (from num in numbers
                where (num % 2) == 0
                select num).ToArray();

            Console.WriteLine("[ {0} ]", string.Join(", ", numQuery));
        }
    }
}
