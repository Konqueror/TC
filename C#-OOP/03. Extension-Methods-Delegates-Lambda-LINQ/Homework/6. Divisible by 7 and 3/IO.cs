//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Linq;

namespace _6.Divisible_by_7_and_3
{
    class IO
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 50, 42, 63 };

            Console.WriteLine("With lambda expressions:");
            
            var resultWithLambda = array.Where((intiger) => (intiger % 7 == 0) && (intiger % 3 == 0)).Select((intiger) => intiger);

            foreach (var intiger in resultWithLambda)
            {
                Console.WriteLine(intiger);
            }

            Console.WriteLine("\nWith LINQ");

            var resultWitLINQ = 
                from intiger in array
                where intiger % 3 == 0 && intiger % 7 == 0
                select intiger;

            foreach (var intiger in resultWitLINQ)
            {
                Console.WriteLine(intiger);
            }

        }
    }
}
