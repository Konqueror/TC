using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majorant_N
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 2, 3, 2, 3, 2, 3, 4, 3, 3 };

            int? majorityElement = null;
            int stack = 0;

            foreach (int number in numbers)
            {
                if (stack == 0)
                {
                    majorityElement = number;
                }
                if (number == majorityElement)
                {
                    stack++;
                }
                else
                {
                    stack--;
                }
            }

            int count = numbers.Count(number => number == majorityElement);
            
            if (count <= numbers.Length / 2)
            {
                majorityElement = null;
            }

            Console.WriteLine(majorityElement);
        }
    }
}
