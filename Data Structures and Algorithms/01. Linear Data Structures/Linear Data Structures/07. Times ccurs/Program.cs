using System;
using System.Linq;
using System.Collections.Generic;

namespace Times_ccurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            //Lets test with something bigger.
            const int Range = 1000;
            int[] numbers = new int[Range];
            Random RandomNumber = new Random();

            for (int i = 0; i < Range; i++)
            {
                numbers[i] = RandomNumber.Next(1, Range);
            }
            Dictionary<int, int> sortedByOccures = numbers.GroupBy(el => el).ToDictionary(group => group.Key, group => group.Count());

            Console.WriteLine(string.Join(" ", sortedByOccures));
        }
    }
}
