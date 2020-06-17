using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5_PHASE4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };

            Console.WriteLine("Names that start with 'O':");

            var startingO =
                from name in names
                where name.StartsWith("O")
                select name;
            
            foreach (string name in startingO)
            {
                Console.WriteLine($"{name}");
            }

            Console.WriteLine("Names with more than six letters: ");

            var moreThanSix =
                from name in names
                where name.Length > 6
                select name;

            foreach (string name in moreThanSix)
            {
                Console.WriteLine($"{name}");
            }

            Console.WriteLine("Names sorted in descending order: ");

            var descendingOrder =
                from name in names
                orderby name descending
                select name;

            foreach (string name in descendingOrder)
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
