using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_number_of_times
{
    class Program
    {
        static void Main()
        {

            List<int> startNumbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            Dictionary<int, int> occurs = new Dictionary<int, int>();

            for (int i = 0; i < startNumbers.Count; i++)
            {
                if (!occurs.Keys.Contains(startNumbers[i]))
                {
                    occurs.Add(startNumbers[i], 1);
                }
                else
                {
                    occurs[startNumbers[i]]++;
                }
            }

            startNumbers.RemoveAll(number => occurs[number] % 2 != 0);

            Console.WriteLine(string.Join(" ", startNumbers));
        }
    }
}
